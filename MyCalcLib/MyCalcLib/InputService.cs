using System;
using CalcLib;

namespace MyCalcLib
{
	class InputService
	{
        private CmdLineOutputService outputService;

		public Arguments  ReadArgs()
		{
            outputService = new CmdLineOutputService();
            outputService.RequestFirstNumber();
	
			int firstNumber = Convert.ToInt32(Console.ReadLine());
			outputService.RequestSecondNumber();
			int secondNumber = Convert.ToInt32(Console.ReadLine());

			Arguments arguments = new Arguments(firstNumber, secondNumber);
			
		
			return arguments;
		}

		public OperationType ReadOperatoin()
		{

			outputService = new CmdLineOutputService();
			outputService.PrintAvailableOperations();
			return (OperationType)Convert.ToChar(Console.ReadLine());
		}
	}
}
