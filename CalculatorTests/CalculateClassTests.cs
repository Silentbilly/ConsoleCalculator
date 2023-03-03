using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculateClassTests
    {
        CalculateClass calculator = new CalculateClass();
        private const string Add = "+";
        private const string Subtract = "-";
        private const string Multiply = "*";
        private const string Divide = "/";
        private const string Empty = "";

        [TestMethod()]
        public void CalculateTestAddition()
        {
            double epectedResult = calculator.Calculate(2, 3, Add);
            double actualResult = 5;
            Assert.AreEqual(epectedResult, actualResult);
        } 

        [TestMethod()]
        public void CalculateTestAdditionWithZero()
        {
            double epectedResult = calculator.Calculate(0, 1, Add);
            double actualResult = 1;
            Assert.AreEqual(epectedResult, actualResult);
        }    

        [TestMethod()]
        public void CalculateTestAdditionWithNegative()
        {
            double epectedResult = calculator.Calculate(1, -5, Add);
            double actualResult = -4;
            Assert.AreEqual(epectedResult, actualResult);
        }

        [TestMethod()]
        public void CalculateTestMultiply()
        {
            double epectedResult = calculator.Calculate(2, 3, Multiply);
            double actualResult = 6;
            Assert.AreEqual(epectedResult, actualResult);
        }

        [TestMethod()]
        public void CalculateTestMultiplyWithZero()
        {
            double epectedResult = calculator.Calculate(0, 1, Multiply);
            double actualResult = 0;
            Assert.AreEqual(epectedResult, actualResult);
        }

        [TestMethod()]
        public void CalculateTestSubtraction()
        {
            double epectedResult = calculator.Calculate(3, 3, Subtract);
            double actualResult = 0;
            Assert.AreEqual(epectedResult, actualResult);
        }

        [TestMethod()]
        public void CalculateTestDivide()
        {
            double epectedResult = calculator.Calculate(6, 4, Divide);
            double actualResult = 1.5;
            Assert.AreEqual(epectedResult, actualResult);
        }

        [TestMethod()]
        public void CalculateTestDivideByZero()
        {
            try
            {
                calculator.Calculate(1, 0, Divide);

            }
            catch (ArithmeticException e)
            {
                StringAssert.Contains(e.Message, "Can't divide by zero");
            }
        }
    }
}