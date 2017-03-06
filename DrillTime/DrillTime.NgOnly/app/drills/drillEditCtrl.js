(function () {
    "use strict";

    angular.module("drillTimeNgOnly").controller("DrillEditCtrl", ["drill", DrillEditCtrl]);

    function DrillEditCtrl(drill) {
        var vm = this;
        vm.drill = drill;

        if (vm.drill && vm.drill.Id) {
            vm.title = "Edit: " + vm.drill.Name;
        } else {
            vm.title = "New Drill";
        }

    }


})();