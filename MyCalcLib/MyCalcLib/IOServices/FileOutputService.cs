using CalculatorLib.Interfaces;
using System;
using System.IO;

namespace CalculatorLab.IOServices
{
	public class FileOutputService : IOutputService
	{
		private const bool APPENDABLE = true;
		private string _outputFile;
		private string fullPath;

		private void Initialize()
		{
			fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _outputFile);
		}

		public FileOutputService(string outputFile)
		{
			_outputFile = outputFile;
			Initialize();
		}

		public void Print(int firstNumb, char operation, int secondNumb, int result)
		{
			using(StreamWriter streamWriter = new StreamWriter(fullPath, APPENDABLE))
			{
				streamWriter.WriteLine("{0} {1} {2} = {3}", firstNumb, operation, secondNumb, result);
			}
		}
	}
}
