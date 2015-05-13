var quoteMartModule = angular.module('QuoteMart');

quoteMartModule.controller('InsurerDetailsController', function ($scope, InsurerDetailsService) {
    $scope.Model = InsurerDetailsService;
    $scope.Model.GetInsurerDetails();
});

quoteMartModule.service('InsurerDetailsService', function ($http, $rootScope,$location) {
    return new InsurerDetailsServiceViewModel($http, $rootScope,$location);
});


var InsurerDetailsServiceViewModel = (function () {
    var model = function (http, rootScope,location) {
        var self = this;
        self.Insurers = [];

        self.ViewDetails = function (id) {
            rootScope.insurerId = id;
            var path = location.$$protocol + "://" + location.$$host + ":" + location.$$port + "/quotemart/index.html#/insurer/" + id;
            window.open(path,'_blank');
        };

        self.GetInsurerDetails = function () {
            http({
                method: "GET",
                url:"/api/Insurer"
            })
            .success(function (data) {
                self.Insurers = data;
            })
            .error(function (error) {
                    alert("We are facing some techinical difficulties. Please try again after some time.")
            });
        };
    };
    return model;
})();