var quoteMartModule = angular.module('QuoteMart');

quoteMartModule.controller('CustomerDetailsController', function ($scope, CustomerDetailsService, $compile) {
    $scope.Model = CustomerDetailsService;
    $scope.Model.Compile = function(){        
        $compile($('#dependents').contents())($scope);
    };
});

quoteMartModule.service('CustomerDetailsService', function ($http, $location) {
    return new CustomerDetailsServiceViewModel($http, $location);
});


var CustomerDetailsServiceViewModel = (function () {
    var model = function (http,location) {
        var self = this;
        self.Insurers = [];
        self.Customer = {};

        self.AddDependentTemplate = function () {
            http({
                method: 'GET',
                url:"/QuoteMart/templates/DependentsTemplate.html"
            })
            .success(function (data) {
                $('#dependents').append(data);
                self.Compile();
            });
        };

        self.RemoveDependent = function (elt) {
            $(elt).closest(".row").remove();
        };

        self.GetInsurerDetails = function () {
            http({
                method: "POST",
                url: "/api/Insurer",
                data: self.Customer
            })
            .success(function (data) {
                location.path('insurers');
            })
            .error(function (error) {
                    alert("We are facing some techinical difficulties. Please try again after some time.")
            });
        };
    };
    return model;
})();

function removedep(elt) {
    $(elt).closest("div.row").remove();
}