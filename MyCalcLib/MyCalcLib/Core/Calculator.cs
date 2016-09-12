using System;
using CalculatorLib.CommonTypes;

namespace CalculatorLib.Core
{
	public class Calculator
	{
	    private const int POW2 = 2;
        private const int POW3 = 3;

        public double Sum(Arguments args) => args.A + args.B;
	
		public double Substract(Arguments args) => args.A - args.B;

		public double Multiply(Arguments args) => args.A * args.B;

		public double Divide(Arguments args) => args.A / args.B;

		public double Modulo(Arguments args) => args.A % args.B;

		public double Sqrt(Arguments args) => Math.Sqrt(args.A);
        
		public double Pow2(Arguments args) => Math.Pow(args.A, POW2);

	    public double Pow3(Arguments args) => Math.Pow(args.A, POW3);
	}
}
