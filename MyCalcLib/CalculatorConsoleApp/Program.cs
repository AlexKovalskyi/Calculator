using CalcLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

			
			RunCalculator();
        }
       
        static void RunCalculator()
        {
			Console.WriteLine("Calculator with can only sum");
			Console.WriteLine("Write your first number: ");
			int firstNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Write your second number: ");
			int secondNumber = Convert.ToInt32(Console.ReadLine());

			Arguments arguments = new Arguments(firstNumber, secondNumber);
			Calculator calc = new Calculator();
			int answer = calc.Sum(arguments);
			
			Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, answer);
			Console.ReadLine();
			}
		}
}
