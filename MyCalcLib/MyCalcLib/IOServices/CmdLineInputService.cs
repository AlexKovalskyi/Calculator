using CalculatorLib.CommonTypes;
using CalculatorLib.Interfaces;
using System;

namespace CalculatorLib.IOServices
{
	public class CmdInputService : IInputService
    {
        private CmdLineOutputService outputService;

		public Arguments  ReadArgs()
		{
            outputService = new CmdLineOutputService();
            outputService.RequestFirstNumber();
	
			double firstNumber = Convert.ToInt32(Console.ReadLine());
			outputService.RequestSecondNumber();
			double secondNumber = Convert.ToInt32(Console.ReadLine());

			Arguments arguments = new Arguments(firstNumber, secondNumber);
			return arguments;
		}

		public OperationType ReadOperations()
		{
			outputService = new CmdLineOutputService();
			outputService.PrintAvailableOperations();
			return (OperationType)Convert.ToChar(Console.ReadLine());
		}
	}
}
