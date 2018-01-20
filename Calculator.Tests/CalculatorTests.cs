using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void VerifyAddMethodWorkingProperly()
        {
            var calculator = new MathCalculator();

            var result = calculator.Add(10,20);

            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void VerifySubtractMethodWorkingProperly()
        {
            var calculator = new MathCalculator();

            var result = calculator.Subtract(20,10);

            Assert.AreEqual(10, result);
        }
    }
}
