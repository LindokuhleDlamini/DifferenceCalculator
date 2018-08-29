using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DifferenceCalculatorTests
{
    [TestClass]
    public class CalculatorTests: BaseTest
    {
        [TestMethod]
        public void DifferenceCalculator_WhenValidInputPassed_ReturnsDifference()
        {
            var response = _results.Calculator(1);
            Assert.AreEqual(4, response);
        }
    }
}
