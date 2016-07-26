using System;
using CalcLib;

namespace MyCalcLib
{
	class InputService
	{

		public OutputService outputService = new OutputService();
		public Arguments  ReadArgs()
		{

			outputService.RequestFirstNumber();
	
			int firstNumber = Convert.ToInt32(Console.ReadLine());
			outputService.RequestSecondNumber();
			int secondNumber = Convert.ToInt32(Console.ReadLine());

			Arguments arguments = new Arguments(firstNumber, secondNumber);
			
		
			return arguments;
		}

		public OperationType ReadOperatoin()
		{
			outputService.PrintAvailableOperations();
			return (OperationType) Convert.ToChar(Console.ReadLine());

		}
	}
}
