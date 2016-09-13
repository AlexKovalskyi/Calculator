using CalculatorLib.CommonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	class Program
	{
		static void Main(string[] args)
		{
			Func<int> func = () =>
			{
				Console.WriteLine("Hello world");
				return 0;
			};
			func();
			Func<int, int> func2;
				
		}
	}
	public class Calculator
	{
		private const int POW2 = 2;
		private const int POW3 = 3;

		private Dictionary<OperationType, Func<Arguments, double>> operationsDic = new Dictionary<OperationType, Func<Arguments, double>>
		{
			{ OperationType.Sum, args => args.A + args.B },
			{ OperationType.Sub, args => args.A - args.B },
			{ OperationType.Mul, args => args.A * args.B },
			{ OperationType.Div, args => args.A / args.B },
			{ OperationType.Mod, args => args.A % args.B },
			{ OperationType.Sqrt, args => Math.Sqrt(args.A) },
			{ OperationType.Pow2, args => Math.Pow(args.A, POW2) },
			{ OperationType.Pow3, args => Math.Pow(args.A, POW3) }
		};

		public void AddOperation(OperationType operationType, Func<Arguments, double> value)
		{
			operationsDic.Add(operationType, value);
		}

		public void RemoveOperation(OperationType operationType)
		{
			operationsDic.Remove(operationType);
		}
	}
}
