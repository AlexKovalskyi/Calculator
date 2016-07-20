using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalcLibTests
	{
	[TestClass]
	public class MycalcTests
		{
		[TestMethod]
		public void Sum_10and20_30returned ( )
			{
			//arrange

			int x = 10;
			int y = 20;
			int expected = 30;

			// act
			
			MyCalcLib.MyCalc c = new MyCalcLib.MyCalc ( );
			int actual = c.Sum ( x, y );

			//assert
			Assert.AreEqual ( expected, actual );
			}
		}
	}
