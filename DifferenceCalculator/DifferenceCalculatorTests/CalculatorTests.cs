using DifferenceCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DifferenceCalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        public ResultsProcessor _results;
        [TestInitialize]
        public void Initialize()
        {
            _results = new ResultsProcessor(5);
        }

        [TestMethod]
        public void DifferenceCalculator_WhenValidInputPassed_ReturnsDifference()
        {
            var response = _results.ResultsCalculator(1);
            Assert.AreEqual(4, response);
        }
    }
}
