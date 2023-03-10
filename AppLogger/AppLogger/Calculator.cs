using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogger
{
    internal class Calculator
    {
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }
        public double Sub(double number1, double number2)
        {
            return number1 - number2;
        }

        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public double Div(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}
