Number.prototype.toMoney = function (decimals, decimal_sep, thousands_sep) {
    var n = this,
    c = isNaN(decimals) ? 0 : Math.abs(decimals), //if decimal is zero we must take it, it means user does not want to show any decimal
    d = decimal_sep || ',', //if no decimal separator is passed we use the dot as default decimal separator (we MUST use a decimal separator)
    
    /*
    according to [http://stackoverflow.com/questions/411352/how-best-to-determine-if-an-argument-is-not-sent-to-the-javascript-function]
    the fastest way to check for not defined parameter is to use typeof value === 'undefined' 
    rather than doing value === undefined.
    */
    t = (typeof thousands_sep === 'undefined') ? '.' : thousands_sep, //if you don't want to use a thousands separator you can pass empty string as thousands_sep value

    sign = (n < 0) ? '-' : '',

    //extracting the absolute value of the integer part of the number and converting to string
    i = parseInt(n = Math.abs(n).toFixed(c)) + '',

    j = ((j = i.length) > 3) ? j % 3 : 0;
    var retorno = sign + (j ? i.substr(0, j) + t : '') + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + t) + (c ? d + Math.abs(n - i).toFixed(c).slice(2) : '');
    
    return retorno;
}

Number.prototype.noNAN = function () {
    return isNaN(this) ? 0 : this;
}

$(document).ready(function () {


    $.getJSON("http://localhost:8080/api/DetalleCampania/" + $("#IdCampania").val(), function (respoonse) {

        var dataCampania = respoonse;
        
        if (dataCampania.TotalPensionadosCampanados == 0)
        {
            $("#ResumenFinPensionados").css("display", "none");
        }

        if (dataCampania.TotalTrabajadoresCampanados == 0)
        {
            $("#ResumenFinTrabajadores").css("display", "none");
        }


        //$("#TotalPublicos").text(dataCampania.TotalPublicosContactados.toMoney());
        $("#totalAfiliadosPublicos").text(dataCampania.TotalPublicosContactados.toMoney());

        //$("#TotalPrivados").text(dataCampania.TotalPrivadosContactados.toMoney());
        $("#totalAfiliadosPrivados").text(dataCampania.TotalPrivadosContactados.toMoney());
        $("#TotalTrabajadores").text(dataCampania.TotalTrabajadoresCampanados.toMoney());

        $("#TotalPensionados").text(dataCampania.TotalPensionadosCampanados.toMoney());
        $("#totalAfiliados").text(dataCampania.TotalAFiliadosContactados.toMoney());

        $("#totalAfiliadosCamp").text(dataCampania.TotalAFiliadosCampanados.toMoney());

        $("#totalComunicacionesExitosas").text(dataCampania.TotalComunicacionesExitosas.toMoney());
        

        $("#totalComunicacionesExitosas").text(dataCampania.TotalComunicacionesExitosas.toMoney());

        $("#totalCoclocaciones").text(dataCampania.TotalVentas.toMoney());
        

        /*Tabla*/
        $("#p_email-totl").text(dataCampania.TotalPensionadosCampanadosEmail.toMoney());
        $("#p_email-ncon").text(dataCampania.TotalPensionadosContactadosEmail.toMoney());
        $("#p_email-pcon").text(((dataCampania.TotalPensionadosContactadosEmail / dataCampania.TotalPensionadosCampanadosEmail) * 100).noNAN().toMoney(2) + "%");
        $("#p_email-nexi").text(dataCampania.TotalPensionadosExitosasEmail.toMoney());
        $("#p_email-pexi").text(((dataCampania.TotalPensionadosExitosasEmail / dataCampania.TotalPensionadosCampanadosEmail) * 100).noNAN().toMoney(2) + "%");

        $("#p_sms-totl").text(dataCampania.TotalPensionadosCampanadosSms.toMoney());
        $("#p_sms-ncon").text(dataCampania.TotalPensionadosContactadosSms.toMoney());
        $("#p_sms-pcon").text(((dataCampania.TotalPensionadosContactadosSms / dataCampania.TotalPensionadosCampanadosSms) * 100).noNAN().toMoney(2) + "%");

        $("#p_sms-nexi").text(dataCampania.TotalPensionadosExitosasSms.toMoney());
        $("#p_sms-pexi").text(((dataCampania.TotalPensionadosExitosasSms / dataCampania.TotalPensionadosCampanadosSms) * 100).noNAN().toMoney(2) + "%");

        $("#p_call-totl").text(dataCampania.TotalPensionadosCampanadosCall.toMoney());
        $("#p_call-ncon").text(dataCampania.TotalPensionadosContactadosCall.toMoney());
        $("#p_call-pcon").text(((dataCampania.TotalPensionadosContactadosCall / dataCampania.TotalPensionadosCampanadosCall) * 100).noNAN().toMoney(2));
        $("#p_call-nexi").text(dataCampania.TotalPensionadosExitosasCall.toMoney());
        $("#p_call-pexi").text(((dataCampania.TotalPensionadosExitosasCall / dataCampania.TotalPensionadosCampanadosCall) * 100).noNAN().toMoney(2) + "%");


        $("#t_email-totl").text(dataCampania.TotalTrabajadoresCampanadosEmail.toMoney());
        $("#t_email-ncon").text(dataCampania.TotalTrabajadoresContactadosEmail.toMoney());
        $("#t_email-pcon").text(((dataCampania.TotalTrabajadoresContactadosEmail / dataCampania.TotalTrabajadoresCampanadosEmail) * 100).noNAN().toMoney(2) + "%");
        $("#t_email-nexi").text(dataCampania.TotalTrabajadoresExitosasEmail.toMoney());
        $("#t_email-pexi").text(((dataCampania.TotalTrabajadoresExitosasEmail / dataCampania.TotalTrabajadoresCampanadosEmail) * 100).noNAN().toMoney(2) + "%");

        $("#t_sms-totl").text(dataCampania.TotalTrabajadoresCampanadosSms.toMoney());
        $("#t_sms-ncon").text(dataCampania.TotalTrabajadoresContactadosSms.toMoney());
        $("#t_sms-pcon").text(((dataCampania.TotalTrabajadoresContactadosSms / dataCampania.TotalTrabajadoresCampanadosSms)*100).noNAN().toMoney(2) + "%");
        $("#t_sms-nexi").text(dataCampania.TotalTrabajadoresExitosasSms.toMoney());
        $("#t_sms-pexi").text(((dataCampania.TotalTrabajadoresExitosasSms / dataCampania.TotalTrabajadoresCampanadosSms) * 100).noNAN().toMoney(2) + "%");

        $("#t_call-totl").text(dataCampania.TotalTrabajadoresCampanadosCall.toMoney());
        $("#t_call-ncon").text(dataCampania.TotalTrabajadoresContactadosCall.toMoney());
        $("#t_call-pcon").text((dataCampania.TotalTrabajadoresContactadosCall / dataCampania.TotalTrabajadoresCampanadosCall).noNAN().toMoney());
        $("#t_call-nexi").text(dataCampania.TotalTrabajadoresExitosasCall.toMoney());
        $("#t_call-pexi").text((dataCampania.TotalTrabajadoresExitosasCall / dataCampania.TotalTrabajadoresCampanadosCall).noNAN().toMoney());
        
        $("#p_email-ncompra").text((dataCampania.TotalVentasPensionadosEmail).toMoney());
        $("#p_email-pcompra").text(((dataCampania.TotalVentasPensionadosEmail / dataCampania.TotalPensionadosCampanadosEmail) * 100).noNAN().toMoney(2) + "%");
        
        $("#p_sms-ncompra").text((dataCampania.TotalVentasPensionadosSMS).toMoney());
        $("#p_sms-pcompra").text(((dataCampania.TotalVentasPensionadosSMS / dataCampania.TotalPensionadosCampanadosSms) * 100).noNAN().toMoney(2) + "%");

        $("#p_call-ncompra").text((dataCampania.TotalVentasPensionadosCall).toMoney());
        $("#p_call-pcompra").text(((dataCampania.TotalVentasPensionadosCall / dataCampania.TotalPensionadosCampanadosCall) * 100).noNAN().toMoney(2) + "%");

        $("#t_email-ncompra").text((dataCampania.TotalVentasTrabajadoresEmail).toMoney());
        $("#t_email-pcompra").text(((dataCampania.TotalVentasTrabajadoresEmail / dataCampania.TotalTrabajadoresCampanadosEmail) * 100).noNAN().toMoney(2) + "%");

        $("#t_sms-ncompra").text((dataCampania.TotalVentasTrabajadoresSMS).toMoney());
        $("#t_sms-pcompra").text(((dataCampania.TotalVentasTrabajadoresSMS / dataCampania.TotalTrabajadoresCampanadosSms) * 100).noNAN().toMoney(2) + "%");

        $("#t_call-ncompra").text((dataCampania.TotalVentasTrabajadoreaCall).toMoney());
        $("#t_call-pcompra").text(((dataCampania.TotalVentasTrabajadoreaCall / dataCampania.TotalTrabajadoresCampanadosCall) * 100).noNAN().toMoney(2) + "%");


        /*Tasa Contacto*/
        var efc = (dataCampania.TotalAFiliadosContactados / dataCampania.TotalAFiliadosCampanados) * 100;
        $("#tasaContacto_prc").text(efc.toMoney(2) + "%");
        $("#tasaContacto").css("width", efc.toMoney(2,'.',',') + "%");
        
        if (efc <= 45)
        {

            $("#tasaContacto").removeClass("progress-bar-success");
            $("#tasaContacto").addClass("progress-bar-danger");

            $("#tasaContacto_prc").removeClass("text-success");
            $("#tasaContacto_prc").addClass("text-danger");

        }
        else if (efc > 45 && efc <= 90)
        {
            $("#tasaContacto").removeClass("progress-bar-success");
            $("#tasaContacto").addClass("progress-bar-warning");

            $("#tasaContacto_prc").removeClass("text-success");
            $("#tasaContacto_prc").addClass("text-warning");
        }

        /*Tasa Exito*/
        var exi = (dataCampania.TotalComunicacionesExitosas / dataCampania.TotalAFiliadosCampanados) * 100;

        if (isNaN(exi))
        {
            exi = 0;
        }

        $("#tasaExito_prc").text(exi.toMoney(2) + "%");
        $("#tasaExito").css("width", exi.toMoney(2,'.',',') + "%");

        if (exi <= 45)
        {

            $("#tasaExito").removeClass("progress-bar-success");
            $("#tasaExito").addClass("progress-bar-danger");

            $("#tasaExito_prc").removeClass("text-success");
            $("#tasaExito_prc").addClass("text-danger");


        }
        else if (exi > 45 && exi <= 90)
        {
            $("#tasaExito").removeClass("progress-bar-success");
            $("#tasaExito").addClass("progress-bar-warning");

            $("#tasaExito_prc").removeClass("text-success");
            $("#tasaExito_prc").addClass("text-warning");
        }


        /*Tasa Venta*/
        var vent = (dataCampania.TotalVentas / dataCampania.TotalAFiliadosCampanados) * 100;

        if (isNaN(vent)) {
            vent = 0;
        }

        $("#tasaCompra_prc").text(vent.toMoney(2) + "%");
        $("#tasaCompra").css("width", vent.toMoney(2, '.', ',') + "%");
        
        if (vent <= 45) {

            $("#tasaCompra").removeClass("progress-bar-success");
            $("#tasaCompra").addClass("progress-bar-danger");

            $("#tasaCompra_prc").removeClass("text-success");
            $("#tasaCompra_prc").addClass("text-danger");


        }
        else if (vent > 45 && vent <= 90) {
            $("#tasaCompra").removeClass("progress-bar-success");
            $("#tasaCompra").addClass("progress-bar-warning");

            $("#tasaCompra_prc").removeClass("text-success");
            $("#tasaCompra_prc").addClass("text-warning");
        }

        /*Marsd*/
        var pubprcsms = Math.round(((dataCampania.TotalTrabajadoresContactadosSms + dataCampania.TotalPensionadosContactadosSms) / (dataCampania.TotalPensionadosContactados + dataCampania.TotalTrabajadoresContactados)) * 100);
        $("#PubPrcSms").text((dataCampania.TotalTrabajadoresContactadosSms + dataCampania.TotalPensionadosContactadosSms).toMoney() + " / " + pubprcsms + "%");
        $("#PubBarSms").css("width", pubprcsms.toString() + "%");
        
        var pubprcmail = Math.round(((dataCampania.TotalTrabajadoresContactadosEmail + dataCampania.TotalPensionadosContactadosEmail) / (dataCampania.TotalPensionadosContactados + dataCampania.TotalTrabajadoresContactados)) * 100);
        $("#PubPrcMail").text((dataCampania.TotalTrabajadoresContactadosEmail + dataCampania.TotalPensionadosContactadosEmail).toMoney() + " / " + pubprcmail + "%");
        $("#PubBarMail").css("width", pubprcmail.toString() + "%");


        var pubprccall = Math.round(((dataCampania.TotalTrabajadoresContactadosCall + dataCampania.TotalPensionadosContactadosCall) / (dataCampania.TotalPensionadosContactados + dataCampania.TotalTrabajadoresContactados)) * 100);
        $("#PubPrcCall").text((dataCampania.TotalTrabajadoresContactadosCall + dataCampania.TotalPensionadosContactadosCall).toMoney() + " / " + pubprccall + "%");
        $("#PubBarCall").css("width", pubprccall.toString() + "%");


        /*TotalPrivadosContactados*/
        /*var priprcsms = Math.round((dataCampania.TotalPrivadosContactadosSms / dataCampania.TotalPrivadosContactados) * 100);
        $("#PriPrcSms").text(dataCampania.TotalPrivadosContactadosSms.toMoney() + " / " + priprcsms + "%");
        $("#PriBarSms").css("width", priprcsms.toString() + "%");

        var priprcmail = Math.round((dataCampania.TotalPrivadosContactadosEmail / dataCampania.TotalPrivadosContactados) * 100);
        $("#PriPrcMail").text(dataCampania.TotalPrivadosContactadosEmail.toMoney() + " / " + priprcmail + "%");
        $("#PriBarMail").css("width", priprcmail.toString() + "%");


        var priprccall = Math.round((dataCampania.TotalPrivadosContactadosCall / dataCampania.TotalPrivadosContactados) * 100);
        $("#PriPrcCall").text(dataCampania.TotalPrivadosContactadosCall.toMoney() + " / " + priprccall + "%");
        $("#PriBarCall").css("width", priprccall.toString() + "%");*/


                    
        /* GRAFICOS*/
        var dataRt = [
           
            {
                "label": "Trabajadores",
                "value": dataCampania.TotalTrabajadoresCampanados,
                'color': '#5fbeaa'
            },
            {
                "label": "Pensionados",
                "value": dataCampania.TotalPensionadosCampanados,
                'color': '#5d9cec'
            }
        ];


        var dataRt2 = [

            {
                "label": "Trabajadores",
                "value": dataCampania.TotalTrabajadoresContactados,
                'color': '#5fbeaa'
            },
            {
                "label": "Pensionados",
                "value": dataCampania.TotalPensionadosContactados,
                'color': '#5d9cec'
            }
        ];


        var dataRt3 = [

            {
                "label": "Trabajadores",
                "value": dataCampania.TotalTrabajadoresExitosas,
                'color': '#5fbeaa'
            },
            {
                "label": "Pensionados",
                "value": dataCampania.TotalPensionadosExitosas,
                'color': '#5d9cec'
            }
        ];



        //Donut chart example
        nv.addGraph(function () {
            var chart = nv.models.pieChart()
                    .x(function (d) { return d.label })
                    .y(function (d) { return d.value })
                    .showLabels(true) 
                    .labelThreshold(.05) 
                    .labelType("percent")
                    .donut(true)
                    .donutRatio(0.30)
                    .valueFormat(function(d) {
                        return d.toMoney();
                    })
            ;

            d3.select("#chart2 svg")
                .datum(dataRt)
                .transition()
                .duration(350)
                .call(chart);


            d3.select("#chart23 svg")
                .datum(dataRt2)
                .transition()
                .duration(350)
                .call(chart);


            d3.select("#chart24 svg")
                .datum(dataRt3)
                .transition()
                .duration(350)
                .call(chart);

            return chart;
        });


        /*Morris stackedBar*/

        var $campContactados = [
            { y: 'Trab.', alcance: dataCampania.TotalTrabajadoresContactados, total: dataCampania.TotalTrabajadoresCampanados },
            { y: 'Pens.', alcance: dataCampania.TotalPensionadosContactados, total: dataCampania.TotalPensionadosCampanados }
        ];

        var $campExitosos = [
           { y: 'Trab.', alcance: dataCampania.TotalTrabajadoresExitosas, total: dataCampania.TotalTrabajadoresCampanados },
           { y: 'Pens.', alcance: dataCampania.TotalPensionadosExitosas, total: dataCampania.TotalPensionadosCampanados }
        ];

        console.log($campExitosos);


        var $campVentas = [
           { y: 'Trab.', alcance: dataCampania.TotalVentasTrabajadores, total: dataCampania.TotalTrabajadoresCampanados },
           { y: 'Pens.', alcance: dataCampania.TotalVentasPensionados, total: dataCampania.TotalPensionadosCampanados }
        ];


        Morris.Bar({
            element: "contactados-tipo-afiliado",
            data: $campContactados,
            xkey: 'y',
            ykeys: ['alcance', 'total'],
            stacked: true,
            labels: ['Contactados', 'Campañados'],
            hideHover: 'auto',
            resize: true, //defaulted to true
            gridLineColor: '#eeeeee',
            barColors: ['#5d9cec', '#dcdcdc'],
            hoverCallback: function (index, options, content, row) {

                var Titulo = (row.y == "Trab.") ? "Trabajadores" : "Pensionados";

                return "<div class='morris-hover-row-label'>" + Titulo + "</div><div class='morris-hover-point' style='color: #5d9cec'>" +
                            "Contactados: " + row.alcance.toMoney() +
                            "</div><div class='morris-hover-point' style='color: #dcdcdc'>" +
                            "Campañados: " + row.total.toMoney() + " </div>";

            }
        });


        Morris.Bar({
            element: "exitosos-tipo-afiliado",
            data: $campExitosos,
            xkey: 'y',
            ykeys: ['alcance', 'total'],
            //stacked: true,
            labels: ['Exitosos', 'Campañados'],
            hideHover: 'auto',
            resize: true, //defaulted to true
            gridLineColor: '#eeeeee',
            barColors: ['#5d9cec', '#dcdcdc'],
            hoverCallback: function (index, options, content, row) {
                var Titulo = (row.y == "Trab.") ? "Trabajadores" : "Pensionados";
                return "<div class='morris-hover-row-label'>" + Titulo + "</div><div class='morris-hover-point' style='color: #5d9cec'>" +
                            "Contactados: " + row.alcance.toMoney() +
                            "</div><div class='morris-hover-point' style='color: #dcdcdc'>" +
                            "Campañados: " + row.total.toMoney() + " </div>";

            }
        });


        Morris.Bar({
            element: "compras-tipo-afiliado",
            data: $campVentas,
            xkey: 'y',
            ykeys: ['alcance', 'total'],
            //stacked: true,
            labels: ['Exitosos', 'Campañados'],
            hideHover: 'auto',
            resize: true, //defaulted to true
            gridLineColor: '#eeeeee',
            barColors: ['#5d9cec', '#dcdcdc'],
            hoverCallback: function (index, options, content, row) {
                var Titulo = (row.y == "Trab.") ? "Trabajadores" : "Pensionados";
                return "<div class='morris-hover-row-label'>" + Titulo + "</div><div class='morris-hover-point' style='color: #5d9cec'>" +
                            "Contactados: " + row.alcance.toMoney() +
                            "</div><div class='morris-hover-point' style='color: #dcdcdc'>" +
                            "Campañados: " + row.total.toMoney() + " </div>";

            }
        });

    });






});