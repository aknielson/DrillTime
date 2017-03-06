(function (undefined) {

    "use strict";

    //first decalre yourself as a "Module"... still don't get this

    angular.module("drillTimeNgOnly").controller("DrillDetailCtrl",["drill", DrillDetailCtrl]);

    function DrillDetailCtrl(drill) {
        var vm = this;

        vm.drill = drill;

        vm.title = "Drill Detail: " + vm.drill.Name;

        if (vm.drill.Tags) {
            vm.drill.tagList = vm.drill.Tags.toString();
        }

    }

})();