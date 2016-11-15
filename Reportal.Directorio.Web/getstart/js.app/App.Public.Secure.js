$(function () {


    $("#bts").on("click", function () {

	    var encryptedPass = $.md5($('#Password').val()).toString().toUpperCase();
	    jQuery.ajax({
			url: "http://localhost:9090/api/Auth/authenticate",
			type: "post",
			beforeSend: function (xhr) {
			    xhr.setRequestHeader('Authorization', 'Basic ' + btoa($('#Username').val() + ':' + encryptedPass));
			},
			success: function (data, textStatus, request) {
			    var UserData = { 
			        'name': request.getResponseHeader("Uname"),
			        'token': request.getResponseHeader("Token")
			    };
			    console.log(UserData);
			    sessionStorage.setItem('userdata', JSON.stringify(UserData));

			    var ur = httpGet("ur");
			    if (typeof ur != "undefined")
			    {
			        location.href = "http://localhost" + ur;
			    }
			    else
			    {
			        location.href = "http://localhost/DirectorioReportal/Home";
			    }
			},
			error: function (request, textStatus, errorThrown) {
				console.log(errorThrown);
			}
		});
	});

});