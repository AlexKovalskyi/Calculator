using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcLib;

namespace MyCalcLibTests
{
    [TestClass]
    public class MycalcTests
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

        //TODO: Add multiplication function.
        [TestMethod]
        public void CheckMultiplication()
        {
            int a = 11;
            int b = 3;

            MyCalc calc = new MyCalc();
            int actual = calc.Multiply(a, b);

            Assert.AreEqual(actual, 33);
        }

        //TODO: Add substraction function.
        [TestMethod]
        public void CheckSubstractrion()
        {
            int a = 11;
            int b = 3;

            MyCalc calc = new MyCalc();
            int actual = calc.Substract(a, b);

            Assert.AreEqual(actual, 11 - 3);
        }
    }
}