using CalculatorLib.Interfaces;
using System;

namespace CalculatorLib.IOServices
{
	public class CmdLineOutputService : IOutputService
	{
		public void Print(double firstNumb, char operation, double secondNumb, double result)
		{
			Console.WriteLine("{0} {1} {2} = {3}", firstNumb, operation, secondNumb, result);
		}

		public void PrintUnaryOperation(double firstNumb, char operation, double result)
		{
			Console.WriteLine("{0} {1} = {2}", firstNumb, operation, result);
		}
		
		public void PrintAvailableOperations () 
		{
			Console.WriteLine("Enter one of the operation : +, -, *, /, %, t - Sqrt, r - POW2, s - POW3"); 
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
