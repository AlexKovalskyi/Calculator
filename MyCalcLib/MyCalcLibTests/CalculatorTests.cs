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

            MyCalc c = new MyCalc();
            int actual = c.Sum(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }
		
        [TestMethod]
        public void CheckMultiplication()
        {
            int a = 11;
            int b = 3;

            MyCalc calc = new MyCalc();
            int actual = calc.Multiply(a, b);

            Assert.AreEqual(actual, 33);
        }
        
        [TestMethod]
        public void CheckSubstractrion()
        {
            int a = 11;
            int b = 3;

            MyCalc calc = new MyCalc();
            int actual = calc.Substract(a, b);

            Assert.AreEqual(actual, 11 - 3);
        }

        //TODO: Add division. Recall information about data types http://metanit.com/sharp/tutorial/2.1.php
        [TestMethod]
        public void CheckDivision()
        {
            int a = 11;
            int b = 3;

            MyCalc calc = new MyCalc();
            float actual = calc.Devide(a, b);

            Assert.AreEqual(actual, 11 - 3);
        }

        //TODO: Class name should be close to its logical context. (Whithout 'my', 'his', 'cool', etc.)
        [TestMethod]
        public void CheckClassName()
        {
            string expectedName = "Calculator";

            string actualName = nameof(MyCalc);

            Assert.AreEqual(expectedName, actualName);
        }
    }
}