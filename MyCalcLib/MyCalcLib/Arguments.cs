using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
{
	//TODO: * INFO: This class will contain just arguments for calulator operations. Such types of data very often called 'model'.

	public class Arguments
		{
		public int A { get; set; }
		public int B { get; set; }

		public  Arguments ( int firstNumb, int secondNumb ) {
			A = firstNumb;
			B = secondNumb;	
		}
	}
}
