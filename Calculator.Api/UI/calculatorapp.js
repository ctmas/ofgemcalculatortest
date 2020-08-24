(function () {
    angular.module("calculatorApp", ["ngRoute"])
    .config(function ($routeProvider) {
        $routeProvider.
            when("/", {
                templateUrl: "pages/calculator.html",
                controller: "calculatorController"
            })
    });
}());