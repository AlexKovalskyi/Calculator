using MyCalcLib;
using System;

namespace CalcLib
{
    //TODO: Read: SIP - Single Responsibility Principle 231-242
    public class Calculator
    {
        public int Sum(Arguments args) => args.A + args.B;

        public int Substract(Arguments args) => args.A - args.B;

        public int Multiply(Arguments args) => args.A * args.B;

        public int Divide(Arguments args) => args.A / args.B;

        public int Modulo(Arguments args) => args.A % args.B;

        public void RunCalculatorLoop()
        {
            Console.WriteLine("Best of the best Calculator with 5 operations");
            while (true)
            {
                IOutputService cmdOutput = new CmdLineOutputService();
				InputService inputService = new InputService();
				OperationType operation = inputService.ReadOperatoin();
				Arguments arguments = inputService.ReadArgs();
				OperationDelegate operationDelegate;
				switch (operation)
				{
					case OperationType.Sum:
						operationDelegate = Sum;
						break;

					case OperationType.Div:
						operationDelegate = Divide;
						break;

					case OperationType.Mul:
						operationDelegate = Multiply;
						break;

					case OperationType.Sub:
						operationDelegate = Substract;
						break;

					case OperationType.Mod:
						operationDelegate = Modulo;
						break;

					default:
						Console.WriteLine("Invalid operation");
						throw new Exception();
				}

				if (operationDelegate != null)
				{
					int result = operationDelegate.Invoke(arguments);
                    //TODO: Check operation printing.
					cmdOutput.Print(arguments.A, (char)operation, arguments.B, result);
				}
			}
        }
    }
}