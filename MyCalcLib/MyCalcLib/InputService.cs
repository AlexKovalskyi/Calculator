using System;
using CalcLib;

namespace MyCalcLib
{
	class InputService
	{
        private OutputService outputService;

		public Arguments  ReadArgs()
		{
            outputService = new OutputService();
            outputService.RequestFirstNumber();
	
			int firstNumber = Convert.ToInt32(Console.ReadLine());
			outputService.RequestSecondNumber();
			int secondNumber = Convert.ToInt32(Console.ReadLine());

			Arguments arguments = new Arguments(firstNumber, secondNumber);
			
		
			return arguments;
		}

		public OperationType ReadOperatoin()
		{

			outputService = new OutputService();
			outputService.PrintAvailableOperations();
			return (OperationType)Convert.ToChar(Console.ReadLine());
		}
	}
}
