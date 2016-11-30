
/**
* Theme: Ubold Admin Template
* Author: Coderthemes
* Nestable Component
*/

!function($) {
    "use strict";

    var Nestable = function () { };

    Nestable.prototype.updateOutput = function (e) {
        var list = e.length ? e : $(e.target),
            output = list.data('output');
        if (window.JSON) {
            output.val(window.JSON.stringify(list.nestable('serialize'))); //, null, 2));
        } else {
            output.val('JSON browser support required for this demo.');
        }
    },
    //init
    Nestable.prototype.init = function() {
        $('#nestable_list_3').nestable({ maxDepth: 3 });
    },
    //init
    $.Nestable = new Nestable, $.Nestable.Constructor = Nestable
}(window.jQuery),

//initializing 
function($) {
    "use strict";
    $.Nestable.init()
}(window.jQuery);
