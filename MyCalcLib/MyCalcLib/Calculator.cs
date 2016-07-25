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
            OutputService printOperationResult = new OutputService();
            Console.WriteLine("Best of the best Calculator with 5 operations");
            while (true)
            {
                OperationDelegate operationDelegate; //TODO: Remove declaring closer to usage. 
                Console.WriteLine("Enter one of the operation : +, -, *, /, %"); //TODO: Remove to OutputService
                char operation = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Write your first number: ");//TODO: Remove to OutputService
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Write your second number: ");//TODO: Remove to OutputService
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                Arguments arguments = new Arguments(firstNumber, secondNumber);
                Calculator calc = new Calculator(); //TODO: Critical implementation issue. Think, why?
                switch (operation)
                {
                    case ('+'): //TODO: Remove '(' and ')' characters
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
                        Console.WriteLine("invalid operation"); //TODO: Rename to "Invalid operation."
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