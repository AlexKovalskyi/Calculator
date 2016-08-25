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
            Console.WriteLine("Best of the best Calculator with 5 operations");
            while (true)
            {
                OperationType operation = _inputService.ReadOperations();
                Arguments arguments = _inputService.ReadArgs();
                OperationDelegate operationDelegate;
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

                    default:
                        Console.WriteLine("Invalid operation");
                        throw new Exception();
                }

                if (operationDelegate != null)
                {
                    int result = operationDelegate.Invoke(arguments);
                    //TODO: Check operation printing.
                    _outputService.Print(arguments.A, (char)operation, arguments.B, result);
                }
            }
        }
    }
}
