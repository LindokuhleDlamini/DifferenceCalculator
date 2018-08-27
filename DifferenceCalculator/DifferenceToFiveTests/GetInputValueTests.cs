using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DifferenceCalculator;

namespace DifferenceToFiveTests
{
    [TestClass]
    public class GetInputValueTests
    {

        [TestMethod]
        public void GetInputValue_WhenInputValueIsNumeric_ReturnsValueInput()
        {
            var response =main.GetInputValue("1");
            Assert.AreEqual(response, 1);
        }

        [TestMethod]
        public void GetInputValue_WhenInputValueIsNotNumeric_ReturnsNegativeValue()
        {
            var response = main.GetInputValue("qwerty");
            Assert.AreEqual(response, -1);
        }
    }
}
