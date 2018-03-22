using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalkulatorSilniaAndFibonacci;

namespace SilniaTest.UnitTest
{
    /// <summary>
    /// Summary description for calcSilniaTest
    /// </summary>
    [TestClass]
    public class CalcSilniaTest
    {
     
        [TestMethod]
        public void Silnia_value_is_equal_0()
        {
            int x = 0;
            var normalValue = Silnia.NormalCalculateSilnia(x);
            var recurentValue = Silnia.RekurentCalculateSilnia(x);

            Assert.AreEqual(normalValue, recurentValue);
            Assert.AreEqual(normalValue, 1);
        }

        [TestMethod]
        public void Silnia_normal_calculate()
        {
            int x = 5;
            int result = 120;

            var normalValue = Silnia.NormalCalculateSilnia(x);
           
            Assert.AreEqual(normalValue, result);
           
        }

        [TestMethod]
        public void Silnia_recurent_calculate()
        {
            int x = 5;
            int result = 120;

            var recurentValue = Silnia.RekurentCalculateSilnia(x);

            Assert.AreEqual(recurentValue, result);
        }

    }
}
