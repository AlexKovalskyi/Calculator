using MyCalcLib;
using System;

namespace CalcLib
{
    public class Calculator
    {
        public int Sum(Arguments args) => args.A + args.B;

        public int Substract(Arguments args) => args.A - args.B;

        public int Multiply(Arguments args) => args.A * args.B;

        public int Devide(Arguments args) => args.A / args.B;

        public int Modulo(Arguments args) => args.A % args.B;

        public void RunCalculatorLoop()
        {
            OutputService outputService = new OutputService();
            Console.WriteLine("Best of the best Calculator with 5 operations");
            while (true)
            {
				outputService.PrintAvailableOperations();
                //TODO: Remove to new class InputService to method ReadArgs();
				char operation = Convert.ToChar(Console.ReadLine());
                //TODO: Add 'OperationType ReadOperation();'
				outputService.RequestFirstNumber();
                int firstNumber = Convert.ToInt32(Console.ReadLine());
				outputService.RequestSecondNumber();
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                Arguments arguments = new Arguments(firstNumber, secondNumber);
				OperationDelegate operationDelegate;
				switch (operation)
                {
                    case '+':
                        operationDelegate = Sum;
                        break;

                    case '/':
                        operationDelegate = Devide;
                        break;

                    case '*':
                        operationDelegate = Multiply;
                        break;

                    case '-':
                        operationDelegate = Substract;
                        break;

                    case '%':
                        operationDelegate = Modulo;
                        break;

                    default:
                        Console.WriteLine("Invalid operation");
                        throw new Exception();
                }

                if (operationDelegate != null)
                {
                    int result = operationDelegate.Invoke(arguments);
                    outputService.Print(arguments.A, operation, arguments.B, result);
                }
            }
        }
    }
}