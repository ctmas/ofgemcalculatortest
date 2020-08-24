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
            calculatorservice.calculate(data);
            //switch (sign) {
               
            //    case '+': vm.result = calculatorservice.calculate(sign, a, b,); break;
            //    case '-': vm.result = calculatorservice.subtract(a, b); break;
            //    case '*': vm.result = calculatorservice.multiply(a, b); break;
            //    case '/': vm.result = calculatorservice.divide(a, b); break;
            //}
        };
    };
    app.controller("calculatorController", ["$scope", "calculatorService", calculatorController]);
}(angular.module("calculatorApp")));