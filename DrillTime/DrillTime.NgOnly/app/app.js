(function () {  //use //IIFE
    "use strict";
    var app = angular.module("drillTimeNgOnly",
        ['ui.router', "common.services"]);  //having the second parameter of an array means we are 'setting' the module, without the secound param, its a 'getter'

    app.config(
        [
            "$stateProvider",
            "$urlRouterProvider",
            function ($stateProvider, $urlRouterProvider) {
                $urlRouterProvider.otherwise("/");
                $stateProvider
                    .state("home",
                    {
                        url: "/",
                        templateUrl: "app/welcomeView.html"
                    })
                    .state("drillList",
                    {
                        url: "/drills",
                        templateUrl: "app/drills/drillListView.html",
                        controller: "DrillListCtrl as vm"
                    })
                    .state("drillEdit",
                    {
                        url: "/drills/edit/:drillId",
                        templateUrl: "app/drills/drillEditView.html",
                        controller: "DrillEditCtrl as vm"
                    });
            }
        ]
    );
}());