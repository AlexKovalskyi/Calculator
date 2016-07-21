using System;
//TODO: Delete namespaces wich are not in use.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: 0 Delete 'My'
namespace MyCalcLib
{
	//TODO: * Info: While changing class name, physical file didn't changed. So it confuses when the name of file and the name of type in file are different.
	public class Calculator
	{
		//TODO: You can simplify short methods like this...
		public int Sum(int x, int y) => x + y;

		public int Substract(int a, int b) // It is called as 'lamda function' with '=>' - lamda operator
		{
			return a - b;
		}

		public int Multiply(int a, int b) // And here
		{
			return a * b;
		}

		public int Devide(int a, int b) // And here
		{
			return a - b;
		}

		public int Modulo(int a, int b) // And here
		{
			throw new NotImplementedException();
		}
	}
}
