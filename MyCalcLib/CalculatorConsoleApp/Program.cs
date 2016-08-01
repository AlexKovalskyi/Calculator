using CalcLib;
using System;

namespace MyCalcLib
{
    class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Calculator calculator = new Calculator();
				calculator.RunCalculatorLoop();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error : please try again. Maybe you are using wrong argments");
				Console.WriteLine("Program will be close");
				Console.ReadLine();
			}
		}
	}
}
