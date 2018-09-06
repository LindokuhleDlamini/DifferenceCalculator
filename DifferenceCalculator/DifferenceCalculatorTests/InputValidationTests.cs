using DifferenceCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DifferenceCalculatorTests
{
    [TestClass]
    public class InputValidationTests
    {
        public InputProcessor _results;
        [TestInitialize]
        public void Initialize()
        {
            _results = new InputProcessor(5);
        }

        [TestMethod]
        public void InputValidation_WhenInputValueMeetsPredefinedCondition_ReturnsTrue()
        {
            var response = _results.InputValidation(1);
            Assert.AreEqual(response, true);
        }

        [TestMethod]
        public void InputValidation_whenInputValueDoesNotMeetPredefinedCondition_ReturnFalse()
        {
            var response = _results.InputValidation(-1);
            Assert.AreEqual(response, false);
        }
    }
}
