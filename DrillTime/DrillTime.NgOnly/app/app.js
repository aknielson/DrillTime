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

                    .state("drillDetail",
                    {
                        url: "/drills/:drillId",
                        templateUrl: "app/drills/drillDetailView.html",
                        controller: "DrillDetailCtrl as vm",
                        resolve: {
                            drillResource: "drillResource",
                            drill: function (drillResource, $stateParams) {
                                var drillId = $stateParams.drillId;
                                return drillResource.get({ drillId: drillId }).$promise;

                            }
                        }
                    })


                    .state("drillEdit",
                    {
                        abstract: true,
                        url: "/drills/edit/:drillId",
                        templateUrl: "app/drills/drillEditView.html",
                        controller: "DrillEditCtrl as vm",
                        resolve: {
                        drillResource: "drillResource",
                                drill: function (drillResource, $stateParams) {
                                var drillId = $stateParams.drillId;
                                return drillResource.get({
                                    drillId: drillId
                                }).$promise;

                                }
                        }
                    })

                        .state("drillEdit.info",
                        {
                            url: "/info",
                            templateUrl: "app/drills/drillEditInfoView.html"
                        })
                        .state("drillEdit.image",
                        {
                            url: "/image",
                            templateUrl: "app/drills/drillEditImageView.html"
                        })
                        .state("drillEdit.tags",
                        {
                            url: "/tags",
                            templateUrl: "app/drills/drillEditTagsView.html"
                        });
            }
        ]
    );
}());