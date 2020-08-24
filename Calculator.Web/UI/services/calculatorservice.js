(function (app) {
    var calculatorService = function ($http) {
        var calculatorFactory = {};
        var url = "/api/Calculator/Calculate";
        calculatorFactory.calculate = function (data) {
            return $http({
                method: 'get',
                data: data,
                url: url
            });
        
       };

        

        return calculatorFactory;
    };
    app.factory("calculatorService", calculatorService);

}(angular.module("calculatorApp")));