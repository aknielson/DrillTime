(function () {
    "use strict";

    angular
        .module("common.services") //note this is "getting" module common.services
        .factory("drillResource", ["$resource", drillResource]);

    function drillResource($resource) {
        return $resource("http://localhost:12441/api/drills/:drillId");
    }



})();