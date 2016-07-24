using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcLib;

namespace CalcLibTests
{
	[TestClass]
	public class CalculatorTests
	{
		Arguments args = new Arguments(11, 3);
		[TestMethod]
		public void Sum_10and20_30returned()
		{
			//arrange
			int expected = 11+3;
			// act
			Calculator c = new Calculator();
			int actual = c.Sum(args);

			//assert
			Assert.AreEqual(expected, actual);
		}
		
		[TestMethod]
		public void CheckMultiplication()
		{
			int expected = 11*3;

			Calculator calc = new Calculator();
			int actual = calc.Multiply(args);

			Assert.AreEqual(actual, expected);
		}
		
		[TestMethod]
		public void CheckSubstractrion()
		{
			int expected = 11-3;
			Calculator calc = new Calculator();
			int actual = calc.Substract(args);

			Assert.AreEqual(actual,expected);
		}

		
		[TestMethod]
		public void CheckDivision()
		{
			int expected = 11 / 3;
			Calculator calc = new Calculator();
			float actual = calc.Devide(args);

			Assert.AreEqual(actual, expected);
		}

		[TestMethod]
		public void CheckModulo()
		{
			int expected = 11 % 3;
			Calculator calc = new Calculator();
			int actual = calc.Modulo(args);

			Assert.AreEqual(actual, expected);
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