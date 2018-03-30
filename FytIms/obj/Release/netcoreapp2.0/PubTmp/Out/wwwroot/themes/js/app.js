$(function () {
    $(".btn-back").click(function () {
        history.go(-1);
    });
    $(".btn-open-close").click(function () {
        os.closeOpen();
    });
});

var os = {
    ajax: function (url, options, callFun) {
        var httpUrl = "/"; 
        $.ajax(httpUrl + url, {
            data: options,
            async: false,
            dataType: 'json', //服务器返回json格式数据
            type: 'post', //HTTP请求类型
            timeout: 50 * 1000, //超时时间设置为50秒；
            success: function (data) {
                callFun(data);
            },
            error: function (xhr, type, errorThrown) {
                if (type === 'timeout') {
                    alert('连接超时，请稍后重试！');
                } else if (type === 'error') {
                    alert('连接异常，请稍后重试！');
                }
            }
        });
    },
    Open: function (title, url, width, height, fun) {
        layer.open({
            type: 2,
            title: title,
            shadeClose: true,
            shade: 0.3,
            maxmin: false, //开启最大化最小化按钮
            area: [width, height],
            content: url,
            zIndex: "10",
            end: function () {
                if (fun) fun();
            }
        });
    },
    closeOpen: function () {
        layer.closeAll();      
    }, 
    toastr: function (type,msg) {
        //toastr.options = { positionClass: 'toast-top-center' };
        switch (type) {
            case "ok":
                toastr.success(msg);
                break;
            case "warning":
                toastr.warning(msg);
                break;
            case "error":
                toastr.error(msg);
                break;
        }
        
    }
}