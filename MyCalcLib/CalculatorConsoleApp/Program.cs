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

        //TODO: Remove to Calculator class.
		static void RunCalculatorLoop()
		{
			WriteMassageToConsole printOperationResult = new WriteMassageToConsole(); //TODO: Rename class to OutputService
			Console.WriteLine("Best of the best Calculator with 5 operations");
            while (true)
            {
                OperationDelegate operationDelegate = null;
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
                        operationDelegate = calc.Sum;
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

                if (operationDelegate != null)
                {
                    int result = operationDelegate.Invoke(arguments);
                }
            }
        }
	}
}
