using Microsoft.VisualStudio.TestTools.UnitTesting;
using DifferenceCalculator;

namespace DifferenceCalculatorTests
{
    [TestClass]
    public class BaseTest
    {
        public ResultsProcessor _results;
        [TestInitialize]
        public void Initialize()
        {
            _results = new ResultsProcessor(5);
        }
    }
}
