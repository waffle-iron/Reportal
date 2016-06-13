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

            /*
            $("#CVAdulto").text(data.CVAdulto.toMoney() + "%");
            $("#CVAdultoMayor").text(data.CVAdultoMayor.toMoney() + "%");
            $("#CVDesarrollo").text(data.CVDesarrollo.toMoney() + "%");
            $("#CVJovenes").text(data.CVJovenes.toMoney() + "%");
            $("#CVMadurez").text(data.CVMadurez.toMoney() + "%");
            */
            

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
                    "label": "Jovenes",
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
            /*
            $("#NSEABC1").text(data.NS_Abc1.toMoney());
            $("#NSEC2").text(data.NS_C2.toMoney());
            $("#NSEC3").text(data.NS_C3.toMoney());
            $("#NSED").text(data.NS_D.toMoney());
            $("#NSEE").text(data.NS_E.toMoney());
            */


            var proNSE = [
                {
                    "label": "ABC1",
                    "value": data.NS_Abc1,
                    "color": '#5fbeaa'
                },
                {
                    "label": "C2",
                    "value": data.NS_C2,
                    "color": '#5d9cec'
                },
                {
                    "label": "C3",
                    "value": data.NS_C3,
                    "color": '#A9F5BC'
                },
                {
                    "label": "D",
                    "value": data.NS_D,
                    "color": '#A9F5A9'
                },
                {
                    "label": "E",
                    "value": data.NS_E,
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

            /*
            $("#Tramo_A").text(data.TA_Tramo_A.toMoney());
            $("#Tramo_B").text(data.TA_Tramo_B.toMoney());
            $("#Tramo_C").text(data.TA_Tramo_C.toMoney());
            $("#Tramo_D").text(data.TA_Tramo_D.toMoney());
            */


            var proAsignacionFamiliar = [
                {
                    "label": "Tramo A",
                    "value": data.TA_Tramo_A,
                    "color": '#5fbeaa'
                },
                {
                    "label": "Tramo B",
                    "value": data.TA_Tramo_B,
                    "color": '#5d9cec'
                },
                {
                    "label": "Tramo C",
                    "value": data.TA_Tramo_C,
                    "color": '#A9F5BC'
                },
                {
                    "label": "Tramo D",
                    "value": data.TA_Tramo_D,
                    "color": '#A9F5A9'
                }

            ];



            //Donut chart example
            nv.addGraph(function () {
                var chartAsignacionFamiliar = nv.models.pieChart()
                    .x(function (d) { return d.label })
                    .y(function (d) { return d.value })
                    .showLabels(true)     //Display pie labels
                    .labelThreshold(.05)  //Configure the minimum slice size for labels to show up
                    .labelType("percent") //Configure what type of data to show in the label. Can be "key", "value" or "percent"
                    .donut(true)          //Turn on Donut mode. Makes pie chart look tasty!
                    .donutRatio(0.30)     //Configure how big you want the donut hole size to be.

                ;

                d3.select("#grafTramoAF svg")
                    .datum(proAsignacionFamiliar)
                    .transition().duration(350)
                    .call(chartAsignacionFamiliar);

                return chartAsignacionFamiliar;
            });
            /*
            $("#18a30").text(data.TramoEtarioDe18a30Anios.toMoney());
            $("#31a45").text(data.TramoEtarioDe31a45Anios.toMoney());
            $("#46a60").text(data.TramoEtarioDe46a60Anios.toMoney());
            $("#61a75").text(data.TramoEtarioDe61a75Anios.toMoney());
            $("#75mas").text(data.TramoEtarioDe75aMasAnios.toMoney());
            */


            var proTramoEtarioAfiliado = [
                {
                    "label": "18 a 30",
                    "value": data.TramoEtarioDe18a30Anios,
                    "color": '#5fbeaa'
                },
                {
                    "label": "31 a 45",
                    "value": data.TramoEtarioDe31a45Anios,
                    "color": '#5d9cec'
                },
                {
                    "label": "46 a 60",
                    "value": data.TramoEtarioDe46a60Anios,
                    "color": '#A9F5BC'
                },
                {
                    "label": "61 a 75",
                    "value": data.TramoEtarioDe61a75Anios,
                    "color": '#A9F5A9'
                },
                {
                    "label": "75 a más",
                    "value": data.TramoEtarioDe75aMasAnios,
                    "color": '#0000FF'
                }

            ];

            //Donut chart example
            nv.addGraph(function () {
                var chartTramoEtarioAfiliado = nv.models.pieChart()
                    .x(function (d) { return d.label })
                    .y(function (d) { return d.value })
                    .showLabels(true)     //Display pie labels
                    .labelThreshold(.05)  //Configure the minimum slice size for labels to show up
                    .labelType("percent") //Configure what type of data to show in the label. Can be "key", "value" or "percent"
                    .donut(true)          //Turn on Donut mode. Makes pie chart look tasty!
                    .donutRatio(0.30)     //Configure how big you want the donut hole size to be.

                ;

                d3.select("#grafTramoEtarioA svg")
                    .datum(proTramoEtarioAfiliado)
                    .transition().duration(350)
                    .call(chartTramoEtarioAfiliado);

                return chartTramoEtarioAfiliado;
            });

            /*
            $("#Fonasa").text(data.RegimenSaludFonasa.toMoney());
            $("#Isapre").text(data.RegimenSaludIsapre.toMoney());
            $("#SinInfo").text(data.RegimenSaludSinInformacion.toMoney());
            */
          



            var proRegimenSalud = [
                {
                    "label": "Fonasa",
                    "value": data.RegimenSaludFonasa,
                    "color": '#5fbeaa'
                },
                {
                    "label": "Isapre",
                    "value": data.RegimenSaludIsapre,
                    "color": '#5d9cec'
                },
                {
                    "label": "Sin Información",
                    "value": data.RegimenSaludSinInformacion,
                    "color": '#A9F5BC'
                }
            ];

            //Donut chart example
            nv.addGraph(function () {
                var chartRegimenSalud = nv.models.pieChart()
                    .x(function (d) { return d.label })
                    .y(function (d) { return d.value })
                    .showLabels(true)     //Display pie labels
                    .labelThreshold(.05)  //Configure the minimum slice size for labels to show up
                    .labelType("percent") //Configure what type of data to show in the label. Can be "key", "value" or "percent"
                    .donut(true)          //Turn on Donut mode. Makes pie chart look tasty!
                    .donutRatio(0.30)     //Configure how big you want the donut hole size to be.

                ;

                d3.select("#grafRegimenSalud svg")
                    .datum(proRegimenSalud)
                    .transition().duration(350)
                    .call(chartRegimenSalud);

                return chartRegimenSalud;
            });

            var proGenero = [
               {
                   "label": "Masculino",
                   "value": data.SexoMasculino,
                   "color": '#5fbeaa'
               },
               {
                   "label": "Femenino",
                   "value": data.SexoFemenino,
                   "color": '#5d9cec'
               },
               {
                   "label": "Sin Información",
                   "value": data.SexoSinInfo,
                   "color": '#A9F5BC'
               }
            ];

            //Donut chart example
            nv.addGraph(function () {
                var chartGenero = nv.models.pieChart()
                    .x(function (d) { return d.label })
                    .y(function (d) { return d.value })
                    .showLabels(true)     //Display pie labels
                    .labelThreshold(.05)  //Configure the minimum slice size for labels to show up
                    .labelType("percent") //Configure what type of data to show in the label. Can be "key", "value" or "percent"
                    .donut(true)          //Turn on Donut mode. Makes pie chart look tasty!
                    .donutRatio(0.30)     //Configure how big you want the donut hole size to be.

                ;

                d3.select("#grafGenero svg")
                    .datum(proGenero)
                    .transition().duration(350)
                    .call(chartGenero);

                return chartGenero;
            });

            var proTenenciaCarga = [
              {
                  "label": "Si",
                  "value": data.TC_Si,
                  "color": '#5fbeaa'
              },
              {
                  "label": "No",
                  "value": data.TC_No,
                  "color": '#5d9cec'
              }
            ];

            //Donut chart example
            nv.addGraph(function () {
                var chartCarga = nv.models.pieChart()
                    .x(function (d) { return d.label })
                    .y(function (d) { return d.value })
                    .showLabels(true)     //Display pie labels
                    .labelThreshold(.05)  //Configure the minimum slice size for labels to show up
                    .labelType("percent") //Configure what type of data to show in the label. Can be "key", "value" or "percent"
                    .donut(true)          //Turn on Donut mode. Makes pie chart look tasty!
                    .donutRatio(0.30)     //Configure how big you want the donut hole size to be.

                ;

                d3.select("#grafCargas svg")
                    .datum(proTenenciaCarga)
                    .transition().duration(350)
                    .call(chartCarga);

                return chartCarga;
            });

            var proTipoCarga = [
             {
                 "label": "Hijos",
                 "value": data.TipoCargaHijo,
                 "color": '#5fbeaa'
             },
             {
                 "label": "Otros",
                 "value": data.TipoCargaOtros,
                 "color": '#5d9cec'
             }
            ];

            //Donut chart example
            nv.addGraph(function () {
                var chartTipoCarga = nv.models.pieChart()
                    .x(function (d) { return d.label })
                    .y(function (d) { return d.value })
                    .showLabels(true)     //Display pie labels
                    .labelThreshold(.05)  //Configure the minimum slice size for labels to show up
                    .labelType("percent") //Configure what type of data to show in the label. Can be "key", "value" or "percent"
                    .donut(true)          //Turn on Donut mode. Makes pie chart look tasty!
                    .donutRatio(0.30)     //Configure how big you want the donut hole size to be.

                ;

                d3.select("#grafTipoCarga svg")
                    .datum(proTipoCarga)
                    .transition().duration(350)
                    .call(chartTipoCarga);

                return chartTipoCarga;
            });
        });//ciere local

      

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