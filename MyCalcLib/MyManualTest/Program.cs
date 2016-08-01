using System;
using CalcLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedCodeSnippets.RefTypePassing;

namespace SharedCodeSnippets
{
    public delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
		{
			foreach (string item in args)
			{

			}
			OutputMethod();
			Console.ReadLine();
			//ReferenceTypeUsage.Run();
		}

		private static void OutputMethod()
		{
			// Настроить консольный интерфейс (CUI).
			Console.Title = "My Rocking App";
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.WriteLine("*************************************");
			Console.WriteLine("***** Welcome to My Rocking App *****");
			Console.WriteLine("*************************************");
			Console.BackgroundColor = ConsoleColor.Black;
			// Ожидать нажатия клавиши <Enter>.
		}
	}
}
