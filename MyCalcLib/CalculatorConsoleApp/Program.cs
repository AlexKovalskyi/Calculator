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
				Calculator runCalculatorLoop = new Calculator();
				runCalculatorLoop.RunCalculatorLoop();
			}
			catch (Exception)
			{
				Console.WriteLine("Error : please try again. Maybe you are using wrong argments");
				Console.WriteLine("Program will be close");
				Console.ReadLine();
			}
		}
	}
}
