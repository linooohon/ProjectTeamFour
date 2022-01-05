# Raisebubu - 募資電商網站

> RaiseBuBu - 集資車車
> 立即註冊上車，你可以消費，也可以提案。


![首圖](https://i.imgur.com/AhB2x97.png)


---


## 一. 介紹:

#### 1. 概念:
純電商太無聊，純募資太無聊，結合起來或許可以?!
透過募資活動搭配募資結束後的持續電商銷售行為。(Demo Project)


#### 2. 使用技術:

- Vue, C#, Web API, Imgur, Axios, Razor
- .Net MVC, .NET Core, Authentication
- CodeFirst, Oauth, Entity Framework

---

## 二. 網站架構:

> 分為前台與後台:

#### 前台:
<!-- [前台](https://raisebubufront.azurewebsites.net/):  -->

一個募資結合電商功能的平台，提供完整的提案流程加上車車商城電商擁有完整購物車功能。 前後台皆採用 Repository Pattern + Service Layer 的分層架構，前台配合 MVC - Razor Page 製作前端頁面，後台前端使用以Vue.js 對資料欄位做 Binding、後端提供 API 的方式，透過 Axios 請求 API 對資料庫動作，後端 API 使用 .Net Core 並實踐 DI 相依性注入來降低類別或模組之間的耦合度，並使用 ORM - Entity Framework 實作 CRUD，網站實現 更新提案募資狀況、金額、時間、草稿續存修改等功能，且能依照提案者需求 將募資成功專案續留車車專區 續售服務。

---


![](https://i.imgur.com/oP8LM9S.png)


#### 後台:
<!-- [後台](https://raisebububack.azurewebsites.net/): -->

以 ASP.NET Core 為主，後台功能主要包括專案審核與拒絕、權限管理、會員管理、訂單管理、網站狀態圖表分析 ，與前台較不相同的是落實前後端分離的概念，使用 DI 注入，依賴介面而不依賴實作，因抽象化實作，故抽換實作也變得容易，使整個專案更有架構。
- 測試客服帳密:  帳號: linooohon@gmail.com  密碼: linooohon
- 測試管理人帳密: 帳號: admin@gmail.com 密碼: admin


---

## 三. 主要負責:

#### Phil(我)負責部分:
  - 前、後台提案系統
  - 專案草稿、審核功能
  - 會員註冊登入系統
  - 第三方登入串接、忘記密碼
  - 首頁、車車商城前端切版、資料處理


Skill:

- JavaScript / Vue / jQuery / Bootstrap / HTML / CSS / Axios
- .NET MVC / .NET Core / Entity Framework / Linq / Razor
- Authentication / Oauth / Imgur / Azure / SQL Server


#### 細項:

##### 1. 前台提案系統：畫面處理、資料、草稿、修改、呈交、預覽、前往專案

為一個四頁式的連續提案表單
- 可以編輯文字
- 照片上傳
- 暫存草稿
- 富文本編輯器撰寫募資提案


<div style="display: flex; flex-wrap: wrap;">
    <img src="https://i.imgur.com/lLZHMAj.png" width="30%"/>
    <img src="https://i.imgur.com/a7iYGrr.png" width="30%"/>
    <img src="https://i.imgur.com/UXbSAZc.png" width="30%"/>
    <img src="https://i.imgur.com/26iQPDP.png" width="30%"/>
    <img src="https://i.imgur.com/jNNSY12.png" width="60%"/>
</div>


##### 2. 後台提案管理：資料串接、審核、拒絕、後台預覽

<img src="https://i.imgur.com/0IpHizK.png" width="30%"/>


##### 3. 會員註冊登入系統，寄信、忘記密碼

<img src="https://i.imgur.com/HVKkJkw.png" width="30%"/>


##### 4. 第三方登入 Facebook、Google 串接

<img src="https://i.imgur.com/LbYZ4Nf.png" width="30%"/>


##### 5. 首頁、車車商城、提案流程切版、資料處理、搜索功能


<img src="https://i.imgur.com/K8dDUIJ.png" width="30%"/>
<img src="https://i.imgur.com/AhB2x97.png" width="30%"/>


