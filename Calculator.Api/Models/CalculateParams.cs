using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Api.Models
{
    public class CalculateParams
    {
        public int FirstValue { get; set; }
        public int SecondValue { get; set; }
        public string Sign { get; set; }
    }
}