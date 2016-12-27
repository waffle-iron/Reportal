$(function () {


    //Funciones para recordarme

    if (localStorage.getItem('rep_recordarme'))
    {
        var usa = JSON.parse(localStorage.getItem('rep_recordata'));
        $('#Password').val(usa.password);
        $('#Username').val(usa.username);
        $("#rememberme-form-checkbox").attr("checked", true);
    }



    $("#bts").on("click", function () {
        $(".alert").remove();
        $(this).attr("disabled", true);
        $("body").prepend($('<div class="alert alert-primary"><strong>Accediendo!</strong> Estamos verificando sus datos, por favor espere un momento.</div>'))

        if ($('#Password').val() === '' || $('#Username').val() === '') {
            $(".alert").remove();
            $("body").prepend($('<div class="alert alert-danger"><button class="close" data-dismiss="alert"><i class="pci-cross pci-circle"></i></button><strong>Oh no!</strong> Por favor ingrese sus datos de usuario e intente denuevo.</div>'))
            $(this).attr("disabled", false);
            return false;
        }

	    var encryptedPass = $.md5($('#Password').val()).toString().toUpperCase();
	    jQuery.ajax({
			url: getSecurityApiHost() + "api/Auth/authenticate",
			type: "post",
			beforeSend: function (xhr) {
			    xhr.setRequestHeader('Authorization', 'Basic ' + btoa($('#Username').val() + ':' + encryptedPass));
			},
			success: function (data, textStatus, request) {
			    var UserData = { 
			        'name': atob(request.getResponseHeader("Uname")),
			        'token': request.getResponseHeader("Token")
			    };
			    localStorage.setItem('userdata', JSON.stringify(UserData));

			    if ($("#rememberme-form-checkbox").is(":checked")) {
			        var recordata = {
			            'username': $('#Username').val(),
			            'password': $('#Password').val()
			        };
			        localStorage.setItem('rep_recordarme', $("#rememberme-form-checkbox").is(":checked"));
			        localStorage.setItem('rep_recordata', JSON.stringify(recordata));
			    } else {
			        localStorage.removeItem('rep_recordarme');
			        localStorage.removeItem('rep_recordata');
			    }
			   
			    var ur = httpGet("ur");
                console.log(ur)
			    if (typeof ur != "undefined")
			    {
			        location.href = (getRootAplicationHost() + ur).replace("//","/");
			    }
			    else
			    {
			        location.href = getAplicationHost() + request.getResponseHeader("Uindex");
			    }
			},
			error: function (request, textStatus, errorThrown) {
			    $(".alert").remove();
			    $("#bts").attr("disabled", false);
			    if (request.status === 401) {
			        $("body").prepend($('<div class="alert alert-danger"><button class="close" data-dismiss="alert"><i class="pci-cross pci-circle"></i></button><strong>Oh no!</strong> Datos de usuario incorrectos.</div>'))
			    } else {
			        $("body").prepend($('<div class="alert alert-danger"><button class="close" data-dismiss="alert"><i class="pci-cross pci-circle"></i></button><strong>Oh no!</strong> Ha ocurrido un error inesperado.</div>'))
			    }

			}
		});
	});

});