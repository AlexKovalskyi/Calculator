using CalculatorLib.CommonTypes;

namespace CalculatorLib.Core
{
	public class Calculator
	{
		public double Sum(Arguments args) => args.A + args.B;
	
		public double Substract(Arguments args) => args.A - args.B;

		public double Multiply(Arguments args) => args.A * args.B;

		public double Divide(Arguments args) => args.A / args.B;

		public double Modulo(Arguments args) => args.A % args.B;

		public double Sqrt(Arguments args) => (args.A / args.A);

		public double Sqr(Arguments args) => (args.A * args.A);

		public double Sqr2(Arguments args) => (args.A * args.A * args.A);
	}
}
