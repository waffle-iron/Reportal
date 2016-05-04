$(function () {
    var flagNuevoMenu = false;
    var slio;


    $('.dd-list').on('click', '.edit', function () {
        slio = $(this).closest('li');
        $("#txtTitulo").val(slio.data("titulo"));
        $("#txtUrl").val(slio.data("url"));
        $("#field-3").val(slio.data("icono"));
        flagNuevoMenu = false;
    });


    $('.dd-list').on('click', '.delete', function () {
        $(this).closest('li').toggle("slow", function () {
            //eliminar colapsable si no hay nada mas debajo
            var sli = $(this).closest('li').closest('ol').closest('li');
            var slo = $(this).closest('li').closest('ol');
            $(this).closest('li').remove();

            if (sli.length > 0 && slo.length > 0 && slo.children().length <= 0) {
                sli.removeClass('dd-collapsed');
                sli.children('[data-action]').remove();
                slo.remove();
            }
        });
    });

    /*$(".edit").on("click", function () {
        slio = $(this).closest('li');

        console.log(slio);

        $("#txtTitulo").val(slio.data("titulo"));
        $("#txtUrl").val(slio.data("url"));
        flagNuevoMenu = false;
    });

    $(".delete").on("click", function () {
        $(this).closest('li').toggle("slow", function () {
            //eliminar colapsable si no hay nada mas debajo
            var sli = $(this).closest('li').closest('ol').closest('li');
            var slo = $(this).closest('li').closest('ol');
            $(this).closest('li').remove();
            
            if (sli.length > 0 && slo.length > 0 && slo.children().length <= 0)
            {
                sli.removeClass('dd-collapsed');
                sli.children('[data-action]').remove();
                slo.remove();    
            }
        });
    });*/

    $('#con-close-modal').on('shown.bs.modal', function (e) {
        console.log("abrió modal....");
    })

    $("#btnGrabar").on("click", function () {
        var jsonenv = $('.dd').nestable('serialize');
        var jsonOfdt_c = JSON.stringify(jsonenv);

        $.ajax({
            type: 'POST',
            dataType: 'json',
            url: "/Reportal/Sadmin/Guardarmenu/",
            data: { jsonOfdt: jsonOfdt_c, opcion: "guardar" },
            success: function (response) {
                if (response.Result == "1") {
                    $.Notification.autoHideNotify('success', 'bottom right', response.Title, response.Message);
                }
                else
                {
                    $.Notification.autoHideNotify('error', 'bottom right', response.Title, response.Message);
                }

            },
            error: function (xhr, ajaxOptions, thrownError) {
                console && console.log("request failed");
            },

            processData: true,
            async: false
        });
    });


    

    $("#btnPublicar").on("click", function () {
        $.blockUI({ message: null });
        $.Notification.confirm('warning', 'bottom right', 'Confirmación', "¿Esta seguro que desea publicar los cambios?");
    });


    $("#btnAgregarMenu").on("click", function () {
        flagNuevoMenu = true;
    });


    $("#btnInsertaMenu").on("click", function () {

        if (flagNuevoMenu)
        {
            var htmnw = "<li class=\"dd-item dd3-item\" data-titulo=\"" + $("#txtTitulo").val() + "\" data-url=\"" + $("#txtUrl").val() + "\" data-icono=\"" + $("#field-3").val() + "\">" +
                                "<div class=\"dd-handle dd3-handle\"></div>" +
                            "<div class=\"dd3-content\">" + $("#txtTitulo").val() + "</div>" +
                            "<div class=\"dd3-buttons\">" +
                                "<div class=\"btn-group-chr btn-group-xs btn-group-solid btn-adentro\">" +
                                "<button class=\"btn purple edit\" type=\"button\" data-toggle=\"modal\" data-target=\"#con-close-modal\"> <i class=\"fa fa-edit\"></i> </button>" +
                                    "<button class=\"btn purple delete\" type=\"button\"> <i class=\"fa fa-remove\"></i> </button>" +
                            "</div>" +
                            "</div>" +
                            "</li>";

            var elm = $(".dd > ol.dd-list");
            $(htmnw).appendTo(elm);
           
            $.Notification.autoHideNotify('success', 'bottom right', 'Información', 'Nuevo Menu agregado con éxito!!');
            $('#con-close-modal').modal('toggle');

        }
        else
        {
            slio.data("titulo", $("#txtTitulo").val());
            slio.data("url", $("#txtUrl").val());
            slio.data("icono", $("#field-3").val());
            slio.find(".dd3-content").eq(0).html($("#txtTitulo").val());
            $.Notification.autoHideNotify('success', 'bottom right', 'Información', 'Nuevo Menu agregado con éxito!!');
            $('#con-close-modal').modal('toggle');
        }
    });


    //listen for click events from this style
    $(document).on('click', '.notifyjs-metro-base .no', function () {
        $.unblockUI();
        $(this).trigger('notify-hide');
    });
    $(document).on('click', '.notifyjs-metro-base .yes', function () {
        //hide notification

        var jsonenv = $('.dd').nestable('serialize');
        var jsonOfdt_c = JSON.stringify(jsonenv);

        $.ajax({
            type: 'POST',
            dataType: 'json',
            url: "/Reportal/Sadmin/Guardarmenu/",
            data: { jsonOfdt: jsonOfdt_c, opcion: "publicar" },
            success: function (response) {
                if (response.Result == "1") {
                    $.Notification.autoHideNotify('success', 'bottom right', response.Title, response.Message);
                }
                else {
                    $.Notification.autoHideNotify('error', 'bottom right', response.Title, response.Message);
                }

            },
            error: function (xhr, ajaxOptions, thrownError) {
                console && console.log("request failed");
            },

            processData: true,
            async: false
        });
        $.unblockUI();
        $(this).trigger('notify-hide');
    });


});
