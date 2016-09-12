using CalculatorLib.CommonTypes;
using CalculatorLib.Core;
using CalculatorLib.Interfaces;
using System;

namespace CalculatorLib
{
    public class CalcApp : ICalcFacade
    {
        private Calculator _calc;
        private IInputService _inputService;
        private IOutputService _outputService;

		public CalcApp(Calculator calc, IInputService inputService, IOutputService outputService)
        {
            _calc = calc;
            _inputService = inputService;
            _outputService = outputService;
        }

        public void Run()
        {
			OperationDelegate operationDelegate;
			OperationType operation;
			Arguments arguments;
			do
			{
				operation = _inputService.ReadOperations();
				arguments = _inputService.ReadArgs();
				switch (operation)
				{
					case OperationType.Sum:
						operationDelegate = _calc.Sum;
						break;
					case OperationType.Div:
						operationDelegate = _calc.Divide;
						break;
					case OperationType.Mul:
						operationDelegate = _calc.Multiply;
						break;
					case OperationType.Sub:
						operationDelegate = _calc.Substract;
						break;
					case OperationType.Mod:
						operationDelegate = _calc.Modulo;
						break;
					case OperationType.Sqrt:
						operationDelegate = _calc.Sqrt;
						break;
					case OperationType.Pow2:
						operationDelegate = _calc.Pow2;
						break;
					case OperationType.Pow3:
						operationDelegate = _calc.Pow3;
						break;
					case OperationType.NOP:
						continue;
					default:
					    Console.WriteLine("Invalid operation");
					    throw new Exception();
				}

				if (operationDelegate != null)
				{   
					double result = operationDelegate.Invoke(arguments);
				    if (OperationType.Sqrt == operation || OperationType.Pow2 == operation || OperationType.Pow3 == operation)
				    {
                        _outputService.PrintUnaryOperation(arguments.A, (char)operation, result);
                    }
				    else
				    {
                        _outputService.Print(arguments.A, (char)operation, arguments.B, result);
                    }
				}
			} while (operation != OperationType.NOP && arguments != null);
		}
    }
}
