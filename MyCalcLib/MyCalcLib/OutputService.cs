using System;
using CalcLib;

namespace MyCalcLib
{
	public class OutputService
	{
		public void Print(int firstNumb, char operation, int secondNumb, int result)
		{
			Console.WriteLine("{0} {1} {2} = {3}", firstNumb, operation, secondNumb, result);
		}
	}
}
