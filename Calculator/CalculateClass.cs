using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculateClass
    {
        public double Calculate(double num1, double num2, string operation)
        {
            if (operation.Equals("/") && num2 == 0)
            {
                throw new ArithmeticException("Can't divide by zero");
            }
            double expected = 0;
            switch (operation)
            {
                case "+": expected = num1 + num2; break;
                case "-": expected = num1 - num2; break;
                case "*": expected = num1 * num2; break;
                case "/": expected = num1 / num2; break;
            }
            return expected;
        }
    }
}
