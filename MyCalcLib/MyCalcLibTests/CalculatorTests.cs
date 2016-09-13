using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLib.CommonTypes;
using CalculatorLib.Core;

namespace CalcLibTests
{
	[TestClass]
	public class CalculatorTests
	{
		private Arguments args = new Arguments(9, 3);
        private Calculator calc = new Calculator();
		private OperationType operationType;

        [TestMethod]
        public void CheckPow2()
        {
			operationType = OperationType.Pow2;
            double expected = 81;

            double actual = calc.GetFunk(operationType).Invoke(args);

            Assert.AreEqual(expected, actual, "Sqrt operation failed.");
        }

        [TestMethod]
        public void CheckPow3()
        {
            double expected = 729;

            double actual = calc.GetFunk(operationType).Invoke(args);

			Assert.AreEqual(expected, actual, "Sqrt operation failed.");
        }

        [TestMethod]
	    public void CheckSqrt()
        {
            double expected = 3;

            double actual = calc.GetFunk(operationType).Invoke(args);

			Assert.AreEqual(expected, actual, "Sqrt operation failed.");
        }

		[TestMethod]
		public void Sum_10and20_30returned()
		{
			//arrange
			var expected = args.A + args.B;
            // act
			double actual = calc.GetFunk(operationType).Invoke(args);

			//assert
			Assert.AreEqual(expected, actual);
		}
		
		[TestMethod]
		public void CheckMultiplication()
		{

			int expected = 11*3;
            
			double actual = calc.GetFunk(operationType).Invoke(args);

			Assert.AreEqual(actual, expected);
		}
		
		[TestMethod]
		public void CheckSubstractrion()
		{
			var expected = args.A - args.B;
			double actual = calc.GetFunk(operationType).Invoke(args);

			Assert.AreEqual(actual,expected);
		}

		
		[TestMethod]
		public void CheckDivision()
		{
			var expected = args.A / args.B;
			double actual = calc.GetFunk(operationType).Invoke(args);

			Assert.AreEqual(actual, expected);
		}

		[TestMethod]
		public void CheckModulo()
		{
			int expected = 11 % 3;
            
			double actual = calc.GetFunk(operationType).Invoke(args);

			Assert.AreEqual(actual, expected);
		}


		[TestMethod]
		public void CheckClassName()
		{
			string expectedName = "Calculator";

			string actualName = nameof(CalculatorLab);

			Assert.AreEqual(expectedName, actualName);
		}
    }
}