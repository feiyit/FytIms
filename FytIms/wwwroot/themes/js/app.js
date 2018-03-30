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

Date.prototype.Format = function (fmt) {
    var o = {
        "M+": this.getMonth() + 1,                 //月份   
        "d+": this.getDate(),                    //日   
        "h+": this.getHours(),                   //小时   
        "m+": this.getMinutes(),                 //分   
        "s+": this.getSeconds(),                 //秒   
        "q+": Math.floor((this.getMonth() + 3) / 3), //季度   
        "S": this.getMilliseconds()             //毫秒   
    };
    if (/(y+)/.test(fmt))
        fmt = fmt.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length));
    for (var k in o)
        if (new RegExp("(" + k + ")").test(fmt))
            fmt = fmt.replace(RegExp.$1, (RegExp.$1.length === 1) ? (o[k]) : (("00" + o[k]).substr(("" + o[k]).length)));
    return fmt;
} 

function DataFormat(dt, fmt) {
    var ndt = new Date(dt);
    var o = {
        "M+": ndt.getMonth() + 1,                 //月份   
        "d+": ndt.getDate(),                    //日   
        "h+": ndt.getHours(),                   //小时   
        "m+": ndt.getMinutes(),                 //分   
        "s+": ndt.getSeconds(),                 //秒   
        "q+": Math.floor((ndt.getMonth() + 3) / 3), //季度   
        "S": ndt.getMilliseconds()             //毫秒   
    };
    if (/(y+)/.test(fmt))
        fmt = fmt.replace(RegExp.$1, (ndt.getFullYear() + "").substr(4 - RegExp.$1.length));
    for (var k in o)
        if (new RegExp("(" + k + ")").test(fmt))
            fmt = fmt.replace(RegExp.$1, (RegExp.$1.length === 1) ? (o[k]) : (("00" + o[k]).substr(("" + o[k]).length)));
    return fmt;
}