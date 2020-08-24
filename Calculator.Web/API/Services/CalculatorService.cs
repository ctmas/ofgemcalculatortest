using Calculator.Web.API.Models;
//using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Calculator.Web.API.Services
{
    public class CalculatorService : ICalculatorService
    {
        public double Calculate(string signValue, double a, double b )
        {
            switch (signValue)
            {
                case "+":
                    return Addition(a, b);
                case "-":
                    return Substraction(a, b);
                case "*":
                    return Multiplication(a, b);
                case "/":
                    return Division(a, b);
            }

            return 0;
        }

        private double Addition(double a, double b)
        {
            return a + b;
        }

        private double Substraction(double a, double b)
        {
            return a - b;
        }

        private double Multiplication(double a, double b)
        {
            return a * b;
        }

        private double Division(double a, double b)
        {
            return a / b;
        }

        /*public interface ICalculation
        {
            double Result(double a, double b);
        }

        public class Addition : ICalculation
        {
            public double Result(double a, double b)
            {
                return a + b;
            }
        }

        public class Substraction : ICalculation
        {
            public double Result(double a, double b)
            {
                return a - b;
            }
        }*/
    }
}