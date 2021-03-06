﻿using DifferenceCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DifferenceCalculatorTests
{
    [TestClass]
    public class GetInputValueTests
    {
        public InputProcessor _results;
        [TestInitialize]
        public void Initialize()
        {
            _results = new InputProcessor(5);
        }

        [TestMethod]
        public void GetInputValue_WhenInputValueIsNumeric_ReturnsValueInput()
        {
            var response = _results.GetInputValue("1");
            Assert.AreEqual(response, 1);
        }

        [TestMethod]
        public void GetInputValue_WhenInputValueIsNotNumeric_ReturnsNegativeValue()
        {
            var response = _results.GetInputValue("qwerty");
            Assert.AreEqual(response, -1);
        }
    }
}
