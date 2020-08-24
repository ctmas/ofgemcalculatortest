(function (app) {
    var calculatorService = function ($http) {
        var calculatorFactory = {};
        var url = "/api/Calculator/Calculate";
        calculatorFactory.calculate = function (data) {
            return $http.get(url, { params: data });
        
       };

        

        return calculatorFactory;
    };
    app.factory("calculatorService", calculatorService);

}(angular.module("calculatorApp")));