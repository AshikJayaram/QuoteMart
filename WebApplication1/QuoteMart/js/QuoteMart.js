var quoteMartModule = angular.module('QuoteMart', ['ngRoute']);

quoteMartModule.controller('QuoteMartController', function ($scope,QuoteMartService) {
    $scope.Model = QuoteMartService;
});

quoteMartModule.service('QuoteMartService', [function ($http) {
    return new QuoteMartServiceViewModel($http);
}]);


quoteMartModule.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/home', {
            templateUrl: '/QuoteMart/templates/CustomerDetailsTemplate.html',
            controller: 'CustomerDetailsController'
        }).
        when('/insurers', {
            templateUrl: '/QuoteMart/templates/InsurerDetailsTemplate.html',
            controller: 'InsurerDetailsController'
        }).
        when('/insurer/:id', {
            templateUrl: '/QuoteMart/templates/InsurerBenefitDetailsTemplate.html',
            controller: 'InsurerBenefitDetailsController'
        }).
      otherwise({
          redirectTo: '/home'
      });
  }]);


var QuoteMartServiceViewModel = (function () {
    var model = function (http) {
        var self = this;

    };
    return model;
})();