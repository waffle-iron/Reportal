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

        $.getJSON("http://localhost:8080/api/CicloVidaEmpresa", function (data) {

            var prcAF = Math.round((data.TotalAfiliadosContactables / data.TotalAfiliados) * 100);
            $(".knob").val(prcAF.toString());

            /*Totales*/
            //$("#totalAfiliados").html(data.TotalAfiliados.toMoney());
            //$("#AfiliadosContactables").html(data.TotalAfiliadosContactables.toMoney());


            /*Afiliados correo*/
            //$("#TotalAfiliadosCorreo").html(data.TotalAfiliadosCorreo.toMoney());

            $("#CVAdultoMayor").html(data.CVAdultoMayor.toMoney());
            $("#CVAdultos").html(data.CVAdultos.toMoney());
            $("#CVDesarrollo").html(data.CVDesarrollo.toMoney());
            $("#CVJovenes").html(data.CVJovenes.toMoney()); 
            $("#CVMadurez").html(data.CVMadurez.toMoney());

            var proCorreos = [
	              {
	                  "label": "Adulto Mayor",
	                  "value": Math.round(data.CVAdultoMayor).toMoney(),
	                  "color": "#5fbeaa"
	              },
	              {
	                  "label": "Adultos",
	                  "value": Math.round(data.CVAdultoMayor).toMoney(),
	                  'color': '#f05050'
	              },
	              {
	                  "label": "Desarrollo",
	                  "value": Math.round((data.AfiliadosCorreoPensionados / data.TotalAfiliadosCorreo) * 100).toMoney(),
	                  'color': '#5d9cec'
	              },
                  {
	                  "label": "Jovenes",
                      "value": Math.round((data.AfiliadosCorreoPensionados / data.TotalAfiliadosCorreo) * 100).toMoney(),
                      'color': '#5d9cec'
                  },
                   {
                       "label": "Madurez",
                       "value": Math.round((data.AfiliadosCorreoPensionados / data.TotalAfiliadosCorreo) * 100).toMoney(),
                       'color': '#5d9cec'
                   }


            ];

            //Donut chart example
            nv.addGraph(function () {
                var chartCorreos = nv.models.pieChart()
                    .x(function (d) { return d.label })
                    .y(function (d) { return d.value })
                    .showLabels(true)     //Display pie labels
                    .labelThreshold(.05)  //Configure the minimum slice size for labels to show up
                    .labelType("percent") //Configure what type of data to show in the label. Can be "key", "value" or "percent"
                    .donut(true)          //Turn on Donut mode. Makes pie chart look tasty!
                    .donutRatio(0.30)     //Configure how big you want the donut hole size to be.

                ;

                d3.select("#grafCicloVida svg")
                    .datum(proCorreos)
                    .transition().duration(350)
                    .call(chartCorreos);

                return chartCorreos;
            });

    });
    }

});