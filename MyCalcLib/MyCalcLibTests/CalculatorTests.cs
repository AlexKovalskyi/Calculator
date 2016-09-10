using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLib;
using CalculatorLib.CommonTypes;
using CalculatorLib.Core;

namespace CalcLibTests
{
	[TestClass]
	public class CalculatorTests
	{
		private Arguments args = new Arguments(11, 3);
		[TestMethod]
		public void Sum_10and20_30returned()
		{
			//arrange
			int expected = 11+3;
            // act
            Calculator c = new Calculator();
			double actual = c.Sum(args);

			//assert
			Assert.AreEqual(expected, actual);
		}
		
		[TestMethod]
		public void CheckMultiplication()
		{
			int expected = 11*3;

            Calculator calc = new Calculator();
			double actual = calc.Multiply(args);

			Assert.AreEqual(actual, expected);
		}
		
		[TestMethod]
		public void CheckSubstractrion()
		{
			int expected = 11-3;
            Calculator calc = new Calculator();
			double actual = calc.Substract(args);

			Assert.AreEqual(actual,expected);
		}

		
		[TestMethod]
		public void CheckDivision()
		{
			int expected = 11 / 3;
            Calculator calc = new Calculator();
			double actual = calc.Divide(args);

			Assert.AreEqual(actual, expected);
		}

		[TestMethod]
		public void CheckModulo()
		{
			int expected = 11 % 3;
            Calculator calc = new Calculator();
			double actual = calc.Modulo(args);

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