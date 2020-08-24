(function (app) {
    var calculatorController = function ($scope, calculatorservice) {
        var vm = this;
        vm.result = 0;
        vm.sign = '+';
        vm.values = {
            first: 0,
            second: 0
        };
       
        vm.doCalculations = function (sign, a, b) {
            var data = {
                sign: sign,
                firstValue: a,
                secondValue: b
            };
            calculatorservice.calculate(data).then(x => {
                vm.result = x.data.Result;
            });
        };
    };
    app.controller("calculatorController", ["$scope", "calculatorService", calculatorController]);
}(angular.module("calculatorApp")));