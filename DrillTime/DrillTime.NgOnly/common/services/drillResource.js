(function () {
    "use strict";

    angular
        .module("common.services") //note this is "getting" module common.services
        .factory("drillResource", ["$resource", drillResource]);

    function drillResource($resource) {
        return $resource("http://localhost:12441/api/drills/:drillId");
    }

    //function drillResource($resource) {
    //    return $resource("http://192.168.1.163:12442/api/drills/:drillId",
    //        { drillId: '@_id' },
    //        {
    //            update: {
    //                method: 'PUT',
    //                params: { drillId: "@drillId" }
    //            }
    //        });
    //}



})();