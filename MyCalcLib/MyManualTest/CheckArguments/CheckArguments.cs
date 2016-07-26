﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcLib;

namespace SharedCodeSnippets.notes
{
    static class CheckArguments
	{
		static void ArgumentsCheck()
		{
			Arguments arguments = new Arguments(33, 3);

			SomeCode(arguments);

			Console.WriteLine(arguments.A + " " + arguments.B);
			var res = arguments.A * arguments.B;
			Assert.AreEqual(res, 99);
			Console.WriteLine(res);
		}

		static void SomeCode(Arguments arg)
		{
			Console.WriteLine(arg.A);
			Console.WriteLine(arg.A);
		}
	}
}