(function () {  //use //IIFE
    "use strict";
    var app = angular.module("drillTimeNgOnly",
        ["common.services"]);  //having the second parameter of an array means we are 'setting' the module, without the secound param, its a 'getter'
}());