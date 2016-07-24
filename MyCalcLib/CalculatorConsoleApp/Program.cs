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
			int answer;
			
			Console.WriteLine("Best of the best Calculator with 5 operation");
			while (true)
				{
				try
					{


					Console.WriteLine("Enter one of the operation : +, -, *, / ,%");
					char operation = Convert.ToChar(Console.ReadLine());
					Console.WriteLine("Write your first number: ");
					int firstNumber = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Write your second number: ");
					int secondNumber = Convert.ToInt32(Console.ReadLine());

					Arguments arguments = new Arguments(firstNumber, secondNumber);
					Calculator calc = new Calculator();
					if (operation == '+')
						{
						answer = calc.Sum(arguments);
						
						Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, answer);
						}
					else if (operation == '/')
						{
						answer = calc.Devide(arguments);
						Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, answer);
						}
					else if (operation == '*')
						{
						answer = calc.Multiply(arguments);
						Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, answer);
						}
					else if (operation == '-')
						{
						answer = calc.Substract(arguments);
						Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, answer);
						}
					else if (operation == '%')
						{
						answer = calc.Modulo(arguments);
						Console.WriteLine("{0} % {1} = {2}", firstNumber, secondNumber, answer);
						}
						
					}
				catch (Exception ex)
					{
					Console.WriteLine("Error: " + ex.Message);
					}
				
				}
			}
		
		}
}
