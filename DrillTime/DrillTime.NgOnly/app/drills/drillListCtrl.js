(function () {
    "use strict";

    angular
        .module("drillTimeNgOnly")
        .controller("DrillListCtrl",
        ["drillResource", DrillListCtrl]);

    function DrillListCtrl(drillResource) {
        var vm = this;

        vm.Drillsxxxx = [
            {
                Id: 1,
                Name: "Sight Picture Confirmation ",
                StartPosition: "Standing in box A, hands naturally at sides",
                Procedure:
                    "Draw and establish an acceptable sight picture on a blank wall (no target). Finger should end on Trigger. Do not pull the trigger",
                SuggestedTimeSpan: 0,
                SuggestedReps: 0,
                TargetPar: 0
            },
            {
                Id: 2,
                Name: "10-Yard Index ",
                StartPosition: "Standing in box A, hands naturally at sides",
                Procedure:
                    "Draw and establish an acceptable sight picture on the lower A zone of T1. Do not pull the trigger.",
                SuggestedTimeSpan: 0,
                SuggestedReps: 0,
                TargetPar: 0
            },
            {
                Id: 3,
                Name: "10-Yard Surrender Index ",
                StartPosition: "Standing in box A, hands above shoulders",
                Procedure:
                    "Draw and establish an acceptable sight picgture on the lower A-zone of T1. Do not pull the trigger.",
                SuggestedTimeSpan: 0,
                SuggestedReps: 0,
                TargetPar: 0
            },
            {
                Id: 4,
                Name: "Turn and Draw ",
                StartPosition: "Standing in box A, facing up rage away from the target the hands above shoulders",
                Procedure:
                    "Trun, then draw and establish an acceptablde sight picgture on the lower A-zone of T1. Do not pull the trigger.",
                SuggestedTimeSpan: 0,
                SuggestedReps: 0,
                TargetPar: 0
            },
            {
                Id: 5,
                Name: "Strong Hand Index ",
                StartPosition: "Standing in box A, hands naturally at sides",
                Procedure:
                    "Draw and establish an acceptable sight picture on the lower A-Zone of T1 with the strong hand only. Do not pull the trigger.",
                SuggestedTimeSpan: 0,
                SuggestedReps: 0,
                TargetPar: 0
            },
            {
                Id: 6,
                Name: "Weak Hand Index ",
                StartPosition: "Standing in box A, hands naturally at sides",
                Procedure:
                    "Draw, transfer gun to weak hand and establish an acceptable sight picture on the lower A-zone of T1 with the weak hand only. Do not pull the trigger.",
                SuggestedTimeSpan: 0,
                SuggestedReps: 0,
                TargetPar: 0
            },
            {
                Id: 7,
                Name: "Burkett Reloads ",
                StartPosition: "Gun on targe in a freestyle position",
                Procedure: "Hit the mag button while bringing a new mag just to the edge of the magwell",
                SuggestedTimeSpan: 0,
                SuggestedReps: 0,
                TargetPar: 0
            },
            {
                Id: 8,
                Name: "6 Reload 6 ",
                StartPosition: "Standing in box A, hands naturally at sides",
                Procedure:
                    "Engage T1-T3 with two shots only, perform a reload, and then engate T1-T3 with two shots only",
                SuggestedTimeSpan: 0,
                SuggestedReps: 0,
                TargetPar: 0
            },
            {
                Id: 9,
                Name: "Surrender 6, Reload 6 ",
                StartPosition: "Standing in box A, hands naturally at sides",
                Procedure:
                    "Engage T1-T3 with two shots only, perform a reload, and then engate T1-T3 with two shots only",
                SuggestedTimeSpan: 0,
                SuggestedReps: 0,
                TargetPar: 0
            },
            {
                Id: 10,
                Name: "El Prez ",
                StartPosition: "Facing uprange away from the targets, hands above shoulders.",
                Procedure:
                    "Turn, then draw and engage T1 - T3 with two shots only, perform a reload and engage T1 - T3 with two shots only.",
                SuggestedTimeSpan: 0,
                SuggestedReps: 0,
                TargetPar: 0
            },
            {
                Id: 11,
                Name: "6 Reload Strong ",
                StartPosition: "Standing in box A, hands relaxed at sides.",
                Procedure:
                    "Engage T1 - T3 with two shots only freestyle, perform a relad the engage T1 - T3 with two shots only with just the strong hand.",
                SuggestedTimeSpan: 0,
                SuggestedReps: 0,
                TargetPar: 0
            },
            {
                Id: 12,
                Name: "6 Reload Weak ",
                StartPosition: "Standing in box A, hands relaxed at sides.",
                Procedure:
                    "Engage T1 - T3 with two shots only, perform a reload then engage T1 - T3 with just two shots with the weak hand only.",
                SuggestedTimeSpan: 0,
                SuggestedReps: 0,
                TargetPar: 0
            }
        ];

        drillResource.query(function (data) {
            console.log(data);
            vm.Drills = data;
        });

     //   drillResource.get(function (data) {
     //       vm.Drills = data;
    //    });

        vm.showProcedure = true;

        vm.toggleProcedure = function () {
            vm.showProcedure = !vm.showProcedure;
        }

    }




})();