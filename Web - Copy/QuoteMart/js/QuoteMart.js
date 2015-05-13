var quoteMartModule = angular.module('QuoteMart', []);

quoteMartModule.controller('QuoteMartcontroller', [function ($scope,QuoteMartService) {
    $scope.Model = QuoteMartService;
}]);

quoteMartModule.service('QuoteMartService', [function ($http) {
    return new QuoteMartServiceViewModel($http);
}]);


var QuoteMartServiceViewModel = (function () {
    var mocel = function (http) {
        var self = this;

    };
    return model;
})();