using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcLib
{
    public class Calculator  //change clss name
    {
		public int Sum ( int x, int y )
		{
			return x + y;
		}

        public int Substract(int a, int b)
        {
			return a - b;
        }

        public int Multiply(int a, int b)
        {
			return a * b;
        }

        public int Devide(int a, int b)  // add new meyhod
        {
            return a-b;
        }
    }
}
