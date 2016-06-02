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

    var InicializaGraficas = function () {

        $.getJSON("http://localhost:8080/api/DetalleEmpresa/" + $("#IdEmpresa").val(), function (data) {


            $("#CVAdulto").html(data.CVAdulto);
            $("#CVAdultoMayor").html(data.CVAdultoMayor);
            $("#CVDesarrollo").html(data.CVDesarrollo);
            $("#CVJovenes").html(data.CVJovenes);
            $("#CVMadurez").html(data.CVMadurez);

            var proCicloVida = [
                {
                    "label": "Adulto",
                    "value": data.CVAdulto,
                    "color": '#5fbeaa'
                },
                {
                    "label": "Adulto Mayor",
                    "value": data.CVAdultoMayor,
                    "color": '#5d9cec'
                },
                {
                    "label": "Desarrollo",
                    "value": data.CVDesarrollo,
                    "color": '#A9F5BC'
                },
                {
                    "label": "Joevenes",
                    "value": data.CVJovenes,
                    "color": '#A9F5A9'
                },
                {
                    "label": "Madurez",
                    "value": data.CVMadurez,
                    "color": '#0000FF'
                }

            ];



            //Donut chart example
            nv.addGraph(function () {
                var chartCicloVida = nv.models.pieChart()
                    .x(function (d) { return d.label })
                    .y(function (d) { return d.value })
                    .showLabels(true)     //Display pie labels
                    .labelThreshold(.05)  //Configure the minimum slice size for labels to show up
                    .labelType("percent") //Configure what type of data to show in the label. Can be "key", "value" or "percent"
                    .donut(true)          //Turn on Donut mode. Makes pie chart look tasty!
                    .donutRatio(0.30)     //Configure how big you want the donut hole size to be.

                ;

                d3.select("#grafCicloVida svg")
                    .datum(proCicloVida)
                    .transition().duration(350)
                    .call(chartCicloVida);

                return chartCicloVida;
            });

        });

        $.getJSON("http://localhost:8080/api/NSEEmpresa/" + $("#IdEmpresa").val(), function (data) {


            $("#NSEABC1").html(data.NSEABC1);
            $("#NSEC2").html(data.NSEC2);
            $("#NSEC3").html(data.NSEC3);
            $("#NSED").html(data.NSED);
            $("#NSEE").html(data.NSEE);

            var proNSE = [
                {
                    "label": "ABC1",
                    "value":data.NSEABC1,
                    "color": '#5fbeaa'
                },
                {
                    "label": "C2",
                    "value": data.NSEC2,
                    "color": '#5d9cec'
                },
                {
                    "label": "C3",
                    "value": data.NSEC3,
                    "color": '#A9F5BC'
                },
                {
                    "label": "D",
                    "value": data.NSED,
                    "color": '#A9F5A9'
                },
                {
                    "label": "E",
                    "value": data.NSEE,
                    "color": '#0000FF'
                }

            ];



            //Donut chart example
            nv.addGraph(function () {
                var chartNSE = nv.models.pieChart()
                    .x(function (d) { return d.label })
                    .y(function (d) { return d.value })
                    .showLabels(true)     //Display pie labels
                    .labelThreshold(.05)  //Configure the minimum slice size for labels to show up
                    .labelType("percent") //Configure what type of data to show in the label. Can be "key", "value" or "percent"
                    .donut(true)          //Turn on Donut mode. Makes pie chart look tasty!
                    .donutRatio(0.30)     //Configure how big you want the donut hole size to be.

                ;

                d3.select("#grafNSE svg")
                    .datum(proNSE)
                    .transition().duration(350)
                    .call(chartNSE);

                return chartNSE;
            });

        });

    }

    InicializaGraficas();
    $(".knob").knob();

    var resizeChart;

    $(window).resize(function (e) {
        clearTimeout(resizeChart);
        resizeChart = setTimeout(function () {
            InicializaGraficas();
        }, 300);
    });



});