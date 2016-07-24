using CalcLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				RunCalculator();
			}
			catch (Exception)
			{
				Console.WriteLine("Error : please try again. Maybe you use wrong argments");
				Console.WriteLine("Program will be close");
				Console.ReadLine();
			}
		}

		static void RunCalculator()
		{
			int answer;
			PrintResult printOperationResult = new PrintResult();
			
			Console.WriteLine("Best of the best Calculator with 5 operation");
			while (true)
			{
				Console.WriteLine("Enter one of the operation : +, -, *, /, %");
				char operation = Convert.ToChar(Console.ReadLine());
				Console.WriteLine("Write your first number: ");
				int firstNumber = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Write your second number: ");
				int secondNumber = Convert.ToInt32(Console.ReadLine());
				
				Arguments arguments = new Arguments(firstNumber, secondNumber);
				Calculator calc = new Calculator();
				if (operation == '+')
				{
					answer = calc.Sum(arguments);
					printOperationResult.Print (firstNumber, operation, secondNumber, answer);
				}
				else if (operation == '/')
				{
					answer = calc.Devide(arguments);
					printOperationResult.Print(firstNumber, operation, secondNumber, answer);
				}
				else if (operation == '*')
				{
					answer = calc.Multiply(arguments);
					printOperationResult.Print(firstNumber, operation, secondNumber, answer);
				}
				else if (operation == '-')
				{
					answer = calc.Substract(arguments);
					printOperationResult.Print(firstNumber, operation, secondNumber, answer);
				}
				else if (operation == '%')
				{
					answer = calc.Modulo(arguments);
					printOperationResult.Print(firstNumber, operation, secondNumber, answer);
				}
				else
				{
					Console.WriteLine("invalid operation");
				}
			}
			
		}
		public void Print(int firstNumb, char operation, int secondNumb, int result)
		{
			Console.WriteLine("{0} {1} {2} = {3}", firstNumb, operation, secondNumb, result);
		}
	}
}
