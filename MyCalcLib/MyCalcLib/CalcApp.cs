using CalculatorLib.CommonTypes;
using CalculatorLib.Core;
using CalculatorLib.Interfaces;

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
			OperationType operation;
			Arguments arguments;
			Calculator calc = new Calculator();
			do
			{
				operation = _inputService.ReadOperations();
				arguments = _inputService.ReadArgs();
				calc.GetFunk(operation);
				double result = calc.GetFunk(operation).Invoke(arguments);
				if (OperationType.Sqrt == operation || OperationType.Pow2 == operation || OperationType.Pow3 == operation)
				{
                    _outputService.PrintUnaryOperation(arguments.A, (char)operation, result);
                }
				else
				{
                    _outputService.Print(arguments.A, (char)operation, arguments.B, result);
                }
			} while (operation != OperationType.NOP && arguments != null);
		}
    }
}
