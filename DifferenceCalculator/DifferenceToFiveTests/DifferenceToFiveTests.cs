using DifferenceCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DifferenceToFiveTests
{
    [TestClass]
    public class DifferenceToFiveTests
    {
        [TestMethod]
        public void DifferenceCalculator_WhenValidInputPassed_ReturnsDifference()
        {
            var response = main.Calculator(1);
            Assert.AreEqual("4 is required to get to 5", response);
        }
    }
}
