using CalculatorLab.IOServices;
using CalculatorLib.Core;
using CalculatorLib.Interfaces;
using CalculatorLib.IOServices;
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
				IInputService inputService = new CmdInputService();
				IOutputService outputService = new CmdLineOutputService();
                ICalcFacade simpleCalcApp = new CalcApp(calc, inputService, outputService);
                simpleCalcApp.Run();
				Console.ReadLine();
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
