using CalculatorLib.Interfaces;
using System;
using System.IO;

namespace CalculatorLab.IOServices
{
	public class FileOutputService : IOutputService
	{
		private const bool IS_APPENDABLE = true;
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

		public void Print(double firstNumb, char operation, double secondNumb, double result)
		{
			using(StreamWriter streamWriter = new StreamWriter(fullPath, IS_APPENDABLE))
			{
				streamWriter.WriteLine("{0} {1} {2} = {3}", firstNumb, operation, secondNumb, result);
			}
		}

	    public void PrintUnaryOperation(double firstNumb, char operation, double result)
	    {
	        throw new NotImplementedException();
	    }
	}
}
