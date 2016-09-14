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
			operationType = OperationType.Pow3;
			double expected = 729;
            double actual = calc.GetFunk(operationType).Invoke(args);
			Assert.AreEqual(expected, actual, "Sqrt operation failed.");
        }

        [TestMethod]
	    public void CheckSqrt()
        {
			operationType = OperationType.Sqrt;
			double expected = 3;
            double actual = calc.GetFunk(operationType).Invoke(args);

			Assert.AreEqual(expected, actual, "Sqrt operation failed.");
        }

		[TestMethod]
		public void CheckSumm()
		{
			operationType = OperationType.Sum;
			double expected = args.A + args.B;
			double actual = calc.GetFunk(operationType).Invoke(args);
			Assert.AreEqual(expected, actual);
		}
		
		[TestMethod]
		public void CheckMultiplication()
		{
			operationType = OperationType.Mul;
			double expected = 9*3;
			double actual = calc.GetFunk(operationType).Invoke(args);
			Assert.AreEqual(actual, expected);
		}
		
		[TestMethod]
		public void CheckSubstractrion()
		{
			operationType = OperationType.Sub;
			double  expected = args.A - args.B;
			double actual = calc.GetFunk(operationType).Invoke(args);
			Assert.AreEqual(actual,expected);
		}

		
		[TestMethod]
		public void CheckDivision()
		{
			operationType = OperationType.Div;
			double expected = args.A / args.B;
			double actual = calc.GetFunk(operationType).Invoke(args);
			Assert.AreEqual(actual, expected);
		}

		[TestMethod]
		public void CheckModulo()
		{
			operationType = OperationType.Mod;
			double expected = args.A % args.B;
			double actual = calc.GetFunk(operationType).Invoke(args);
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