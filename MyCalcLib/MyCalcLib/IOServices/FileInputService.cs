using CalculatorLib.Interfaces;
using System;
using CalculatorLib.CommonTypes;
using System.IO;

namespace CalculatorLab.IOServices
{
	public class FileInputService : IInputService
	{
		private string _filePath;
		private string[] tasks;
		private int cursor;

		public FileInputService(string filePath)
		{
			_filePath = filePath;
			ReadTask();
		}
		
		private void ReadTask()
		{
			using (StreamReader streamReader = new StreamReader(_filePath))
			{
				string task = streamReader.ReadToEnd();
				tasks = task.Split('\n');
			}
		}

		public Arguments ReadArgs()
		{
			if (cursor >= tasks.Length)
			{
				return null;
			}
			string[] symbol = tasks[cursor].Split(' ');
			double firstNumber = Convert.ToInt32(symbol[0]);
			double secondNumber = Convert.ToInt32(symbol[2]);
			Arguments arguments = new Arguments(firstNumber, secondNumber);
			cursor++;

			return arguments;
		}

		public OperationType ReadOperations()
		{
			if (cursor < tasks.Length)
			{
				string[] symbol = tasks[cursor].Split(' ');

				return (OperationType)Convert.ToChar(symbol[1]);
			}
			else
			{
				return OperationType.NOP;
			}
		}
	}
}
