using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Api.Services
{
    public interface ICalculatorService
    {
        double Calculate(string signValue, double a, double b);

    }
}
