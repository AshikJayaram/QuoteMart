var quoteMartModule = angular.module('QuoteMart');

quoteMartModule.controller('InsurerBenefitDetailsController', function ($scope, InsurerBenefitDetailsService, $compile) {
    $scope.Model = InsurerBenefitDetailsService;
    $scope.Model.GetBenefitDetails();
});

quoteMartModule.service('InsurerBenefitDetailsService', function ($http, $rootScope,$location) {
    return new InsurerBenefitDetailsServiceViewModel($http, $rootScope, $location);
});

var InsurerBenefitDetailsServiceViewModel = (function () {
    var model = function (http, rootScope,location) {
        var self = this;
        self.BenefitDetails = {};
        self.Text = "Remove Benefit";

        self.CheckBenefit = function (index) {
            if (self.BenefitDetails.Benefits[index].IsActive) {
                self.BenefitDetails.Benefits[index].Text = "Remove Benefit";
                self.BenefitDetails.Benefits[index].IsActive = false;
            }
            else {
                self.BenefitDetails.Benefits[index].Text = "Add Benefit";
                self.BenefitDetails.Benefits[index].IsActive = true;
            }
        };

        self.AddBenefit = function (index) {
            self.CheckBenefit(index);
            if (self.BenefitDetails.Benefits[index].IsActive) {
                self.BenefitDetails.Premium = self.BenefitDetails.Premium - 500;
            }
            else {
                self.BenefitDetails.Premium = self.BenefitDetails.Premium + 500;
            }
        };

        self.GetBenefitDetails = function () {
            var id = location.path().split('/')[2];
            http({
                method: 'GET',
                url: '/api/InsurerBenefitDetails?insurerId=' + id

            })
            .success(function (data) {
                self.BenefitDetails = data;
            });
        };
    };

    return model;
})();