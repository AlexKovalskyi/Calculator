using CalculatorLib.Interfaces;
using System;

namespace CalculatorLib.IOServices
{
	public class CmdLineOutputService : IOutputService, IOutputHardOperation
	{
		public void Print(double firstNumb, char operation, double secondNumb, double result)
		{
			Console.WriteLine("{0} {1} {2} = {3}", firstNumb, operation, secondNumb, result);
		}

		public void PrintHardOperation(double firstNumb, char operation, double result)
		{
			Console.WriteLine("{0} {1} = {3}", firstNumb, operation, result);
		}
		
		public void PrintAvailableOperations () 
		{
			Console.WriteLine("Enter one of the operation : +, -, *, /, %"); 
		}

		public void RequestFirstNumber()
		{
			Console.WriteLine("Write your first number: ");
		}

		public void RequestSecondNumber()
		{
			Console.WriteLine("Write your second number: ");
		}
    }
}
