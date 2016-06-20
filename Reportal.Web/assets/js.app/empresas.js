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
            $("#empresaRut").text(data.Id);
            $("#empresaSegmento").text(data.empresaSegmento);
            $("#empresaDV").text(data.empresaDV)
            $("#empresaNSE").text(data.empresaNSE);
            $("#empresaNombre").text(data.empresaNombre);
            $("#empresaNumTrabajadores").text(data.empresaCantidadTrabajadores);
            $("#empresaTipo").text(data.tipoEmpresa);
            $("#empresaTrabajadorMail").text(data.empresaTrabajadorMail);
            $("#empresaSectorEconomico").text(data.empresaSectorEconomico);
            $("#empresaTrabajadorCelular").text(data.empresaTrabajadorCelular);
            $("#clasificacionComercial").text(data.empresaclasificacionComercial);
            $("#clasificacionRiesgo").text(data.empresaclasificacionRiesgo);
            $("#empresaTrabajadorMailCelular").text(data.empresaTrabajadorMailCelular);
            $("#empresaTrabajadorTarjeta").text(data.empresaTrabajadorTarjDigital);
            $("#clasificacionCredito").text(data.empresaSegmentoCredito);
            $("#empresaTrabajadorRentaPromedio").text(data.empresaPromedioRenta.toMoney());
            $("#antiguedadempresa").text(data.empresaAniosAfiliado); 
            $("#empresatrabajadorpromedio").text(data.empresaPromedioEdad);
            $("#perteneceholding").text(data.empresaHolding);

            var proCicloVida = [
                {
                    "label": "Adulto",
                    "value": Math.round(data.CVAdulto * data.empresaCantidadTrabajadores),
                    "color": '#5fbeaa'
                },
                {
                    "label": "Adulto Mayor",
                    "value": Math.round(data.CVAdultoMayor * data.empresaCantidadTrabajadores),
                    "color": '#5d9cec'
                },
                {
                    "label": "Desarrollo",
                    "value": Math.round(data.CVDesarrollo * data.empresaCantidadTrabajadores),
                    "color": '#A9F5BC'
                },
                {
                    "label": "Jovenes",
                    "value": Math.round(data.CVJovenes * data.empresaCantidadTrabajadores),
                    "color": '#A9F5A9'
                },
                {
                    "label": "Madurez",
                    "value": Math.round(data.CVMadurez * data.empresaCantidadTrabajadores),
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
         


            var proNSE = [
                {
                    "label": "ABC1",
                    "value": Math.round(data.NS_Abc1 * data.empresaCantidadTrabajadores),
                    "color": '#5fbeaa'
                },
                {
                    "label": "C2",
                    "value": Math.round(data.NS_C2 * data.empresaCantidadTrabajadores),
                    "color": '#5d9cec'
                },
                {
                    "label": "C3",
                    "value": Math.round(data.NS_C3 * data.empresaCantidadTrabajadores),
                    "color": '#A9F5BC'
                },
                {
                    "label": "D",
                    "value": Math.round(data.NS_D * data.empresaCantidadTrabajadores),
                    "color": '#A9F5A9'
                },
                {
                    "label": "E",
                    "value": Math.round(data.NS_E * data.empresaCantidadTrabajadores),
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

         

            var proAsignacionFamiliar = [
                {
                    "label": "Tramo A",
                    "value": Math.round(data.TA_Tramo_A * data.empresaCantidadTrabajadores),
                    "color": '#5fbeaa'
                },
                {
                    "label": "Tramo B",
                    "value": Math.round(data.TA_Tramo_B * data.empresaCantidadTrabajadores),
                    "color": '#5d9cec'
                },
                {
                    "label": "Tramo C",
                    "value": Math.round(data.TA_Tramo_C * data.empresaCantidadTrabajadores),
                    "color": '#A9F5BC'
                },
                {
                    "label": "Tramo D",
                    "value": Math.round(data.TA_Tramo_D * data.empresaCantidadTrabajadores),
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
                    "value": Math.round(data.TramoEtarioDe18a30Anios * data.empresaCantidadTrabajadores),
                    "color": '#5fbeaa'
                },
                {
                    "label": "31 a 45",
                    "value": Math.round(data.TramoEtarioDe31a45Anios * data.empresaCantidadTrabajadores),
                    "color": '#5d9cec'
                },
                {
                    "label": "46 a 60",
                    "value": Math.round(data.TramoEtarioDe46a60Anios * data.empresaCantidadTrabajadores),
                    "color": '#A9F5BC'
                },
                {
                    "label": "61 a 75",
                    "value": Math.round(data.TramoEtarioDe61a75Anios * data.empresaCantidadTrabajadores),
                    "color": '#A9F5A9'
                },
                {
                    "label": "75 a más",
                    "value": Math.round(data.TramoEtarioDe75aMasAnios * data.empresaCantidadTrabajadores),
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
                    //"value": data.RegimenSaludFonasa,
                    "value": Math.round(data.RegimenSaludFonasa * data.empresaCantidadTrabajadores),
                    "color": '#5fbeaa'
                },
                {
                    "label": "Isapre",
                    //"value": data.RegimenSaludIsapre,
                    "value": Math.round(data.RegimenSaludIsapre * data.empresaCantidadTrabajadores),
                    "color": '#5d9cec'
                },
                {
                    "label": "Sin Información",
                    //"value": data.RegimenSaludSinInformacion,
                    "value": Math.round(data.RegimenSaludSinInformacion * data.empresaCantidadTrabajadores),
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
                   //"value": data.SexoMasculino,
                   "value": Math.round(data.SexoMasculino * data.empresaCantidadTrabajadores),
                   "color": '#5fbeaa'
               },
               {
                   "label": "Femenino",
                   //"value": data.SexoFemenino,
                   "value": Math.round(data.SexoFemenino * data.empresaCantidadTrabajadores),
                   "color": '#5d9cec'
               },
               {
                   "label": "Sin Información",
                   //"value": data.SexoSinInfo,
                   "value": Math.round(data.SexoSinInfo * data.empresaCantidadTrabajadores),
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
                  //"value": data.TC_Si,
                  "value": Math.round(data.TC_Si * data.empresaCantidadTrabajadores),
                  "color": '#5fbeaa'
              },
              {
                  "label": "No",
                  //"value": data.TC_No,
                  "value": Math.round(data.TC_No * data.empresaCantidadTrabajadores),
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
                 //"value": data.TipoCargaHijo,
                 "value": Math.round(data.TipoCargaHijo * data.empresaCantidadTrabajadores),
                 "color": '#5fbeaa'
             },
             {
                 "label": "Otros",
                 //"value": data.TipoCargaOtros,
                 "value": Math.round(data.TipoCargaOtros * data.empresaCantidadTrabajadores),
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