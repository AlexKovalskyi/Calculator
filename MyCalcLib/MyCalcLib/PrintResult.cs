﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    //TODO: Rename
	public class PrintResult
	{
		public void Print(int firstNumb, char operation, int secondNumb, int result)
		{
			Console.WriteLine("{0} {1} {2} = {3}", firstNumb, operation, secondNumb, result);
		}
	}
}
