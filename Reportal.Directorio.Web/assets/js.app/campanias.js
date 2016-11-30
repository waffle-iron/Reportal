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


        $.getJSON("http://localhost:8080/api/Resumen", function (data) {


            var prcAF = Math.round((data.TotalAfiliadosContactables / data.TotalAfiliados) * 100);
            $(".knob").val(prcAF.toString());

            /*Totales*/
            $("#totalAfiliados").html(data.TotalAfiliados.toMoney());
            $("#AfiliadosContactables").html(data.TotalAfiliadosContactables.toMoney());

            
            /*Afiliados correo*/
            $("#TotalAfiliadosCorreo").html(data.TotalAfiliadosCorreo.toMoney());
            
            $("#AfiliadosCorreoTrabajadores").html((data.AfiliadosCorreoPrivados + data.AfiliadosCorreoPublicos).toMoney());
            //$("#AfiliadosCorreoPrivados").html(data.AfiliadosCorreoPrivados.toMoney());
            //$("#AfiliadosCorreoPublicos").html(data.AfiliadosCorreoPublicos.toMoney());
            $("#AfiliadosCorreoPensionados").html(data.AfiliadosCorreoPensionados.toMoney());


            var fechaAct = new Date(Date.parse(data.FechaActualizacion));
            $("#fechaActualizacion").html(fechaAct.toLocaleDateString());

            var proCorreos =  [

	              { 
	                  "label": "Trabajadores",
	                  "value": (data.AfiliadosCorreoPublicos + data.AfiliadosCorreoPrivados),
	                  'color': '#5fbeaa'
	              } , 
	              { 
	                  "label": "Pensionados",
	                  "value": data.AfiliadosCorreoPensionados,
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
                    .valueFormat(function (d) {
                        return d.toMoney();
                    })
                ;

                d3.select("#grafCorreos svg")
                    .datum(proCorreos)
                    .transition().duration(350)
                    .call(chartCorreos);

                return chartCorreos;
            });



            /*Afiliados SMS*/
            $("#TotalAfiliadosSMS").html(data.TotalAfiliadosSMS.toMoney());


            $("#AfiliadosSMSTrabajadores").html((data.AfiliadosSMSPrivados + data.AfiliadosSMSPublicos).toMoney());
            //$("#AfiliadosSMSPrivados").html(data.AfiliadosSMSPrivados.toMoney());
            //$("#AfiliadosSMSPublicos").html(data.AfiliadosSMSPublicos.toMoney());
            $("#AfiliadosSMSPensionados").html(data.AfiliadosSMSPensionados.toMoney());

            var prcSMS = [
	             
	              {
	                  "label": "Trabajadores",
	                  "value": (data.AfiliadosSMSPublicos + data.AfiliadosSMSPrivados),
	                  'color': '#5fbeaa'
	              },
	              {
	                  "label": "Pensionados",
	                  "value": data.AfiliadosSMSPensionados,
	                  'color': '#5d9cec'
	              }
            ];


            //Donut chart example
            nv.addGraph(function () {
                var chartSMS = nv.models.pieChart()
                    .x(function (d) { return d.label })
                    .y(function (d) { return d.value })
                    .showLabels(true)     //Display pie labels
                    .labelThreshold(.05)  //Configure the minimum slice size for labels to show up
                    .labelType("percent") //Configure what type of data to show in the label. Can be "key", "value" or "percent"
                    .donut(true)          //Turn on Donut mode. Makes pie chart look tasty!
                    .donutRatio(0.30)     //Configure how big you want the donut hole size to be.
                .valueFormat(function (d) {
                    return d.toMoney();
                })
                ;

                d3.select("#grafSMS svg")
                    .datum(prcSMS)
                    .transition().duration(350)
                    .call(chartSMS);

                return chartSMS;
            });

            //#3366cc,#dc3912,#ff9900,#109618,#66aa00,#dd4477,#0099c6,#990099 

            /*Afiliados Llamada*/
            $("#TotalAfiliadosCall").html(data.TotalAfiliadosCall.toMoney());
            
            $("#AfiliadosCallTrabajadores").html((data.AfiliadosCallPrivados + data.AfiliadosCallPublicos).toMoney());
            //$("#AfiliadosCallPrivados").html(data.AfiliadosCallPrivados.toMoney());
            //$("#AfiliadosCallPublicos").html(data.AfiliadosCallPublicos.toMoney());
            $("#AfiliadosCallPensionados").html(data.AfiliadosCallPensionados.toMoney());

            var prcCall = [
	              
	              {
	                  "label": "Trabajadores",
	                  "value": (data.AfiliadosCallPrivados + data.AfiliadosCallPublicos),
	                  'color': '#5fbeaa'
	              },
	              {
	                  "label": "Pensionados",
	                  "value": data.AfiliadosCallPensionados,
	                  'color': '#5d9cec'
	              }
            ];

            //Donut chart example
            nv.addGraph(function () {
                var chartCall = nv.models.pieChart()
                    .x(function (d) { return d.label })
                    .y(function (d) { return d.value })
                    .showLabels(true)     //Display pie labels
                    .labelThreshold(.05)  //Configure the minimum slice size for labels to show up
                    .labelType("percent") //Configure what type of data to show in the label. Can be "key", "value" or "percent"
                    .donut(true)          //Turn on Donut mode. Makes pie chart look tasty!
                    .donutRatio(0.30)     //Configure how big you want the donut hole size to be.
                .valueFormat(function (d) {
                    return d.toMoney();
                })
                ;

                d3.select("#grafCall svg")
                    .datum(prcCall)
                    .transition().duration(350)
                    .call(chartCall);

                return chartCall;
            });

        });


        $.getJSON("http://localhost:8080/api/TendenciaResumen", function (data) {

                //Grafico de barras
                var BarChart = {
                    labels: ["Enero - 2016", "Febrero - 2016"],
                    datasets: [
                        {
                            fillColor: 'rgba(95, 190, 170, 0.7)',
                            strokeColor: 'rgba(95, 190, 170, 1)',
                            highlightFill: 'rgba(95, 190, 170, 1)',
                            highlightStroke: 'rgba(95, 190, 170, 0.9)',
                            data: [75, 100]
                        }
                    ]
                }


                var selector = $("#bar");
                var ctx = selector.get(0).getContext("2d");
                var container = $(selector).parent();
                var ww = selector.attr('width', $(container).width());
                var sal = new Chart(ctx).Bar(data);
            });

        $.getJSON("http://localhost:8080/api/D_CredPptoMensual/", function (data) {
            var prcAF = Math.round(data.Enero_Neto+data.febrero_neto);
            $(".knob").val(prcAF.toString());
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