﻿(function (window, undefined) {

    var ud = {}
    if (JSON.parse(localStorage.getItem('userdata')) != null) {
        ud = JSON.parse(localStorage.getItem('userdata'));
    }

jQuery.each(["SecGetJSON", "SecPostJSON", "SecGetBLOB"], function (i, method) {
    jQuery[method] = function (url, data, callback) {
        var typdat = 'json';
        var metodo_peticion = 'get';
        if (method === 'SecPostJSON')
        {
            metodo_peticion = 'post'
        }

        if (method === 'SecGetBLOB') {
            typdat = 'blob'
        }

        if (jQuery.isFunction(data)) {
            callback = data;
            data = undefined;
        }

        return jQuery.ajax({
            url: url,
            type: metodo_peticion,
            headers: {
                "Token": ud.token,
                "TokenExpiry": "900",
                "Access-Control-Expose-Headers": "Token,TokenExpiry"
            },
            dataType: typdat,
            data: data,
            success: callback
        });
    };
});

$("body").css("display","none");
//Validar los permisos de url
jQuery.ajax({
    url: getSecurityApiHost() + "api/Auth/permission",
    type: "post",
    headers: {
        "Token": ud.token,
        "TokenExpiry": "900",
        "Access-Control-Expose-Headers": "Token,TokenExpiry"
    },
    statusCode: {
        401: function (a) {
            location.href = getAplicationHost() + "Acceso?ru=" + location.pathname
        },
        200: function () {
            $("body").css("display", "block");
        }
    }
});

})(window);
