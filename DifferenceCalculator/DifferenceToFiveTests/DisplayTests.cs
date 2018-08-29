using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DifferenceCalculatorTests
{
    [TestClass]
    public class DisplayTests: BaseTest
    {

        [TestMethod]
        public void Display_WhenValidInputSupplied_ReturnsDifferenceToTargetValue()
        {
            var expectedResponse = "4 is required to get to 5";
            var response = _results.Display(1);
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void Display_WhenInvalidInputSupplied_ReturnsValidationMessage()
        {
            var expectedResponse = "Value provided doesn't meet the condition (0<= x <=5)";
            var response = _results.Display(-1);
            Assert.AreEqual(expectedResponse, response);
        }
    }
}
