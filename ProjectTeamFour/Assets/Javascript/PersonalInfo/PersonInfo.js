﻿$(document.getElementById('user-profile')).ready(function () {
    var uploadimg = document.querySelector('#uploadimg');
    uploadimg.addEventListener('change', function (e) {
        //debugger;
        let files = $(this).get(0).files;
        let formData = new FormData();
        formData.append(files[0].name, files[0]);
        uploadFile(formData);
        console.log(files);
        console.log(formData);
    })

    //document.getElementById('user-profile').addEventListener('',)

    //document.getElementById('user-profile').addEventListener('click', function () {

    var btn_submit = document.querySelector('#btnSub');
    var imgUrl = document.getElementById('imgshow');
    btn_submit.addEventListener('click', function () {

        $.ajax({
            url: '/api/memberapi/update',
            type: 'post',
            data: {
                MemberId: $('#memberid').text(),
                MemberConEmail: $('#contactEmail').val(),
                Gender: document.getElementById('gender1').value,
                MemberBirth: document.getElementById('birthday1').value,
                AboutMe: $('#about').val(),
                MemberName: $('#name1').val(),
                MemberWebsite: $('#personal-site').val(),
                ProfileImgUrl: document.getElementById('imgshow').getAttribute('src')
            },
            success: function (response) {
                if (response == "成功") {
                    //debugger;
                    let imgurl = document.getElementById('imgshow').getAttribute('src');
                    console.log(imgurl);
                    imgUrl.setAttribute('src', imgurl);
                    //document.getElementsByName('memberimg').forEach(item => {
                    //    console.log(imgurl);
                    //    item.setAttribute('src', imgurl);
                    //})

                    Swal.fire({
                        position: 'top-center',
                        icon: 'success',
                        title: '修改成功',
                        showConfirmButton: false,
                        timer: 1500
                    })
                }
                else {
                    Swal.fire({
                        position: 'top-center',
                        icon: 'error',
                        title: '修改失敗, 您可能密碼輸入不對',
                        showConfirmButton: false,
                        timer: 1500
                    })
                }
            }
        })
    })

    //$('.card_part').slick({
    //    infinite: true,
    //    slidesToShow: 3,
    //    slidesToScroll: 3
    //});

})

function uploadFile(formData) {
    //debugger;
    console.log(formData);
    $.ajax({
        url: '/api/memberapi/UploadFiles',
        method: 'post',
        data: formData,
        processData: false,
        contentType: false,
        success: function (response) {
            document.getElementById('imgshow').setAttribute('src', response);
        }
    })
};

function getGender() {
    let mygender = document.getElementById('gender1').value;
    //e.options[e.selectedIndex].text;
    //let genderselect = document.getElementById('gender1');
    switch (myselect) {
        case "女性":
            //setgender.selectedOptions[1].setAttribute("selected")
            genderselect.selectedIndex = "1";
            break;
        case "男性":
            //setgender.selectedOptions[2].setAttribute("selected")
            genderselect.selectedIndex = "2";
            break;
        case "其他":
            //setgender.selectedOptions[3].setAttribute("selected")
            genderselect.selectedIndex = "3";
            break;
        default:
            //setgender.selectedOptions[0].setAttribute("selected")
            genderselect.selectedIndex = "0";
            break;
    }
}






//--------------


//console.log(oldPassword);

//let oldPassword = $('#inputPassword').val();
//let newPassword = $('#newPassword').val();
//let confirmPassword = $('#checkPassword').val();
//let submitBtn = $('#change-password');
//var submit = true;

//console.log(oldPassword);


$('#change-password').click(function (e) {
    e.preventDefault();
    ModifyPassword();
    //console.log(oldPassword);
    //SubmitPwd();
});


function ModifyPassword() {
    console.log($('#inputPassword').val());

    if ($('#inputPassword').val() == "") {
        Swal.fire({
            position: 'top',
            icon: 'warning',
            title: '原始密碼為空!',
            showConfirmButton: false,
            timer: 1500
        })
        //submit = false;
    }
    else if ($('#newPassword').val() == "") {
        Swal.fire({
            position: 'top',
            icon: 'warning',
            title: '新密碼為空!',
            showConfirmButton: false,
            timer: 1500
        })
        //submit = false;
    }
    else if ($('#checkPassword').val() == "") {
        Swal.fire({
            position: 'top',
            icon: 'warning',
            title: '確認密碼為空!',
            showConfirmButton: false,
            timer: 1500
        })
        //submit = false;
    }
    else if ($('#newPassword').val() != $('#checkPassword').val()) {
        Swal.fire({
            position: 'top',
            icon: 'warning',
            title: '兩次輸入密碼不相符',
            showConfirmButton: false,
            timer: 1500
        })
        //submit = false;
    }
    else {
        //submit = true;
        SubmitPwd();
    }

};



function SubmitPwd() {
    console.log($('#inputPassword').val());
    console.log(1);

    var data = {
        MemberId: $('#memberId').text(),
        MemberRegEmail: $('#account').val(),
        MemberPassword: $('#newPassword').val(),
        //OldPassword: $('#inputPassword').val(),
    };

   
        $.ajax({
            url: '/UserInfo/LoginedChangePassword',
            type: 'POST',
            //dataType: "json",
            //contentType: "application/json",
            data: data,
            success: function (res) {
                if (res == "成功") {
                    Swal.fire({
                        position: 'top',
                        icon: 'success',
                        title: '修改成功',
                        showConfirmButton: false,
                        timer: 3000
                    })

                    setTimeout(() => {
                        window.location.href="/Home/Index"
                    }, 3000)
                }
                else {
                    Swal.fire({
                        position: 'top',
                        icon: 'error',
                        title: '修改失敗',
                        showConfirmButton: false,
                        timer: 1500
                    })
                }
            }
        });
}


//-----------跳轉指定頁面-------------------
function ToNews() {
    var hash = location.hash; //獲取跳轉頁面引數
    var tab = $('.nav-pills li');
    var con = $('.tab-content .tab-pane');
    console.log(con);
    for (var i = 0; i < con.length; i++) {
        var page = con[i]; //第幾個
        var selectCon = "#" + $(page).attr('id');
        if (hash == selectCon) {
            tab.siblings().removeClass('active'); //查找每個tab移除active
            con.siblings().removeClass('active');
            $(tab[i]).addClass('active');//查找每個tab增加active
            $(con[i]).addClass('active');
        }
    }
    //var news = $('#pills-news-tab');
    //var connew = $('#pills-news');
    //tab.siblings().removeClass('active');
    //con.siblings().removeClass('active');
    //tab.attr('aria-selected', 'false');
    //news.attr('aria-selected', 'true');
    //news.addClass('active show');
    //connew.addClass('active show');
    //console.log(news);

}

//$('.product-item-qty button').on('click', function () {
//    var $input = $(this).siblings('input');
//    if (isNaN($input.val())) {
//        alert('請輸入有效數字');
//        return;
//    }
//    var data = {
//        PlanId: $input.data('planid'),
//        SubmitLimit: $input.val()
//    }
//    $.ajax({
//        url: '/api/memberapi/UpdatePlan',
//        method: 'post',
//        data: data,
//        success: function (response) {
//            console.log(data);
//            if (response.IsSuccessful) {
//                alert('提交成功');
//            }
//            else {
//                alert('提交失敗');
//			}
//        },
//        error: function (err) {
//            console.log(err);
//        }
//    })
//});