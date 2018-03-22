using CalkulatorSilniaAndFibonacci;
using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciTest.Tests
{
    [TestClass]
    public class CalcFibonacciTest
    {
        [TestMethod]
        public void Fibonacci_value_is_equal_0()
        {
            var n = 0;

            var result = 0;

            var testMethod = Fibonacci.FibonacciNumber(n);

            Assert.AreEqual(testMethod, result);
        }

        [TestMethod]
        public void Fibonacci_value_is_less_than_0()
        {
            var n = -3;

            var result = 0;

            var testMethod = Fibonacci.FibonacciNumber(n);

            Assert.AreEqual(testMethod, result);
        }

        [TestMethod]
        public void Fibonacci_value_is_equal_5()
        {
            var n = 11;

            var result = 89;

            var testMethod = Fibonacci.FibonacciNumber(n);

            Assert.AreEqual(testMethod, result);
        }
    }
}


