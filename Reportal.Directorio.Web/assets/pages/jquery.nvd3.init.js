/**
* Theme: Ubold Admin
* Author: Coderthemes
* Chart Nvd3 page
*/


(function($) {
    'use strict';

	
	//Donut chart example
	nv.addGraph(function() {
	  var chart = nv.models.pieChart()
	      .x(function(d) { return d.label })
	      .y(function(d) { return d.value })
	      .showLabels(true)     //Display pie labels
	      .labelThreshold(.05)  //Configure the minimum slice size for labels to show up
	      .labelType("percent") //Configure what type of data to show in the label. Can be "key", "value" or "percent"
	      .donut(true)          //Turn on Donut mode. Makes pie chart look tasty!
	      .donutRatio(0.30)     //Configure how big you want the donut hole size to be.
	      ;
	
	    d3.select("#chart2 svg")
	        .datum(exampleData())
	        .transition().duration(350)
	        .call(chart);
	
	  return chart;
	});
	
	//Pie chart example data. Note how there is only a single array of key-value pairs.
	function exampleData() {
	  return  [
	      { 
	        "label": "Privados",
	        "value" : 50,
	        "color" : "#5fbeaa"
	      } , 
	      { 
	        "label": "Publicos",
	        "value" : 20,
	        'color': '#f05050'
	      } , 
	      { 
	        "label": "Pensionados",
	        "value" : 30,
	        'color': '#5d9cec'
	      } 	      
	    ];
	}
})(jQuery);