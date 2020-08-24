using Calculator.Web.API.Models;
using Calculator.Web.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Calculator.Web.API.Controllers
{
    public class CalculatorController : ApiController
    {
        private readonly ICalculatorService _calculatorService = new CalculatorService();
        //public CalculatorController(ICalculatorService calculatorService)
        //{
        //    _calculatorService = calculatorService;
        //}
       // [System.Web.Http.HttpGet("Calculate")]
        public IHttpActionResult Calculate(CalculateParams param)
        {
            var result = _calculatorService.Calculate(param.Sign, param.FirstValue, param.SecondValue);
            var resultData = new ResultData
            {
                Result = result,
                ErrorMessage = string.Empty
            };
            return Ok(resultData);
        }
    }
}
