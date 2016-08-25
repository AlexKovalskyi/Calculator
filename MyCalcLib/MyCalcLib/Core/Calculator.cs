using CalculatorLib.CommonTypes;

namespace CalculatorLib.Core
{
    public class Calculator
    {
        public int Sum(Arguments args) => args.A + args.B;

        public int Substract(Arguments args) => args.A - args.B;

        public int Multiply(Arguments args) => args.A * args.B;

        public int Divide(Arguments args) => args.A / args.B;

        public int Modulo(Arguments args) => args.A % args.B;
    }
}