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
    return sign + (j ? i.substr(0, j) + t : '') + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + t) + (c ? d + Math.abs(n - i).toFixed(c).slice(2) : '');
}



$(document).ready(function () {


    $.getJSON("http://localhost:8080/api/DetalleCampania/" + $("#IdCampania").val(), function (respoonse) {

        var dataCampania = respoonse;


        //$("#TotalPublicos").text(dataCampania.TotalPublicosContactados.toMoney());
        $("#totalAfiliadosPublicos").text(dataCampania.TotalPublicosContactados.toMoney());

        //$("#TotalPrivados").text(dataCampania.TotalPrivadosContactados.toMoney());
        $("#totalAfiliadosPrivados").text(dataCampania.TotalPrivadosContactados.toMoney());
        $("#TotalTrabajadores").text((dataCampania.TotalPrivadosContactados + dataCampania.TotalPublicosContactados).toMoney());

        $("#TotalPensionados").text(dataCampania.TotalPensionadosContactados.toMoney());
        $("#totalAfiliados").text(dataCampania.TotalAFiliadosContactados.toMoney());

        $("#totalAfiliadosCamp").text(dataCampania.TotalAFiliadosCampanados.toMoney());
        
        /*Efectivosdad*/
        var efc = (dataCampania.TotalAFiliadosContactados / dataCampania.TotalAFiliadosCampanados) * 100;
        $("#efectivbs").text(efc.toMoney() + "%");
        $("#efectivb").css("width", efc.toMoney() + "%");
        
        if (efc <= 45) {

            $("#efectivb").removeClass("progress-bar-success");
            $("#efectivb").addClass("progress-bar-danger");

            $("#efectivbs").removeClass("text-success");
            $("#efectivbs").addClass("text-danger");

            
        }
        else if (efc > 45 && efc <= 90)
        {
            $("#efectivb").removeClass("progress-bar-success");
            $("#efectivb").addClass("progress-bar-warning");

            $("#efectivbs").removeClass("text-success");
            $("#efectivbs").addClass("text-warning");
        }


        /*Marsd*/
        var pubprcsms = Math.round((dataCampania.TotalPublicosContactadosSms / dataCampania.TotalPublicosContactados) * 100);
        $("#PubPrcSms").text(dataCampania.TotalPublicosContactadosSms.toMoney() + " / " + pubprcsms + "%");
        $("#PubBarSms").css("width", pubprcsms.toString() + "%");
        
        var pubprcmail = Math.round((dataCampania.TotalPublicosContactadosEmail / dataCampania.TotalPublicosContactados) * 100);
        $("#PubPrcMail").text(dataCampania.TotalPublicosContactadosEmail.toMoney() + " / " + pubprcmail + "%");
        $("#PubBarMail").css("width", pubprcmail.toString() + "%");


        var pubprccall = Math.round((dataCampania.TotalPublicosContactadosCall / dataCampania.TotalPublicosContactados) * 100);
        $("#PubPrcCall").text(dataCampania.TotalPublicosContactadosCall.toMoney() + " / " + pubprccall + "%");
        $("#PubBarCall").css("width", pubprccall.toString() + "%");


        /*TotalPrivadosContactados*/
        var priprcsms = Math.round((dataCampania.TotalPrivadosContactadosSms / dataCampania.TotalPrivadosContactados) * 100);
        $("#PriPrcSms").text(dataCampania.TotalPrivadosContactadosSms.toMoney() + " / " + priprcsms + "%");
        $("#PriBarSms").css("width", priprcsms.toString() + "%");

        var priprcmail = Math.round((dataCampania.TotalPrivadosContactadosEmail / dataCampania.TotalPrivadosContactados) * 100);
        $("#PriPrcMail").text(dataCampania.TotalPrivadosContactadosEmail.toMoney() + " / " + priprcmail + "%");
        $("#PriBarMail").css("width", priprcmail.toString() + "%");


        var priprccall = Math.round((dataCampania.TotalPrivadosContactadosCall / dataCampania.TotalPrivadosContactados) * 100);
        $("#PriPrcCall").text(dataCampania.TotalPrivadosContactadosCall.toMoney() + " / " + priprccall + "%");
        $("#PriBarCall").css("width", priprccall.toString() + "%");


                    
        /* GRAFICOS*/
        var dataRt = [
           
            {
                "label": "Trabajadores",
                "value": (dataCampania.TotalTrabajadoresContactados),
                'color': '#f05050'
            },
            {
                "label": "Pensionados",
                "value": dataCampania.TotalPensionadosContactados,
                'color': '#5d9cec'
            }
        ];


        //Donut chart example
        nv.addGraph(function () {
            var chart = nv.models.pieChart()
                    .x(function (d) { return d.label })
                    .y(function (d) { return d.value })
                    .showLabels(true) //Display pie labels
                    .labelThreshold(.05) //Configure the minimum slice size for labels to show up
                    .labelType("percent")
                        //Configure what type of data to show in the label. Can be "key", "value" or "percent"
                    .donut(true) //Turn on Donut mode. Makes pie chart look tasty!
                    .donutRatio(0.30) //Configure how big you want the donut hole size to be.
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
                .datum(dataRt)
                .transition()
                .duration(350)
                .call(chart);


            d3.select("#chart24 svg")
                .datum(dataRt)
                .transition()
                .duration(350)
                .call(chart);

            return chart;
        });

    });




      

});