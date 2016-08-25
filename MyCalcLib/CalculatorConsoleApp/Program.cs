using CalculatorLab.IOServices;
using CalculatorLib.Core;
using CalculatorLib.Interfaces;
using System;

namespace CalculatorLib
{
    class Program
	{
		static void Main(string[] args)
		{
			try
			{
                Calculator calc = new Calculator();
                IInputService inputService = new FileInputService(@"I:\GitHub\Calculator\MyCalcLib\Task.txt");
                IOutputService outputService = new FileOutputService("CalculatorResult.txt");
                ICalcFacade simpleCalcApp = new CalcApp(calc, inputService, outputService);
                simpleCalcApp.Run();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error : please try again. Maybe you are using wrong argments.");
				Console.WriteLine("Program will be close.");
				Console.ReadLine();
			}
		}
	}
}
