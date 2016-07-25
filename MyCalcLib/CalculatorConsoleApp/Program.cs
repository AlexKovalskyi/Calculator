using CalcLib;
using System;
using MyCalcLib;

namespace CalculatorConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				RunCalculatorLoop(); 
			}
			catch (Exception)
			{
				Console.WriteLine("Error : please try again. Maybe you are using wrong argments");
				Console.WriteLine("Program will be close");
				Console.ReadLine();
			}
		}

		static void RunCalculatorLoop()
		{


			WriteMassageToConsole printOperationResult = new WriteMassageToConsole();
			Console.WriteLine("Best of the best Calculator with 5 operations");
			while (true)
			{
				OperationDelegate operationDelegate;
				int answer = 1;
				Console.WriteLine("Enter one of the operation : +, -, *, /, %");
				char operation = Convert.ToChar(Console.ReadLine());
				Console.WriteLine("Write your first number: ");
				int firstNumber = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Write your second number: ");
				int secondNumber = Convert.ToInt32(Console.ReadLine());

				Arguments arguments = new Arguments(firstNumber, secondNumber);
				Calculator calc = new Calculator();
				switch (operation)
				{
					case ('+'):
						answer = calc.Sum(arguments);
						printOperationResult.Print(firstNumber, operation, secondNumber, answer);
						break;
					case ('/'):
						answer = calc.Devide(arguments);
						printOperationResult.Print(firstNumber, operation, secondNumber, answer);
						break;
					case ('*'):
						answer = calc.Multiply(arguments);
						printOperationResult.Print(firstNumber, operation, secondNumber, answer);
						break;
					case ('-'):
						answer = calc.Substract(arguments);
						printOperationResult.Print(firstNumber, operation, secondNumber, answer);
						break;
					case ('%'):
						answer = calc.Modulo(arguments);
						printOperationResult.Print(firstNumber, operation, secondNumber, answer);
						break;
					default:
						Console.WriteLine("invalid operation");
							throw new Exception();

				}

				operationDelegate = null;
				if (operationDelegate != null)
				{
					var result = operationDelegate.Invoke(arguments);

				}
			
		
        }
      }
	}
}
