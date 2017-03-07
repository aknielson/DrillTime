(function () {
    "use strict";

    angular
        .module("drillTimeNgOnly")
        .controller("DrillEditCtrl",
            [
                "drill",
                "$state",
                DrillEditCtrl
            ]);

    function DrillEditCtrl(drill, $state) {
        var vm = this;

        vm.drill = drill;

        console.log("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");

        if (vm.drill && vm.drill.Id) {
            vm.title = "Edit: " + vm.drill.Name;
        } else {
            vm.title = "New Drill";
        }

        vm.TagList = vm.drill.Tags ? vm.drill.Tags.split(',') : [];
        console.log(vm);

        vm.submit = function () {
            console.log(vm.drill);
            vm.drill.$save(function(data) {
                toastr.success("Save Successful");
                $state.go('drillList');
            });
        }

        vm.cancel = function() {
            $state.go('drillList');
        }

        vm.addTags = function(tags) {
            if (tags) {
                var array = tags.split(',');
                vm.TagList = vm.TagList ? vm.TagList.concat(array) : array;
                vm.drill.Tags = vm.TagList.toString();
                vm.newTags = "";
            } else {
                alert("Please enter one or more tags separated by commas");
            }
            console.log(vm);
        }

        vm.removeTag = function(idx) {
            vm.TagList.splice(idx, 1);
            vm.drill.Tags = vm.TagList.toString();
        }

    }


})();