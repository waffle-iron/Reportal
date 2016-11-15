//class=""
function Recxve(arreglo, elmBase)
{
    var ContLi, Anch, Icon, Text, ContUl
    $.each(arreglo, function (i, o) {
        
        ContLi = $("<li>").attr("id-menu", o.IdRecurso);
        if (o.Tipo === "ENC" && o.IdRecursoPradre == 0)
        {
            ContLi.addClass("active-sub");
            Anch = $("<a>").attr("href", "#");
            Text = $("<span>").addClass("menu-title").html(o.Nombre);
            Icon = $("<i>").addClass(o.Icono);
            Anch.append(Icon).append(Text).append($("<i>").addClass("arrow"));
            ContLi.append(Anch);
            if (o.Hijos.length > 0)
            {
                ContUl = $("<ul>").addClass("collapse").attr("aria-expanded", "false").css("height","0px");
                ContLi.append(ContUl);
                Recxve(o.Hijos, ContUl);
            }
        }
        else if (o.Tipo === "ENC" && o.IdRecursoPradre > 0)
        {
            ContLi.addClass("active-sub");
            Anch = $("<a>").attr("href", "#").html(o.Nombre).append($("<i>").addClass("arrow"));
            ContLi.append(Anch);
            if (o.Hijos.length > 0) {
                ContUl = $("<ul>").addClass("collapse").attr("aria-expanded", "false").css("height", "0px");
                ContLi.append(ContUl);
                Recxve(o.Hijos, ContUl);
            }
        }
        else
        {
            Anch = $("<a>").attr("href", o.Url).html(o.Nombre);
            ContLi.append(Anch);
        }
        $(elmBase).append(ContLi);
    });
}


$(document).on("menu.ready", function () {
    $.SecPostJson("http://localhost:9090/api/Auth/draw-user-resources", function (menus) {
        console.log("Accediendo a mi funcion");
        Recxve(menus, $("#mainnav-menu"));
    });
});


$(document).ready(function () {
    $(document).trigger('menu.ready');
});
