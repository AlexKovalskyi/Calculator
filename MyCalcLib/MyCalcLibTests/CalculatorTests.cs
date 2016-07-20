using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcLib;

namespace MyCalcLibTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            //arrange

            int x = 10;
            int y = 20;
            int expected = 30;

            // act

            Calculator c = new Calculator();
            int actual = c.Sum(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }
		
        [TestMethod]
        public void CheckMultiplication()
        {
            int a = 11;
            int b = 3;

            Calculator calc = new Calculator();
            int actual = calc.Multiply(a, b);

            Assert.AreEqual(actual, 33);
        }
        
        [TestMethod]
        public void CheckSubstractrion()
        {
            int a = 11;
            int b = 3;

            Calculator calc = new Calculator();
            int actual = calc.Substract(a, b);

            Assert.AreEqual(actual, 11 - 3);
        }

        
        [TestMethod]
        public void CheckDivision()
        {
            int a = 11;
            int b = 3;

            Calculator calc = new Calculator();
            float actual = calc.Devide(a, b);

            Assert.AreEqual(actual, 11 - 3);
        }

        
        [TestMethod]
        public void CheckClassName()
        {
            string expectedName = "Calculator";

            string actualName = nameof(Calculator);

            Assert.AreEqual(expectedName, actualName);
        }
    }
}