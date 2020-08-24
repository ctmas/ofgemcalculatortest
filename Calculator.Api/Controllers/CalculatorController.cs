using Calculator.Api.Models;
using Calculator.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Mvc;

namespace Calculator.Api.Controllers
{
    public class CalculatorController : ApiController
    {
        private readonly ICalculatorService _calculatorService;
        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpGet]
        public IHttpActionResult Calculate([FromUri]  CalculateParams param)
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
