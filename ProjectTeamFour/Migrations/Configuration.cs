﻿namespace ProjectTeamFour.Migrations
{
    using ProjectTeamFour.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjectTeamFour.Models.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ProjectTeamFour.Models.ProjectContext context)
        {
            //第一個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 1,
                MemberId = 1,
                ProjectName = "窩窩睏床墊｜從工廠到你家！你的第一張全方位好床墊",
                Category = "科技設計",
                ProjectStatus = "已結束",
                StartDate = new DateTime(2021, 3, 1),
                EndDate = new DateTime(2021, 3, 20),
                Fundedpeople = 39,
                FundingAmount = 658200m,
                AmountThreshold = 1000000m,
                CreatorName = "窩窩睏",
                ProjectMainUrl = "https://i.imgur.com/fEmjPnym.png",//提案瀏覽頁的頁面照片 照片格式IMGURL SIZE:		320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/LAEi48ql.png",//提案詳細頁的影片覆蓋照片
                ProjectDescription = "",
                ProjectImgUrl = "https://i.imgur.com/KseRcyB.png,https://i.imgur.com/XoyHd8T.png,https://i.imgur.com/GK9q8iW.png,https://i.imgur.com/UfGDPix.png,https://i.imgur.com/CHtcrnu.png,https://i.imgur.com/5KodELQ.png,https://i.imgur.com/iTMb39E.png,https://i.imgur.com/KmYFz9v.gif,https://i.imgur.com/ALhvyjv.png,https://i.imgur.com/74YlEUe.png,https://i.imgur.com/4AN1ZPV.gif,https://i.imgur.com/IgVHTa3.png,https://i.imgur.com/meq8PUW.png,https://i.imgur.com/Fa5WYm5.png,https://i.imgur.com/dS488Qa.png,https://i.imgur.com/XzIcJW0.png,https://i.imgur.com/thG6VBH.png,https://i.imgur.com/r6dMTZL.gif,https://i.imgur.com/kZe7g6c.png,https://i.imgur.com/Dxd0ayK.png,https://i.imgur.com/P5QfjdC.png,https://i.imgur.com/V9aPqgJ.gif,https://i.imgur.com/AlEpL9c.png",
                ///提案詳細內容
                ProjectVideoUrl = "https://www.youtube.com/embed/_AlH_WRj6Ak",
                Project_Question = "窩窩睏床墊的結構有幾層？,與一般床墊清潔方式差異？有標準清洗方式？,床墊表層有防蟎的功能嗎？,彈力支撐泡棉會不會長年使用下來會壓縮變形？,窩窩睏床墊的四邊透氣泡膠邊框和市面上的床墊設計有什麼差別？,窩窩睏床墊的軟硬度？,是否有保固？以及保固範圍,如果我需要維修或是保固的服務，應該去哪裡尋求幫助？",
                Project_Answer = "一共有6層結構，每層都是精心計算的黃金比例，也是最貼心的人性化設計第1層可拆洗天絲™品牌萊賽爾纖維的表布舒適不悶熱，還有可拆洗設計 。第2層涼爽透氣親水棉層吸走悶熱不適，帶入乾爽空氣。​第3層高支撐泡綿柔軟卻不塌陷，溫柔包覆疲勞的身體。​第4層MIT 高碳鋼獨立筒 高耐震、不變形的高碳鋼獨立筒。第5層四邊泡膠透氣邊框增加床墊的穩定和支撐度。​第6層高支撐釋壓棉從頭到尾都透氣，進一步支撐重量。​,一般床墊清潔需要花大請請專業清潔公司處理，窩窩睏考量到消費者的生活習慣，尤其時有小小孩和毛小孩的家庭，特別設計了採用天絲™品牌萊賽爾纖維的可拆洗式涼感表布，即使沾染到污漬也能輕鬆拆洗，不但清洗變得更容易！更能抑制病菌及塵蟎孳生。,有的，窩窩睏採用天絲™品牌萊賽爾纖維作為可拆洗式的涼感表布，其特性做過吸濕及保濕度檢測，透過濕氣管理功能，有效吸收濕氣，因此不易形成細菌賴以生存的潮濕環境，因此不利細菌滋生，提供一個更加健康衛生的環境。,窩窩睏採用密度高達30，接近於記憶棉的泡綿，加上使用了2.0線徑MIT高碳鋼獨立筒彈簧，除了不易塌陷外，支撐效果與耐用度也比一般床墊好！但長時間睡在同一個位置，床墊的泡綿和彈簧也會些許彈性疲乏。建議固定每半年將床墊前後對調，給彈簧一點時間休息，床墊壽命會更長。,有些床墊會有床緣容易塌陷的問題，這是因為完全沒有使用邊框固定彈簧，好一點的會加入鋼條邊框，但躺坐時會有較為明顯的異物感。而窩窩睏所使用的「透氣泡膠邊框」與國際頂級名床相同，能大大增加位於床緣的穩定度就算翻身到床邊，也能睡得很安心，此外長輩以坐姿要從床邊站起時，也會輕鬆許多。,市面上許多床墊，總是只使用一個數字量表，表示整張床墊的軟硬度。軟、硬、適中就代表了一張床的躺感。​但窩窩睏的 #舒適層 和 #支撐層 卻是不同的軟硬度設計，用來放鬆皮膚與肌肉的舒適層是偏軟的，有著溫柔的包覆感，而用來支撐骨骼的支撐層，擇是軟硬適中的設計，能服貼支撐你的自然身形。窩窩睏床墊的好睡秘密​#窩窩睏舒適層（偏軟）​窩窩睏床墊的舒適層由 #涼爽透氣親水棉層 和 #高支撐泡綿 所組成。舒適層柔軟卻不塌陷，服貼不同身形、還有極具安全感的舒適包覆感 。還能吸走水氣 ，帶入乾爽空氣，床墊就像自帶空調一樣舒爽好睡。​#高碳鋼獨立筒 （軟硬適中）​軟硬適中的高碳鋼獨立筒，有絕佳的 #耐震性、#回彈力 和 #耐用度。窩窩睏更加碼進行支撐力測試，確保最高品質。高品質的材質，才能堅定有力的支撐身體重量，並且讓脊椎保持自然伸展，每晚睡眠都能好好療癒疲憊。​如此一來，躺在窩窩睏上，有舒適層的柔軟包覆感，讓折騰了一天的肌肉在舒適層上好好休息；同時高碳鋼獨立筒又能撐起全身的重量，保護筋骨不傷脊椎。窩窩睏的黃金比例，成就了一張完美的床墊。,窩窩睏募資計畫即將登上於集資車車募資平台募資會提供 100晚試睡計劃：從床墊送到家中的那天開始，有100天的時間可以試睡窩窩睏床墊。不滿意即可申請全額退費，並有專人協助回收床墊。也享有10年保固服務：只要是正常使用，獨立筒若有損壞，我 們將免費提供保固服務。,窩窩睏為了讓大家享有最實惠的價格就可以擁有一張全方位的好床墊，採用工廠直送頂級床墊的新模式，以打破傳統須經過層層中間商後，才能到消費者的家銷售模式只要線上跟我們預約就會派人提供保固服務唷！",
                ProjectPlansCount = 4,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 12, 20),
                ApprovingStatus = 2


            });
            //第一個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 1,
                MemberAccount = "NO1member",
                MemberPassword = "NO1memberPassword",
                MemberName = "窩窩睏",
                MemberAddress = "100台北市中正區重慶南路一段122號",
                MemberBirth = new DateTime(1980, 1, 1),
                MemberConEmail = "1234@gmail.com",
                MemberRegEmail = "1234@gmail.com",
                MemberMessage = "",
                MemberPhone = "0935-123456",
                MemberTeamName = "窩窩睏",
                MemberWebsite = "https://www.facebook.com/%E7%AA%A9%E7%AA%A9%E7%9D%8F-WO-WO-COO-113398027184309",
                AboutMe = "窩窩睏的工廠成立將近50年， 曾為多家知名及國際品牌床墊代工。 以近50年職人經驗，精心計算床墊結構的黃金比例 ，用心挑選頂級用料，去除層層高額成本， 用最真實的價格，最誠懇的保證，守護全家大小的睡眠健康。 窩窩睏 你的第一張全方位萬元好床。",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/LNPGyBEt.jpg",

            });
            //第一個提案內的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {

                ProjectId = 1,
                ProjectName = "窩窩睏床墊｜從工廠到你家！你的第一張全方位好床墊",
                PlanId = 1,
                ProjectPlanId = 1,
                PlanTitle = "【台制 單人標準 1 張】",
                PlanDescription = "台制單人｜90 x 188 x 26 cm±1cm 原價 20,800 元(現省 9, 000元)► 免費搬運舊床墊至管理處或巷口► 全台灣寄送免運費(台灣本島)► 偏遠地區須加運費",
                PlanFundedPeople = 1,
                PlanShipDate = new DateTime(2021, 3, 29),
                PlanImgUrl = "https://i.imgur.com/dmoLRa1m.png",
                PlanPrice = 11800m,
                QuantityLimit = 100,
                AddCarCarPlan = true,

            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                ProjectId = 1,
                ProjectName = "窩窩睏床墊｜從工廠到你家！你的第一張全方位好床墊",
                PlanId = 2,
                ProjectPlanId = 2,
                PlanTitle = "【台制 單人加大 1 張】",
                PlanDescription = "台制單人加大｜105 x 188 x 26 cm±1cm 原價 24,800 元(現省 12, 000元)► 免費搬運舊床墊至管理處或巷口► 全台灣寄送免運費(台灣本島)",
                PlanFundedPeople = 3,
                PlanShipDate = new DateTime(2021, 3, 29),
                PlanImgUrl = "https://i.imgur.com/eZ84taVm.png",
                PlanPrice = 12800m,
                QuantityLimit = 30,
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                ProjectId = 1,
                ProjectName = "窩窩睏床墊｜從工廠到你家！你的第一張全方位好床墊",
                PlanId = 3,
                ProjectPlanId = 3,
                PlanTitle = "【台制 雙人標準 1 張】",
                PlanDescription = "台制雙人｜150 x 188 x 26 cm±1cm 原價 29,800 元(現省 15,000元)► 免費搬運舊床墊至管理處或巷口► 全台灣寄送免運費(台灣本島)► 偏遠地區須加運費",
                PlanFundedPeople = 20,
                PlanShipDate = new DateTime(2021, 3, 29),
                PlanImgUrl = "https://i.imgur.com/CNLokGtm.png",
                PlanPrice = 14800m,
                QuantityLimit = 40,
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                ProjectId = 1,
                ProjectName = "窩窩睏床墊｜從工廠到你家！你的第一張全方位好床墊",
                PlanId = 4,
                ProjectPlanId = 4,
                PlanTitle = "【台制 雙人特大 1 張】",
                PlanDescription = "台制雙人特大｜180 x 210 x 26 cm±1cm 原價 41,800 元(現省 21,000元)► 免費搬運舊床墊至管理處或巷口► 全台灣寄送免運費(台灣本島)► 偏遠地區須加運費",
                PlanFundedPeople = 15,
                PlanShipDate = new DateTime(2021, 3, 29),
                PlanImgUrl = "https://i.imgur.com/donBSJIm.png",
                PlanPrice = 20800m,
                QuantityLimit = 50,
            });
            //第二個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {

                ProjectId = 2,
                MemberId = 2,
                ProjectName = "不讓土地哭泣——預購手工木餐具・讓這片土地不受農藥污染",
                Category = "生活",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 3, 10),
                EndDate = new DateTime(2021, 4, 25),
                Fundedpeople = 69,
                FundingAmount = 107200m,
                AmountThreshold = 400000m,
                CreatorName = "魟魚與貓",
                ProjectMainUrl = "https://i.imgur.com/fY4fvf2m.jpg",
                //提案瀏覽頁的頁面照片 照片格式IMGURL SIZE:		320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/eCm2xggl.jpg",
                //提案詳細頁的影片覆蓋 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "在苗栗獅潭山區中，有一片即將被種植生薑的土地。目前，它還保有純淨，並沒有化學農藥的污染， 我們想要讓它一直保持下去，不過現在，我們需要協助了！,https://i.imgur.com/7rins05h.jpg,【募資緣由】我們在2020年購買了這片將近1500坪的土地，準備開始夢想已久的自給自足生活。但，因為當初並沒有資金可以讓我們做整地，而原地主又提出幫我們免費整地，交換我們讓他種植生薑一年，對當時的我們來說，是一個很划算的交換。 但是，隨著搬進了我們在這片土地上搭建的小木屋後，漸漸察覺我們對於這片土地的熱愛原來如此濃厚。想到土地即將面對這樣無情的對待，心裡滿是不捨和難過，而且隨著我們搬遷過來的三隻貓咪，也有可能因為誤觸農藥而死亡，這一切都讓我們後悔著當初並沒有深思熟慮。考慮過再去申請貸款，但是如果加上原本購買土地所需支付的貸款，負擔會太過於沈重。原本對於已經沒有方法的我們來說只能放棄，眼睜睜地看著一切發生，但是募資的想法突然出現在我們的腦海裡面，也才發現，也許一切都還有機會。,https://i.imgur.com/4YWh6muh.jpg,【所需的資金】整地的費用，再加上我們與原本即將種植生薑的農人契作的種苗費用、種植人力費用、與其他雜支，保守預估大約至少需要40萬。又或者，如果屆時募資金額足夠，我們也考慮更改種植項目（須提出申請與更改費用），以更為自然的多種作物種植，來取代傳統的單一作物種植方式，讓土地注入更多元的生命，延續它應有的活力。,【回饋方案】我們會用自己手工製作的木餐具與木製品來進行回饋，作品完成後，會塗上數層的食用等級亞麻仁油與其製成的護木蠟，絕對安全無毒！,創作者：魟魚與貓（陳鍵輝）所有這些作品，都是我們用熱愛生命的活力去創作出來的，每一件作品都是我們生活中的剪影，是我們生命中的一部分，也期望可以成為您生命中的一小部分，而能在您的生活中，更添加一些美好。希望喜愛木製品、喜歡我們的生活、支持我們理念的朋友們，可以幫我們分享，或實際成為我們的贊助者，和我們一起成為這片土地的守護者之一。也許有天，您會有機會來到這片土地上，它一定會感受到您，並給予最大的歡迎。,https://i.imgur.com/Rw5euhuh.jpg,【聯絡我們】如果有任何的問題，也歡迎直接到我們的粉絲專頁詢問魟魚與貓，任何方面的問題我們都很樂意回答。有興趣的朋友，也可以持續關注我們的分享，也許能夠帶給您一些不同想法，去創作屬於自己獨特的生活。木製作品產地：台灣木材來源：美國、緬甸、台灣等。,https://i.imgur.com/HS2ypXdh.jpg,【關於魟魚與貓】從都市移居鄉間，再從鄉間搬到了山上，一步一步，我們遵循著自己的內心，找到了方向與生活。在跌跌撞撞與悲喜交織的路途上，描繪出了那腦海中的夢想，雖然並不是一切都能如願，但有時換了角度，呈現的景色卻意外地更加美好。,https://i.imgur.com/zIWYmIVh.jpg,【故事大綱】大家好，我是魟魚，與妻子貓一起帶著出生不久的女兒栗子，在台灣苗栗山區開始建造自己的家園，也開始了夢想，那年是2020年。這一切並不是一時的想法或衝動，而是在2013 - 2015年，我們一起在澳洲打工度假時所發芽的種子。在那邊我們看見了另一種生活與可能，也撇見了彼此內心深處渴望的一切。那段時間，我們在不同的農場碰觸了大自然，而祂以極其愉悅舒適的方式告知我們該何去何從，只是後來內心的掙扎與衝突就沒那麼容易應付。回台後，感受到文化與內心的衝擊，而靈魂也不再安靜無語。無法再過著朝九晚五的生活，木工便是詢問自己後得到的答案。開始一遍自學木工與農業一邊打工，體驗到了內心的狂喜，但同時卻也是生活最為困苦的時候，也多虧妻子的支持才能度過那最為艱苦的時期。,【轉捩點】2017年，開始了第一次的鄉村移居，住進台中太平山區幾十年沒人居住的土屋，興奮地著手了第一次的老屋整修，心靈無限滿足。同時，這一年我們的人生也有了非常重大的轉變，我們不再將動物視為食物或產品，徹底改變了我們的飲食，也解放了靈魂。2018年，再次移居苗栗鄉間，一樣是多年沒人居住的老屋，繼續累積著房屋整修的經驗，也用更多的農耕嘗試、更多的生活體驗、更多的內在思考，去慢慢丟棄了多餘的物品與既定觀念，放下更多的自我，去體驗更多的愛與慈悲，用更多不同的角度去看待出現身邊的人事物，相信一切的安排自有其道理。2019年，栗子來到我們身邊，完整了我們，讓我們體驗到圓滿的意義。2020年，找到了家園，感受到夢想成真的喜悅，也開始了自給自足的實踐，獨力建造自己的房子，夢境就這樣一一實現。現在，我們極其享受每一天的每分每秒，無法忍受彼此必須短暫分離的時刻，也無法接受任何時光的蹉跎。,https://i.imgur.com/N9yfyQIh.jpg,【友善大地的生活】在這棟小屋裡，我們使用太陽能來提供電力，除了大瓦數的機具需要使用發電機來運作外，其餘生活與創作上的電力使用都供應無虞。而水則是利用雨水回收系統儲存在水塔裡面，也即將度過我們的第一個乾季，而水塔還有八分滿。當然，所有這一切都是必須先調整生活習慣，將不必要的消耗減到最低，紀錄與觀察能源使用量，進而去評估自己真正所需的一切。在我們的土地上看不見電線桿，也不用擔心電磁波過強的問題，對我們來說也是一個非常大且意外的收穫。,【學習簡單】你一定會好奇我們如何維持生活、賺取生活費，或者直接認定我們有著強力的後盾，或是已經賺夠了錢而提早退休；但是，只有真正認識我們，接觸我們的生活，才會知道原來生活可以非常簡單，金錢也絕非打造夢想的唯一途徑。當然，我們也還在學習當中，學習更進一步的自給自足、學習拋下更多我們認為必須擁有的非必要事物。,【感謝所有】我們並不是來享受大自然的一切，而是成為自然裡的一部分。不過度消耗資源、不污染土地，也不自以為是地認為人類是主宰萬物的主人，我們感謝與驚嘆大自然的運作與給予，神秘又令人敬畏！感謝來到我們身邊的人事物，讓我們成為我們現在的自己。,https://i.imgur.com/2kjzV0Th.jpg",
                //格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/l-IXCqSzNZA",///youtobe分享
                Project_Question = "木餐具使用上的注意事項,為什麼要使用木餐具？,如何保養？,發霉了還有救嗎？",
                Project_Answer = "木製品並非一定不耐用，只要能夠注意幾點，絕對可以有很長的使用年限！而魟魚與貓所製作的木餐具皆使用亞麻仁籽油反覆數層地塗裝，絕對安全無毒！雖然保養很麻煩，但只要偶爾花一點時間，就可以延續它的生命，且不傷荷包，其實是非常划算的！也能夠藉由這樣的練習，來戒除快速時尚以及浪費金錢的惡習哦！絕對百利而無害！【平時應注意事項】*避免使用洗碗機或是烘碗機清洗木餐具，容易造成彎曲或裂痕。*清洗後，放置通風處陰乾即可。*可僅用菜瓜布搭配溫水清洗，避免使用鋼刷或過多的化學清潔劑。*可浸泡用醋或檸檬的稀釋液中來消除異味，但注意需完全乾燥後再收。*常常甚至天天使用是最好的保養方式。*如使用一陣子後有缺角或斷裂，可自行用砂紙研磨修補，再進行保養的步驟即可。*保養油可使用生飲無妨的食用油品，家中常備的油即可，不必另外購買。,首要的原因當然是溫暖又好看！不論是拿在手上或是放入口中，都散發著溫潤的能量，樸實且典雅，而且不會燙手或燙口哦！不過如果再更進一步思考使用木餐具的理由，會發現它所帶來的正向影響是非常廣闊的。木餐具的碳排放量非常地低，材料取得容易且便宜，最重要的是，它是少數不需要經由工廠就能被製作出來。意思就是，每個有意願的人都能夠做得出來！也意味著，不會有大量的能源消耗，也不會有大量污水和廢棄物的排放，更不會有後續無謂的包裝垃圾和運輸能源的消耗等等，光是這些，就能夠減少很多污染及能源的浪費，而且還有更多層面沒有提及呢！如果壞了、發霉了也無妨，因為它會自行分解，不會藉由你的手來造成環境的傷害！,由於木材的天然特性，剛開始的使用及清潔後，容易有纖維反翹的現象，造成表面粗糙，屬於正常現象，但不會造成使用的問題，請不用擔心。建議持續使用一週以上，可以進行一次的砂磨。清洗放置完全乾燥後，再利用#600或#800的水砂紙沾些食用油來砂磨，表面光滑後再靜置任其吸收油質，可視情況來定期使用同樣方式保養，之後反翹的現象就會漸漸減少甚至消失，木材便會逐漸穩定。隨著使用，木餐具也可能會因食材的色素改變顏色，也是正常現象，請不用擔心。,如果木餐具因為閒置太久或環境太過於潮濕而形成黴菌，請不要慌張，先觀察黴菌狀況。如果黴菌只在表面，尚未侵入木材纖維，直接清洗即可。但如果已經侵入纖維，請用溫水加小蘇打及食鹽浸泡來去除黴菌，陰乾後可以再用噴槍或瓦斯爐點火來烘烤，讓表面形成碳化，冷卻後再進行清潔保養即可。",
                ProjectPlansCount = 9,//提案內方案數量
                CreatedDate = new DateTime(2020, 12, 1),///在StartDate前
                SubmittedDate = new DateTime(2020, 12, 31),///在StartDate前
                LastEditTime = new DateTime(2021, 12, 20),///在StartDate前
                ApprovingStatus = 2


            });
            //第二個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 2,
                MemberAccount = "NO2member",
                MemberPassword = "NO2memberPassword",
                MemberName = "魟魚與貓",
                MemberAddress = "100台北市中正區重慶南路一段122號",
                MemberBirth = new DateTime(1988, 11, 1),
                MemberConEmail = "1233@gmail.com",
                MemberRegEmail = "1233@gmail.com",
                MemberMessage = "",
                MemberPhone = "0935-123456",
                MemberTeamName = "魟魚與貓",
                MemberWebsite = "https://www.facebook.com/rayandcatsworkingshop",
                AboutMe = "我們是一對嘗試自給自足、尋找屬於自己的生活模式的夫妻，現在育有一個小孩，並帶著三隻貓咪，在苗栗山區開始我們夢想。在這裡我們自己動手蓋了一間不到十坪的小木屋，近1500坪的土地是畫紙，我們即將在上面畫出天堂。 利用農業的自給自足、木工技能的創作，以及消費欲望的降低，我們得以過著深居簡出的日子。創作只為了賺取生活所需並滿足心靈，家人間在生活中的彼此陪伴與成長才是一切。 我們捨棄了大多數的便利，丟棄一件件我們原本無法放手的物品與觀念，發現原來那些都是捆綁著我們的枷鎖，才開始看見自由的模樣。我們想要分享，讓他人也能看見，黑暗外的一切原來是一片綠意盎然的光明。",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/cdLjTOut.jpg",
                //照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第二個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 5,
                ProjectName = "不讓土地哭泣——預購手工木餐具・讓這片土地不受農藥污染",
                ProjectId = 2,
                ProjectPlanId = 1,
                PlanTitle = "【單純贊助，不需要任何回饋！】",
                PlanFundedPeople = 11,
                PlanDescription = "喜歡我們的生活理想與實踐，以少量的金額付出，來實際支持我們的理念。",
                PlanShipDate = new DateTime(2021, 3, 21),
                PlanImgUrl = "https://i.imgur.com/eCm2xggm.jpg",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 500m,
                QuantityLimit = 100
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 6,
                ProjectName = "不讓土地哭泣——預購手工木餐具・讓這片土地不受農藥污染",
                ProjectId = 2,
                ProjectPlanId = 2,
                PlanTitle = "【友善無毒農產品回饋方案】",
                PlanFundedPeople = 23,
                PlanDescription = "此方案可以收到我們（一年或更久之後）在這片土地上所種植的生鮮農產品，或者是我們自行加工的農產品。但是！無法保證作物的美觀或作物的種類，也許，可以當作福袋的心情來訂購喔！（笑）【可以保證的是：友善環境與無毒栽培】",
                PlanShipDate = new DateTime(2021, 3, 21),
                PlanImgUrl = "https://i.imgur.com/hSE6nFam.jpg",
                PlanPrice = 800m,
                QuantityLimit = 200
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 7,
                ProjectName = "不讓土地哭泣——預購手工木餐具・讓這片土地不受農藥污染",
                ProjectId = 2,
                ProjectPlanId = 3,
                PlanTitle = "【早鳥優惠的簡約餐具方案】",
                PlanFundedPeople = 10,
                PlanDescription = "一隻湯匙一雙筷子間單人生不過如此但是因為是早鳥再多一雙筷子也是剛好此方案包含湯匙x1支筷子x2雙島森家餐具袋x1只【約略尺寸】湯匙長約20cm寬5cm筷子長約23cm餐具袋長24cm寬7.5cm（收摺後）手工製作，難免誤差，感謝諒解",
                PlanShipDate = new DateTime(2021, 3, 21),
                PlanImgUrl = "https://i.imgur.com/WRP6FKnm.jpg",
                PlanPrice = 980m,
                QuantityLimit = 200
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 8,
                ProjectName = "不讓土地哭泣——預購手工木餐具・讓這片土地不受農藥污染",
                ProjectId = 2,
                ProjectPlanId = 4,
                PlanTitle = "【簡約餐具方案】",
                PlanFundedPeople = 0,
                PlanDescription = "一隻湯匙一雙筷子間單人生不過如此此方案包含湯匙x1支筷子x1雙島森家餐具袋x1只【約略尺寸】湯匙長約20cm寬5cm筷子長約23cm餐具袋長24cm寬7.5cm（收摺後）手工製作，難免誤差，感謝諒解",
                PlanShipDate = new DateTime(2021, 3, 21),
                PlanImgUrl = "https://i.imgur.com/QHpTRMum.jpg",
                PlanPrice = 980m,
                QuantityLimit = 200
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 9,
                ProjectName = "不讓土地哭泣——預購手工木餐具・讓這片土地不受農藥污染",
                ProjectId = 2,
                ProjectPlanId = 5,
                PlanTitle = "【好像有點豪華方案】",
                PlanFundedPeople = 3,
                PlanDescription = "此方案包含筷子一雙、湯匙一支、喝湯深湯匙一支、餐叉一支、甜點水果叉一支、奶油果醬抹刀一支、島森家餐具袋一只約略尺寸筷子 長23cm湯匙 長20cm 寬5cm深湯匙 長17cm 寬5.5cm餐叉 長20cm水果叉 長14cm抹刀 長19cm餐具袋長24cm寬12 - 15cm（收摺後）",
                PlanShipDate = new DateTime(2021, 3, 21),
                PlanImgUrl = "https://i.imgur.com/wnqwp61m.jpg",
                PlanPrice = 1980m,
                QuantityLimit = 200
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 10,
                ProjectName = "不讓土地哭泣——預購手工木餐具・讓這片土地不受農藥污染",
                ProjectId = 2,
                ProjectPlanId = 6,
                PlanTitle = "【來點下午茶方案】",
                PlanFundedPeople = 5,
                PlanDescription = "啊！好美！此方案包含手刻點心盤x2手刻杯墊x2咖啡量豆勺x1點心水果叉x2奶油果醬抹刀x1約略尺寸點心盤直徑 14 - 15cm 厚2cm杯墊直徑 10cm 厚1 - 1.5cm咖啡量豆勺 10 - 16cm 豆量約15克點心叉 13 - 14cm抹刀 18 - 20cm",
                PlanShipDate = new DateTime(2021, 3, 21),
                PlanImgUrl = "https://i.imgur.com/sLuiuPHm.jpg",
                PlanPrice = 2180m,
                QuantityLimit = 200
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 11,
                ProjectName = "不讓土地哭泣——預購手工木餐具・讓這片土地不受農藥污染",
                ProjectId = 2,
                ProjectPlanId = 7,
                PlanTitle = "【好像一切都有了呢！】",
                PlanFundedPeople = 6,
                PlanDescription = "此方案包含有手把大砧板一片、大炒菜匙一支、中炒菜匙一支、攪拌匙一支、飯匙一支、料理長筷一雙、大湯杓一支約略尺寸手把大砧板 30x55cm(含手把)炒菜匙 大35x8cm 中26x7cm攪拌匙 35x5cm飯匙 21x6cm長筷 37.5cm大湯勺 42x8cm",
                PlanShipDate = new DateTime(2021, 3, 21),
                PlanImgUrl = "https://i.imgur.com/aLPQXYgm.jpg",
                PlanPrice = 3880m,
                QuantityLimit = 200
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 12,
                ProjectName = "不讓土地哭泣——預購手工木餐具・讓這片土地不受農藥污染",
                ProjectId = 2,
                ProjectPlanId = 8,
                PlanTitle = "【無開關感應式小夜燈】",
                PlanFundedPeople = 8,
                PlanDescription = "此方案包含全木製5vLED小夜燈組x1(內建LED燈、電子線路、高級電子零件)木質感應開關x1約略尺寸整體長寬高23x23x38cm底座直徑23 - 24cm 厚度約4cm小夜燈開啟方式https://www.youtube.com/watch?v=HoEgP1jn16U",
                PlanShipDate = new DateTime(2021, 3, 21),
                PlanImgUrl = "https://i.imgur.com/YnlACWOm.jpg",
                PlanPrice = 2680m,
                QuantityLimit = 200
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 13,
                ProjectName = "不讓土地哭泣——預購手工木餐具・讓這片土地不受農藥污染",
                ProjectId = 2,
                ProjectPlanId = 9,
                PlanTitle = "【簡約棧板盤案】",
                PlanFundedPeople = 3,
                PlanDescription = "此方案包含全木製5vLED小夜燈組x1(內建LED燈、電子線路、高級電子零件)木質感應開關x1約略尺寸整體長寬高23x23x38cm底座直徑23 - 24cm 厚度約4cm小夜燈開啟方式https://www.youtube.com/watch?v=HoEgP1jn16U",
                PlanShipDate = new DateTime(2021, 3, 21),
                PlanImgUrl = "https://i.imgur.com/RYrTiN5m.jpg",
                PlanPrice = 3980m,
                QuantityLimit = 200
            });
            //第三個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 3,
                MemberId = 3,
                ProjectName = "#先浪狗變少——相信動物協會「紮女養成計」，前進桃園！",
                Category = "公共在地",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 3, 7),
                EndDate = new DateTime(2021, 4, 30),
                Fundedpeople = 2396,
                FundingAmount = 3042302m,
                AmountThreshold = 5200000m,
                CreatorName = "FaithForAnimals",
                ProjectMainUrl = "https://i.imgur.com/OQB8O5Pm.jpg",//提案瀏覽頁的頁面照片 照片格式IMGURL SIZE:		320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/JwjyIzal.jpg",//提案詳細頁的影片覆蓋照片 照片格式IMGURL SIZE: 640x640 連結檔案名結尾l
                ProjectDescription = ",",
                ProjectImgUrl = "https://i.imgur.com/twUjqYX.jpg,親愛的朋友，在台灣生長的這幾十年，你是否遇過下列令你懷疑人生的時候呢？靠著自己的實力拿了筆獎金，你承諾周圍的朋友這筆錢要部分捐給流浪動物。上網打開數個募款頁，有很多作法：收容、急傷⋯⋯，很多矛盾：人犬衝突、安樂死......，很多團體及個人的名稱：友善、尊敬......。最後你選擇把錢捐給了一個有名的團體並分享在社群，但......。,https://i.imgur.com/88HaqLB.jpg,回到鄉下，阿公家新養的母狗不在，堂妹說，今天帶去車程一小時外的獸醫院結紮了，因為上個月生了一窩，家裏只是想要養一隻狗，沒想到會生這麼多。「幼犬呢？」你問。堂妹說：「阿公裝塑膠袋拿去河裡淹了......。」堂妹接著說：「對面鄰居阿府，上星期也把養半年的狗載去丟了，他一直不喜歡牠。」......你感到震懾。這些人，都是你親近的人，你知道他們不是壞人，那事情為什麼會這樣？,https://i.imgur.com/Hg2cEDg.jpg,埋首於浪犬前線任務多年、經歷無數打磨，現在，相信動物協會提出了一個最有效率的浪浪解決方案——高強度絕育計畫。針對從未被飼主責任妥善規範及照顧的狗兒，我們有一個強而有力的主張 —— ,#先浪狗變少。,https://i.imgur.com/xQonBnr.jpg,必須知道！浪浪變少大秘寶：絕育，絕育，絕育！,https://i.imgur.com/a6vioWG.jpg,加碼了解！「高強度絕育計畫」國際共識：80%！,https://i.imgur.com/dpkGabU.jpg,2016-2020年10月，相信動物協會共絕育了北北基的8,818隻母狗。現在台北新北的母犬絕育比例都超過80 %，基隆則在2018年底就有 85.6％的成績。,https://i.imgur.com/CqpsAhS.jpg,https://i.imgur.com/zTxmIwG.jpg,https://i.imgur.com/GsIQcp1.jpg,https://i.imgur.com/3QTSMpQ.jpg,帶著北北基豐碩的成果，相信動物協會決定於2020年前進桃園。年初完成桃園市浪犬族群調查後，我們馬上發現擴區桃園的困難：,相信動物協會的眼界放眼全台高強度絕育計畫，代表的意義不止是區域性的有效減量，雖然這樣已經非常值得！除了提供絕育資源，家戶訪查是最直接的教育，還有過程中動保網絡及專業志工的累積培育。而協會的目光也從未止步於區域，我們渴望打磨出一個有效的、在地的，台灣流浪動物問題處理模板——希望幫助民間及公家機關找到良性合作平衡，使地方及中央對進程有共識不至政令斷層。盼行動可供更多單位複製借鑑，加速擴散 #先浪狗變少 的動保能量。,https://i.imgur.com/n35AzFo.jpg,https://i.imgur.com/eLoDdnx.jpg,https://i.imgur.com/rCHmEDb.jpg,https://i.imgur.com/USXUbj0.jpg,https://i.imgur.com/tIAyMry.jpg,https://i.imgur.com/uNLXCun.jpg,https://i.imgur.com/RYNk1Qa.jpg,https://i.imgur.com/isIUk5Y.jpg,https://i.imgur.com/EPjPCGk.jpg,https://i.imgur.com/xdNx3MJ.jpg",
                ProjectVideoUrl = "https://www.youtube.com/embed/40vGu9I2SAc",
                Project_Question = "為什麼相信動物協會只絕育母犬？,相信動物協會目前服務的區域在哪裡?,請問可以寄送到海外嗎？運費如何計算？,請問可以單買或加購回饋品嗎?,回饋品預計何時寄出？,如果我忘記填寫尺寸、或是寄送、發票資訊填寫錯誤，請問我可以在哪裡修改?,會有收據或發票嗎?可以打統編或抬頭嗎?,請問相信動物 x 半隻羊立體書實驗室 聯名桌曆會由支持者自己組裝嗎？,「前線體驗營」＆「執行長演講」有地點限制嗎？,關於募資計畫的問題要如何聯繫你們？,請問回饋品的製造產地？",
                Project_Answer = "相信動物協會的主力全放在母犬絕育，很多人疑問我們為何不絕育公犬？因為在人力及資源有限的情況下，母犬絕育比公犬絕育優先且有效。假設一個地區有10隻公犬及10隻母犬，捕捉公犬與母犬所花費的時間及資源相同。絕育了9隻公犬後，僅存的1隻未絕育公犬一樣能讓10隻母犬懷孕。就算絕育了10隻公犬，母犬一旦發情，還是可以吸引其他地區公犬前來交配。絕育公犬完全無益於降低繁殖數量。而絕育1隻母犬，則會直接減少狗群的生產力。相信動物選擇全力進行母犬絕育，才能使有限人物力發揮最大效益。,北北基桃。,可以，海外運費金額因不同國家及包裹重量會有差異，需另計。請來信詢問 info@faithforanimals.org.tw,目前回饋品不開放單買或加購，僅在此募資計畫以方案形式贈送。,2021/2/7前支持募資案的贊助者，會在4/30前寄出回饋品！2021 / 2 / 8 - 3 / 9的贊助者，回饋品寄送會在5 / 31前完成。回饋品統一以包裹寄送。為響應環保，包裝皆使用重複利用之材料。,請於募資頁面右上方選取您的贊助紀錄進行相關資料修改即可。,若是選擇「隨喜贊助」方案，我們將開立捐款收據。若選擇其餘回饋方案，我們將開立發票。統編及抬頭資訊，請在回饋調查欄位填寫。收據/發票統一以紙本型式，郵局寄送。,不會，我們會在寄送前幫您組裝完畢。,「前線體驗營」地點為北北基桃，贊助成功後會有專人與您聯繫安排時間地點；「執行長演講」地點以台灣本島為主，若有其他疑問歡迎聯絡我們。,請於週一至週五10-19點 撥打(02)2701-3623 相信動物辦公室或來信詢問info@faithforanimals.org.tw,購物袋及開瓶器為陸製，其他都是台灣製造喔！",
                ProjectPlansCount = 10,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 12, 20),
                ApprovingStatus = 2


            });
            //第三個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 3,
                MemberAccount = "NO3member",
                MemberPassword = "NO3memberPassword",
                MemberName = "FaithForAnimals",
                MemberAddress = "100台北市中正區重慶南路一段122號",
                MemberBirth = new DateTime(1990, 12, 3),
                MemberConEmail = "12345@gmail.com",
                MemberRegEmail = "12345@gmail.com",
                MemberMessage = "",
                MemberPhone = "0935-123457",
                MemberTeamName = "FaithForAnimals",
                MemberWebsite = "http://www.faithforanimals.org.tw/",
                AboutMe = "相信動物協會成立至今，使盡洪荒之力，只做一件事：母犬絕育！因為我們相信，要解決浪犬問題，當務之急是 #先浪狗變少！",
                Gender = "女",
                ProfileImgUrl = "https://i.imgur.com/TV217MMt.jpg",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第三個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 14,
                ProjectName = "#先浪狗變少——相信動物協會「紮女養成計」，前進桃園！",
                ProjectId = 3,
                ProjectPlanId = 1,
                PlanTitle = "【 隨喜贊助 】",
                PlanFundedPeople = 512,
                PlanDescription = "・我們將寄送電子感謝卡給您",
                PlanShipDate = new DateTime(2021, 4, 21),
                PlanImgUrl = "https://i.imgur.com/S0pVvGNm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 100m,
                QuantityLimit = 200
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 15,
                ProjectName = "#先浪狗變少——相信動物協會「紮女養成計」，前進桃園！",
                ProjectId = 3,
                ProjectPlanId = 2,
                PlanTitle = "【我紮狗】",
                PlanFundedPeople = 724,
                PlanDescription = "・貼紙組＋防水大購物袋",
                PlanShipDate = new DateTime(2021, 4, 21),
                PlanImgUrl = "https://i.imgur.com/q1U8EY1m.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 589m,
                QuantityLimit = 300
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 16,
                ProjectName = "#先浪狗變少——相信動物協會「紮女養成計」，前進桃園！",
                ProjectId = 3,
                ProjectPlanId = 3,
                PlanTitle = "【 愛狗狗 】",
                PlanFundedPeople = 332,
                PlanDescription = "・貼紙組＋磁鐵開瓶器＋短Tee(款式任選)",
                PlanShipDate = new DateTime(2021, 4, 21),
                PlanImgUrl = "https://i.imgur.com/u8c75kZm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1299m,
                QuantityLimit = 200
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 17,
                ProjectName = "#先浪狗變少——相信動物協會「紮女養成計」，前進桃園！",
                ProjectId = 3,
                ProjectPlanId = 4,
                PlanTitle = "【 遛狗狗 】",
                PlanFundedPeople = 332,
                PlanDescription = "・貼紙組＋快乾浴巾＋行李箱束帶",
                PlanShipDate = new DateTime(2021, 4, 21),
                PlanImgUrl = "https://i.imgur.com/SfYXHfSm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1699m,
                QuantityLimit = 100
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 18,
                ProjectName = "#先浪狗變少——相信動物協會「紮女養成計」，前進桃園！",
                ProjectId = 3,
                ProjectPlanId = 5,
                PlanTitle = "【 愛狗久久 】",
                PlanFundedPeople = 189,
                PlanDescription = "・貼紙組＋磁鐵開瓶器＋防水大購物袋＋快乾浴巾＋行李箱束帶",
                PlanShipDate = new DateTime(2021, 4, 21),
                PlanImgUrl = "https://i.imgur.com/TzZpxZrm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 2299m,
                QuantityLimit = 100
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 19,
                ProjectName = "#先浪狗變少——相信動物協會「紮女養成計」，前進桃園！",
                ProjectId = 3,
                ProjectPlanId = 6,
                PlanTitle = "【 相信動物 】",
                PlanFundedPeople = 143,
                PlanDescription = "・貼紙組＋短Tee * 3(款式任選)",
                PlanShipDate = new DateTime(2021, 4, 21),
                PlanImgUrl = "https://i.imgur.com/39hfwKam.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 3405m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 20,
                ProjectName = "#先浪狗變少——相信動物協會「紮女養成計」，前進桃園！",
                ProjectId = 3,
                ProjectPlanId = 7,
                PlanTitle = "【 驕傲單身狗 — 單人套組 】",
                PlanFundedPeople = 93,
                PlanDescription = "・貼紙組＋磁鐵開瓶器＋短Tee(款式任選)＋防水大購物袋＋快乾浴巾＋行李箱束帶",
                PlanShipDate = new DateTime(2021, 4, 21),
                PlanImgUrl = "https://i.imgur.com/zth2ZNqm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 3999m,
                QuantityLimit = 60
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 21,
                ProjectName = "#先浪狗變少——相信動物協會「紮女養成計」，前進桃園！",
                ProjectId = 3,
                ProjectPlanId = 8,
                PlanTitle = "【 鬥陣來愛狗 — 雙人套組 】",
                PlanFundedPeople = 39,
                PlanDescription = "・貼紙組 * 2＋磁鐵開瓶器 * 2＋短Tee * 3(款式任選)＋防水大購物袋 * 2＋快乾浴巾 * 2＋行李箱束帶 * 2",
                PlanShipDate = new DateTime(2021, 4, 21),
                PlanImgUrl = "https://i.imgur.com/pG6K3Kvm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 7999m,
                QuantityLimit = 70
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 22,
                ProjectName = "#先浪狗變少——相信動物協會「紮女養成計」，前進桃園！",
                ProjectId = 3,
                ProjectPlanId = 9,
                PlanTitle = "【 巾划算 】",
                PlanFundedPeople = 30,
                PlanDescription = "・快乾浴巾 * 6",
                PlanShipDate = new DateTime(2021, 4, 21),
                PlanImgUrl = "https://i.imgur.com/opTuc7om.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 6000m,
                QuantityLimit = 80
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 23,
                ProjectName = "#先浪狗變少——相信動物協會「紮女養成計」，前進桃園！",
                ProjectId = 3,
                ProjectPlanId = 10,
                PlanTitle = "【 作伙一企來愛狗 】",
                PlanFundedPeople = 2,
                PlanDescription = "・貼紙組 * 10＋短Tee * 10(款式任選)＋快乾浴巾 * 10＋防水大購物袋 * 10＋相信動物協會執行長演講1小時",
                PlanShipDate = new DateTime(2021, 4, 21),
                PlanImgUrl = "https://i.imgur.com/jpnfrqtm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 99000m,
                QuantityLimit = 90
            });
            //第4個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 4,
                MemberId = 4,
                ProjectName = "Cheerpod 智慧滑鼠 | 一片在手，螢幕隨控",
                Category = "科技設計",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 4, 10),
                EndDate = new DateTime(2021, 5, 10),
                Fundedpeople = 173,
                FundingAmount = 273670m,
                AmountThreshold = 761209m,
                CreatorName = "cheerdots TW",
                ProjectMainUrl = "https://i.imgur.com/8hymepqm.jpg",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:		320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/8hymepql.jpg",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "https://i.imgur.com/QK3Ac7A.jpg,https://i.imgur.com/vIlBhyV.jpg,https://i.imgur.com/J6F8H1X.jpg,https://i.imgur.com/BgFoDWO.jpg,https://i.imgur.com/7cGY7VF.jpg,https://i.imgur.com/JE3W2RD.jpg,https://i.imgur.com/dQ8TPGO.gif,https://i.imgur.com/jIxJJPM.gif,https://i.imgur.com/KKjvWtY.gif,https://i.imgur.com/zvsUErj.gif,https://i.imgur.com/hjRLIod.gif,https://i.imgur.com/9bkhmMh.gif,https://i.imgur.com/t2ovAFd.jpg,https://i.imgur.com/T6DU2im.gif,https://i.imgur.com/W36X5aA.jpg,https://i.imgur.com/a4osRfW.gif,https://i.imgur.com/8hMaPHJ.jpg,https://i.imgur.com/eOhNYAk.jpg,https://i.imgur.com/TldF1Qc.gif,https://i.imgur.com/PcXD4dw.jpg,https://i.imgur.com/G9S3Ocx.jpg,https://i.imgur.com/toiSoHl.jpg,https://i.imgur.com/C3beGew.jpg",
                //	Large Thumbnail 格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/bfiv1Vf02dY",
                Project_Question = "材質是防刮傷嗎?,桌面材質有限定嗎?,最遠可以離連結設備多遠？,有幾顆實體按鍵？,按鍵會不會容易按壞？,請問實際操作手勢有幾種?,如果收到產品不夠滿意，可以做退換貨嗎？,機器防水嗎？,可以連平板嗎？,當電視遙控器是啥意思？",
                Project_Answer = "外殼採用電鍍氧化技術，非常耐刮。募資也有開放加購皮套，可保護產品。,除了玻璃桌面外，其他材質皆可正常使用！,最遠可到 10 M 喔,有三顆，左右中鍵各一，讓你操作時也能有滿滿的回饋感！,不會，滑鼠按鍵實際測試數據可達100萬次以上按壓。切換模式按鍵可達 10 萬次以上！,總共最多有 19 種！依照您的設備而有所不同~,可以的，我們依照消費者保護法的規定，提供商品貨到日起七天猶豫期的權益。另外產品也由台灣在地代理商引進出貨，後續保固也不需擔心喔！,本身不防水唷～,可以，只要有藍牙皆可連結使用,這是配合手機／平板／筆電的鏡像功能，將畫面投影到電視上時就可坐在沙發上操控喔",
                ProjectPlansCount = 4,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 12, 20),
                ApprovingStatus = 2


            });
            //第4個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 4,
                MemberAccount = "NO4member",
                MemberPassword = "NO4memberPassword",
                MemberName = "cheerdots TW",
                MemberAddress = "100台北市中正區重慶南路一段122號",
                MemberBirth = new DateTime(1995, 12, 3),
                MemberConEmail = "12346@gmail.com",
                MemberRegEmail = "12346@gmail.com",
                MemberMessage = "",
                MemberPhone = "0935-123458",
                MemberTeamName = "cheerdots TW",
                MemberWebsite = "https://www.facebook.com/cheerdots",
                AboutMe = "哈囉！我們是 Cheerdots 團隊，一直以來總是找不到能完美滿足【筆電/平板工作者】使用的一款滑鼠，它必須同時符合【方便攜帶】，【觸控板】，【簡報輔助】這三大功能 而今年，我們決定自行研發一款符合上述所有條件的完美滑鼠：【CheerPod】因此誕生。並於美國 indiegogo 上獲得 50 萬美金的支持！",
                Gender = "女",
                ProfileImgUrl = "https://i.imgur.com/B3XGnURt.png",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第4個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 24,
                ProjectId = 4,
                ProjectName = "Cheerpod 智慧滑鼠 | 一片在手，螢幕隨控",
                ProjectPlanId = 1,
                PlanTitle = "CheerPod x1",
                PlanFundedPeople = 154,
                PlanDescription = "・Type-C充電線 x1 專屬皮盒 x1",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/l1PaFfwm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1590m,
                QuantityLimit = 1000
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 25,
                ProjectId = 4,
                ProjectName = "Cheerpod 智慧滑鼠 | 一片在手，螢幕隨控",
                ProjectPlanId = 2,
                PlanTitle = "CheerPod x1",
                PlanFundedPeople = 18,
                PlanDescription = "・Type-C充電線 x1 ",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/SxgTSLTm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1490m,
                QuantityLimit = 500
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 26,
                ProjectId = 4,
                ProjectName = "Cheerpod 智慧滑鼠 | 一片在手，螢幕隨控",
                ProjectPlanId = 3,
                PlanTitle = "CheerPod x1",
                PlanFundedPeople = 0,
                PlanDescription = "・Type-C充電線 x1 ",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/Mpjrv8sm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1890m,
                QuantityLimit = 400
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 27,
                ProjectId = 4,
                ProjectName = "Cheerpod 智慧滑鼠 | 一片在手，螢幕隨控",
                ProjectPlanId = 4,
                PlanTitle = "CheerPod x1",
                PlanFundedPeople = 1,
                PlanDescription = "・Type-C充電線 x1 專屬皮盒 x1",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/7j2cn5tm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1990m,
                QuantityLimit = 100
            });
            //第5個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {

                ProjectId = 5,
                MemberId = 5,
                ProjectName = "開啟與孩子的第一場程式冒險 《解碼傳說 CO·DECODE》",
                Category = "遊戲出版",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 3, 30),
                EndDate = new DateTime(2021, 4, 25),
                Fundedpeople = 916,
                FundingAmount = 949280m,
                AmountThreshold = 140000m,
                CreatorName = "Papacode-程式老爹",
                ProjectMainUrl = "https://i.imgur.com/FTTAIvIm.png",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:		320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/0VaBATol.png",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "https://i.imgur.com/qWwY6Y2.jpg,最受歡迎的程式桌遊回來了！這次程式老爹將為大家帶來全球第一款程式解謎遊戲《解碼傳說 CO·DECODE》！老爹源自於交通大學，我們過去打造的《Coding Ocean：海霸》已被全台超過500所國中、國小支持，並於2019年被納入國中教科書，現在每年都幫助超過十萬位小朋友學習程式！,https://i.imgur.com/1r6jcGv.jpg,我們相信，教育可以藉由不同的方式，在孩子最有創意的年紀，以他們擅長的思考方式—探索與遊戲，體驗生活上的程式概念，並激起對程式邏輯的興趣，從此程式將不再是孩子未來的痛點，重新打造與程式的一趟冒險之旅。經過了兩年時間的經驗累積，研發、測試，在2021年，我們要為各位帶來全新的程式遊戲體驗：世界第一款結合了團隊解謎闖關，APP互動，故事閱讀與程式邏輯結合的桌遊《解碼傳說 CO·DECODE》,https://i.imgur.com/YcAVaGQ.png,《解碼傳說 CO·DECODE》一款適合所有人學習程式的解謎桌遊！從故事的角度出發並加入更多程式邏輯，包含二進位、編碼、加密、搜尋演算法、排序演算法、最佳化、資料結構...等，重新打造9大程式航道的邏輯體驗，搭配有趣的密室逃脫機制以及獨自研發的APP助手，不論大人小孩都可以多人一起團隊解謎。,https://i.imgur.com/2faisgy.png,https://i.imgur.com/LZ1hYnu.png,資訊科學概念融入，遊玩中體驗程式邏輯蒐集線索、分析推理、試驗想法，除了這些本來就與程式設計有關的素養以外，《解碼傳說》將各種資訊科學的概念，融合到情境故事當中，成為其中的機關與線索，解謎的過程中，玩家將不知不覺運用各種演算法背後的邏輯！,https://i.imgur.com/gncGVyA.png,獨創卡牌互動解謎機制，不只好上手，搭配有趣的機制，更能輕鬆了解背後傳達的程式邏輯概念！學程式的方法百百種，解碼傳說把最有趣的方法收錄在每一個故事細節裡，每場故事冒險都會有新的程式體驗！玩家要親自決定用什麼方式破解難題，也大大增加沈浸感！,https://i.imgur.com/L9c0dAw.gif,每一個細節都是線索！每一個問題都有他的解決方式！搭配故事體驗，學習如何打敗每個關卡的魔王,https://i.imgur.com/Sn1iX6t.gif,https://i.imgur.com/X8Bl7Kh.gif,獨創解謎APP：一套會自我更新的桌遊！  《解碼傳說》 有專屬APP，除了引導關卡的進行外，還內建了非常多的獨特機關，增加解謎豐富度，此外還會協助玩家紀錄學習成就，把各別程式概念透過數據化的方式有系統的做追蹤，未來在遊戲玩完後，也會有不定期的免費更新，搭配專屬解碼手冊，可以補齊更多劇情關卡，讓孩子一玩再玩愛上程式。,https://i.imgur.com/GZ9Imxu.jpg,十分鐘輕鬆上手！馬上開始冒險！內附生動有趣的教學體驗關，花10分鐘跟著安卓麗德的指示，帶你快速上手解碼傳說的遊玩方法！,https://i.imgur.com/GHU4x07.gif,解謎×程式×設計：250張完全獨特卡牌！  我們再次與金馬獎動畫設計團隊dosomething studio合作，原創設計了超過250張不重複的獨立卡牌，遊戲中玩家將依照卡牌線索完成冒險，從精美的美術中找尋蛛絲馬跡，並從解謎過程學到程式知識。我們會選擇解謎作為主題，正是因為解謎的過程跟真實寫程式的狀態很雷同，當你遇到問題時，都需要不斷思考系統運作的邏輯，並找出解開BUG的線索!,https://i.imgur.com/RwWO5Yw.jpg,https://i.imgur.com/2XTJmaA.jpg,https://i.imgur.com/MAY0jcY.png,https://i.imgur.com/nVTL4SW.jpg,https://i.imgur.com/71I2c7n.jpg,https://i.imgur.com/dLIEKsO.jpg,https://i.imgur.com/BWbgN3x.png,https://i.imgur.com/QaV0Y3W.jpg,https://i.imgur.com/DOOR29h.jpg,https://i.imgur.com/DrTWsd3.png,https://i.imgur.com/4LvqZKM.jpg,https://i.imgur.com/8SRi0Rk.jpg,https://i.imgur.com/euRMN0l.jpg,https://i.imgur.com/miGvGAY.png,https://i.imgur.com/nrWn1Mc.png,https://i.imgur.com/K4mvycQ.png,https://i.imgur.com/Xk4U7B4.png,https://i.imgur.com/jjqW1Yn.png,https://i.imgur.com/h6ynByG.jpg,https://i.imgur.com/b94UHW9.jpg,https://i.imgur.com/ysb9nRd.jpg,https://i.imgur.com/iujI1j2.png,https://i.imgur.com/b02RbS1.png,https://i.imgur.com/gXj67cj.png,https://i.imgur.com/UUt1UYO.jpg,https://i.imgur.com/XNUVtPg.jpg ",
                //	Large Thumbnail 格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/_RYBkvErQLA",
                Project_Question = "家長/老師本身沒有程式基礎，也能引導小孩一起玩嗎？,許多桌遊的規則都很複雜，《解碼傳說》會不會很難上手？,《解碼傳說》是不是只適合給小朋友玩？,是否需要有玩過《海霸》或是會寫程式才能玩?,會在什麼時候收到遊戲呢?,學校如果想要購買《解碼傳說》，有什麼需要注意的事項？,可以寄送到海外嗎？,我可以更改贊助方案/取消贊助嗎？,我有填寫募資前的問卷，但是沒有收到折扣碼怎麼辦?,如果我想要贊助兩組以上，填單兩次嗎?",
                Project_Answer = "「沒問題的！這次海霸外傳《解碼傳說》附有詳解手冊，就算沒有程式基礎，也能夠輕鬆看懂唷！」,《解碼傳說》的規則非常容易，口述只需要三分鐘以內。除了規則說明書，我們還設計了教學關卡，會逐步帶玩家熟練規則。此外，我們屆時還會拍攝教學影片放上Youtube平台供玩家參考。,「其它年紀的玩家也適合喔！《解碼傳說》已經有過千人次的測試經驗，玩家包含了其它年紀的學生（國中至大學生）、成人(家長、老師、解謎遊戲玩家)，都獲得了大量的好評，遊戲在故事風格、難易度、趣味性是適合各年齡層的玩家的。」,《解碼傳說》與《海霸》共用同一個世界觀，不過兩個遊戲是彼此獨立的。而且《解碼傳說》目標是培養玩家的「邏輯思維」，所以除了閱讀、觀察、思考能力以外，玩家不需要其它特定的先備知識。,目前預估最遲會在五月時寄送，但老爹會盡全力加快速度的！詳細的進度會公布於粉絲專頁、專案進度頁面。,您可以將學校統編寫在備註欄，另外遊戲與發票將於最遲五月一起發貨，如果學校對於發票、帳務有特殊需求，可以私訊我們，我們會協助您處理。,沒問題，但是目前無法估計之後的海外運費，因此您可以先贊助，等到準備出貨時，我們會再根據報價跟您收取運費。,不好意思，我們後台無法更改您的訂單要請您在專案結束前，來信至 fundingCar@ontoo.cc 告知＂退款原因＂，同時附上您贊助的「專案名稱、金流單號、贊助金額」，平台將儘速為您處理退款程序。【信用卡】退款程序全額刷退至原付費信用卡帳單中（無手續費產生）。◎ 退款完成會收到「NewebPay 藍新金流」Email 通知，請留存備查。◎ 請依據信用卡之結帳日判斷，刷退款項將返還於當月或次月信用卡帳單中。【ATM／超商】退款程序客服收到來信會請申請人提供個人銀行或郵局之帳戶資料，請協助回填退款所需資訊（非第一銀行用戶需承擔轉帳手續費 10 元，直接由贊助金中扣除）。◎ 超商手續費（35元）／銀行匯款手續費（10~15元）不列入退還款項，此費用為 各家超商／銀行 收取的一次性費用，選用此兩種付款方式時，付款方須自行吸收以上金流方所強制收取的服務費用，平台依據實際贊助金額退費。◎ 退款作業固定於每週五轉帳（遇例假日提前至週四），轉帳日當天收到之退款資訊會順延至隔週作業。匯款完成將會收到＂第一銀行＂EMAIL 通知即代表款項已入帳。,有可能是被分類的垃圾信件了，如果您查找過依然沒有，請聯絡我們提供您的信箱，我們會重新補發一份給您,您只需要填單一次，可以用「額外支持」來補足例如：打算贊助「完整方案2 + 1」兩套您可以在第一套的「額外支持」金額外加1820並在備註欄說明【額外贊助「完整方案2 + 1」一套】我們就能幫您處理",
                ProjectPlansCount = 4,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 12, 20),
                ApprovingStatus = 2


            });
            //第5個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 5,
                MemberAccount = "NO5member",
                MemberPassword = "NO5memberPassword",
                MemberName = "Papacode-程式老爹",
                MemberAddress = "100台北市中正區重慶南路一段122號",
                MemberBirth = new DateTime(1995, 12, 3),
                MemberConEmail = "12347@gmail.com",
                MemberRegEmail = "12347@gmail.com",
                MemberMessage = "",
                MemberPhone = "0935-123459",
                MemberTeamName = "Papacode-程式老爹",
                MemberWebsite = "http://www.papacode.com.tw/",
                AboutMe = "2016年由交大畢業工程團隊創辦，台灣程式教育桌遊第一品牌。本次聯手美感教科書團隊，Dosomething Studio，創造台灣程式教育的未來可能。",
                Gender = "女",
                ProfileImgUrl = "https://i.imgur.com/fzJV5KHt.jpg",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第5個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 28,
                ProjectId = 5,
                ProjectName = "開啟與孩子的第一場程式冒險 《解碼傳說 CO·DECODE》",
                ProjectPlanId = 1,
                PlanTitle = "《解碼傳說 CO·DECODE》",
                PlanFundedPeople = 256,
                PlanDescription = "額外收錄《Coding Ocean：海霸》以及四本藏寶圖擴充，把冦丁海洋全部一起帶回家！！！",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/Pm8tb4dm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 3280m,
                QuantityLimit = 500
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 29,
                ProjectId = 5,
                ProjectName = "開啟與孩子的第一場程式冒險 《解碼傳說 CO·DECODE》",
                ProjectPlanId = 2,
                PlanTitle = "《解碼傳說 CO·DECODE》",
                PlanFundedPeople = 11,
                PlanDescription = "額外收錄《Coding Ocean：海霸》以及四本藏寶圖擴充，把冦丁海洋全部一起帶回家！！！",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/EPz86uYm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 3480m,
                QuantityLimit = 500
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 30,
                ProjectId = 5,
                ProjectName = "開啟與孩子的第一場程式冒險 《解碼傳說 CO·DECODE》",
                ProjectPlanId = 3,
                PlanTitle = "《解碼傳說 CO·DECODE》",
                PlanFundedPeople = 3,
                PlanDescription = "《解碼傳說 CO·DECODE》4組與4本解碼手冊，周圍親朋好友團購首選！",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/OOElEYrm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 6880m,
                QuantityLimit = 240
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 31,
                ProjectId = 5,
                ProjectName = "開啟與孩子的第一場程式冒險 《解碼傳說 CO·DECODE》",
                ProjectPlanId = 4,
                PlanTitle = "《解碼傳說 CO·DECODE》",
                PlanFundedPeople = 5,
                PlanDescription = "《解碼傳說 CO·DECODE》10組與10本完整大解析，揪團挑戰最佳方案！！",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/qp8nlSQm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 16400m,
                QuantityLimit = 230
            });
            //第6個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 6,
                MemberId = 6,
                ProjectName = "SWOL 雙水箱旋轉拖把 | 分離淨水和污水，才是真正的乾淨",
                Category = "科技設計",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 3, 25),
                EndDate = new DateTime(2021, 4, 25),
                Fundedpeople = 131,
                FundingAmount = 132975m,
                AmountThreshold = 100000m,
                CreatorName = "SWOL",
                ProjectMainUrl = "https://i.imgur.com/YwrOaYYm.jpg",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:		320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/X0SUgevl.jpg",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "https://i.imgur.com/orQ8HcD.jpg,https://i.imgur.com/hlzHEoh.jpg,https://i.imgur.com/QZEu1IV.gif,https://i.imgur.com/wOXJpH8.jpg,https://i.imgur.com/8bIzSJY.gif,https://i.imgur.com/nlU6CzQ.jpg,https://i.imgur.com/oWfBErd.jpg,https://i.imgur.com/AMje1iS.gif,https://i.imgur.com/I0YADR1.jpg,https://i.imgur.com/aszux4j.jpg,https://i.imgur.com/h4Luebc.jpg,https://i.imgur.com/unf9sle.gif,https://i.imgur.com/Nt3MGP9.jpg,https://i.imgur.com/EPlBeuG.jpg,https://i.imgur.com/kQnCA8z.jpg",
                //	原圖格式
                ProjectVideoUrl = "https://www.youtube.com/embed/bOvZt-Rn590",
                Project_Question = "《SWOL雙水箱旋轉拖把》水箱內置的毛刷是否需要定期更換或清洗？,《SWOL雙水箱旋轉拖把》的水箱應該要如何清理呢？,《SWOL雙水箱旋轉拖把》如果故障應該如何修理？,耗材（拖把毛、水箱內毛刷）要在哪裡購買更換？",
                Project_Answer = "毛刷不需要更換，採用的是尼龍材料，韌性和強度都比較好。若使用上造成損壞，未來官網也會提供備品讓您可以付費更換！,清水區的蓋子拿掉之後，清水區和髒水區都是可以直接清洗的，搭配小刷子清潔的話會更乾淨喔！,基本故障可以透過購買零件自行更換，也可以送回SWOL團隊，由我們替您處理。,未來官網我們會上架備品給各位選購，請放心下單！",
                ProjectPlansCount = 5,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 12, 20),
                ApprovingStatus = 2


            });
            //第6個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 6,
                MemberAccount = "NO6member",
                MemberPassword = "NO6memberPassword",
                MemberName = "SWOL",
                MemberAddress = "100台北市中正區重慶南路一段122號",
                MemberBirth = new DateTime(1975, 12, 3),
                MemberConEmail = "12348@gmail.com",
                MemberRegEmail = "12348@gmail.com",
                MemberMessage = "",
                MemberPhone = "0935-123450",
                MemberTeamName = "SWOL",
                MemberWebsite = "https://www.facebook.com/SWLOCleaning",
                AboutMe = "SWOL淨污家居，致力於研發設計簡單、人性化的家庭清潔產品，我們的第一個作品即將登場：「SWOL 雙水箱旋轉拖把」",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/qtaujCet.png",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第6個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 32,
                ProjectId = 6,
                ProjectName = "SWOL 雙水箱旋轉拖把 | 分離淨水和污水，才是真正的乾淨",
                ProjectPlanId = 1,
                PlanTitle = "SWOL 雙水箱旋轉拖把 1 組",
                PlanFundedPeople = 83,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/Z6uzD7Xm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 949m,
                QuantityLimit = 120
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 33,
                ProjectId = 6,
                ProjectName = "SWOL 雙水箱旋轉拖把 | 分離淨水和污水，才是真正的乾淨",
                ProjectPlanId = 2,
                PlanTitle = "SWOL 雙水箱旋轉拖把 1 組",
                PlanFundedPeople = 0,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/VSBASBjm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1090m,
                QuantityLimit = 220
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 34,
                ProjectId = 6,
                ProjectName = "SWOL 雙水箱旋轉拖把 | 分離淨水和污水，才是真正的乾淨",
                ProjectPlanId = 3,
                PlanTitle = "SWOL 拖把替換布 5 片",
                PlanFundedPeople = 42,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/o3AAjwYm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 399m,
                QuantityLimit = 320
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 35,
                ProjectId = 6,
                ProjectName = "SWOL 雙水箱旋轉拖把 | 分離淨水和污水，才是真正的乾淨",
                ProjectPlanId = 4,
                PlanTitle = "SWOL 雙水箱旋轉拖把 5 組",
                PlanFundedPeople = 0,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/zmYG4eem.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 4450m,
                QuantityLimit = 150
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 36,
                ProjectId = 6,
                ProjectName = "SWOL 雙水箱旋轉拖把 | 分離淨水和污水，才是真正的乾淨",
                ProjectPlanId = 5,
                PlanTitle = "1. SWOL 雙水箱旋轉拖把 10 組 2. 主揪額外贈送拖把替換布 5 片",
                PlanFundedPeople = 6,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/Fi1P2lMm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 7490m,
                QuantityLimit = 40
            });
            //第7個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 7,
                MemberId = 7,
                ProjectName = "一場集結展現消費端聲音的「珍惜 ‧ 真食物蹲點募資計畫」",
                Category = "公共在地",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 3, 25),
                EndDate = new DateTime(2021, 4, 25),
                Fundedpeople = 36,
                FundingAmount = 33400m,
                AmountThreshold = 200000m,
                CreatorName = "致理未來超市",
                ProjectMainUrl = "https://i.imgur.com/RocoEApm.png",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/dl6fEiWl.png",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "https://i.imgur.com/JisMTKT.png,每當你走進超市，是不是常常看見店員下架那些賣不完的商品與生鮮蔬果？,https://i.imgur.com/mfgslQd.jpg,https://i.imgur.com/pHi8vPt.jpg,《珍食物APP》起源與我們在致理科技大學開的一間小小的有機超市，我們抱著對台灣這片土地的熱愛與信仰，期待能讓更多致理的師生看見農業的美好與價值。,https://i.imgur.com/gtvyz19.jpg,https://i.imgur.com/zovAJtm.jpg,https://i.imgur.com/z46j9QH.jpg,https://i.imgur.com/UsACKQU.jpg,https://i.imgur.com/IcFb8l4.jpg,https://i.imgur.com/EcyCQtW.jpg,https://i.imgur.com/jax2s3k.jpg,1.在賣場或超市購物時，你會想要?,https://i.imgur.com/BlyJXRz.png,2.對於這麼大量的即期品，您覺得最有效處理的方式是?,https://i.imgur.com/Ge7Kd1Z.jpg,https://i.imgur.com/6o10wgt.png,https://i.imgur.com/oIMePar.jpg,https://i.imgur.com/84Pifbj.png,https://i.imgur.com/hZ9Rc05.jpg,https://i.imgur.com/MW2BqCd.jpg,https://i.imgur.com/w7g5w93.jpg,https://i.imgur.com/bjMRpv4.jpg,https://i.imgur.com/9vtUxp0.jpg,https://i.imgur.com/IiQbmu9.jpg,https://i.imgur.com/4KRfnYg.jpg,https://i.imgur.com/aVMe3Q4.jpg,https://i.imgur.com/O8XsvmP.jpg,https://i.imgur.com/f7sloEf.jpg,https://i.imgur.com/cMANfQx.jpg,https://i.imgur.com/38Avtj5.png,https://i.imgur.com/dF6oYtO.jpg,https://i.imgur.com/8bkmG9F.jpg,https://i.imgur.com/Cf7SQYL.jpg,https://i.imgur.com/eUyxhgn.jpg,https://i.imgur.com/AxIWrdL.jpg,https://i.imgur.com/k77zDYt.jpg,https://i.imgur.com/6b5PR4T.jpg,https://i.imgur.com/E8uhoU1.png,https://i.imgur.com/KgIFdG5.png,https://i.imgur.com/euA0AIi.png,https://i.imgur.com/Xu2MrGN.png,https://i.imgur.com/MTOfWQk.jpg,https://i.imgur.com/y6WAarM.png",
                //	Large Thumbnail 格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/11l_A0vW32w",
                Project_Question = "請問珍食幣是什麼？ 該如何使用呢？,我的地區沒有在開發名單中的前三名內，那珍食幣該如何處理呢?,未來是否有機會前往其他地區開發商家呢?,小農商品可以任意拆分選配嗎? 例如世芳有機茗茶園的茶糖搭配樸食小舖的當季果醬,我是商家，我想與《珍食物APP》進行合作，請問我可以找誰洽談呢?",
                Project_Answer = "珍食幣是《珍食物APP》專用的虛擬貨幣。當你使用《珍食物APP》結帳購買即期品時，你可以用珍食幣換取與台幣幣值1:1的即期品。,募資結束後，我們將會公布統計開發商家的地區，並向每位贊助者進行聯繫。若你的所在地不在開發商家的前三名內，你可以自由選擇將珍食幣兌換成等值的小農商品，也可以選擇將珍食幣保留在我們未來第二次募資計畫做使用。,有的！本次募資計畫是《珍食物APP》第一階段的募資計畫，當我們完成本次計畫內容後，會根據這次開發商家的經驗與使用者回饋，在舉辦第二階、第三階的募資計劃，請持續關注我們的粉絲專頁，了解最新的開發商家進度哦！,我們的小農商品是【不能拆分選配】的哦！,可以私訊我們粉絲專頁詢問小編哦！我們非常高興有志同道合的夥伴，願意與我們一起改變剩食 >> https://www.facebook.com/GoingFM",
                ProjectPlansCount = 5,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 12, 20),
                ApprovingStatus = 2


            });
            //第7個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 7,
                MemberAccount = "NO7member",
                MemberPassword = "NO7memberPassword",
                MemberName = "致理未來超市",
                MemberAddress = "100台北市中正區重慶南路一段122號",
                MemberBirth = new DateTime(1998, 12, 3),
                MemberConEmail = "12349@gmail.com",
                MemberRegEmail = "12349@gmail.com",
                MemberMessage = "",
                MemberPhone = "0935-123449",
                MemberTeamName = "致理未來超市",
                MemberWebsite = "https://lohas.acsite.org/",
                AboutMe = "初心，是未來超市開始這一切的理由、是我們一切行動的起點，在科技日新月異的現代，食物變得唾手可得，而簡單取得食物的背後，似乎也讓人們逐漸忘記珍惜食物的重要，造成台灣剩食問題日益嚴重，而這一切，讓我們更確信該前進的道路。",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/fE26Ycnt.png",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第7個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 37,
                ProjectId = 7,
                ProjectName = "一場集結展現消費端聲音的「珍惜 ‧ 真食物蹲點募資計畫」",
                ProjectPlanId = 1,
                PlanTitle = "【單純贊助，感謝有你】",
                PlanFundedPeople = 6,
                PlanDescription = "回饋品內容：‧每季蹲點進度報告 ‧珍提袋 ×1(單純贊助，不計算在未來開發商家的統計中)",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/TebfrQ4m.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 300m,
                QuantityLimit = 80
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 38,
                ProjectId = 7,
                ProjectName = "一場集結展現消費端聲音的「珍惜 ‧ 真食物蹲點募資計畫」",
                ProjectPlanId = 2,
                PlanTitle = "【改變剩食的第一步】",
                PlanFundedPeople = 11,
                PlanDescription = "回饋品內容：‧統計你的所在地開發商家 ‧每季蹲點進度報告 ‧珍食幣 $150 (珍食幣為台幣幣值1: 1的虛擬貨幣，你能用珍食物APP購買相同定價的即期品)",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/DbcfFvqm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 500m,
                QuantityLimit = 90
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 39,
                ProjectId = 7,
                ProjectName = "一場集結展現消費端聲音的「珍惜 ‧ 真食物蹲點募資計畫」",
                ProjectPlanId = 3,
                PlanTitle = "【改變剩食的推手】",
                PlanFundedPeople = 14,
                PlanDescription = "回饋品內容：‧統計你的所在地開發商家 ‧每季蹲點進度報告 ‧珍食物APP感謝頁列名 ‧珍食幣 $300 (珍食幣為台幣幣值1: 1的虛擬貨幣，你能用珍食物APP購買相同定價的即期品)",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/Q45lve9m.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 800m,
                QuantityLimit = 20
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 40,
                ProjectId = 7,
                ProjectName = "一場集結展現消費端聲音的「珍惜 ‧ 真食物蹲點募資計畫」",
                ProjectPlanId = 4,
                PlanTitle = "【改變剩食的推手】",
                PlanFundedPeople = 5,
                PlanDescription = "回饋品內容：‧統計你的所在地開發商家 ‧每季蹲點進度報告 ‧珍食物APP感謝頁列名 ‧小農商品(M) ‧珍食幣 $500 (珍食幣為台幣幣值1: 1的虛擬貨幣，你能用珍食物APP購買相同定價的即期品) ‧剩食講座",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/7h1NFxzm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1600m,
                QuantityLimit = 70
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 41,
                ProjectId = 7,
                ProjectName = "一場集結展現消費端聲音的「珍惜 ‧ 真食物蹲點募資計畫」",
                ProjectPlanId = 5,
                PlanTitle = "【改變剩食的推手】",
                PlanFundedPeople = 3,
                PlanDescription = "回饋品內容：‧統計你的所在地開發商家 ‧每季蹲點進度報告 ‧珍食物APP感謝頁列名 ‧小農商品(M)  ‧珍提袋 ×1 ‧珍食幣 $800 (珍食幣為台幣幣值1: 1的虛擬貨幣，你能用珍食物APP購買相同定價的即期品) ‧剩食講座",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/g8vpmrVm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 2300m,
                QuantityLimit = 80
            });
            //第8個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 8,
                MemberId = 8,
                ProjectName = "《小狗大盜》| 淡江大傳第35屆畢業製作拍攝計畫",
                Category = "藝術影視",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 3, 15),
                EndDate = new DateTime(2021, 4, 25),
                Fundedpeople = 10,
                FundingAmount = 4266m,
                AmountThreshold = 100000m,
                CreatorName = "半獸人工作室 ORC Studio",
                ProjectMainUrl = "https://i.imgur.com/ObjlmhQm.png",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/P9mVbH2l.png",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "https://i.imgur.com/R0MQUuP.png,淡江大學大眾傳播學系舉行畢製展演已有二十多年，我們希望帶領大眾探討各種議題與多元行銷，藉由影像、聲音、圖文、新媒體等媒介，傳遞真實故事與社會現象。讓各位與我們一起關懷社會。歷年來，學長姐也製作了不少作品，我們的創意及成果也受到各方肯定。,https://i.imgur.com/UVbdclW.png,https://i.imgur.com/vRfk7hF.png,嗨！您好！我們是來自淡江大學大眾傳播學系四年級的學生。我們正在執行大四畢業製作的拍攝。在大學四年中，我們拍過不少的影片，也從中累積了些許經驗；而現在的畢業製作也將會是我們學生時期的最後一部作品，期許將這四年之所學，發揮的淋漓盡致，展現我們熱血的青春。,半獸人”的名稱由來半獸人工作室共有8名成員，名稱由來是因為我們覺得年輕世代的想法總是想要突破框架，跳脫種種的限制，如同橫衝直撞的野獸般，不畏懼外在的眼光，然而入社會後，許多壓力，使大家都變成一個行屍走肉、沒有靈魂的殭屍人。在這大學的最後一年，也是我們即將蛻變，離社會職場最近的距離。我們希望在現實的社會裡，可以保有天馬行空的想法，在未來成為一個能發揮自如的半獸人！,https://i.imgur.com/Ghlhk4R.png,劉建瑋是一名靠外送維生的年輕人，某天看見一則高額的尋狗啟事，便突發奇想的決定要來「偷狗騙錢」，藉由外送工作鎖定有錢的飼主，偷走狗後再送回去騙取獎金。但後來劉建瑋卻因為遇到不良飼主，意外的開始照顧起了狗，一人一狗也在過程中漸漸建立起互相陪伴的親密情感。,https://i.imgur.com/vTTXX20.png,昔日在討論畢業製作的主題選材時，我們覺得現在許多年輕人對生活沒有期待，對比生活現況，常在理想與現實間產生矛盾，年輕人不願生活被工作佔據，同時又需要追求物質生活，就這樣渾渾噩噩、日復一日過著無所目標的人生，內心也逐漸對世界感到冷漠。其實大家真正需要的只是一個心靈慰藉。曾經看過一本人生哲理的書，就是關於貪婪與偷狗的故事，使我們印象深刻，便毅然決然採用這個主題。另外有鑑於學生製片，很少會創作喜劇，因此產生了想挑戰的雄心。,《小狗大盜》片名是由劇組全體一起發想。其含義有三，可説是一語三關。一、小狗「大盜」指的是男主角建瑋，在劇情中建瑋為了懸賞金而去偷狗，因此成為了偷小狗的大盜。二、「小狗」大盜，也暗喻著建瑋的生活，如被棄養的流浪狗般落魄。三、「小狗」大盜，指的是主角狗Kuma。意想不到的狀況，讓Kuma悄悄地進入了建瑋的生活，偷走建瑋的心，也漸漸地改變了他的生活。小狗大盜英文片名為Plan D，其中D代表Dog的意思，Plan象徵著建瑋的偷狗計畫,https://i.imgur.com/mgGZDaI.png,https://i.imgur.com/CFmwsRE.png,https://i.imgur.com/XXlytXz.png,https://i.imgur.com/tIFHv7W.png,劉建瑋：男性，25歲，全職外送員。劉建瑋一直都讀不好書，他喜歡交朋友，和他們一起到處玩樂。大學畢業時也只是勉強過關。因此畢業後沒有專長的建瑋便選擇繼續做他從大學就有在兼職的外送工作，他認為只要能賺錢養活自己就好，對其他人事物漠不關心。他喜歡夾娃娃，賺了一些錢後總是會拿一部份去玩夾娃娃機，房間也擺放了不少他的娃娃，或許這些娃娃就是孤單的他僅剩的朋友。KUMA：寵物主角犬。原是貴婦養的狗狗，後來被建瑋偷走。因主人對牠漠不關心，也沒有想要贖回牠的意思，後來便跟隨建瑋生活，而且也改變了建瑋冷漠的心。曾陳肉圓：走失犬。活潑好動，經常不見。幸虧主人很富有，經常用錢贖回肉圓。,https://i.imgur.com/S1cc6yl.png,https://i.imgur.com/9LQeAxC.png,https://i.imgur.com/WIxOUKil.png,https://i.imgur.com/q8LYWNs.png,嗨!各位正在瀏覽本專案的朋友們，您們好！非常感謝您騰出寶貴的時間閲讀本專案。如果認同我們的議題，喜歡我們的故事，希望藉助您的力量，支持半獸人工作室。讓這部帶來歡笑與溫馨的影片，給更多人看見。由於我們為學生劇組，拍攝期間需要的各項開銷，對於劇組成員來說，是一大負擔，目前35萬的資金來源，75％(25萬)已由半獸人劇組自行出資，其餘25％(10萬)需要大家的協助，共同完成這部年輕人與寵物的喜劇片。大家的支持是我們堅持下去的動力！",
                //	Large Thumbnail 格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/d1OXuQggjWk",
                Project_Question = "",
                Project_Answer = "",
                ProjectPlansCount = 3,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 12, 20),
                ApprovingStatus = 2


            });
            //第8個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 8,
                MemberAccount = "NO8member",
                MemberPassword = "NO8memberPassword",
                MemberName = "半獸人工作室 ORC Studio",
                MemberAddress = "100台北市中正區重慶南路一段122號",
                MemberBirth = new DateTime(2000, 12, 3),
                MemberConEmail = "12350@gmail.com",
                MemberRegEmail = "12350@gmail.com",
                MemberMessage = "",
                MemberPhone = "0935-123450",
                MemberTeamName = "半獸人工作室 ORC Studio",
                MemberWebsite = "https://instagram.com/plan.__d?igshid=1llnk7oc29dvy",
                AboutMe = "嗨！您好！我們是來自淡江大學大衆傳播學系四年級的學生。 這個團隊是由一群熱愛電影的同學們組成，我們享受拍片的過程，喜歡用鏡頭跟觀眾說故事，希望將這四年的課堂及課餘所學，發揮出來，展現我們的熱血與熱情。 “半獸人”的名稱由來： 年輕世代的想法總是突破現實的框架，跳脫種種的限制。天馬行空可謂是我們腦袋的代名詞，如同橫衝直撞的野獸般，不畏懼外在的眼光，走出自己瘋狂的道路。入社會後，許多壓力，使大家都變成一個行屍走肉、沒有靈魂、按照慣例行事的殭屍人。 在這大學的最後一年，也是我們即將蛻變，離社會職場最近的距離。我們希望在現實的大鴻溝裡，可以保有天真爛漫的幻想，",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/hNwrZpRt.png",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第8個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 42,
                ProjectId = 8,
                ProjectName = "《小狗大盜》| 淡江大傳第35屆畢業製作拍攝計畫",
                ProjectPlanId = 1,
                PlanTitle = "180 | 劇本半年後的時程，也代表了主角在180天後的轉變",
                PlanFundedPeople = 3,
                PlanDescription = "回饋內容：✓ 明信片1款 ✓ 片尾感謝",
                PlanShipDate = new DateTime(2021, 5, 10),
                PlanImgUrl = "https://i.imgur.com/vxeNl2mm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 180m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 43,
                ProjectId = 8,
                ProjectName = "《小狗大盜》| 淡江大傳第35屆畢業製作拍攝計畫",
                ProjectPlanId = 2,
                PlanTitle = "531 | 外送員，這是一個外送青年的故事",
                PlanFundedPeople = 1,
                PlanDescription = "回饋內容：✓ 貼紙1款 ✓ 明信片1款 ✓ 片尾感謝",
                PlanShipDate = new DateTime(2021, 5, 10),
                PlanImgUrl = "https://i.imgur.com/4w5f9s1m.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 531m,
                QuantityLimit = 30
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 44,
                ProjectId = 8,
                ProjectName = "《小狗大盜》| 淡江大傳第35屆畢業製作拍攝計畫",
                ProjectPlanId = 3,
                PlanTitle = "888 | 恭喜發財，祝大家發發發",
                PlanFundedPeople = 0,
                PlanDescription = "回饋內容：✓ 貼紙1款 ✓ 明信片3款 ✓ 片尾感謝",
                PlanShipDate = new DateTime(2021, 5, 10),
                PlanImgUrl = "https://i.imgur.com/o5ubgxym.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 888m,
                QuantityLimit = 60
            });
            //第9個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 9,
                MemberId = 9,
                ProjectName = "拍拍打｜SWDK無線吸塵除螨機",
                Category = "科技設計",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 3, 20),
                EndDate = new DateTime(2021, 4, 30),
                Fundedpeople = 125,
                FundingAmount = 327820m,
                AmountThreshold = 100000m,
                CreatorName = "潤益國際",
                ProjectMainUrl = "https://i.imgur.com/3QZROEUm.jpg",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/3QZROEUl.jpg",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "https://i.imgur.com/bV1ou6W.jpg,https://i.imgur.com/Lbgvfpn.gif,https://i.imgur.com/9LFSMAu.jpg,https://i.imgur.com/5pkdnR0.jpg,https://i.imgur.com/0DA7W2x.gif,https://i.imgur.com/AEsQWIO.jpg,https://i.imgur.com/rysyQiQ.gif,https://i.imgur.com/LIkBRa0.jpg,https://i.imgur.com/MyGNBEi.gif,https://i.imgur.com/bFOznBb.jpg,https://i.imgur.com/EW3tFWr.jpg,https://i.imgur.com/9jNrMht.gif,https://i.imgur.com/w15e7J6.jpg,https://i.imgur.com/hNBjGIl.gif,https://i.imgur.com/pM4pSaz.jpg,https://i.imgur.com/K7625df.gif,https://i.imgur.com/aOoS98B.jpg,https://i.imgur.com/JKPbpP3.gif,https://i.imgur.com/wms0o1T.jpg,https://i.imgur.com/6Aofgzw.gif,https://i.imgur.com/sQGQbGh.jpg,https://i.imgur.com/iIpK1RO.jpg,https://i.imgur.com/oEsLRNk.jpg,https://i.imgur.com/gLCEFB6.gif,https://i.imgur.com/2Gyxh6Q.jpg,https://i.imgur.com/TvBTLIw.jpg,https://i.imgur.com/wSdRkeM.gif,https://i.imgur.com/0qogBvx.jpg,https://i.imgur.com/18BDTV.gif,https://i.imgur.com/BdqNLS8.jpg,https://i.imgur.com/XGT6Xac.gif,https://i.imgur.com/MTKrm6D.jpg,https://i.imgur.com/WXog2ev.jpg,https://i.imgur.com/G3vu6A9.gif,https://i.imgur.com/2qm4zvy.jpg,https://i.imgur.com/RaVSzdz.gif,https://i.imgur.com/98J6IvH.jpg,https://i.imgur.com/u9l5wVr.jpg,https://i.imgur.com/0lnS5x7.gif,https://i.imgur.com/7rV7WYP.jpg,https://i.imgur.com/DWdbRAs.jpg,https://i.imgur.com/faM0P4Z.jpg,https://i.imgur.com/y4hyzgv.png,https://i.imgur.com/ngK9Lshl.jpg,https://i.imgur.com/m14u6nR.jpg,https://i.imgur.com/0iU88Yk.jpg,https://i.imgur.com/Yd3dVfU.png",
                //	Large Thumbnail 格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/d1OXuQggjWk",
                Project_Question = "贊助者如何知道專案的進度？,如何支付贊助費用？,產品相關問題,我會在什麼時候收到商品呢？,運費相關問題,保固服務,聯絡客服",
                Project_Answer = "我們會建議提案者將計畫的相關過程（開始執行到完成）以及寄送回饋的最新訊息，都公告在專案頁的【進度】中。當專案結束時系統會寄送 Email 通知所有贊助人，讓贊助者了解目前的最新進度。,付款方式有：信用卡、ATM（WebATM／ATM 櫃員機）、超商付款。① 【信用卡一次付清】支援卡別：VISA、MasterCard、JCB、銀聯。◎ VISA 金融卡 需已開通網路交易功能。◎ 每筆贊助於信用卡帳單上顯示的交易明細為「藍新－集資車車群眾募資平台」，不會列出募資專案名稱或回饋品的內文資訊。② 【信用卡分期付款】（提案者選擇是否開放）支援卡別：VISA、MasterCard、JCB。◎ 每筆贊助於信用卡帳單上顯示的交易明細為「綠界 - 昂圖股份有限公司」，不會列出募資專案名稱或回饋品的內文資訊。可分期數：3 期 及 6 期可分期銀行：中信、台新、玉山、永豐◎ 信用卡分期各期金額，需依發卡銀行實際計算方式為準，一般依選擇期數平均每期付款，不足額部分併入第 1 期計算。如對信用卡分期金額有異議，請與您的發卡行聯繫確認。◎ 在您使用分期付款時，銀行會確認您的信用卡額度是否高於「贊助總額」，而非一期的費用。所以請您在訂購前先確認額度是否足夠，否則會贊助不成功。◎ 如您使用的信用卡本身已具備分期功能，例如大眾銀行分期卡，訂購時請選,想了解是否很耗電、機體會不會發燙、電池安不安全？►產品使用锂电池，可以满足家庭一次性正常清洁的需要；同时正常使用电池包是安全的；如若不使用，機器需存放在干燥的環境下；長时间不使用機器需每隔3个月充一次电避免過度放电使用時聲音會不會很大？► 噪音：≤ 68dB，聲音不會太大，放心使用充電之後可以使用多久？►正常情况下一次充满电电约可以使用25分钟拍拍打無線塵蟎機適用的電壓及插座是？►100V - 240V~50 / 60Hz 0.4A,110年5月按照訂單順序出貨，感謝您的耐心等候,運費如何計算►拍拍打團隊出貨都含運費。是否有提供海外運送？►沒有，不提供海外運送團購方案可以分送不同地址嗎？►團購是含單點運費,如果要送多點運費另計,保固期限• 憑本產品保固卡，凡購買本商品可享一年商品保固服務(非人為因素破壞之情況下)。• 自收到商品起10日內，本產品出現『產品性能故障表』所列性能故障的情況，經由潤益國際有限公司售後服務人員檢測確認，可免費安排商品退貨或換貨服務。• 保固期間維修運費計算，由客戶自行寄回檢修商品；於檢修完成後，由我司支付運費寄回。過保期限則依照維修部分報價維修。• 本保固書如有遺失，恕不補發，敬請妥善保存。,潤益國際營業時間：週一至週五09:00 - 12:30、13:30 - 18:00聯絡信箱：shop@richmore.com.tw",
                ProjectPlansCount = 5,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 12, 20),
                ApprovingStatus = 2


            });
            //第9個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 9,
                MemberAccount = "NO9member",
                MemberPassword = "NO9memberPassword",
                MemberName = "潤益國際",
                MemberAddress = "100台北市中正區重慶南路一段122號",
                MemberBirth = new DateTime(1970, 12, 3),
                MemberConEmail = "12352@gmail.com",
                MemberRegEmail = "12352@gmail.com",
                MemberMessage = "",
                MemberPhone = "0935-123452",
                MemberTeamName = "潤益國際",
                MemberWebsite = "https://instagram.com/plan.__d?igshid=1llnk7oc29dvy",
                AboutMe = "Hi ~ 我們是拍拍打台灣代理商，潤益國際 致力於提供方便好用高CP值的家電產品，幫助每個家庭有更多時間享受生活～ 90%過敏、氣喘兒的救星，灰塵 皮屑 除螨一次到位，清潔交給 拍拍打｜SWDK無線吸塵除螨機",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/YqvvtMXt.png",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第9個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 45,
                ProjectId = 9,
                ProjectName = "拍拍打｜SWDK無線吸塵除螨機",
                ProjectPlanId = 1,
                PlanTitle = "► 限量優惠價 ",
                PlanFundedPeople = 117,
                PlanDescription = "► 台灣保固1年 ►預購市售價 $3480",
                PlanShipDate = new DateTime(2021, 5, 10),
                PlanImgUrl = "https://i.imgur.com/60FYPzRm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 2480m,
                QuantityLimit = 200
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 46,
                ProjectId = 9,
                ProjectName = "拍拍打｜SWDK無線吸塵除螨機",
                ProjectPlanId = 2,
                PlanTitle = "► 拍拍打｜ Swdk無線吸塵除螨機一台 ",
                PlanFundedPeople = 5,
                PlanDescription = "► 台灣保固1年 ►預購市售價 $3480",
                PlanShipDate = new DateTime(2021, 5, 10),
                PlanImgUrl = "https://i.imgur.com/Wlk4E9Vm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 2780m,
                QuantityLimit = 130
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 47,
                ProjectId = 9,
                ProjectName = "拍拍打｜SWDK無線吸塵除螨機",
                ProjectPlanId = 3,
                PlanTitle = "► 拍拍打｜ Swdk無線吸塵除螨機三台 ",
                PlanFundedPeople = 0,
                PlanDescription = "► 台灣保固1年 ►預購市售價 $10440",
                PlanShipDate = new DateTime(2021, 5, 10),
                PlanImgUrl = "https://i.imgur.com/PhkMIV7m.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 7740m,
                QuantityLimit = 150
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 48,
                ProjectId = 9,
                ProjectName = "拍拍打｜SWDK無線吸塵除螨機",
                ProjectPlanId = 4,
                PlanTitle = "► 拍拍打｜ Swdk無線吸塵除螨機五台 ",
                PlanFundedPeople = 0,
                PlanDescription = "► 台灣保固1年 ►預購市售價 $17440",
                PlanShipDate = new DateTime(2021, 5, 10),
                PlanImgUrl = "https://i.imgur.com/9gFiS6xm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 12400m,
                QuantityLimit = 200
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 49,
                ProjectId = 9,
                ProjectName = "拍拍打｜SWDK無線吸塵除螨機",
                ProjectPlanId = 5,
                PlanTitle = "► 拍拍打｜ Swdk無線吸塵除螨機十台 ",
                PlanFundedPeople = 0,
                PlanDescription = "► 台灣保固1年 ►預購市售價 $34800",
                PlanShipDate = new DateTime(2021, 5, 10),
                PlanImgUrl = "https://i.imgur.com/MWxcnJem.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 23800m,
                QuantityLimit = 200
            });
            //第10個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 10,
                MemberId = 10,
                ProjectName = "一個把廢物變寶物的塑膠資源再生計畫-不垃圾場",
                Category = "公共在地",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 4, 7),
                EndDate = new DateTime(2021, 5, 1),
                Fundedpeople = 39,
                FundingAmount = 81000m,
                AmountThreshold = 350000m,
                CreatorName = "不垃圾場",
                ProjectMainUrl = "https://i.imgur.com/BItzv0vm.jpg",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/PgIzBeIl.jpgl.jpg",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "https://i.imgur.com/4RPQQYe.jpg,https://i.imgur.com/STYm7Ch.jpg,https://i.imgur.com/qxZdqFT.jpg,https://i.imgur.com/hm9weGo.jpg,https://i.imgur.com/YMHNtyn.jpg,https://i.imgur.com/Jjnt56N.jpg,https://i.imgur.com/5ECdXZv.jpg,https://i.imgur.com/wtEZLbk.jpg,https://i.imgur.com/X8gHZol.jpg,https://i.imgur.com/DKaPGql.jpg,https://i.imgur.com/cZm1b27.jpg,https://i.imgur.com/DPZ02id.jpg,https://i.imgur.com/5OYzRRe.jpg,https://i.imgur.com/5ChxFb4.jpg,https://i.imgur.com/6I7kik4.jpg,https://i.imgur.com/DprtvkW.jpg,https://i.imgur.com/2kb15SX.jpg,https://i.imgur.com/Zg3hI49.jpg,https://i.imgur.com/mjN5wgl.jpg,https://i.imgur.com/0hW7Z2W.jpg,https://i.imgur.com/wtpB7wu.jpg",
                //	Large Thumbnail 格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/z-ukGL9KlzI",
                Project_Question = "回饋品的材料來源？是誰做的？在哪裡做的？,回饋品對人體會有毒性嗎？,塑膠再生體驗過程中會不會產生有毒氣體？有何防護措施？,請問選擇塑膠再生體驗後續是什麼？舉辦地點在哪裡呢？,塑膠再生是一個解決問題拯救世界的方式，所以可以一直使用一次性塑膠？,為什麼回饋品的顏色是隨機出貨呢？,未來如果回饋品損壞或拋棄時怎麼辦？,如果有其他疑問該如何聯繫你們呢？",
                Project_Answer = "不垃圾場只收集商家與家庭產生的民生廢棄物，回饋品方面再生鑰匙圈和花磚材質皆為聚丙烯（PP），零錢包與卡片夾材質皆為低密度聚乙烯（LDPE），以上兩種材質於塑膠種類中相對安全與穩定的材質，全程由不垃圾場團隊在不垃圾場製作，百分之百純廢棄物再生，百分之百台灣製造。,塑膠二次料來源本身就複雜難以追溯，加上台灣法規規定二次料不能用在食用相關的用途。所以在回饋品的來源與材質選擇上，我們都認真把關多以食品或食器相關等一次性塑膠作為原料，觸碰身體與配戴都沒有問題，請避免回饋品接觸到熱源即可。,塑膠再生體驗課程皆使用塑膠材質中最穩定安全的材質“PP聚丙烯”（回收號碼5號）作為體驗教材，於創作加熱過程中會產生微量的有機蒸汽，與油漆、松香水、稀釋劑等有機溶劑所揮發出的氣體相似，製作現場會保持排風，若是害怕味道自備市售的活性碳口罩；塑膠再生的製作方式為熱融塑膠，不是燃燒塑膠，於材質上、做法上都不會產生像戴奧辛、二噁英等劇毒氣體，請不用過度擔心。,若是你選擇塑膠再生體驗，於募資過後我們將用emil與你聯繫預約體驗時間，不管是選擇哪種體驗，地點都在不垃圾場宜蘭的工作室進行。,這觀念不對，塑膠必須經過很多工序才有辦法安全、成功的被再生，不一定每次都會成功。這個計畫的初衷是讓大家開始善用塑膠，使用一次性的塑膠不是一個善用的行為。,因為我們收集到的塑膠廢棄物來源有很多種，塑膠色彩本就多變，無法製作出一模一樣的規格化商品，所以大家收到的回饋品都會是獨一無二的，絕對與他人不同。,我們認為必須要對自己所生產的物品負責任，若是回饋品損壞或要被拋棄時，可以寄回給不垃圾場，我們會再重新利用再製，延續此物件的生命。,你可以傳訊息至不垃圾場Facebook粉絲專頁或寫信至我們的信箱：trasholove@gmail.com",
                ProjectPlansCount = 8,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 12, 20),
                ApprovingStatus = 2


            });
            //第10個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 10,
                MemberAccount = "NO10member",
                MemberPassword = "NO10memberPassword",
                MemberName = "不垃圾場",
                MemberAddress = "100台北市中正區重慶南路一段122號",
                MemberBirth = new DateTime(1980, 12, 3),
                MemberConEmail = "12353@gmail.com",
                MemberRegEmail = "12353@gmail.com",
                MemberMessage = "",
                MemberPhone = "0935-123453",
                MemberTeamName = "不垃圾場",
                MemberWebsite = "http://www.trasholove.com/",
                AboutMe = "垃圾青年 不垃圾場是由Mai和Kaiy所組成的塑膠再生研究工作室我們相信世界上每一種資源都是有價值的，由於可被大量製造、成本低，塑膠一直以來被市場塑造成便宜可丟棄的廉價品形象，其實塑膠這個材質比我們想像得更有潛力也更有趣，可塑性高又堅固，是可重複使用且大有潛力的一種珍貴材料！ 從塑膠的研究、收集、清洗、設計、再生，我們全部自己來！我們的目標是讓塑膠在進入焚化爐或掩埋場之前給它一次機會能被重複使用，尋找另一種可能性讓塑膠可以被重複利用，同時啟發與改變大眾對於塑膠這個材質的想像與價值。",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/rA2Tu28t.jpg",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第10個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 50,
                ProjectId = 10,
                ProjectName = "一個把廢物變寶物的塑膠資源再生計畫-不垃圾場",
                ProjectPlanId = 1,
                PlanTitle = "塑膠再生寶石耳環x1對 ",
                PlanFundedPeople = 3,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 5, 11),
                PlanImgUrl = "https://i.imgur.com/tKxVktQm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 450m,
                QuantityLimit = 160
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 51,
                ProjectId = 10,
                ProjectName = "一個把廢物變寶物的塑膠資源再生計畫-不垃圾場",
                ProjectPlanId = 2,
                PlanTitle = "塑膠再生鑰匙圈x4",
                PlanFundedPeople = 6,
                PlanDescription = "100 % 廢棄塑膠回收再生製作。不分顏色，隨機出貨。",
                PlanShipDate = new DateTime(2021, 5, 11),
                PlanImgUrl = "https://i.imgur.com/KOt8HMWm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 500m,
                QuantityLimit = 180
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 52,
                ProjectId = 10,
                ProjectName = "一個把廢物變寶物的塑膠資源再生計畫-不垃圾場",
                ProjectPlanId = 3,
                PlanTitle = "塑膠再生鑰匙圈x2 塑膠再生卡片夾x1 塑膠袋再生零錢包x1",
                PlanFundedPeople = 5,
                PlanDescription = "100 % 廢棄塑膠回收再生製作。不分顏色，隨機出貨。",
                PlanShipDate = new DateTime(2021, 5, 11),
                PlanImgUrl = "https://i.imgur.com/Yrk24clm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 750m,
                QuantityLimit = 200
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 53,
                ProjectId = 10,
                ProjectName = "一個把廢物變寶物的塑膠資源再生計畫-不垃圾場",
                ProjectPlanId = 4,
                PlanTitle = "塑膠再生鑰匙圈x2 塑膠再生卡片夾x1 塑膠袋再生零錢包x1 塑膠再生編織收納籃x1 六角形再生杯墊x2 極簡再生方形掛鐘x1",
                PlanFundedPeople = 5,
                PlanDescription = "100 % 廢棄塑膠回收再生製作。不分顏色，隨機出貨。",
                PlanShipDate = new DateTime(2021, 5, 11),
                PlanImgUrl = "https://i.imgur.com/22I4cjym.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1500m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 54,
                ProjectId = 10,
                ProjectName = "一個把廢物變寶物的塑膠資源再生計畫-不垃圾場",
                ProjectPlanId = 5,
                PlanTitle = "來硬的！塑膠再生深度體驗x1人",
                PlanFundedPeople = 4,
                PlanDescription = "塑膠再生花磚燈箱 x塑膠再生深入體驗工作坊 x一堂學校沒有教過的塑膠課",
                PlanShipDate = new DateTime(2021, 5, 11),
                PlanImgUrl = "https://i.imgur.com/GQ7nxDFm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 3000m,
                QuantityLimit = 15
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 55,
                ProjectId = 10,
                ProjectName = "一個把廢物變寶物的塑膠資源再生計畫-不垃圾場",
                ProjectPlanId = 6,
                PlanTitle = "一片巨大的阿花x1 神秘展覽preview邀請函",
                PlanFundedPeople = 2,
                PlanDescription = "100 % 再生回收製作",
                PlanShipDate = new DateTime(2021, 5, 11),
                PlanImgUrl = "https://i.imgur.com/BN2Vb7Xm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 4200m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 56,
                ProjectId = 10,
                ProjectName = "一個把廢物變寶物的塑膠資源再生計畫-不垃圾場",
                ProjectPlanId = 7,
                PlanTitle = "原創性物件開發，依據30人投票結果決定物件，並共同開發及作出物件。",
                PlanFundedPeople = 3,
                PlanDescription = "優先共享不垃圾場工作空間，讓我們一起用想像力跟實際作為去慶祝一個更好的未來。",
                PlanShipDate = new DateTime(2021, 8, 1),
                PlanImgUrl = "https://i.imgur.com/RWWy6sQm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 5000m,
                QuantityLimit = 30
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 57,
                ProjectId = 10,
                ProjectName = "一個把廢物變寶物的塑膠資源再生計畫-不垃圾場",
                ProjectPlanId = 8,
                PlanTitle = "社會企業責任鬥陣來",
                PlanFundedPeople = 1,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 8, 1),
                PlanImgUrl = "https://i.imgur.com/W8DaURRm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 30000m,
                QuantityLimit = 10
            });


            //第11個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 11,
                MemberId = 11,
                ProjectName = "SoulFa靈魂沙發第二張專輯< Slumber Days>",
                Category = "音樂",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 4, 7),
                EndDate = new DateTime(2021, 5, 7),
                Fundedpeople = 19,
                FundingAmount = 142680m,
                AmountThreshold = 350500m,
                CreatorName = "SoulFa 靈魂沙發",
                ProjectMainUrl = "https://i.imgur.com/eTKxhXTm.jpg",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/91YB27Wl.jpg",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "大家好！我們是SoulFa靈魂沙發！2019年的12 / 1我們發行了我們的首張專輯《SoulFa》，儘管2020很特別，但依然很幸運地能完售我們的巡迴、完售了所有實體專輯（港恩ㄉ心），我們相信這不是僥倖而是每一個你們真真實實的支持和喜歡。當你看到這裡時，我們的第二張專輯《Slumber Days》也即將抵達製作期的最後階段，為了能夠獲得這張專輯的完整體驗，我們誠摯邀請您用行動支持我們，讓我們一起迎接＼第二張專輯／的到來！我們要出第二張專輯了，靈魂沙發需要你們！募資動機上一張專輯的募資計畫，在小沙發們踴躍的支持下，周邊商品與專輯銷售一空。而這次，在希望大家都能安安穩穩得到專輯和周邊的前提下，我們將募資的時間加長與專輯預購數量增加，並且巡演計畫已經在規劃的路上了，很快就能夠跟大家見面，希望大家能夠穿著這次募資的商品，作伙相見歡。這次的專輯，將會帶給大家不同以往的感官享受，想看到不同面貌的我們，絕對不容錯過！周邊商品部分，也是全新的設計概念，在日常與時尚之間取得巧妙的平衡，不論何時何地，都能讓你呈現最有自信的一面！用言語難以形容，擁有過才知道成員介紹,https://i.imgur.com/yemG6vd.jpg,https://i.imgur.com/uazz8J2.jpg,《Slumber Days》專輯介紹「在季風的尾巴，繫上一排搖曳風鈴，等待候鳥歸來的季節，提醒你我曾經沈睡」-《沙發上的白日夢》關於沈睡，姿態存在千百種。有的人雙眼緊閉；有些人是鼾聲雷動；有些人看似清醒的在活動，實則在夢中快活，那叫夢遊。然而，有沒有一種可能，是旁人看你酣睡如泥，但其實你知道自己是神智清醒？究竟是沈睡亦或是清醒、是現實亦或是虛幻； 一切似乎終將成為魚樂之辯的哲學提問。而這次，靈魂沙發將邀請你和我們一同出走意識模糊的疆界，漫遊在沈睡的時光裡，尋找答案。第二張專輯總共會有9首精彩的創作，這次也特別收錄《留一盞燈給漫漫長夜》，在每個無邊的黑暗裡，讓我們找到你。歌詞,https://i.imgur.com/uazz8J2.jpg,活動與經歷《發行作品》2018發行單曲《PolyDream》《44 seconds road movie》 2019 發行單曲《Lover Song》《Rose and i.》《Hear Hear》 2019發行專輯《SoulFa》 2020發行單曲《夏日午睡》《留一盞燈給漫漫長夜》,《參與重要演出》2018 『Simple Day 台北簡單生活節X 尼古拉斯採購日』首演2019「2019 The Next Big Thing 大團誕生」入選演出2019「Simple Urban +」演出2019 『Lover Song 首演會』 feat.張淦勳、南西肯恩@Legacy mini2019 焦慮抑制劑＠糖果LIVE三層，北京2019 大團誕生 @Legacy Taipei2019 簡單生活節＠101水舞廣場2020 首發專輯『沙發上的白日夢』台灣北中南巡迴演唱會Sold Out2020 貴人散步音樂節2020 簡單生活音樂節,https://i.imgur.com/WeLQH5l.jpg,https://i.imgur.com/YEakXk0.jpg",
                //	Large Thumbnail 格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/s0VbGDaLnYk",
                Project_Question = "",
                Project_Answer = "",
                ProjectPlansCount = 4,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 12, 20),
                ApprovingStatus = 2


            });
            //第11個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 11,
                MemberAccount = "NO11member",
                MemberPassword = "NO11memberPassword",
                MemberName = "SoulFa 靈魂沙發",
                MemberAddress = "100台北市中正區重慶南路一段122號",
                MemberBirth = new DateTime(1999, 12, 3),
                MemberConEmail = "1235835@gmail.com",
                MemberRegEmail = "1235835@gmail.com",
                MemberMessage = "",
                MemberPhone = "0935-145874",
                MemberTeamName = "SoulFa 靈魂沙發",
                MemberWebsite = "",
                AboutMe = "來自台北的樂團，由四個大男孩組成，曲風受英式搖滾啟蒙，結合了對這世代生活的體驗，並與音樂融合，唱著他們對世界的態度 一張給靈魂休息的沙發，在生活中有個屬於「心」的角落，不僅是他們對音樂上的期許，更希望用輕鬆的氛圍、自由的旋律、療癒的聲響，讓他們的音樂無論在開心或是難過時，都陪伴在大家身旁。希望有朝一日能變成別人的陽光、 空氣、水，他們對音樂的執著，在於真摯地表現自己，透過具有傳染力的輕鬆 節奏，鼓勵大家不要陷入無限的日常循環，應該勇於闖蕩自己的不平凡。",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/vo6V6X3t.jpg",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第11個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 58,
                ProjectId = 11,
                ProjectName = "SoulFa靈魂沙發第二張專輯< Slumber Days>",
                ProjectPlanId = 1,
                PlanTitle = "「 純贊助 SoulFa 」不求回報的你最可愛，SoulFa愛你",
                PlanFundedPeople = 2,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 6, 1),
                PlanImgUrl = "https://i.imgur.com/os0iCyYm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 200m,
                QuantityLimit = 60
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 59,
                ProjectId = 11,
                ProjectName = "SoulFa靈魂沙發第二張專輯< Slumber Days>",
                ProjectPlanId = 2,
                PlanTitle = "「 SoulFa親筆簽名專輯 」第一張專輯都有了，第二張專輯還不買爆嗎？",
                PlanFundedPeople = 210,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 6, 1),
                PlanImgUrl = "https://i.imgur.com/1HFv9fNm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 480m,
                QuantityLimit = 1500
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 60,
                ProjectId = 11,
                ProjectName = "SoulFa靈魂沙發第二張專輯< Slumber Days>",
                ProjectPlanId = 3,
                PlanTitle = "「 SoulFa親筆簽名專輯 」第一張專輯都有了，第二張專輯還不買爆嗎？",
                PlanFundedPeople = 17,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 6, 1),
                PlanImgUrl = "https://i.imgur.com/SPf6jZUm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1400m,
                QuantityLimit = 100
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 61,
                ProjectId = 11,
                ProjectName = "SoulFa靈魂沙發第二張專輯< Slumber Days>",
                ProjectPlanId = 4,
                PlanTitle = "「 SoulFa，專屬T-shirt 」2020沙發限定T - shirt，小沙發們來巡迴場的必備衣物。",
                PlanFundedPeople = 26,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 6, 1),
                PlanImgUrl = "https://i.imgur.com/GgZkcE8m.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 680m,
                QuantityLimit = 100
            });

            //第12個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 12,
                MemberId = 12,
                ProjectName = "PockeTool2.0 戶外多功能小工具",
                Category = "科技設計",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 3, 7),
                EndDate = new DateTime(2021, 5, 5),
                Fundedpeople = 98,
                FundingAmount = 203728m,
                AmountThreshold = 355555m,
                CreatorName = "MicroNovelty",
                ProjectMainUrl = "https://i.imgur.com/oNyUOL4m.jpg",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/oNyUOL4l.jpg",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "https://i.imgur.com/gtArrl0.jpg,https://i.imgur.com/4yAvNQn.jpg,https://i.imgur.com/oLpxY2v.jpg,https://i.imgur.com/ieqnLUj.jpg,https://i.imgur.com/ajvrnxZ.jpg,https://i.imgur.com/303GUfG.jpg,https://i.imgur.com/5y5aP7J.jpg,https://i.imgur.com/LrgRt67.jpg,https://i.imgur.com/AK83LKc.jpg,",

                ProjectVideoUrl = "https://www.youtube.com/embed/srC7fmMbtNk",
                Project_Question = "我該如何聯繫提案人？,產品產地是在哪裡？",
                Project_Answer = "1.通過集資車車的站內信聯繫。2.通過我們的客服信箱support@micronovelty.com聯繫我們的客服團隊。,中國深圳",
                ProjectPlansCount = 5,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 12, 20),
                ApprovingStatus = 2


            });
            //第12個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 12,
                MemberAccount = "NO12member",
                MemberPassword = "NO12memberPassword",
                MemberName = "MicroNovelty",
                MemberAddress = "100台北市中正區重慶南路一段122號",
                MemberBirth = new DateTime(1980, 11, 3),
                MemberConEmail = "123545@gmail.com",
                MemberRegEmail = "123545@gmail.com",
                MemberMessage = "",
                MemberPhone = "0935-123789",
                MemberTeamName = "MicroNovelty",
                MemberWebsite = "https://www.micronovelty.com/",
                AboutMe = "MicroNovelt是一家致力於極客產品開發和推廣的科技公司。 MicroNovelty的願景和使命是讓極客（發明家）的創新設計能夠變為商品，被更多的人接受和使用。我們希望做極客（發明家）的經紀人，讓極客（發明家）專注創新，我們做產品的工程化和商業化推廣。 目前，MicroNovelty在上海丶台湾、大連、深圳、紐約和矽谷設有分支機構，具有完善的工程師、供應鏈管理和市場推廣團隊。累計開發產品20餘款，涵蓋消費電子品、戶外用品、個人護理、旅行產品、攝影器材等多個品類，依托渠道和互聯網平台，銷售遍布全球150多個國家和地區。",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/DIu40gRt.jpg",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第12個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 62,
                ProjectId = 12,
                ProjectName = "PockeTool2.0 戶外多功能小工具",
                ProjectPlanId = 1,
                PlanTitle = "【超級早鳥】馬上優惠 36 % OFF未來售價 : NT$1545，現省NT$557元!---------------------------------------內容物▸1 x PockeTool2.0多功能小工具▲ 全球免運▲ 一年保固服務",
                PlanFundedPeople = 62,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/t3qZGe1m.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 989m,
                QuantityLimit = 200
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 63,
                ProjectId = 12,
                ProjectName = "PockeTool2.0 戶外多功能小工具",
                ProjectPlanId = 2,
                PlanTitle = "【超級早鳥】馬上優惠 36 % OFF未來售價 : NT$1545，現省NT$557元!---------------------------------------內容物▸1 x PockeTool2.0多功能小工具▲ 全球免運▲ 一年保固服務",
                PlanFundedPeople = 62,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/4a29a37m.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1099m,
                QuantityLimit = 200
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 64,
                ProjectId = 12,
                ProjectName = "PockeTool2.0 戶外多功能小工具",
                ProjectPlanId = 3,
                PlanTitle = "【超級早鳥】馬上優惠 36 % OFF未來售價 : NT$1545，現省NT$557元!---------------------------------------內容物▸1 x PockeTool2.0多功能小工具▲ 全球免運▲ 一年保固服務",
                PlanFundedPeople = 14,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/PIId0f0m.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1899m,
                QuantityLimit = 80
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 65,
                ProjectId = 12,
                ProjectName = "PockeTool2.0 戶外多功能小工具",
                ProjectPlanId = 4,
                PlanTitle = "【超級早鳥】馬上優惠 36 % OFF未來售價 : NT$1545，現省NT$557元!---------------------------------------內容物▸1 x PockeTool2.0多功能小工具▲ 全球免運▲ 一年保固服務",
                PlanFundedPeople = 9,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/thOBHsKm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 2799m,
                QuantityLimit = 40
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 66,
                ProjectId = 12,
                ProjectName = "PockeTool2.0 戶外多功能小工具",
                ProjectPlanId = 5,
                PlanTitle = "【超級早鳥】馬上優惠 36 % OFF未來售價 : NT$1545，現省NT$557元!---------------------------------------內容物▸1 x PockeTool2.0多功能小工具▲ 全球免運▲ 一年保固服務",
                PlanFundedPeople = 13,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 5, 21),
                PlanImgUrl = "https://i.imgur.com/u9JeTZVm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 4499m,
                QuantityLimit = 60
            });


            //第13個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 13,
                MemberId = 13,
                ProjectName = "Ultra Coat – 全境溫控風雨衣｜挑戰你的環境 操控你的溫度",
                Category = "科技設計",
                ProjectStatus = "集資成功",
                StartDate = new DateTime(2021, 3, 7),
                EndDate = new DateTime(2021, 4, 26),
                Fundedpeople = 485,
                FundingAmount = 4330767m,
                AmountThreshold = 300000m,
                CreatorName = "TRANZEND",
                ProjectMainUrl = "https://i.imgur.com/mSsGSNFm.jpg",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/OPlFGaOl.jpg",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "【 台北試穿體驗會 】來看看大家如何評價 Ultra Coat！,錯過體驗會的朋友們注意！#台北 #台中 試穿店面正式開放，現場將有專業的門市人員為大家介紹，也備有各尺寸的 Ultra Coat 讓大家試穿！,https://i.imgur.com/NdogmaV.png,https://i.imgur.com/sCAKFpx.png,https://i.imgur.com/AvU4JgR.png,https://i.imgur.com/X7WCX7u.png,https://i.imgur.com/edlXFOq.png,https://i.imgur.com/Pj5vdwQ.png,https://i.imgur.com/0em3tHx.gif,https://i.imgur.com/i1ywXnA.gif,https://i.imgur.com/4WOrAjl.png",
                //	Large Thumbnail 格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/scEttN1ewFI",
                Project_Question = "外套的重量有多重呢？,加熱模式開啟與一般穿著時的保暖程度為？,平常不穿時，如何折疊與收納才不會影響發熱元件？發熱元件安全嗎？,剪裁設計與提供尺寸是否符合亞洲人身型？",
                Project_Answer = "Men-S:含帽子 880g，不含帽子 780g，Female-S: 含帽子 820g，不含帽子 740g，一般厚羽絨外套或是保暖大衣的重量大約落在900g~1300g不等～,一般穿著：適用20度上下，開啟第一段溫控(42度)：適用16度上下，開啟第二段溫控(50度)：適用13度上下，開啟第一段溫控(55度)：適用10度以下,一般正常使用即可，發熱元件原料為日本進口高純度95%的石墨碳纖維，堅韌耐拉扯，避免拉扯斷裂漏電短路風險。線材阻燃等級UL 94 V0-V2，至少可耐溫到280度；線材接頭防水達IP68，可泡水可機洗。,我們是根據亞洲人(團隊成員們)做尺寸以及剪裁設計的喔",
                ProjectPlansCount = 5,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 12, 20),
                ApprovingStatus = 2
            });


            //第13個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 13,
                MemberAccount = "NO13member",
                MemberPassword = "NO13memberPassword",
                MemberName = "TRANZEND",
                MemberAddress = "100台北市中正區重慶南路一段122號",
                MemberBirth = new DateTime(1993, 1, 6),
                MemberConEmail = "19930106@gmail.com",
                MemberRegEmail = "19930106@gmail.com",
                MemberMessage = "",
                MemberPhone = "0919930106",
                MemberTeamName = "TRANZEND",
                MemberWebsite = "https://www.facebook.com/TranzendTW/",
                AboutMe = "具有極佳的超彈性，透氣性和防水性 - Tranzend 我們的價值觀源於三個要素 - 裁縫審美，高技術性和永續環保。 我們相信這為西裝創造了無可爭議的視角。 我們的設計融合了永續環保材質的運動元素和傳統時尚 - 為每位顧客提供舒適感和適應不同環境的能力。 我們看到了新興的男裝市場，並將功能性和永續環保的紡織品應用於成衣，打破了正式男裝的印象，讓風格和功能共存。 我們的目標是創造新時代，反映我們的口號 - 作為傳說的立場，像野獸一樣移動！",
                Gender = "其他",
                ProfileImgUrl = "https://i.imgur.com/Hwq8j0Kt.jpg",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });


            //第13個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 67,
                ProjectId = 13,
                ProjectName = "Ultra Coat – 全境溫控風雨衣｜挑戰你的環境 操控你的溫度",
                ProjectPlanId = 1,
                PlanTitle = "▎限量早鳥價(限量250組), 未來市價 $15500｜現省 $7920",
                PlanFundedPeople = 200,
                PlanDescription = "Ultra Coat 經典黑*1",
                PlanShipDate = new DateTime(2021, 5, 9),
                PlanImgUrl = "https://i.imgur.com/zCwvQQLm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 7580m,
                QuantityLimit = 250
            });


            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 68,
                ProjectId = 13,
                ProjectName = "Ultra Coat – 全境溫控風雨衣｜挑戰你的環境 操控你的溫度",
                ProjectPlanId = 2,
                PlanTitle = "▎限量價 - 加購行動電源組(限量200組)未來市價 $16490｜現省 $8040",
                PlanFundedPeople = 183,
                PlanDescription = "✅Ultra Coat 經典黑*1,✅ADAM Gravity-M行動電源*1",
                PlanShipDate = new DateTime(2021, 5, 9),
                PlanImgUrl = "https://i.imgur.com/cLuKsY8m.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 8450m,
                QuantityLimit = 200
            });



            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 69,
                ProjectId = 13,
                ProjectName = "Ultra Coat – 全境溫控風雨衣｜挑戰你的環境 操控你的溫度",
                ProjectPlanId = 3,
                PlanTitle = "▎限量早鳥價(限量100組)未來市價 $15500｜現省 $7920",
                PlanFundedPeople = 41,
                PlanDescription = "✅Ultra Coat 海軍藍或軍綠色*1",
                PlanShipDate = new DateTime(2021, 5, 9),
                PlanImgUrl = "https://i.imgur.com/RvxoXnYm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 7580m,
                QuantityLimit = 100
            });


            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 70,
                ProjectId = 13,
                ProjectName = "Ultra Coat – 全境溫控風雨衣｜挑戰你的環境 操控你的溫度",
                ProjectPlanId = 4,
                PlanTitle = "▎限量早鳥價 - 加購行動電源組(限量100組)未來市價 $16490｜現省 $8040",
                PlanFundedPeople = 56,
                PlanDescription = "✅Ultra Coat 海軍藍或軍綠色*1✅ADAM Gravity-M行動電源*1",
                PlanShipDate = new DateTime(2021, 5, 9),
                PlanImgUrl = "https://i.imgur.com/MtzPYqPm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 8450m,
                QuantityLimit = 100
            });

            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 71,
                ProjectId = 13,
                ProjectName = "Ultra Coat – 全境溫控風雨衣｜挑戰你的環境 操控你的溫度",
                ProjectPlanId = 5,
                PlanTitle = "未來市價 $15500｜現省 $7520",
                PlanFundedPeople = 5,
                PlanDescription = "✅Ultra Coat 經典黑*1",
                PlanShipDate = new DateTime(2021, 5, 9),
                PlanImgUrl = "https://i.imgur.com/bcfHu8gm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 7980m,
                QuantityLimit = 56
            });




            //第14個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 14,
                MemberId = 14,
                ProjectName = "SAX VOYAGE 米特薩克斯風重奏團｜走出臺灣，風鳴亞洲",
                Category = "藝術影視",
                ProjectStatus = "集資成功",
                StartDate = new DateTime(2021, 3, 3),
                EndDate = new DateTime(2021, 4, 27),
                Fundedpeople = 222,
                FundingAmount = 640858m,
                AmountThreshold = 600000m,
                CreatorName = "米特薩克斯風重奏團",
                ProjectMainUrl = "https://i.imgur.com/71CD6Jdm.png",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/JooJa6Ol.png",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "因緣際會下，讓來自法國的大師看見米特薩克斯風重奏團的無限可能！ 即將帶著米特（MIT）走出臺灣，一場與大師巡演四個城市的音樂之旅，由此揭開序幕⋯⋯。",
                ProjectImgUrl = "https://i.imgur.com/zPZ39CP.jpg,https://i.imgur.com/866S4hz.jpg,https://i.imgur.com/IFdeIju.jpg,https://i.imgur.com/GH4xiVr.jpg",
                ProjectVideoUrl = "https://www.youtube.com/embed/xNS9Lu14zx0",
                Project_Question = "如何回饋?",
                Project_Answer = "我們的回饋商品主要分成：音樂會票券／Vincent David CD／紀念琴譜袋／Vincent David 海報 / 手寫明信片／巡迴紀錄DVD／紀念Polo衫",
                ProjectPlansCount = 5,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 12, 20),
                ApprovingStatus = 2
            });


            //第14個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 14,
                MemberAccount = "NO14member",
                MemberPassword = "NO14memberPassword",
                MemberName = "米特薩克斯風重奏團",
                MemberAddress = "100台北市中正區重慶南路一段123號",
                MemberBirth = new DateTime(1993, 2, 6),
                MemberConEmail = "19930206@gmail.com",
                MemberRegEmail = "19930206@gmail.com",
                MemberMessage = "",
                MemberPhone = "0919930206",
                MemberTeamName = "米特薩克斯風重奏團",
                MemberWebsite = "https://www.facebook.com/MITSaxophoneEnsemble/",
                AboutMe = "成立於2013年的MIT米特薩克斯風重奏團，由一群極為年輕、具有高度演奏天分的音樂家們組成。 近四年以來，米特薩克斯風重奏團不斷試驗與開發新組合與新曲目；同時，米特薩克斯風重奏團定期透過下鄉義演、深度耕耘與教學來推廣薩克斯風音樂獨一無二的魅力。 除了演出外，米特也推廣「重奏」之演奏形式，由於薩克斯風擁有編制完整的家族樂器，因此「薩克斯風重奏團」在國外相當盛行。目前米特團員總數已達上百人。",
                Gender = "其他",
                ProfileImgUrl = "https://i.imgur.com/G0viRSut.png",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });


            //第14個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 72,
                ProjectId = 14,
                ProjectName = "SAX VOYAGE 米特薩克斯風重奏團｜走出臺灣，風鳴亞洲",
                ProjectPlanId = 1,
                PlanTitle = "【穿上米特】米特紀念Polo衫一件",
                PlanFundedPeople = 9,
                PlanDescription = "【穿上米特】米特紀念Polo衫一件",
                PlanShipDate = new DateTime(2021, 5, 4),
                PlanImgUrl = "https://i.imgur.com/2YrHahxm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 890m,
                QuantityLimit = 100
            });

            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 73,
                ProjectId = 14,
                ProjectName = "SAX VOYAGE 米特薩克斯風重奏團｜走出臺灣，風鳴亞洲",
                ProjectPlanId = 2,
                PlanTitle = "【巡迴DVD兩片裝】內容包含巡迴過程紀錄及一場完整音樂會。",
                PlanFundedPeople = 10,
                PlanDescription = "【巡迴DVD兩片裝】內容包含巡迴過程紀錄及一場完整音樂會。",
                PlanShipDate = new DateTime(2021, 5, 4),
                PlanImgUrl = "https://i.imgur.com/7PoshTpm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 990m,
                QuantityLimit = 100
            });

            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 74,
                ProjectId = 14,
                ProjectName = "SAX VOYAGE 米特薩克斯風重奏團｜走出臺灣，風鳴亞洲",
                ProjectPlanId = 3,
                PlanTitle = "【臺灣場C級座位+米特新版Line貼圖】",
                PlanFundedPeople = 36,
                PlanDescription = "【臺灣場C級座位+米特新版Line貼圖】",
                PlanShipDate = new DateTime(2021, 5, 4),
                PlanImgUrl = "https://i.imgur.com/0mYmTqgm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 500m,
                QuantityLimit = 100
            });

            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 75,
                ProjectId = 14,
                ProjectName = "SAX VOYAGE 米特薩克斯風重奏團｜走出臺灣，風鳴亞洲",
                ProjectPlanId = 4,
                PlanTitle = "【 臺灣場門票套組B 】臺灣場B級座位乙張+紀念琴譜袋1只＋紀念Polo衫1件+米特新版Line貼圖。",
                PlanFundedPeople = 7,
                PlanDescription = "【 臺灣場門票套組B 】臺灣場B級座位乙張+紀念琴譜袋1只＋紀念Polo衫1件+米特新版Line貼圖。",
                PlanShipDate = new DateTime(2021, 5, 4),
                PlanImgUrl = "https://i.imgur.com/G6jx8xcm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 2500m,
                QuantityLimit = 50
            });


            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 76,
                ProjectId = 14,
                ProjectName = "SAX VOYAGE 米特薩克斯風重奏團｜走出臺灣，風鳴亞洲",
                ProjectPlanId = 5,
                PlanTitle = "【 臺灣場門票套組A 】臺灣場A級座位乙張+紀念琴譜袋1只＋紀念Polo衫1件+米特新版Line貼圖。",
                PlanFundedPeople = 16,
                PlanDescription = "【 臺灣場門票套組A 】臺灣場A級座位乙張+紀念琴譜袋1只＋紀念Polo衫1件+米特新版Line貼圖。",
                PlanShipDate = new DateTime(2021, 5, 4),
                PlanImgUrl = "https://i.imgur.com/DP1Nyfnm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 3000m,
                QuantityLimit = 70
            });



            //第15個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 15,
                MemberId = 15,
                ProjectName = "熊野筆 ROTUNDA 沐浴刷",
                Category = "生活",
                ProjectStatus = "集資成功",
                StartDate = new DateTime(2021, 3, 1),
                EndDate = new DateTime(2021, 4, 26),
                Fundedpeople = 36,
                FundingAmount = 221540,
                AmountThreshold = 5000,
                CreatorName = "村岸產業株式会社",
                ProjectMainUrl = "https://i.imgur.com/99sWgpxm.jpg",
                //提案瀏覽頁的頁面照片 照片格式IMGURL SIZE:		320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/99sWgpxl.jpg",
                //提案詳細頁的影片覆蓋 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "https://i.imgur.com/5RZVX0P.jpg,❙ 超過 90 年歷史 ❙對美的熱忱與執著,https://i.imgur.com/2j2h8vF.jpg, 大家好，我們是村岸產業株式会社，自 1929 年於大阪創立以來，持續銷售化妝刷具與美妝用品, 秉持對品質的追求，我們於 1956 年開始和廣島熊野的製造廠合作開發，將「 熊野筆 」的工法應用於高級化妝刷具 ❙ 從職人手作到享譽全國 ❙,https://i.imgur.com/UQjxte9.jpg, 日文的漢字【 筆 】，即有【 刷 】的含義。遠自江戶末期，日本廣島縣熊野町就因盛產毛筆，獲得「 筆之都 」的稱號,https://i.imgur.com/SzTqnM1.jpg, 現今不論毛筆、畫筆、化妝刷具等，仍佔全日本約 80% 以上的產量，「熊野筆」因而被日本經濟產業大臣指名為傳統工藝品,https://i.imgur.com/w82hyDW.jpg, 尤其熊野出品的化妝刷具，刷毛柔軟細緻的觸感、能帶出自然妝感的特色，深受大眾女性及專業模特兒喜愛，也成為高品質的象徵,❙ 向世界傳達熊野筆的美 ❙ 造一把沐浴專用的【 筆 】,熊野筆「 柔軟且親膚 」的特性，不僅適合臉部妝容，更能用於全身清潔，我們希望將「熊野筆」的優點，更廣泛的應用於日常生活中,❙ 堅持職人手工打造 ❙ 每個成品，都蘊含最真誠的浪漫,https://i.imgur.com/T0w6u7B.jpg, 去除多餘的裁切工序，最重要的排列平整、順毛組裝等製成，熊野老師傅仍堅持全手工進行，貫徹對品質的絕對要求,https://i.imgur.com/TAvWRXe.jpg, 將近百年化妝刷製作技術的累積，投注於身體刷重新設計改良，《 熊野筆 ROTUNDA 沐浴刷 》就此傳承新生, 對許多女生來說，熊野筆化妝刷是一生必定要嘗試的夢幻單品；我們相信《 熊野筆 ROTUNDA 沐浴刷 》同樣能帶來前所未有的沐浴享受,https://i.imgur.com/AJb6zsf.jpg, ❙ 溫柔觸感·舒適呵護 ❙, 每次搓揉，都像深層 SPA 按摩, 每組《 熊野筆 ROTUNDA 沐浴刷 》由超過 150,000 根 0.1 mm 極細柔軟刷毛製成,https://i.imgur.com/7kD5N1A.jpg, 極上沐浴體驗！, 享受每日最療癒的時刻,https://i.imgur.com/VEjNukC.jpg, https://i.imgur.com/HRQ1Bcl.gifv,https://i.imgur.com/owhlFNQ.jpg,https://i.imgur.com/OGx8IZr.jpg,https://i.imgur.com/pIuH2Uy.gifv,https://i.imgur.com/wLS3K0P.jpg,https://i.imgur.com/6mwBOLT.jpg,https://i.imgur.com/fxHrNfc.jpg, 【 去污力實測！】, 徒手清潔 vs. 熊野筆 ROTUNDA 沐浴刷, 單純以手洗時，仍有殘留物卡在橘皮隙縫；經過《 熊野筆 ROTUNDA 沐浴刷 》刷洗，如同將毛細孔內的頑垢徹底清除, ❙ 不放過任何髒污死角 ❙, 長短柄 兩種規格選擇, 身體全身、或是需要仔細刷洗的指縫，都能輕鬆清潔,https://i.imgur.com/towH2lE.jpg, 身體全身、或是需要仔細刷洗的指縫，都能輕鬆清潔,https://i.imgur.com/DYXnY5A.jpg, ❙ 長期護理方法 ❙,https://i.imgur.com/OLDlSl9.jpg, ❙ 特別贈禮！ ❙,https://i.imgur.com/4UgdQZC.jpg,  前 60 名贊助者，額外贈送 熊野筆唇刷 1 支, ❙ 產品規格 ❙,https://i.imgur.com/9jtZnuS.jpg,《 熊野筆 ROTUNDA 沐浴刷 》長柄, 尺寸：70 x 62 x 300 mm, 重量:180g, 材質：PBT/天然山羊毛 混毛, 產地：日本,https://i.imgur.com/JQzAmYx.jpg, 《 熊野筆 ROTUNDA 沐浴刷 》短柄 ,尺寸：70 x 50 mm ,重量：105g ,材質：PBT/天然山羊毛 混毛 ,產地：日本, ❙ 贊助方案 ❙ （ 全方案開放 刷卡 3、6 期零利率 ）,https://i.imgur.com/3YOp8M9.jpg, ❙ 關於村岸株式会社 ❙,https://i.imgur.com/eM9qtVd.jpg, 自成立 90 年來，從以化妝刷為中心的美容相關產品的批發銷售，到開發各種各樣的刷具。秉承專業知識和堅定不移的信念，精心製作的最高品質的產品, https://i.imgur.com/3Mwz1l6.jpg",
                //格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/3cO7pC7SeXY",
                Project_Question = "「熊野筆」是化妝刷具的高品質象徵，怎麼會想要拿來做沐浴刷呢？,刷毛的材質為何呢？,《 熊野筆 ROTUNDA 沐浴刷 》中間的凹槽有什麼功能呢？,清潔使用後，該如何收納與保養呢？,如果收到產品後不夠滿意，可以做退換貨嗎？,《 熊野筆 ROTUNDA 沐浴刷 》是否會提供保固呢？",
                Project_Answer = "遠自江戶末期，日本廣島縣熊野町就因盛產毛筆，獲得「 筆之都 」的稱號，我們相信熊野筆「 柔軟且親膚 」的特性，不僅適合臉部妝容，更能用於全身清潔！,我們選用天然山羊毛與PBT纖維，沿襲熊野筆「混毛」的製作方式，由超過 150,000 根 0.1 mm 極細柔軟刷毛製成，除了能深度清潔毛細孔內的污垢、同時達到去角質的效果,以毫米為單位多次重複測試精修，可讓刷洗時產生更細緻且大量的泡沫；不僅帶來更強的去污力，光看著就很療癒,建議用浴巾將沐浴刷擦乾後，採刷毛倒立方式至通風處晾乾，長柄刷亦可透過末端的圈繩吊掛收納,可以的，依照消費者保護法的規定，我們提供商品貨到日起七天猶豫期的權益。請注意猶豫期非試用期，您所退回或要更換的商品若經檢測後有毀損狀況，我們可能會向您收取相關的費用,在 集資車車 參與募資計畫的朋友，都享有收到貨後起算 6 個月保固的權益；若為正常使用耗損、人為因素導致商品毀損，則不在保固範圍內。",
                ProjectPlansCount = 6,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 12, 20),
                ApprovingStatus = 2
            });
            //第15個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 15,
                MemberAccount = "",
                MemberPassword = "NO17memberPassword",
                MemberName = "村岸產業株式会社",
                MemberAddress = "",
                MemberBirth = new DateTime(1929, 5, 1),
                MemberConEmail = "rotundataiwan@gmail.com",
                MemberRegEmail = "rotundataiwan@gmail.com",
                MemberMessage = "",
                MemberPhone = "",
                MemberTeamName = "村岸產業株式会社",
                MemberWebsite = "https://www.facebook.com/RotundaTaiwan",
                AboutMe = "大家好，我們是村岸產業株式会社，自 1929 年於大阪創立以來，持續銷售化妝刷具與美妝用品。 熊野筆「 柔軟且親膚、細緻卻強韌 」的特性，不僅適合臉部妝容，更能用於全身清潔，我們希望將「熊野筆」的優點，更廣泛的應用於日常生活中。 將化妝刷製作技術的累積，投注於身體刷重新設計改良，《 ROTUNDA 熊野筆沐浴刷 》因而傳承新生",
                Gender = "女",
                ProfileImgUrl = "https://i.imgur.com/SsEZLl7.jpg",
                //照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第15個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 77,
                ProjectName = "熊野筆 ROTUNDA 沐浴刷",
                ProjectId = 15,
                ProjectPlanId = 1,
                PlanTitle = "《 ROTUNDA 熊野筆沐浴刷 》短柄 募資早鳥 1 入",
                PlanFundedPeople = 1,
                PlanDescription = "全方案開放「刷卡 3、6 期零利率」,專案前 60 名贊助者，額外贈送「熊野筆唇刷 1 支」",
                PlanShipDate = new DateTime(2021, 08, 01),
                PlanImgUrl = "",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 4290,
                QuantityLimit = 60
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 78,
                ProjectName = "熊野筆 ROTUNDA 沐浴刷",
                ProjectId = 15,
                ProjectPlanId = 2,
                PlanTitle = "《 ROTUNDA 熊野筆沐浴刷 》短柄 募資早鳥 1 入",
                PlanFundedPeople = 1,
                PlanDescription = "全方案開放「刷卡 3、6 期零利率」，專案前 60 名贊助者，額外贈送「熊野筆唇刷 1 支」",
                PlanShipDate = new DateTime(2021, 08, 01),
                PlanImgUrl = "",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 4290,
                QuantityLimit = 60
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 79,
                ProjectName = "熊野筆 ROTUNDA 沐浴刷",
                ProjectId = 15,
                ProjectPlanId = 3,
                PlanTitle = "《 ROTUNDA 熊野筆沐浴刷 》長柄 募資早鳥 1 入",
                PlanFundedPeople = 7,
                PlanDescription = "全方案開放「刷卡 3、6 期零利率」，專案前 60 名贊助者，額外贈送「熊野筆唇刷 1 支」",
                PlanShipDate = new DateTime(2021, 08, 01),
                PlanImgUrl = "",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 6290,
                QuantityLimit = 60
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 80,
                ProjectName = "熊野筆 ROTUNDA 沐浴刷",
                ProjectId = 15,
                ProjectPlanId = 4,
                PlanTitle = "《 ROTUNDA 熊野筆沐浴刷 》短柄 募資早鳥 2 入",
                PlanFundedPeople = 1,
                PlanDescription = "全方案開放「刷卡 3、6 期零利率」，專案前 60 名贊助者，額外贈送「熊野筆唇刷 1 支」",
                PlanShipDate = new DateTime(2021, 08, 01),
                PlanImgUrl = "",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 8490,
                QuantityLimit = 60
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 81,
                ProjectName = "熊野筆 ROTUNDA 沐浴刷",
                ProjectId = 15,
                ProjectPlanId = 5,
                PlanTitle = "《 ROTUNDA 熊野筆沐浴刷 》長柄 募資早鳥 2 入",
                PlanFundedPeople = 1,
                PlanDescription = "全方案開放「刷卡 3、6 期零利率」，專案前 60 名贊助者，額外贈送「熊野筆唇刷 1 支」",
                PlanShipDate = new DateTime(2021, 08, 01),
                PlanImgUrl = "https://imgur.com/qKliU0Fm.jpg",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 12390,
                QuantityLimit = 60
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 82,
                ProjectName = "熊野筆 ROTUNDA 沐浴刷",
                ProjectId = 15,
                ProjectPlanId = 6,
                PlanTitle = "單純贊助，不需回饋",
                PlanFundedPeople = 0,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 08, 01),
                PlanImgUrl = "",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 100,
                QuantityLimit = 60
            });

            //第16個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 16,
                MemberId = 16,
                ProjectName = "《小米遊記》第一本寵物友善環境探訪實錄／寫真書出版計畫",
                Category = "遊戲出版",
                ProjectStatus = "集資成功",
                StartDate = new DateTime(2021, 3, 20),
                EndDate = new DateTime(2021, 4, 27),
                Fundedpeople = 306,
                FundingAmount = 347625,
                AmountThreshold = 300000,
                CreatorName = "米爸",
                ProjectMainUrl = "https://i.imgur.com/jwLGY3Km.png",
                //提案瀏覽頁的頁面照片 照片格式IMGURL SIZE:		320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/jwLGY3Kl.png",
                //提案詳細頁的影片覆蓋 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "為什麼要出書？,你的毛孩...曾經被景點或商家拒絕嗎？,你大概會有這個經驗，你心愛的寶貝，曾經被拒絕於餐館或飯店門外，飽受交通不便， 到了旅遊景點，才發現你的寶貝，無法進入，是不受歡迎的！,https://i.imgur.com/hlwC762.jpg, 如影片所述，期望透過小米的旅遊介紹以及照片，鼓勵大家帶毛孩到一些戶外地點去遊玩並記錄下珍貴的點滴，希望這本書可以讓大家帶著毛小孩們，平安順利的體驗台灣之美。,藉由出書募得資金，重新啟動公益計畫,https://i.imgur.com/jXa7iTX.jpg, 我們費時2年2萬公里探訪台灣的景點寵物友善狀況，產生了大量的寫真照片和景點資訊，在許多粉絲、網友鼓勵下，決定將這些資料和照片製作出高品質的旅遊寫真書，並將書的所得扣除成本後投入公益事業，組成一個公益協會和社會企業，啟動 FURKID 毛小孩計畫，這是寵物專屬平台，並以降低棄養率為主的研發計畫，追蹤寵物過去和未來、寵物友善環境搜尋、提供並協助中途之家媒合平台和分析追蹤工具。,成立推動寵物友善環境及生命教育的公益協會,https://i.imgur.com/EPOQNCM.jpg, 台灣景點和周邊商家，許多地方寵物都可以進入，但也有許多地方仍禁止寵物進入，而我們希望能將這些地方有條件的變成寵物可進入，「透過正確的方式和規劃讓環境對寵物友善，同時也約束毛孩父母，教育好毛孩並做好自身責任對環境友善」，建立起相互信賴，並推動雙向分級「寵物友善環境認證」和「好爸媽及乖毛孩認證（飼主責任和寵物穩定度認定）」，讓友善環境也能有選擇權。,https://i.imgur.com/vChSG9c.jpg, 這是寫真書？還是旅遊書？,https://i.imgur.com/ES9VPa2.jpg,https://i.imgur.com/scvSlbt.jpg, 小米景點寫真, 以台灣北部、中部、南部、東部景點的介紹以及特色，讓我們一起透過小米看看美美的台灣。,https://i.imgur.com/3FXQFis.jpg,https://i.imgur.com/dNpA2Bq.jpg,https://i.imgur.com/bAmvyEX.jpg,https://i.imgur.com/L6ukvAE.jpg,https://i.imgur.com/H7FpUBJ.jpg,https://i.imgur.com/i8Oq6bD.jpg,https://i.imgur.com/s5SzX1V.jpg,https://i.imgur.com/lPjUKQ4.jpg,https://i.imgur.com/9CnlLC8.jpg,https://i.imgur.com/mlzMZ06.jpg,https://i.imgur.com/XYlTuV1.jpg, 一個國家的文明程度就看她怎樣對待動物,要讓整個環境能夠更朝友善寵物前進，有兩個最主要的因素。第一個就是商家和景點的開放，另外一個則是飼主本身的配合和進步。我們深信提升生命教育和飼主應盡責任是降低棄養率及對寵物友善的根本。因此我們準備將出書所得成立一家社會企業和計畫發展的公益協會, https://i.imgur.com/Of9YDuJ.jpg, 成立寵物友善環境發展協會, 透過協會進行寵物友善環境發展、生命教育、飼主教育、寵物證照推廣（乖寶寶證照）、寵物緊急救難基金等。,https://i.imgur.com/Jzz5S15.jpg,https://i.imgur.com/hz7we9i.jpg, 經費使用說明, https://i.imgur.com/VAHpMU2.png",
                //格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/ivij40C-BSs",
                Project_Question = "",
                Project_Answer = "",
                ProjectPlansCount = 6,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 12, 20),
                ApprovingStatus = 2
            });

            //第16個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 16,
                MemberAccount = "Storm Kuo",
                MemberPassword = "NO16memberPassword",
                MemberName = "Miiii",
                MemberAddress = "",
                MemberBirth = new DateTime(1929, 5, 1),
                MemberConEmail = "ricefurkid@gmail.com",
                MemberRegEmail = "rice@furkid.org",
                MemberMessage = "",
                MemberPhone = "",
                MemberTeamName = "米爸",
                MemberWebsite = "https://www.facebook.com/RotundaTaiwan",
                AboutMe = "小米的爸爸，精通於社群操作以及社群平台機制設計，所設計的創新平台曾獲得資策會第1屆IDEAS Show 第1名 以及 2008年 DEMO CHINA 08優勝獎項「Demo God 」，由於所研發的創新平台及概念皆是領先於當時環境，未來趨勢，可惜資源不足無法持續。但不管挫折如何，至今仍一直努力和堅持於數位創新領域上，目前獨力和小米一起執行「FURKID計畫」。",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/UILd3ZHt.jpg",
                //照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第16個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 83,
                ProjectName = "小米遊記》第一本寵物友善環境探訪實錄／寫真書出版計畫",
                ProjectId = 16,
                ProjectPlanId = 1,
                PlanTitle = "《小米遊記》第一本寵物友善環境探訪實錄1【台灣北部、中部】1本",
                PlanFundedPeople = 24,
                PlanDescription = "我們費時2年2萬多公里，探訪台灣景點的寵物友善狀況。藉由出書募資，將所得投入寵物友善環境發展和生命教育推動，及重啟動降低棄養率的公益研發計畫。",
                PlanShipDate = new DateTime(2021, 10, 01),
                PlanImgUrl = "https://i.imgur.com/aq6j2Sdm.png",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 500,
                QuantityLimit = 99
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 84,
                ProjectName = "小米遊記》第一本寵物友善環境探訪實錄／寫真書出版計畫",
                ProjectId = 16,
                ProjectPlanId = 2,
                PlanTitle = "《小米遊記》第一本寵物友善環境探訪實錄2【台灣東部、南部】1本",
                PlanFundedPeople = 19,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 10, 01),
                PlanImgUrl = "https://i.imgur.com/Y3uAEeqm.png",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 500,
                QuantityLimit = 99
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 85,
                ProjectName = "小米遊記》第一本寵物友善環境探訪實錄／寫真書出版計畫",
                ProjectId = 16,
                ProjectPlanId = 3,
                PlanTitle = "《小米遊記》第一本寵物友善環境探訪實錄寫真書1套2冊含外盒",
                PlanFundedPeople = 188,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 10, 01),
                PlanImgUrl = "https://i.imgur.com/mLzamGPm.png",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 950,
                QuantityLimit = 99
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 86,
                ProjectName = "《小米遊記》第一本寵物友善環境探訪實錄／寫真書出版計畫",
                ProjectId = 16,
                ProjectPlanId = 4,
                PlanTitle = "9折，寵物友善環境探訪實錄寫真書5套，亦可指定捐贈國小或者指定單位和是否露出捐贈者",
                PlanFundedPeople = 7,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 10, 01),
                PlanImgUrl = "https://i.imgur.com/YLHUNUC.png",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 4275,
                QuantityLimit = 15
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 87,
                ProjectName = "《小米遊記》第一本寵物友善環境探訪實錄／寫真書出版計畫",
                ProjectId = 16,
                ProjectPlanId = 5,
                PlanTitle = "85折，寵物友善環境探訪實錄寫真書10套，亦可指定捐贈國小或者指定單位和是否露出捐贈者",
                PlanFundedPeople = 10,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 10, 01),
                PlanImgUrl = "https://i.imgur.com/YLHUNUC.png",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 8075,
                QuantityLimit = 10
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 88,
                ProjectName = "《小米遊記》第一本寵物友善環境探訪實錄／寫真書出版計畫",
                ProjectId = 16,
                ProjectPlanId = 6,
                PlanTitle = "純贊助【寵物友善環境發展協會】成立，推動友善環境和好爸媽及乖毛孩的分級認證，不須回饋",
                PlanFundedPeople = 58,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 06, 01),
                PlanImgUrl = "https://i.imgur.com/mWUfu4gm.png",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 100,
                QuantityLimit = 99
            });


            //第17個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 17,
                MemberId = 17,
                ProjectName = "imunsen｜韓國首台擁有檜木濾網與擴香系統的360度雙氣旋清淨機",
                Category = "科技設計",
                ProjectStatus = "結束且成功",
                StartDate = new DateTime(2021, 1, 20),
                EndDate = new DateTime(2021, 2, 20),
                Fundedpeople = 400,
                FundingAmount = 347625,
                AmountThreshold = 300000,
                CreatorName = "imunsen Taiwan",
                ProjectMainUrl = "https://i.imgur.com/HAp0GFDm.jpg",
                //提案瀏覽頁的頁面照片 照片格式IMGURL SIZE:		320x320 連結檔案名結尾m
                ProjectCoverUrl = "",
                //提案詳細頁的影片覆蓋 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "",
                //格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "",
                Project_Question = "",
                Project_Answer = "",
                ProjectPlansCount = 2,
                CreatedDate = new DateTime(2021, 1, 20),
                SubmittedDate = new DateTime(2021, 1, 20),
                LastEditTime = new DateTime(2021, 1, 20),
                ApprovingStatus = 2
            });


            //第17個會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 17,
                MemberAccount = "NO17member",
                MemberPassword = "NO17memberPassword",  //登入假資料用
                MemberName = "imunsen Taiwan",
                MemberAddress = "",
                MemberBirth = new DateTime(1990, 1, 17),
                MemberConEmail = "NO17member@gmail.com",
                MemberRegEmail = "NO17member@gmail.com", //登入用
                MemberMessage = "",
                MemberPhone = "",
                MemberTeamName = "imunsen Taiwan",
                MemberWebsite = "",
                AboutMe = "",
                Gender = "其他",
                ProfileImgUrl = "https://i.imgur.com/woONMm6t.png",
                //照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });

            //第17個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 89,
                ProjectName = "imunsen｜韓國首台擁有檜木濾網與擴香系統的360度雙氣旋清淨機",
                ProjectId = 17,
                ProjectPlanId = 1,
                PlanTitle = "imunsen 空氣清淨機白色套組",
                PlanFundedPeople = 30,
                PlanDescription = "imunsen 空氣清淨機白色 1 台, HEPA濾網 1 組, 擴香石 1 顆",
                PlanShipDate = new DateTime(2021, 5, 25),
                PlanImgUrl = "https://i.imgur.com/d8zirNem.jpg",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 15500,
                QuantityLimit = 30,
                AddCarCarPlan = true,
                SubmitLimit = 135
            });


            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 90,
                ProjectName = "imunsen | 韓國首台擁有檜木濾網與擴香系統的360度雙氣旋清淨機",
                ProjectId = 17,
                ProjectPlanId = 2,
                PlanTitle = "imunsen 空氣清淨機黑色套組",
                PlanFundedPeople = 30,
                PlanDescription = "imunsen 空氣清淨機黑色 1 台, HEPA濾網 1 組, 擴香石 1 顆",
                PlanShipDate = new DateTime(2021, 5, 25),
                PlanImgUrl = "https://i.imgur.com/88YZhvGm.jpg",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 16500,
                QuantityLimit = 30,
                AddCarCarPlan = true,
                SubmitLimit = 145
            });


            //第18個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 18,
                MemberId = 18,
                ProjectName = "BUTTONS AirX 無線耳機 | 黑眼豆豆will.i.am.重磅新作",
                Category = "科技設計",
                ProjectStatus = "結束且成功",
                StartDate = new DateTime(2021, 1, 20),
                EndDate = new DateTime(2021, 2, 20),
                Fundedpeople = 400,
                FundingAmount = 347625,
                AmountThreshold = 300000,
                CreatorName = "BUTTONS",
                ProjectMainUrl = "https://i.imgur.com/c4Fy5Z7m.jpg",
                //提案瀏覽頁的頁面照片 照片格式IMGURL SIZE:		320x320 連結檔案名結尾m
                ProjectCoverUrl = "",
                //提案詳細頁的影片覆蓋 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "",
                //格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "",
                Project_Question = "",
                Project_Answer = "",
                ProjectPlansCount = 2,
                CreatedDate = new DateTime(2021, 1, 20),
                SubmittedDate = new DateTime(2021, 1, 20),
                LastEditTime = new DateTime(2021, 1, 20),
                ApprovingStatus = 2
            });


            //第18個會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 18,
                MemberAccount = "NO18member",
                MemberPassword = "NO18memberPassword",  //登入假資料用
                MemberName = "BUTTONS",
                MemberAddress = "",
                MemberBirth = new DateTime(1990, 1, 18),
                MemberConEmail = "NO18member@gmail.com",
                MemberRegEmail = "NO18member@gmail.com", //登入用
                MemberMessage = "",
                MemberPhone = "",
                MemberTeamName = "BUTTONS",
                MemberWebsite = "",
                AboutMe = "",
                Gender = "其他",
                ProfileImgUrl = "https://i.imgur.com/D5Bg6mft.png",
                //照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });


            //第18個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 91,
                ProjectName = "BUTTONS AirX 無線耳機 | 黑眼豆豆will.i.am.重磅新作",
                ProjectId = 18,
                ProjectPlanId = 1,
                PlanTitle = "BUTTONS Air X 無線耳機 2 組",
                PlanFundedPeople = 30,
                PlanDescription = "BUTTONS Air X 無線耳機 2 組(街頭黑 / 優雅粉 / 迷幻霧藍), 每組各保固 1 年",
                PlanShipDate = new DateTime(2021, 5, 25),
                PlanImgUrl = "https://i.imgur.com/z6JJJgTm.jpg",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 8298,
                QuantityLimit = 30,
                AddCarCarPlan = true,
                SubmitLimit = 130
            });


            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 92,
                ProjectName = "BUTTONS AirX 無線耳機 | 黑眼豆豆will.i.am.重磅新作",
                ProjectId = 18,
                ProjectPlanId = 2,
                PlanTitle = "BUTTONS Air X 無線耳機 3 組",
                PlanFundedPeople = 30,
                PlanDescription = "BUTTONS Air X 無線耳機 3 組(街頭黑 / 優雅粉 / 迷幻霧藍), 每組各保固 1 年",
                PlanShipDate = new DateTime(2021, 5, 25),
                PlanImgUrl = "https://i.imgur.com/lNLFfcrm.jpg",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 12297,
                QuantityLimit = 30,
                AddCarCarPlan = true,
                SubmitLimit = 190
            });


            //第19個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 19,
                MemberId = 19,
                ProjectName = "科沃斯ECOVACS N8 掃拖機器人｜你的第一台除菌掃拖機器人",
                Category = "科技設計",
                ProjectStatus = "結束且成功",
                StartDate = new DateTime(2021, 1, 20),
                EndDate = new DateTime(2021, 2, 20),
                Fundedpeople = 400,
                FundingAmount = 347625,
                AmountThreshold = 300000,
                CreatorName = "ECOVACS",
                ProjectMainUrl = "https://i.imgur.com/hQn8ACTm.jpg",
                //提案瀏覽頁的頁面照片 照片格式IMGURL SIZE:		320x320 連結檔案名結尾m
                ProjectCoverUrl = "",
                //提案詳細頁的影片覆蓋 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "",
                //格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "",
                Project_Question = "",
                Project_Answer = "",
                ProjectPlansCount = 1,
                CreatedDate = new DateTime(2021, 1, 20),
                SubmittedDate = new DateTime(2021, 1, 20),
                LastEditTime = new DateTime(2021, 1, 20),
                ApprovingStatus = 2
            });


            //第19個會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 19,
                MemberAccount = "NO19member",
                MemberPassword = "NO19memberPassword",  //登入假資料用
                MemberName = "ECOVACS",
                MemberAddress = "",
                MemberBirth = new DateTime(1990, 1, 18),
                MemberConEmail = "NO19member@gmail.com",
                MemberRegEmail = "NO19member@gmail.com", //登入用
                MemberMessage = "",
                MemberPhone = "",
                MemberTeamName = "ECOVACS",
                MemberWebsite = "",
                AboutMe = "",
                Gender = "其他",
                ProfileImgUrl = "https://i.imgur.com/pWKHMHMt.jpg",
                //照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });


            //第19個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 93,
                ProjectName = "科沃斯ECOVACS N8 掃拖機器人｜你的第一台除菌掃拖機器人",
                ProjectId = 19,
                ProjectPlanId = 1,
                PlanTitle = "N8 掃拖地機器人 2 套",
                PlanFundedPeople = 30,
                PlanDescription = "N8 掃拖地機器人 2 套, 台灣聯強保固各18個月",
                PlanShipDate = new DateTime(2021, 5, 25),
                PlanImgUrl = "https://i.imgur.com/xkLdk60m.jpg",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 19398,
                QuantityLimit = 30,
                AddCarCarPlan = true,
                SubmitLimit = 100
            });


            //第20個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 20,
                MemberId = 20,
                ProjectName = "陸穎魚首部詩集《淡水月亮》10週年台灣復刻版企劃",
                Category = "遊戲出版",
                ProjectStatus = "結束且成功",
                StartDate = new DateTime(2021, 1, 20),
                EndDate = new DateTime(2021, 2, 20),
                Fundedpeople = 400,
                FundingAmount = 347625,
                AmountThreshold = 300000,
                CreatorName = "詩生活",
                ProjectMainUrl = "https://i.imgur.com/vMlyf2rm.jpg",
                //提案瀏覽頁的頁面照片 照片格式IMGURL SIZE:		320x320 連結檔案名結尾m
                ProjectCoverUrl = "",
                //提案詳細頁的影片覆蓋 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "",
                //格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "",
                Project_Question = "",
                Project_Answer = "",
                ProjectPlansCount = 2,
                CreatedDate = new DateTime(2021, 1, 20),
                SubmittedDate = new DateTime(2021, 1, 20),
                LastEditTime = new DateTime(2021, 1, 20),
                ApprovingStatus = 2
            });


            //第20個會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 20,
                MemberAccount = "NO20member",
                MemberPassword = "NO20memberPassword",  //登入假資料用
                MemberName = "詩生活",
                MemberAddress = "",
                MemberBirth = new DateTime(1990, 1, 18),
                MemberConEmail = "NO20member@gmail.com",
                MemberRegEmail = "NO20member@gmail.com", //登入用
                MemberMessage = "",
                MemberPhone = "",
                MemberTeamName = "詩生活",
                MemberWebsite = "",
                AboutMe = "",
                Gender = "其他",
                ProfileImgUrl = "https://i.imgur.com/5Nonwcdt.jpg",
                //照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });


            //第20個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 94,
                ProjectName = "陸穎魚首部詩集《淡水月亮》10週年台灣復刻版企劃",
                ProjectId = 20,
                ProjectPlanId = 1,
                PlanTitle = "讓月亮清洗憂愁的心",
                PlanFundedPeople = 30,
                PlanDescription = "< 淡水月亮 > 簽名詩集 x 1, [ 透明行李箱詩卡書籤 ] x 1",
                PlanShipDate = new DateTime(2021, 5, 25),
                PlanImgUrl = "https://i.imgur.com/qrvtbaDm.jpg",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 850,
                QuantityLimit = 30,
                AddCarCarPlan = true,
                SubmitLimit = 110
            });

            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 95,
                ProjectName = "陸穎魚首部詩集《淡水月亮》10週年台灣復刻版企劃",
                ProjectId = 20,
                ProjectPlanId = 2,
                PlanTitle = "渾蛋在月亮下說晚安",
                PlanFundedPeople = 30,
                PlanDescription = "< 淡水月亮 > x 1, [ 透明行李箱詩卡書籤 ] x 1, [晚安晚安] x 1, < 抓住那個混蛋 > x 1",
                PlanShipDate = new DateTime(2021, 5, 25),
                PlanImgUrl = "https://i.imgur.com/l7RQG5N.jpg",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1200,
                QuantityLimit = 30,
                AddCarCarPlan = true,
                SubmitLimit = 120
            });


            //第21個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 21,
                MemberId = 21,
                ProjectName = "精釀台灣！用當季產物釀在地啤酒",
                Category = "公共在地",
                ProjectStatus = "結束且成功",
                StartDate = new DateTime(2021, 1, 20),///不要超過60天
                EndDate = new DateTime(2021, 2, 20),
                Fundedpeople = 400,
                FundingAmount = 347625,
                AmountThreshold = 300000,//募資門檻
                CreatorName = "卡維蘭",//提案者
                ProjectMainUrl = "https://i.imgur.com/ZTlwn4Lm.png",
                //提案瀏覽頁的頁面照片 照片格式IMGURL SIZE:		320x320 連結檔案名結尾m
                ProjectCoverUrl = "",
                //提案詳細頁的影片覆蓋 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "",
                //格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "",
                Project_Question = "",
                Project_Answer = "",
                ProjectPlansCount = 2,
                CreatedDate = new DateTime(2021, 1, 20),
                SubmittedDate = new DateTime(2021, 1, 20),
                LastEditTime = new DateTime(2021, 1, 20),
                ApprovingStatus = 2
            });


            //第21個會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 21,
                MemberAccount = "NO21member",
                MemberPassword = "NO21memberPassword",  //登入假資料用
                MemberName = "卡維蘭",
                MemberAddress = "",
                MemberBirth = new DateTime(1990, 1, 18),
                MemberConEmail = "NO21member@gmail.com",
                MemberRegEmail = "NO21member@gmail.com", //登入用
                MemberMessage = "",
                MemberPhone = "",
                MemberTeamName = "卡維蘭",
                MemberWebsite = "",
                AboutMe = "",
                Gender = "其他",
                ProfileImgUrl = "https://i.imgur.com/BLS5NWtt.png",
                //照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });


            //第21個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 96,
                ProjectName = "精釀台灣！用當季產物釀在地啤酒",
                ProjectId = 21,
                ProjectPlanId = 1,
                PlanTitle = "明信片一組 4 張",
                PlanFundedPeople = 30,
                PlanDescription = "明信片一組 4 張",
                PlanShipDate = new DateTime(2021, 5, 25),
                PlanImgUrl = "https://i.imgur.com/PXbgRDOm.png",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 200,
                QuantityLimit = 30,
                AddCarCarPlan = true,
                SubmitLimit = 150
            });

            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 97,
                ProjectName = "精釀台灣！用當季產物釀在地啤酒",
                ProjectId = 21,
                ProjectPlanId = 2,
                PlanTitle = "精釀啤酒 x 2",
                PlanFundedPeople = 30,
                PlanDescription = "台灣風土映紅精釀啤酒 * 6, 卡維蘭水蜜桃精釀啤酒 * 6",
                PlanShipDate = new DateTime(2021, 5, 25),
                PlanImgUrl = "https://i.imgur.com/MDsvL4Xm.png",
                //照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1600,
                QuantityLimit = 30,
                AddCarCarPlan = true,
                SubmitLimit=50
            });
            ////Lesley

            //第22個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 22,
                MemberId = 22,
                ProjectName = "都市相談室｜成功大學都市計劃學系110級畢業成果展",
                Category = "公共在地",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 4, 1),
                EndDate = new DateTime(2021, 6, 1),
                Fundedpeople = 35,
                FundingAmount = 4680m,
                AmountThreshold = 5000m,
                CreatorName = "都市計劃學系110級畢業成果展",
                ProjectMainUrl = "https://i.imgur.com/IXiwVEcm.png",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/EtuLoDmm.png",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "https://i.imgur.com/C0q1J9Yl.png,https://i.imgur.com/UPYdA2ll.png,https://i.imgur.com/clic4Z2l.png,https://i.imgur.com/F6GEuaTl.png,https://i.imgur.com/ZKYawKQl.png,https://i.imgur.com/ZOdXKIll.png,https://i.imgur.com/f2HpwVul.png,https://i.imgur.com/hLsnbKNl.png,https://i.imgur.com/jHlIr8sl.png,https://i.imgur.com/22KSEkgl.png,https://i.imgur.com/o1LkEDtl.png",
                //	Large Thumbnail 格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/KDok4sdv1fA",
                Project_Question = "《都市相談室》的展期及地點為何？,回饋商品何時會收到？",
                Project_Answer = "我們的展期在2021/6/10(四) - 2021/6/14(一) 早上11:00至晚上22:00，展覽地點位於南紡購物中心一館一樓 時尚廣場(臺南市東區中華東路一段366號)。,回饋商品皆於展期間於展覽現場領取，若未領取，則將於展期結束後寄送。",
                ProjectPlansCount = 4,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 3, 31),
                ApprovingStatus = 2


            });
            //第22個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 22,
                MemberAccount = "N22member",
                MemberPassword = "N22memberPassword",
                MemberName = "都市計劃學系110級畢業成果展",
                MemberAddress = "700 臺南市大學路1號",
                MemberBirth = new DateTime(1994, 12, 3),
                MemberConEmail = "cityplan123@gmail.com",
                MemberRegEmail = "cityplan123@gmail.com",
                MemberMessage = "",
                MemberPhone = "0935-666449",
                MemberTeamName = "都市計劃學系110級畢業成果展",
                MemberWebsite = "https://lohas.acsite.org/",
                AboutMe = "都市相談室 | 紡織廠再生-策略規劃與再開發公展,國立成功大學都市計劃學系110級 畢業成果展,NCKU Urban Planning Dept.Graduation Exhibition",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/0loe78pt.png",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第22個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 98,
                ProjectId = 22,
                ProjectName = "都市相談室｜成功大學都市計劃學系110級畢業成果展",
                ProjectPlanId = 1,
                PlanTitle = "【都市拼貼｜都市拓印】",
                PlanFundedPeople = 3,
                PlanDescription = "[ 都市拼貼｜都市拓印 ] 募資限定價$100,✧心之所向✧ 明信片4款＋貼紙3款 你心中有嚮往的城市嗎？,來都市相談室，和我一起拓出屬於我們的城市",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/bPyqZagm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 100m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 99,
                ProjectId = 22,
                ProjectName = "都市相談室｜成功大學都市計劃學系110級畢業成果展",
                ProjectPlanId = 2,
                PlanTitle = "【海綿城市】",
                PlanFundedPeople = 13,
                PlanDescription = "✧海納百川✧ 珪藻土杯墊,做規劃覺得累了嗎？,讓我像海綿城市一樣吸納你的淚水與汗水吧,,//現場販售價格 $120//",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/fCVKsJwm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 100m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 100,
                ProjectId = 22,
                ProjectName = "都市相談室｜成功大學都市計劃學系110級畢業成果展",
                ProjectPlanId = 3,
                PlanTitle = "【都市容受力】",
                PlanFundedPeople = 14,
                PlanDescription = "[ 都市容受力 ] 募資限定價$120,✧回憶滿載✧ A4帆布袋,突然發現自己記憶力變差了嗎？,都市容受力讓你擁有裝下你我點點滴滴的超能力,,//現場販售價格 $150//",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/hWWlAfUm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 120m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 101,
                ProjectId = 22,
                ProjectName = "都市相談室｜成功大學都市計劃學系110級畢業成果展",
                ProjectPlanId = 4,
                PlanTitle = "【四種願望一次滿足】",
                PlanFundedPeople = 5,
                PlanDescription = "[ 四種願望一次滿足 ] 募資限定價$280,✧錯過不再✧ 明信片＋貼紙＋帆布袋＋杯墊,你還在猶豫嗎？,小孩子才做選擇，我全都要！,,//現場販售價格 $330//",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/DDybSo6m.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 280m,
                QuantityLimit = 70
            });

            //第23個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 23,
                MemberId = 23,
                ProjectName = "成為MARAHO的翅膀吧:為新賽季做準備|FRC7497",
                Category = "科技設計",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 4, 1),
                EndDate = new DateTime(2021, 6, 1),
                Fundedpeople = 33,
                FundingAmount = 47100m,
                AmountThreshold = 50000m,
                CreatorName = "提案者FRC7497 MARAHO",
                ProjectMainUrl = "https://i.imgur.com/41xsiTem.jpg",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/7I6JNmdl.png",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "https://i.imgur.com/ASDjEj4l.jpg,https://i.imgur.com/4TeQ3bXl.jpg,https://i.imgur.com/7hEkqnJl.jpg,https://i.imgur.com/Ypo3evSl.jpg,https://i.imgur.com/WNXndFpl.jpg,https://i.imgur.com/w6blQuql.jpg,https://i.imgur.com/c3MJF06l.jpg,https://i.imgur.com/JkiChGKl.jpg,https://i.imgur.com/5fMvpfll.jpg,https://i.imgur.com/b0n8OB9l.jpg,https://i.imgur.com/A2bAjenl.jpg,https://i.imgur.com/dfliRPSl.jpg,https://i.imgur.com/7EWwyVPl.jpg,https://i.imgur.com/Gq7xFaNl.jpg,https://i.imgur.com/yMZvZMkl.jpg,https://i.imgur.com/C5M65BWl.jpg,https://i.imgur.com/ef2k4BWl.jpg",
                //	Large Thumbnail 格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/Lbn6N6zDIDY",
                Project_Question = "為何我們需要您的贊助?",
                Project_Answer = "frc需要大量的經費及精力，您的支持都是我們前進的動力!",
                ProjectPlansCount = 5,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 3, 31),
                ApprovingStatus = 2


            });
            //第23個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 23,
                MemberAccount = "N23member",
                MemberPassword = "N23memberPassword",
                MemberName = "提案者FRC7497 MARAHO",
                MemberAddress = "",
                MemberBirth = new DateTime(1996, 5, 3),
                MemberConEmail = "frc7497@gmail.com",
                MemberRegEmail = "frc7497@gmail.com",
                MemberMessage = "",
                MemberPhone = "0938-616949",
                MemberTeamName = "成功高中 FRC 7497 團隊",
                MemberWebsite = "https://www.flyingv.cc/projects/28002",
                AboutMe = "成功高中 FRC 7497 團隊",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/luE1c85t.png",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第23個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 102,
                ProjectId = 23,
                ProjectName = "成為MARAHO的翅膀吧:為新賽季做準備|FRC7497",
                ProjectPlanId = 1,
                PlanTitle = "單純力挺，不須回饋",
                PlanFundedPeople = 3,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/qWbpDyUm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 200m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 103,
                ProjectId = 23,
                ProjectName = "成為MARAHO的翅膀吧:為新賽季做準備|FRC7497",
                ProjectPlanId = 2,
                PlanTitle = "手寫明信片送上滿滿的感謝!",
                PlanFundedPeople = 3,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/1fgL0v5m.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 500m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 104,
                ProjectId = 23,
                ProjectName = "成為MARAHO的翅膀吧:為新賽季做準備|FRC7497",
                ProjectPlanId = 3,
                PlanTitle = "7497專屬徽章,特製3D列印鑰匙圈,手寫明信片",
                PlanFundedPeople = 20,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/T5xGfcJm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1000m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 105,
                ProjectId = 23,
                ProjectName = "成為MARAHO的翅膀吧:為新賽季做準備|FRC7497",
                ProjectPlanId = 4,
                PlanTitle = "MARAHO 限定杯墊,7497專屬徽章,特製3D列印鑰匙圈,手寫明信片",
                PlanFundedPeople = 5,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/9qDR455m.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 3000m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 106,
                ProjectId = 23,
                ProjectName = "成為MARAHO的翅膀吧:為新賽季做準備|FRC7497",
                ProjectPlanId = 5,
                PlanTitle = "MARAHO 限定馬克杯,MARAHO 限定杯墊,7497專屬徽章,特製3D列印鑰匙圈,手寫明信片",
                PlanFundedPeople = 2,
                PlanDescription = "",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/nOQpf1Fm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 5000m,
                QuantityLimit = 50
            });
            //第24個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 24,
                MemberId = 24,
                ProjectName = "2021 共創台灣教育新世代 | FRC 8585",
                Category = "科技設計",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 4, 10),
                EndDate = new DateTime(2021, 6, 1),
                Fundedpeople = 9,
                FundingAmount = 122000m,
                AmountThreshold = 200000m,
                CreatorName = "FRC8585 BombaxLeopard",
                ProjectMainUrl = "https://i.imgur.com/H5Xgvikm.png",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/M1XVdeVm.png",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "https://i.imgur.com/qB2CiWZl.png,https://i.imgur.com/HQ3UncBl.jpg,https://i.imgur.com/UCeUHYil.png,https://i.imgur.com/Lva4TvQl.png",
                //	Large Thumbnail 格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/M3R0e-NzECc",
                Project_Question = "",
                Project_Answer = "",
                ProjectPlansCount = 6,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 3, 31),
                ApprovingStatus = 2


            });
            //第24個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 24,
                MemberAccount = "N24member",
                MemberPassword = "N24memberPassword",
                MemberName = "簡良宸",
                MemberAddress = "",
                MemberBirth = new DateTime(1997, 2, 3),
                MemberConEmail = "frc8585bl@gmail.com",
                MemberRegEmail = "frc8585bl@gmail.com",
                MemberMessage = "",
                MemberPhone = "0935-568849",
                MemberTeamName = "FRC8585 BombaxLeopard",
                MemberWebsite = "https://lohas.acsite.org/",
                AboutMe = "我們來自大安高工AI自主研究社(機器人研究社) 以Bombax Leopard 山虎棉登記FRC國際隊號#8585 是一支想要改造台灣教育的團隊 儘管我們只是一群高中生 但是我們的執行力和夢想 是遠遠超出其他人的！！",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/4GBsE0Mt.png",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第24個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 107,
                ProjectId = 24,
                ProjectName = "2021 共創台灣教育新世代 | FRC 8585",
                ProjectPlanId = 1,
                PlanTitle = "感謝您支持我們！",
                PlanFundedPeople = 2,
                PlanDescription = "FRC 8585 特製貼紙*1,FRC 8585 團隊特製感謝函*1,列名於FRC 8585社網",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/cABOytMm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 500m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 108,
                ProjectId = 24,
                ProjectName = "2021 共創台灣教育新世代 | FRC 8585",
                ProjectPlanId = 2,
                PlanTitle = "感謝您支持我們！",
                PlanFundedPeople = 0,
                PlanDescription = "FRC 8585 特製貼紙*1,FRC 8585 特製徽章*1,FRC 8585 團隊特製感謝函*1,列名於FRC 8585社網",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/TmRXLBKm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1000m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 109,
                ProjectId = 24,
                ProjectName = "2021 共創台灣教育新世代 | FRC 8585",
                ProjectPlanId = 3,
                PlanTitle = "感謝您支持我們！",
                PlanFundedPeople = 3,
                PlanDescription = "FRC 8585 特製貼紙*1,FRC 8585 特製徽章*1,FRC 8585 團隊親筆感謝函*1,列名於FRC 8585社網、宣傳片",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/KDYiyctm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 2000m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 110,
                ProjectId = 24,
                ProjectName = "2021 共創台灣教育新世代 | FRC 8585",
                ProjectPlanId = 4,
                PlanTitle = "感謝您支持我們！",
                PlanFundedPeople = 3,
                PlanDescription = "FRC 8585 紀念T-shirt*1,FRC 8585 特製貼紙*1,FRC 8585 特製徽章*1,FRC 8585 團隊親筆感謝函*1,列名於FRC 8585社網、宣傳片",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/GYhcBJ0m.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 5000m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 111,
                ProjectId = 24,
                ProjectName = "2021 共創台灣教育新世代 | FRC 8585",
                ProjectPlanId = 5,
                PlanTitle = "感謝您支持我們！",
                PlanFundedPeople = 0,
                PlanDescription = "非常感謝您支持我們！,受邀參觀FRC 8585、感恩餐會等,特製裱框感謝狀*1,,FRC 8585 紀念T-shirt*1,FRC 8585 特製貼紙*1,FRC 8585 特製徽章*1,FRC 8585 團隊親筆感謝函*1,列名於FRC 8585社網、宣傳片",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/EZxVDCtm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 10000m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 112,
                ProjectId = 24,
                ProjectName = "2021 共創台灣教育新世代 | FRC 8585",
                ProjectPlanId = 6,
                PlanTitle = "非常感謝您支持我們的理想！",
                PlanFundedPeople = 1,
                PlanDescription = "非常感謝您支持我們的理想！,受邀參觀FRC 8585、感恩餐會等,可將姓名、公司商標等置於機器人上，讓全世界看見！,,贈送FRC8585全套產品",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/Kdrt83Um.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 100000m,
                QuantityLimit = 50
            });
            //第25個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 25,
                MemberId = 25,
                ProjectName = "MOONPANT 輕微量接漏尿機能性內褲｜瞬吸快乾妳的尷尬",
                Category = "生活",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 4, 10),
                EndDate = new DateTime(2021, 6, 1),
                Fundedpeople = 36,
                FundingAmount = 43280m,
                AmountThreshold = 300000m,
                CreatorName = "三好MOONPANT",
                ProjectMainUrl = "https://i.imgur.com/GITEjAcm.jpg",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/IyjShaRl.png",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "https://i.imgur.com/IyjShaRl.png,https://i.imgur.com/ZdGiP4Hl.png,https://i.imgur.com/Cyjrl8il.jpg,https://i.imgur.com/SJaFXvCl.jpg,https://i.imgur.com/2vEFXdwl.jpg,https://i.imgur.com/FHj6ueBl.jpg,https://i.imgur.com/9cHsv2yl.png,https://i.imgur.com/ACT5Khrl.jpg,https://i.imgur.com/OhtyUFZl.png,https://i.imgur.com/v2VVO15l.png",
                //	Large Thumbnail 格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/iHwEEXPVol8",
                Project_Question = "1. 如何洗滌天絲棉内褲延長使用期限呢?,2. 洗內褲的時候為何會有棉絮？",
                Project_Answer = "最佳的洗滌的方式是【手洗】，天絲棉面料細緻，手洗時別用力搓揉。更別為了省力而用刷子刷，搭配常溫清水在40度以下沖洗，請摺疊擠乾水份，於通風處自然平放晾乾就好；請勿使用漂白水或柔軟精一同清洗，也不要烘乾、熨。特別是第一次下水手洗前，請不要長時間浸泡內褲，容易讓天絲棉因吸附太多水分子而導致膨脹再加上摩擦搓揉而容易起毛絨。,天絲棉是木漿纖維，是由植物纖維提煉出來的天然短纖維，在製造過程中一堆布疊在一起，整批進行裁切時最前面和最後面的布料因為摩擦比較多，導致洗滌的時候帶出棉絮。棉絮洗出來後便不會再有這樣的問題，千萬不要因為有棉絮產生，而誤以為是商品品質不佳。",
                ProjectPlansCount = 3,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 3, 31),
                ApprovingStatus = 2


            });
            //第25個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 25,
                MemberAccount = "N25member",
                MemberPassword = "N25memberPassword",
                MemberName = "三好MOONPANT",
                MemberAddress = "",
                MemberBirth = new DateTime(1996, 5, 3),
                MemberConEmail = "moonpant@gmail.com",
                MemberRegEmail = "moonpant@gmail.com",
                MemberMessage = "",
                MemberPhone = "0932-356949",
                MemberTeamName = "月光下的秘蜜",
                MemberWebsite = "http://www.moonpant.com/",
                AboutMe = "自然純淨 守護您的每一天,MOONPANT沒有華麗的包裝，她希望用自然純淨的面貌和您見面，,MOONPANT不追隨時尚潮流，她希望您就是品牌，,MOONPANT希望女人們都要過美好的生活，,現在開始，MOONPANT",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/mLbA3Urt.jpg",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第25個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 113,
                ProjectId = 25,
                ProjectName = "MOONPANT 輕微量接漏尿機能性內褲｜瞬吸快乾妳的尷尬",
                ProjectPlanId = 1,
                PlanTitle = "MOONPANT 清爽自在系列單件組",
                PlanFundedPeople = 0,
                PlanDescription = "1.商品數量：1件,2.商品顏色：紫月光、北極灰、珊瑚粉 (請選擇顏色)。,3. 商品尺寸：M、L、XL(請參考尺寸表)。,4.商品款式：蕾絲款中低腰(約略在肚臍下2公分)。,5. 商品產地：台灣。,6.商品圖檔顏色因電腦設定差異有所不同，請依照收到的實際商品。",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/ZdGiP4Hm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 400m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 114,
                ProjectId = 25,
                ProjectName = "MOONPANT 輕微量接漏尿機能性內褲｜瞬吸快乾妳的尷尬",
                ProjectPlanId = 2,
                PlanTitle = "MOONPANT 清爽自在系列3件組",
                PlanFundedPeople = 23,
                PlanDescription = "1.商品數量：3件,2.商品顏色：紫月光、北極灰、珊瑚粉(請選擇組別）。,3. 商品尺寸：M、L、XL(請參考尺寸表)。,4.商品款式：蕾絲款中低腰(約略在肚臍下2公分)。,5. 商品產地：台灣。,6.商品圖檔顏色因電腦設定差異有所不同，請依照收到的實際商品。",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/zdOnabEm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 900m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 115,
                ProjectId = 25,
                ProjectName = "MOONPANT 輕微量接漏尿機能性內褲｜瞬吸快乾妳的尷尬",
                ProjectPlanId = 3,
                PlanTitle = "MOONPANT 清爽自在系列5件組",
                PlanFundedPeople = 13,
                PlanDescription = "1.商品數量：5件,2.商品顏色：紫月光、北極灰、珊瑚粉(請選擇組別）。,3. 商品尺寸：M、L、XL(請參考尺寸表)。,4.商品款式：蕾絲款中低腰(約略在肚臍下2公分)。,5. 商品產地：台灣。,6.商品圖檔顏色因電腦設定差異有所不同，請依照收到的實際商品。",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/kda3xFPm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1500m,
                QuantityLimit = 50
            });
            //第26個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 26,
                MemberId = 26,
                ProjectName = "拍謝少年《歹勢好勢》專輯發行募資",
                Category = "音樂",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 4, 15),
                EndDate = new DateTime(2021, 6, 1),
                Fundedpeople = 447,
                FundingAmount = 750960m,
                AmountThreshold = 500000m,
                CreatorName = "拍謝少年",
                ProjectMainUrl = "https://i.imgur.com/qgMOs7Sm.jpg",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/HFxY2JHl.jpg",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "https://i.imgur.com/o7FQGANl.jpg,https://i.imgur.com/Sl48bgOl.jpg,https://i.imgur.com/LHJK391l.jpg,https://i.imgur.com/vee18bvl.jpg,https://i.imgur.com/NJIMyWFl.jpg,https://i.imgur.com/sUSLjTql.jpg,https://i.imgur.com/lNrBfMCl.jpg,https://i.imgur.com/42x65QMl.jpg,https://i.imgur.com/Jg3DZVNl.jpg,https://i.imgur.com/j46OoGHl.jpg,https://i.imgur.com/xR96mUKl.jpg,https://i.imgur.com/Lllepybl.jpg,https://i.imgur.com/NX0AgyTl.jpg,https://i.imgur.com/FMSEs2Jl.png,https://i.imgur.com/rk5Vk9Ul.jpg",
                //	Large Thumbnail 格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/tDKrqhuLZbg",
                Project_Question = "若遇疫情暖身演出會取消嗎？,募資的回饋演出是什麼時間？,回饋商品什麼時候會到貨？,我要怎麼收到回饋商品？海外也可以贊助嗎？,回饋品的寄送需另付運費嗎？贊助好幾個方案會分開寄嗎？,我可以同個贊助方案訂購兩份嗎？,已經贊助成功，但想要更改贊助時留下的基本資料/修改收件人要怎麼辦？,專案進行中，可以取消贊助嗎？,贊助暖身演出方案可以將門票（入場資格）轉讓嗎？,暖身方案要怎麼入場呢？會事先寄票嗎？飲料跟餐點兌換券也會寄嗎？,回饋品的製造產地？",
                Project_Answer = "如遇中央流行疫情指揮中心公佈相關群聚規範影響活動舉辦，回饋演出將順延並另行通知舉辦日期。,三個場次都是16:00開演，預計15:30入場，活動前會再發信給活動參加者提醒唷！,．《歹勢好勢》專輯預計在2021年5月發行，贊助5/8、5/15發行暖身搶聽場的朋友，專輯預計於活動當日領取；贊助5/22發行暖身搶聽場的朋友，專輯將會於活動前郵寄。,回饋品一律採郵局掛號寄出，請參與募資的朋友務必提供正確完整之姓名、電話、地址，以利寄送。由於寄送問題，暫不開放饋品寄送海外，還請見諒。,不用唷！為感謝大家支持，本次募資寄送商品運費將由拍謝少年全數買單！,要麻煩您填兩次單，我們看到相同地址的訂單將會合併寄送。若您兩份商品要寄到不同地方，請填寫不同的寄送地址。,登入平台後，點選右上方個人頭像選取“贊助紀錄”，即可以編輯訂單資料。,可以。請來信至 flyingfive@ontoo.cc 告知＂退款原因＂，同時附上您贊助的「專案名稱、金流單號、贊助金額」，我們將儘速為您處理退款程序。,贊助成功後若想轉讓票券，於專案募資期間請點選右上方個人頭像選取“贊助紀錄”，即可以編輯收件人資料，入場將依「收件人姓名電話」為準。,本次演出皆不會事先寄票也不需取票，活動當天於現場出示可證明身份之相關證件（e.g.身份證、健保卡、學生證），以及集資車車寄出之贊助確認信，核對無誤即可入場。,回饋品皆為台灣生產製造。",
                ProjectPlansCount = 3,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 3, 31),
                ApprovingStatus = 2


            });
            //第26個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 26,
                MemberAccount = "N26member",
                MemberPassword = "N26memberPassword",
                MemberName = "拍謝少年",
                MemberAddress = "",
                MemberBirth = new DateTime(1996, 5, 3),
                MemberConEmail = "sorryyouth@gmail.com",
                MemberRegEmail = "sorryyouth@gmail.com",
                MemberMessage = "",
                MemberPhone = "0938-989849",
                MemberTeamName = "拍謝少年",
                MemberWebsite = "https://www.facebook.com/sorryyouthtw",
                AboutMe = "拍謝少年 (Sorry Youth)，一尾台灣土產搖滾樂隊。",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/xhb9qrit.jpg",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第26個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 116,
                ProjectId = 26,
                ProjectName = "拍謝少年《歹勢好勢》專輯發行募資",
                ProjectPlanId = 1,
                PlanTitle = "｜酒豪傳說｜2021.5.8.台北臺虎精釀Lab限定募資回饋場",
                PlanFundedPeople = 216,
                PlanDescription = "在酒廠旁喝現拉生啤，聽拍謝少年唱歌！,內容物,- 歹勢好勢專輯 x1,- 限定回饋場門票 x1,- 拍謝少年最喜歡的飲料 兌換券 x1,- 臺虎Lab飲料兌換券 x1",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/pIehvo1m.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1680m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 117,
                ProjectId = 26,
                ProjectName = "拍謝少年《歹勢好勢》專輯發行募資",
                ProjectPlanId = 2,
                PlanTitle = "｜魚人返鄉｜2021.5.15.林聰明沙鍋魚頭限定募資回饋場",
                PlanFundedPeople = 120,
                PlanDescription = "魚頭拼魚頭搖滾大對決，吃飽喝足新歌聽滿滿。,內容物,- 歹勢好勢專輯 x1,- 限定回饋場門票 x1,- 拍謝少年最喜歡的飲料 兌換券 x1,- 林聰明限定特餐 x1",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/CgkKiI8m.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1680m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 118,
                ProjectId = 26,
                ProjectName = "拍謝少年《歹勢好勢》專輯發行募資",
                ProjectPlanId = 3,
                PlanTitle = "｜重回台十七｜2021.5.22.高雄蚵寮返鄉限定募資回饋場",
                PlanFundedPeople = 111,
                PlanDescription = "港邊就是唱歌喝酒的好所在，掀海風聽歌爽！,內容物,-歹勢好勢專輯 x1,-限定回饋場門票 x1,-拍謝少年最喜歡的飲料 兌換券 x1,-意滿漁限定特餐 x1",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/BB86is9m.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1680m,
                QuantityLimit = 50
            });
            //第27個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 27,
                MemberId = 27,
                ProjectName = "Sandbox樂團 首張創作EP 《流浪者 The Vagabond》",
                Category = "音樂",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 4, 15),
                EndDate = new DateTime(2021, 6, 1),
                Fundedpeople = 103,
                FundingAmount = 100050m,
                AmountThreshold = 100000m,
                CreatorName = "Sandbox樂團",
                ProjectMainUrl = "https://i.imgur.com/T9jp7bTm.jpg",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/UTtHqLGl.jpg",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "大家好，我們是Sandbox ！,Sandbox沙盒樂團成軍於2011年，是以電吉他、鍵盤、貝斯與鼓組成的四人前衛演奏型獨立樂團，曲風結合前衛搖滾、實驗、後搖與電影音樂，四年以來歷經大小革新，從無數次的深省淬鍊出現今的樣貌。邁入新的里程碑的我們，即將帶來富有畫面感與想像空間的全新創作EP，期待與更多人分享我們在樂曲中欲訴說的故事。,,,夢中恍惚的美好，無可捕捉卻又總是流連；如果你也一樣，那麼，一起來到我們的音樂中吧，相信你能找回那種深刻。這些樂曲沒有文字，聲響的對話、想像的空間裡面，你看見了什麼？邀請你一同將我們的想像實體化，使更多人在樂曲中遇見我們，也遇見流浪已久的自我。,,,《流浪者 The Vagabond》EP,流浪之人在沙漠中漫行，時間似沙一般一點一滴流逝，他行至一個沙丘，雖看來無異於他處，但他選擇在這裡稍停，拿起望遠鏡，多看幾眼指引他方向的滿天星斗，希望除了能看出除了東南西北外，還能在星芒的明滅之間，得到造物主些許的默示。 但，他不知道的是，腳下走過的沙漠，雖然時間一點一滴的流逝，但在另一個時空裡，流逝的沙卻變成了一點一滴充滿色彩的水滴，聚流成河地蔓延，原來在冥冥之中，一個可安歇的境地已悄然誕生．．．",
                ProjectImgUrl = "https://i.imgur.com/UTtHqLGl.jpg,https://i.imgur.com/fW3SCdwl.jpg,https://i.imgur.com/fWxTTsWl.jpg,https://i.imgur.com/Aa70IuKl.jpg,https://i.imgur.com/FwAwzTEl.jpg",
                //	Large Thumbnail 格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/WFCJuhczBkY",
                Project_Question = "",
                Project_Answer = "",
                ProjectPlansCount = 4,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 3, 31),
                ApprovingStatus = 2


            });
            //第27個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 27,
                MemberAccount = "N27member",
                MemberPassword = "N27memberPassword",
                MemberName = "Sandbox樂團",
                MemberAddress = "",
                MemberBirth = new DateTime(1992, 5, 3),
                MemberConEmail = "sandbox666@gmail.com",
                MemberRegEmail = "sandbox666@gmail.com",
                MemberMessage = "",
                MemberPhone = "0938-310899",
                MemberTeamName = "Sandbox樂團",
                MemberWebsite = "https://www.facebook.com/SandboxTW/",
                AboutMe = "Sandbox來自台灣，四件式前衛演奏搖滾樂團，以吉他和鍵盤敘事；鼓和貝斯應答，每首曲子自成一個世界，述說著一個個故事。",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/dsSDxaZt.jpg",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第27個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 119,
                ProjectId = 27,
                ProjectName = "Sandbox樂團 首張創作EP 《流浪者 The Vagabond》",
                ProjectPlanId = 1,
                PlanTitle = "【流浪者EP1張＋1217發片場門票1張】",
                PlanFundedPeople = 42,
                PlanDescription = "行旅天涯，我們走過旱地，唱和著，期待著雙眼被綠洲滋潤的那天。為回報您的支持，我們以十分划算的組合準備了EP專輯1張、以及12月17日 The Wall發片場門票1張套裝組合400元整（原市值共550元），專輯將在發片場當天發放給您，衷心歡迎您！",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/fW3SCdwm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 400m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 120,
                ProjectId = 27,
                ProjectName = "Sandbox樂團 首張創作EP 《流浪者 The Vagabond》",
                ProjectPlanId = 2,
                PlanTitle = "【流浪者EP2張＋1217發片場門票2張】",
                PlanFundedPeople = 11,
                PlanDescription = "行旅天涯，我們走過旱地，唱和著，期待著雙眼被綠洲滋潤的那天。為回報您的支持，我們以十分划算的組合準備了EP專輯2張、以及12月17日 The Wall發片場門票2張套裝組合750元整（原市值共1100元），專輯將在發片場當天發放給您，衷心歡迎您！",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/fWxTTsWm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 750m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 121,
                ProjectId = 27,
                ProjectName = "Sandbox樂團 首張創作EP 《流浪者 The Vagabond》",
                ProjectPlanId = 3,
                PlanTitle = "【流浪者EP5張＋Sandbox Logo貼紙10張】",
                PlanFundedPeople = 20,
                PlanDescription = "行經曠野，雁群有序的掠過穹蒼，它們的羽翼在歸巢的路上，那，我們呢？十人限定組合佳評如潮，上架不到一天銷售一空！為回應向隅的朋友們，我們提供優惠的五人限定組合，5張EP、10張貼紙的組合，只有8組，給喜愛Sandbox但昨日慢了一步的朋友們參考！",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/Aa70IuKm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1050m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 122,
                ProjectId = 27,
                ProjectName = "Sandbox樂團 首張創作EP 《流浪者 The Vagabond》",
                ProjectPlanId = 4,
                PlanTitle = "【流浪者EP10張＋Sandbox Logo貼紙20張】",
                PlanFundedPeople = 30,
                PlanDescription = "行走於無盡的道路上，難免疲憊不堪，同伴們的支持與鼓勵，總是支撐著彼此向前的動力。快揪您的朋友一起共襄盛舉這場音樂饗宴！10人破盤優惠：10張EP、20張貼紙，只要1800！含寄送費用（原市值2900），呼朋引伴！只有三組！把握機會！",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/FwAwzTEm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 1800m,
                QuantityLimit = 50
            });
            //第28個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 28,
                MemberId = 28,
                ProjectName = "傻子與白痴樂團 - 首張實體EP募資",
                Category = "音樂",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 4, 15),
                EndDate = new DateTime(2021, 6, 1),
                Fundedpeople = 100,
                FundingAmount = 2810000m,
                AmountThreshold = 3000000m,
                CreatorName = "傻子與白痴",
                ProjectMainUrl = "https://i.imgur.com/z6Dcgyjm.jpg",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/P38EDQCl.jpg",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "",
                ProjectImgUrl = "https://i.imgur.com/x8uY43Fl.jpg,https://i.imgur.com/4uolqTzl.png,https://i.imgur.com/Y3QtVfvl.jpg,https://i.imgur.com/cM4g8TVl.jpg,https://i.imgur.com/kXvO2uWl.jpg,https://i.imgur.com/175xAF9l.jpg,https://i.imgur.com/IIqdEnRl.jpg,https://i.imgur.com/LN4ridNl.jpg,https://i.imgur.com/cK2tFyhl.jpg,https://i.imgur.com/tZa7MC7l.png,https://i.imgur.com/R3WSWXrl.png,https://i.imgur.com/AowNGxwl.jpg,https://i.imgur.com/NsZpLOHl.jpg,https://i.imgur.com/c1xhqNDl.jpg,https://i.imgur.com/k9rBd6tl.png",
                //	Large Thumbnail 格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/1fgTKtpFaTM",
                Project_Question = "",
                Project_Answer = "",
                ProjectPlansCount = 4,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 3, 31),
                ApprovingStatus = 2


            });
            //第28個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 28,
                MemberAccount = "N28member",
                MemberPassword = "N28memberPassword",
                MemberName = "徐維均",
                MemberAddress = "",
                MemberBirth = new DateTime(1990, 5, 3),
                MemberConEmail = "foolandidiot@gmail.com",
                MemberRegEmail = "foolandidiot@gmail.com",
                MemberMessage = "",
                MemberPhone = "0960-395249",
                MemberTeamName = "傻子與白痴",
                MemberWebsite = "https://www.streetvoice.com/FoolAndIdiotBand/",
                AboutMe = "人生只要專心做好一件事就好了。2015年，我們18歲，傻子與白痴在炎熱的琴房裡誕生。傻子代表的是內心裡最不社會化的那個我，白痴是被眾人與潮流影響的自己。一個很傻，一個很白痴。",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/M6Gpd47t.jpg",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第28個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 123,
                ProjectId = 28,
                ProjectName = "傻子與白痴樂團 - 首張實體EP募資",
                ProjectPlanId = 1,
                PlanTitle = "【傻子與白癡 第一輯】",
                PlanFundedPeople = 20,
                PlanDescription = "送 簽名EP*1 + 簽名海報*1 + 巡迴門票*1 + 收錄所有傻白創團以來demo之CD小專輯 + zippo x 傻白 foollighter打火機 一個 + 傻白全團員手寫信 + 傻白未來演出3場通行",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/M6Gpd47m.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 8000m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 124,
                ProjectId = 28,
                ProjectName = "傻子與白痴樂團 - 首張實體EP募資",
                ProjectPlanId = 2,
                PlanTitle = "【傻子與白癡 第二輯】",
                PlanFundedPeople = 30,
                PlanDescription = "送 簽名EP*1 + 簽名海報*1 + 巡迴門票*1 + 收錄所有傻白創團以來demo之CD小專輯 + 傻白全團員手寫信 + 和傻白團員一起去唱k + 傻白演出門票通行一年份",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/LN4ridNm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 15000m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 125,
                ProjectId = 28,
                ProjectName = "傻子與白痴樂團 - 首張實體EP募資",
                ProjectPlanId = 3,
                PlanTitle = "【傻子與白癡 第三輯】",
                PlanFundedPeople = 40,
                PlanDescription = "送 簽名EP*1 + 簽名海報*1 + 巡迴門票*1 + 收錄所有傻白創團以來demo之CD小專輯 + 傻白全團員手寫信 + 和傻白團員一起去唱k + 傻白演出門票通行一年份 + 傻白為你專屬製作一首你愛的單曲cover",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/IIqdEnRm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 30000m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 126,
                ProjectId = 28,
                ProjectName = "傻子與白痴樂團 - 首張實體EP募資",
                ProjectPlanId = 4,
                PlanTitle = "【傻子與白癡 第四輯】",
                PlanFundedPeople = 10,
                PlanDescription = "送 簽名EP*1 + 簽名海報*1 + 巡迴門票*1 + 收錄所有傻白創團以來demo之CD小專輯 + 傻白全團員手寫信 + 和傻白團員一起去唱k + 傻白為你專屬製作一首你愛的單曲cover +終生免費傻白演出通行",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/cM4g8TVm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 100000m,
                QuantityLimit = 50
            });
            //第29個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 29,
                MemberId = 29,
                ProjectName = "極簡主義電子音樂大師：池田亮司 Ryoji Ikeda 重擊來台・唯一表演！",
                Category = "藝術影視",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 4, 15),
                EndDate = new DateTime(2021, 6, 1),
                Fundedpeople = 76,
                FundingAmount = 450500m,
                AmountThreshold = 400000m,
                CreatorName = "山冶計畫",
                ProjectMainUrl = "https://i.imgur.com/6WrzXdQm.png",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/zV7df3Ul.jpg",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "1966 年生於日本岐阜縣的池田亮司，影響力早已超出日本，融合多重領域的表現，被國際藝術界視為前衛聲音藝術的領軍人物。1980 年代萌生的後工業音樂／噪音／實驗聲響系譜，因為池田亮司的出現，奠定了一個明確階段。從此，聲音藝術有了嶄新且多元的傳承與開展。過去20年來，池田亮司奮力不懈地探索現場演出、裝置和錄音等各種創作形式，日本前衛多媒體媒體實驗組合 Dumb Type 、編舞家威廉．佛塞（William Forsythe）、建築師伊東豊雄都曾為他的合作對象清單，池田亮司跨越的領域廣闊，我們可從中略知一二。藝術界對他的推崇和肯定，更可自諸多國際重要獎項得知：電子藝術大獎金尼卡獎、德國卡爾斯魯 ZKM 媒體藝術中心 Giga-Hertz 獎、歐洲核子研究組織的 Prix Ars Electronica Collide @ CERN 2014……無一不表現全球藝術界對他的推崇和肯定。,,我們期待，不只有全新的展覽創作，更能夠順勢邀請池田亮司來台表演，因而開啟了此募資計畫，期望集眾人之力讓重量級國際大師池田亮司，首度．親臨．台灣現場表演！,,倘若募資成功，池田亮司將額外帶來表演計畫supercodex，這場巡演始於美國紐約大都會博物館、經英國Attenborough藝術中心、中國北京—上海FUTURE X電子音樂節，12月止於休士頓日以繼夜藝術節。",
                ProjectImgUrl = "https://i.imgur.com/8QJQsafl.jpg,https://i.imgur.com/bsSmTXxl.jpg",
                //	Large Thumbnail 格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/J9kHDuGNcLI",
                Project_Question = "",
                Project_Answer = "",
                ProjectPlansCount = 3,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 3, 31),
                ApprovingStatus = 2


            });
            //第29個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 29,
                MemberAccount = "N29member",
                MemberPassword = "N29memberPassword",
                MemberName = "山冶計畫",
                MemberAddress = "",
                MemberBirth = new DateTime(1991, 5, 3),
                MemberConEmail = "mountainplan@gmail.com",
                MemberRegEmail = "mountainplan@gmail.com",
                MemberMessage = "",
                MemberPhone = "0940-166798",
                MemberTeamName = "山冶計畫",
                MemberWebsite = "https://mtproject.land/",
                AboutMe = "立基於當代藝術試問現象的動機，從展演策畫到教育活動，視各種與群眾對話的形式為思考實踐的變體。穿越白盒子與未知的野地，交知著自然與人文；交流始於協同合作，讓在地發生轉化和延續．期待以每一次的藝術計畫，碰撞出更開闊的想像世界。",
                Gender = "男",
                ProfileImgUrl = "https://i.imgur.com/3dcXHxXt.jpg",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第29個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 127,
                ProjectId = 29,
                ProjectName = "極簡主義電子音樂大師：池田亮司 Ryoji Ikeda 重擊來台・唯一表演！",
                ProjectPlanId = 1,
                PlanTitle = "【先鋒電子震波組】",
                PlanFundedPeople = 40,
                PlanDescription = "**新增【先鋒電子震波組】優先入場（搖滾區）2000元",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/xYmrJNIm.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 2000m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 128,
                ProjectId = 29,
                ProjectName = "極簡主義電子音樂大師：池田亮司 Ryoji Ikeda 重擊來台・唯一表演！",
                ProjectPlanId = 2,
                PlanTitle = "【近距震波組】",
                PlanFundedPeople = 30,
                PlanDescription = "【近距震波組】,◐ 優先入場（搖滾區）,◐ 限量明信片一組,◐ 限量提袋,◐ 池田亮司簽名CD,◐ 映像節放映活動保留席,,✶映像節放映活動參與場次可自選，完整節目單將於10月底公佈",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/YttSbyZm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 3500m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 129,
                ProjectId = 29,
                ProjectName = "極簡主義電子音樂大師：池田亮司 Ryoji Ikeda 重擊來台・唯一表演！",
                ProjectPlanId = 3,
                PlanTitle = "【超限序列特製組】",
                PlanFundedPeople = 6,
                PlanDescription = "【超限序列特製組】除了一定額的禮物回饋之外，我們將量身訂做回饋與超限的您！",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/sT9QvESm.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 60000m,
                QuantityLimit = 50
            });
            //第30個提案
            context.Projects.AddOrUpdate((x) => x.ProjectId, new Project
            {
                ProjectId = 30,
                MemberId = 30,
                ProjectName = "《行者》發行募資計劃 x 集資車車 獨家售票",
                Category = "藝術影視",
                ProjectStatus = "集資中",
                StartDate = new DateTime(2021, 4, 15),
                EndDate = new DateTime(2021, 6, 1),
                Fundedpeople = 116,
                FundingAmount = 402000m,
                AmountThreshold = 400000m,
                CreatorName = "行者",
                ProjectMainUrl = "https://i.imgur.com/wfpmKNGm.jpg",
                //提案瀏覽頁的頁面照片 	Medium Thumbnail 照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                ProjectCoverUrl = "https://i.imgur.com/NOSyWvTl.png",
                //提案詳細頁的影片覆蓋 	Large Thumbnail 照片格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectDescription = "《行者》片中部份採用台灣少見的 Dance Film 拍攝，拍攝團隊費盡心思上天下海，尋找出台灣符合無垢舞蹈劇場作品精神的美麗祕境之地，讓舞作中的角色，如神靈顯現般出現在這些秘境中，如神話、如寓言。,,而這樣的拍攝方式，也讓舞蹈作品的呈現，跳脫出劇場的黑盒子，在自然景緻裡活了過來。透過這影像史詩，生命的動能從土地與文化中竄出，在舞者的身體中流轉傳遞，將文字無法言述的畫面意象，透過手足身心，獨立顯影於凝結的時空中。,《行者》完成推出後，相繼獲得台北電影節、台灣國際紀錄片影展、與金馬獎的入圍肯定，更是影展售票中的秒殺片。,,在導演陳芯宜傾十年之力拍完本片後，卻在發行之際面臨資金缺口，電影製作團隊以不計成本的方式拍攝、剪接、後製之後，在已苦無經費的情況下，尚需自掏腰包代墊近百萬的資金缺口。,,為了能讓更多觀眾可以欣賞《行者》，透過電影更深入認識無垢這個美麗而堅毅的故事，同時，看見臺灣舞蹈藝術與土地的能量，我們需要你們的一臂之力。,,,,《行者》即將在 4/10 上映與觀眾見面，請讓我們一起進場支持，也藉由本片對臺灣舞蹈藝術家們獻上最深的敬意！",
                ProjectImgUrl = "https://i.imgur.com/FZBbnTjl.jpg,https://i.imgur.com/DUM6apLl.jpg,https://i.imgur.com/IcJOuEEl.jpg,https://i.imgur.com/stnDVv3l.png,https://i.imgur.com/Sag2x3Pl.jpg,https://i.imgur.com/MPfmB8fl.png,https://i.imgur.com/n50TfEXl.png,https://i.imgur.com/HUQl3TBl.jpg,https://i.imgur.com/UR5dr0al.png,https://i.imgur.com/9psjJuwl.jpg",
                //	Large Thumbnail 格式IMGURL SIZE:	640x640 連結檔案名結尾l
                ProjectVideoUrl = "https://www.youtube.com/embed/uCM1QgwKqII",
                Project_Question = "",
                Project_Answer = "",
                ProjectPlansCount = 4,
                CreatedDate = new DateTime(2020, 12, 1),
                SubmittedDate = new DateTime(2020, 12, 31),
                LastEditTime = new DateTime(2021, 3, 31),
                ApprovingStatus = 2
            });
            //第30個提案的會員資料
            context.Members.AddOrUpdate((x) => x.MemberId, new Member
            {
                MemberId = 30,
                MemberAccount = "N30member",
                MemberPassword = "N30memberPassword",
                MemberName = "行者",
                MemberAddress = "",
                MemberBirth = new DateTime(1988, 7, 13),
                MemberConEmail = "passenger666@gmail.com",
                MemberRegEmail = "passenger666@gmail.com",
                MemberMessage = "",
                MemberPhone = "0945-515849",
                MemberTeamName = "行者",
                MemberWebsite = "https://www.facebook.com/thewalkerslegendlindancetheatre/",
                AboutMe = "《行者》團隊自 2004 年起，貼身捕捉舞蹈家林麗珍動人身影，透過她的日常生活，探索舞蹈創作的原點與精神，而這長達十年的紀錄過程，也呼應了林麗珍十年一大作的創作特色。,,十年來，不僅拍攝了無垢於台北、香港、北京、法國、西班牙等各大藝術節演出的珍貴畫面，同時也真實紀錄一個精湛舞作背後，所經過的各種辛苦：無論是舞者的挑選與訓練、對服裝道具的感情與累積、舞者心靈與身體所展現的一致性等等，都深刻展現了臺灣舞蹈發展脈絡與本土藝術家生命映照之間的高度與深度。",
                Gender = "女",
                ProfileImgUrl = "https://i.imgur.com/wfpmKNGt.jpg",
                //	Small Thumbnail照片格式IMGURL SIZE:160x160 連結檔案名結尾t
            });
            //第30個提案中的方案
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 130,
                ProjectId = 30,
                ProjectName = "《行者》發行募資計劃 x 集資車車 獨家售票",
                ProjectPlanId = 1,
                PlanTitle = "【行者組合一】",
                PlanFundedPeople = 800,
                PlanDescription = "募資限定紀念電影票二張＋《行者》海報一張＋明信片一組＋名列DVD感謝名單",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/lOxl7C3m.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 45m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 131,
                ProjectId = 30,
                ProjectName = "《行者》發行募資計劃 x 集資車車 獨家售票",
                ProjectPlanId = 2,
                PlanTitle = "【行者組合二】",
                PlanFundedPeople = 22,
                PlanDescription = "募資限定紀念電影票一張＋無垢肢體開發體驗課程單堂一張＋無垢作品絕版海報一張＋名列DVD感謝名單",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/5Lc4JT6m.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 3000m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 132,
                ProjectId = 30,
                ProjectName = "《行者》發行募資計劃 x 集資車車 獨家售票",
                ProjectPlanId = 3,
                PlanTitle = "【行者組合三】",
                PlanFundedPeople = 38,
                PlanDescription = "募資限定紀念電影票一張＋《行者》簽名版DVD一組＋《觀》精裝攝影專書一本＋《行者》簽名版海報一張＋明信片一組＋名列DVD感謝名單",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/QCdTAaum.png",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 5000m,
                QuantityLimit = 50
            });
            context.Plans.AddOrUpdate((x) => x.PlanId, new Plan
            {
                PlanId = 133,
                ProjectId = 30,
                ProjectName = "《行者》發行募資計劃 x 集資車車 獨家售票",
                ProjectPlanId = 4,
                PlanTitle = "【行者組合四】",
                PlanFundedPeople = 11,
                PlanDescription = "募資限定紀念電影票一張＋秘境小旅行半日遊＋《行者》簽名版海報一張＋名列DVD感謝名單",
                PlanShipDate = new DateTime(2021, 7, 30),
                PlanImgUrl = "https://i.imgur.com/xa4c1Yem.jpg",
                //	Medium Thumbnail照片格式IMGURL SIZE:320x320 連結檔案名結尾m
                PlanPrice = 10000m,
                QuantityLimit = 50
            });


        }


    }
}