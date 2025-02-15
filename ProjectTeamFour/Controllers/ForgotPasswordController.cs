﻿using ProjectTeamFour.Api;
using ProjectTeamFour.Models;
using ProjectTeamFour.Service;
using ProjectTeamFour.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace ProjectTeamFour.Controllers
{
    public class ForgotPasswordController : Controller
    {

       
        private static readonly TimeSpan _passwordResetExpiry = TimeSpan.FromMinutes(5); //限制5分鐘
        private static readonly Byte[] _privateKey = new HMACSHA256().Key; //做key
        private const Byte _version = 1;


        private MemberApiController _api;
        private MemberService _memberservice;
        private LogService _logservice;
        private MailService _mailservice;


        public ForgotPasswordController()
        {
            _mailservice = new MailService();
            _api = new MemberApiController();
            _memberservice = new MemberService();
            _logservice = new LogService();
        }



        // GET: Mail
        public ActionResult Index()
        {
            return View();
        }

        //找回密碼填email頁
        public ActionResult SendMail()
        {
            return View();
        }

        //找回密碼填email頁的post 送出email
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SendMail([Bind(Include = "sender, receiver, MailTitle, MailBody")] MailViewModel mailVM)
        {

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "如果您的信箱輸入正確，已經發送驗證信至您信箱");  //安全問題就算錯也報這樣的提示
                return RedirectToAction("FinishedSending", "ForgotPassword");
            }

            MemberViewModel currentMember = _api.GetMember(p => p.MemberRegEmail == mailVM.receiver);
          

            if (currentMember == null)
            {
                ModelState.AddModelError("", "如果您的信箱輸入正確，已經發送驗證信至您信箱"); //安全問題就算錯也報這樣的提示
                return RedirectToAction("FinishedSending", "ForgotPassword");
            }

            var outputCode = CreatePasswordResetHmacCode(currentMember.MemberId);


            var link = Request.Url.Scheme + "://"
                    + Request.Url.Authority
                    + @Url.Action("CheckMemberUrl", "ForgotPassword", new { forgotpw = outputCode });


          

            //取Email template
            string returnData = getEmailData();

            //把該帶的資料塞進 template
            string finalReturnData = setReplacedEmailData(returnData, link, currentMember.MemberName);

            var msg = new MailMessage("raisebubu@gmail.com",
              currentMember.MemberRegEmail, "集資車車 - 找回密碼",
              finalReturnData);

            msg.IsBodyHtml = true;


            //mailVM.receiver = currentMember.MemberRegEmail;
            //mailVM.sender = "11@a.com";
            //mailVM.MailTitle = "集資車車 - 找回密碼";
            //mailVM.MailBody = link;



            string id = WebConfigurationManager.AppSettings["GmailId"];
            string password = WebConfigurationManager.AppSettings["GmailPassword"];
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(id, password),
                EnableSsl = true,
                
            };
            //client.Send(mailVM.sender, mailVM.receiver, mailVM.MailTitle, mailVM.MailBody);
            client.Send(msg);
            return RedirectToAction("FinishedSending", "ForgotPassword");
        }


        //送完email頁跳轉
        public ActionResult FinishedSending()
        {
            return View();
        }

        //使用者點連結進到這裡 check 對了返回 View
        public ActionResult CheckMemberUrl(string forgotpw)
        {
            if (!VerifyPasswordResetHmacCode(forgotpw, out Int32 userId))
            {
                return null;
            }

            return View();
        }


        // CheckMemberUrl View 重設密碼 post 傳入這裡  --input ajax要再處理
        public String ResetPassword(MemberViewModel input)
        {

            int getMemberId = 0;
            if (!VerifyPasswordResetHmacCode(input.ResetPasswordCode, out Int32 userId))
            {
                return "失敗";
            }
            else
            {
                getMemberId = userId;
            }
            input.MemberId = getMemberId;

            var result = new OperationResult();
            result = _memberservice.ResetPassWord(input);
            if (result.IsSuccessful)
            {
                return "成功";
            }
            else
            {
                Log entity = new Log()
                {
                    DateTime = result.DateTime
                };
                _logservice.Create(entity);
                return "失敗";
            }
        }


        //----------加密的東西 int 都先寫 int32 比較好換算理解

       // 做 Hmac金鑰雜湊 用 SHA256 包 memberId 和 時間 去做
        public String CreatePasswordResetHmacCode(Int32 userId)
        {
            Byte[] message = Enumerable.Empty<Byte>()
            .Append(_version) //加 1 個 int 也就是 4個byte 32bit
            .Concat(BitConverter.GetBytes(userId))  //Id  回傳4個byte 32bit
            .Concat(BitConverter.GetBytes(DateTime.UtcNow.ToBinary())) //Time 回傳8個byte 64bit  取國際標準時間就好
            .ToArray(); //byte => byte[]

            using (HMACSHA256 hmacSha256 = new HMACSHA256(key: _privateKey))  //開始做 code
            {
                Byte[] hash = hmacSha256.ComputeHash(buffer: message, offset: 0, count: message.Length);  //buffer 材料 //offset 材料起始點 //count 材料使用長度 做出原始 hash
                Byte[] outputMessage = message.Concat(hash).ToArray(); //串在一起 增加複雜度
                String outputCodeB64 = Convert.ToBase64String(outputMessage); //轉 base64string  
                String outputCode = outputCodeB64.Replace('+', '-').Replace('/', '_');  //最後再一次增加複雜度 替換 + 和 /
                return outputCode;
            }
        }


        // 解碼
        public static Boolean VerifyPasswordResetHmacCode(String codeBase64Url, out Int32 userId)   //Id 原本被包在裡面 , 所以先用 out 不用初始化 , 在裡面咐值
        {
            String base64 = codeBase64Url.Replace('-', '+').Replace('_', '/');  //解最外層
            Byte[] messagePlusHash = Convert.FromBase64String(base64); //轉回 byte陣列 index 0 會是 1

            Byte version = messagePlusHash[0];    // 這裡做判斷，但 肯定 1 不會小於 1 所以我有點不懂一開始 append 1 和現在這件事的意義 //也許算是制定一個小規則增加解密難度 讓中間這裡開頭一定是1
            if (version < _version)
            {
                userId = 0;
                return false;
            }

            userId = BitConverter.ToInt32(messagePlusHash, 1); //拿id
            Int64 createdUtcBinary = BitConverter.ToInt64(messagePlusHash, 1 + sizeof(Int32));  //拿時間bit
             
            DateTime createdUtc = DateTime.FromBinary(createdUtcBinary);  //bit => 真正時間
            if (createdUtc.Add(_passwordResetExpiry) < DateTime.UtcNow)  //如果超過5分鐘就失效 
            {
                return false;
            }

            const Int32 _messageLength = 1 + sizeof(Int32) + sizeof(Int64);  //計算原本傳入的長度 32 32 64

            using (HMACSHA256 hmacSha256 = new HMACSHA256(key: _privateKey)) 
            {
                Byte[] hash = hmacSha256.ComputeHash(messagePlusHash, offset: 0, count: _messageLength);   // 取前面 => 所以得到一開始作的時候的原始 hash
                Byte[] messageHash = messagePlusHash.Skip(_messageLength).ToArray(); // 這整串去掉原始message長度  => 會是得到傳進來的 hash
                return Enumerable.SequenceEqual(hash, messageHash);  //原始的 比對 傳進來的 一樣就是 true 
            }
        }



        //DES加密將HmacSha256code存進去  //沒用到
        public static byte[] Encryption(byte[] Deskey, byte[] plainText)
        {
            SymmetricAlgorithm mCSP = new DESCryptoServiceProvider();
            //設定金鑰
            mCSP.Key = Deskey;
            //加密工作模式:CBC
            mCSP.Mode = CipherMode.CBC;
            //補充字元方式:0
            mCSP.Padding = PaddingMode.Zeros;
            //初始向量IV = 0
            mCSP.IV = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            //建立對稱加密物件
            ICryptoTransform ct = mCSP.CreateEncryptor(mCSP.Key, mCSP.IV);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write))
                {
                    cs.Write(plainText, 0, plainText.Length);
                    cs.FlushFinalBlock();
                    cs.Close();
                    return ms.ToArray();
                }
            }
        }

        //DES解密  //沒用到
        public static byte[] Decryption(byte[] Deskey, byte[] CipherText)
        {
            SymmetricAlgorithm desAlg = new DESCryptoServiceProvider();
            //設定金鑰
            desAlg.Key = Deskey;
            //加密工作模式:CBC
            desAlg.Mode = CipherMode.CBC;
            //補充字元方式:0
            desAlg.Padding = PaddingMode.Zeros;
            //初始向量IV = 0
            desAlg.IV = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            ICryptoTransform ict = desAlg.CreateDecryptor(desAlg.Key, desAlg.IV);
            using (MemoryStream mStream = new MemoryStream())
            {
                using (CryptoStream cStream = new CryptoStream(mStream, ict, CryptoStreamMode.Write))
                {
                    cStream.Write(CipherText, 0, CipherText.Length);
                    cStream.FlushFinalBlock();
                }
                return mStream.ToArray();
            }
        }


   
        public string getEmailData()
        {
            string returnData = "";
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Template" + @"\\" + @"mailtemplate.html";

            if (path != null)
            {
                StreamReader streamReader = new StreamReader(path, Encoding.GetEncoding("Big5"));
                //轉字串給輸出
                returnData = streamReader.ReadToEnd();
            }
            return returnData;
        }


        public string setReplacedEmailData(string returnData, string link, string memberName)
        {

            //讀取信件範本
            returnData = getEmailData();

            //取代文字
            
                
            //returnData = Regex.Replace(returnData, "#name#", mailReplaceData.NameRecipient);
                
                
            returnData = Regex.Replace(returnData, "#link#", link);
            returnData = Regex.Replace(returnData, "#memberName#", memberName);
            //...無限向下增加

            return returnData;
        }


        




    }
}