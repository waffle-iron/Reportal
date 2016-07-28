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

        $.getJSON("http://localhost:8080/api/EncabezadoEmpresa/" + $("#IdEmpresa").val(), function (data) {

            $("#empresaRut").text(data.Id);
            $("#empresaSegmento").text(data.empresaSegmento);
            $("#empresaDV").text(data.empresaDV)
            $("#empresaNSE").text(data.empresaNSE);
            $("#empresaNombre").text(data.empresaNombre);
            $("#empresaNumTrabajadores").text(data.empresaCantidadTrabajadores.toMoney());
            $("#empresaTipo").text(data.tipoEmpresa);
            $("#empresaTrabajadorMail").text(data.empresaTrabajadorMail.toMoney());
            $("#empresaSectorEconomico").text(data.empresaSectorEconomico);
            $("#empresaTrabajadorCelular").text(data.empresaTrabajadorCelular.toMoney());
            $("#clasificacionComercial").text(data.empresaclasificacionComercial);
            $("#clasificacionRiesgo").text(data.empresaclasificacionRiesgo);
            $("#empresaTrabajadorMailCelular").text(data.empresaTrabajadorMailCelular.toMoney());
            $("#empresaTrabajadorTarjeta").text(data.empresaTrabajadorTarjDigital.toMoney());
            $("#empresaTrabajadorRentaPromedio").text(data.empresaPromedioRenta.toMoney());
            $("#antiguedadempresa").text(data.empresaAniosAfiliado);
            $("#empresatrabajadorpromedio").text(data.empresaPromedioEdad);
            $("#perteneceholding").text(data.empresaHolding);
        });

        $.getJSON("http://localhost:8080/api/DetalleEmpresa/" + $("#IdEmpresa").val(), function (data) {

            var proCicloVida = [
                {
                    "label": "Adulto",
                    //"value": Math.round(data.CVAdulto * data.TotalTrabajadores),
                    "value": Math.round(data.CVAdulto),
                    "color": '#013ADF'
                },
                {
                    "label": "Adulto Mayor",
                    // "value": Math.round(data.CVAdultoMayor * data.TotalTrabajadores),
                    "value": data.CVAdultoMayor,
                    "color": '#BDBDBD'
                },
                {
                    "label": "Desarrollo",
                    //"value": Math.round(data.CVDesarrollo * data.TotalTrabajadores),
                    "value": data.CVDesarrollo,
                    "color": '#5858FA'
                },
                {
                    "label": "Jovenes",
                    // "value": Math.round(data.CVJovenes * data.TotalTrabajadores),
                    "value": data.CVJovenes,
                    "color": '#FF3131'
                },
                {
                    "label": "Madurez",
                    // "value": Math.round(data.CVMadurez * data.TotalTrabajadores),
                    "value": data.CVMadurez,
                    "color": '#FF8A14'
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
                    .valueFormat(function (d) {
                        return d.toMoney();
                    })
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
                    "value": Math.round(data.NS_Abc1 * data.TotalTrabajadores),
                    "color": '#013ADF'
                },
                {
                    "label": "C2",
                    "value": Math.round(data.NS_C2 * data.TotalTrabajadores),
                    "color": '#BDBDBD'
                },
                {
                    "label": "C3",
                    "value": Math.round(data.NS_C3 * data.TotalTrabajadores),
                    "color": '#5858FA'
                },
                {
                    "label": "D",
                    "value": Math.round(data.NS_D * data.TotalTrabajadores),
                    "color": '#FF3131'
                },
                {
                    "label": "E",
                    "value": Math.round(data.NS_E * data.TotalTrabajadores),
                    "color": '#FF8A14'
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
                .valueFormat(function (d) {
                    return d.toMoney();
                })
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
                    "value": Math.round(data.TA_Tramo_A * data.TotalTrabajadores),
                    "color": '#013ADF'
                },
                {
                    "label": "Tramo B",
                    "value": Math.round(data.TA_Tramo_B * data.TotalTrabajadores),
                    "color": '#BDBDBD'
                },
                {
                    "label": "Tramo C",
                    "value": Math.round(data.TA_Tramo_C * data.TotalTrabajadores),
                    "color": '#FF8A14'
                },
                {
                    "label": "Tramo D",
                    "value": Math.round(data.TA_Tramo_D * data.TotalTrabajadores),
                    "color": '#FF3131'
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
                .valueFormat(function (d) {
                    return d.toMoney();
                })
                ;

                d3.select("#grafTramoAF svg")
                    .datum(proAsignacionFamiliar)
                    .transition().duration(350)
                    .call(chartAsignacionFamiliar);

                return chartAsignacionFamiliar;
            });
            var proTramoEtarioAfiliado = [
                {
                    "label": "18 a 30",
                    "value": Math.round(data.TramoEtarioDe18a30Anios * data.TotalTrabajadores),
                    "color": '#013ADF'
                },
                {
                    "label": "31 a 45",
                    "value": Math.round(data.TramoEtarioDe31a45Anios * data.TotalTrabajadores),
                    "color": '#BDBDBD'
                },
                {
                    "label": "46 a 60",
                    "value": Math.round(data.TramoEtarioDe46a60Anios * data.TotalTrabajadores),
                    "color": '#5858FA'
                },
                {
                    "label": "61 a 75",
                    "value": Math.round(data.TramoEtarioDe61a75Anios * data.TotalTrabajadores),
                    "color": '#FF3131'
                },
                {
                    "label": "75 a más",
                    "value": Math.round(data.TramoEtarioDe75aMasAnios * data.TotalTrabajadores),
                    "color": '#FF8A14'
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
                .valueFormat(function (d) {
                    return d.toMoney();
                })
                ;

                d3.select("#grafTramoEtarioA svg")
                    .datum(proTramoEtarioAfiliado)
                    .transition().duration(350)
                    .call(chartTramoEtarioAfiliado);

                return chartTramoEtarioAfiliado;
            });
            var proRegimenSalud = [
                {
                    "label": "Fonasa",
                    //"value": data.RegimenSaludFonasa,
                    "value": Math.round(data.RegimenSaludFonasa * data.TotalTrabajadores),
                    "color": '#5858FA'
                },
                {
                    "label": "Isapre",
                    //"value": data.RegimenSaludIsapre,
                    "value": Math.round(data.RegimenSaludIsapre * data.TotalTrabajadores),
                    "color": '#FF3131'
                },
                {
                    "label": "Sin Información",
                    //"value": data.RegimenSaludSinInformacion,
                    "value": Math.round(data.RegimenSaludSinInformacion * data.TotalTrabajadores),
                    "color": '#FF8A14'
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
                .valueFormat(function (d) {
                    return d.toMoney();
                })
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
                   "value": Math.round(data.SexoMasculino * data.TotalTrabajadores),
                   "color": '#5858FA'
               },
               {
                   "label": "Femenino",
                   //"value": data.SexoFemenino,
                   "value": Math.round(data.SexoFemenino * data.TotalTrabajadores),
                   "color": '#FF3131'
               },
               {
                   "label": "Sin Información",
                   //"value": data.SexoSinInfo,
                   "value": Math.round(data.SexoSinInfo * data.TotalTrabajadores),
                   "color": '#FF8A14'
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
                .valueFormat(function (d) {
                    return d.toMoney();
                })
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
                  "value": Math.round(data.TC_Si * data.TotalTrabajadores),
                  "color": '#FF8A14'
              },
              {
                  "label": "No",
                  //"value": data.TC_No,
                  "value": Math.round(data.TC_No * data.TotalTrabajadores),
                  "color": '#FF3131'
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
                .valueFormat(function (d) {
                    return d.toMoney();
                })
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
                 "value": Math.round(data.TipoCargaHijo * data.TotalTrabajadores),
                 "color": '#FF8A14'
             },
             {
                 "label": "Otros",
                 //"value": data.TipoCargaOtros,
                 "value": Math.round(data.TipoCargaOtros * data.TotalTrabajadores),
                 "color": '#FF3131'
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
                .valueFormat(function (d) {
                    return d.toMoney();
                })
                ;

                d3.select("#grafTipoCarga svg")
                    .datum(proTipoCarga)
                    .transition().duration(350)
                    .call(chartTipoCarga);

                return chartTipoCarga;
            });
            var proTipoHijosEdad = [
        {
            "label": "De 0 a 2 años",
            //"value": data.TipoCargaHijo,
            "value": Math.round(data.CargaHijoDe0a2Anios * data.TotalTrabajadores),
            "color": '#6890FC'
        },
        {
            "label": "De 3 a 4 años",
            //"value": data.TipoCargaOtros,
            "value": Math.round(data.CargaHijoDe3a4Anios * data.TotalTrabajadores),
            "color": '#FF8A14'
        },
        {
            "label": "De 5 a 6 años",
            //"value": data.TipoCargaOtros,
            "value": Math.round(data.CargaHijoDe5a6Anios * data.TotalTrabajadores),
            "color": '#FF3131'
        },
        {
            "label": "De 7 a 14 años",
            //"value": data.TipoCargaOtros,
            "value": Math.round(data.CargaHijoDe7a14Anios * data.TotalTrabajadores),
            "color": '#5858FA'
        },
        {
            "label": "De 15 a 18 años",
            //"value": data.TipoCargaOtros,
            "value": Math.round(data.CargaHijoDe15a18Anios * data.TotalTrabajadores),
            "color": '#BDBDBD'
        },
         {
             "label": "De 19 a más años",
             //"value": data.TipoCargaOtros,
             "value": Math.round(data.CargaHijoDe19MasAnios * data.TotalTrabajadores),
             "color": '#013ADF'
         }
            ];

            //Donut chart example
            nv.addGraph(function () {
                var chartTipoCargaHijosEdad = nv.models.pieChart()
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

                d3.select("#grafTipoCargaHijosporEdad svg")
                    .datum(proTipoHijosEdad)
                    .transition().duration(350)
                    .call(chartTipoCargaHijosEdad);

                return chartTipoCargaHijosEdad;
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

        });//ciere local

        $.getJSON("http://localhost:8080/api/ResumenLicencia/" + $("#IdEmpresa").val(), function (data) {

            //Grafico de barras
            var BarChart = {
                labels: ["Enero - 2016", "Febrero - 2016"],
                datasets: [
                    {
                        fillColor: 'rgba(95, 190, 170, 0.7)',
                        strokeColor: 'rgba(95, 190, 170, 1)',
                        highlightFill: 'rgba(95, 190, 170, 1)',
                        highlightStroke: 'rgba(95, 190, 170, 0.9)',
                        data: [75, 100] / 100
                    }
                ]
            }


            var selector = $("#bar2");
            var ctx = selector.get(0).getContext("2d");
            var container = $(selector).parent();
            var ww = selector.attr('width', $(container).width());
            var sal = new Chart(ctx).Bar(data);
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