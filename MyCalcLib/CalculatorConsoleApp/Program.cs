using static GlobalLogger.GLogger;
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
				Logger.Info("Starting Calculator's work.");
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
				Logger.Error(ex, "Main program is broken");
				Console.ReadLine();
			}
		}
	}
}
