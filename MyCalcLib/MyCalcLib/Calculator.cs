using System;
using CalcLib;
using MyCalcLib;

namespace CalcLib
{
	public class Calculator
	{
	
		public int Sum(Arguments args) => args.A + args.B;

		public int Substract(Arguments args) => args.A - args.B;

		public int Multiply (Arguments args) => args.A * args.B;

		public int Devide (Arguments args) => args.A / args.B;

		public int Modulo (Arguments args) => args.A % args.B;
	

	public void RunCalculatorLoop()
	{
		
		OutputService printOperationResult = new OutputService();
		Console.WriteLine("Best of the best Calculator with 5 operations");
			while (true)
			{
				OperationDelegate operationDelegate;
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
						break;
					case ('/'):
						operationDelegate = calc.Devide;
						break;
					case ('*'):
						operationDelegate = calc.Multiply;
						break;
					case ('-'):
						operationDelegate = calc.Substract;
						break;
					case ('%'):
						operationDelegate = calc.Modulo;
						break;
					default:
						Console.WriteLine("invalid operation");
						throw new Exception();

				}

				if (operationDelegate != null)
				{
					int result = operationDelegate.Invoke(arguments);
					printOperationResult.Print(arguments.A, operation, arguments.B, result);
				}
			}
		}
	}
}
