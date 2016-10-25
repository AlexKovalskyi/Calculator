using System;
using static GlobalLogger.GLogger;
using CalculatorLib.CommonTypes;
using CalculatorLib.Interfaces;
using System.Text.RegularExpressions;

namespace CalculatorLib.IOServices
{
	public class UIInputService : IInputService
	{
		private double firstNumber;
		private double secondNumber;
		private string expression;
		private OperationType operation;

        public UIInputService(string expression)
		{
			this.expression = expression;
			GetExpressionMembers();
		}
        private void GetExpressionMembers()
        {
            try
            {
                Logger.Info("Reading expression members.");
                string[] expressionMembers = Regex.Split(expression, (@"^(\d{0,10})\s{0,}([*-^\/√%+]{1})\s{0,10}(\d{0,})$"));
                Logger.Info("Set first number.");
                firstNumber = Convert.ToDouble(expressionMembers[1]);
                string operationSymbol = expressionMembers[2];
                Logger.Info("Set operation symbol.");
                if (operationSymbol == "^")
                {
                    string poverIndicator = expressionMembers[3];
                    if (poverIndicator == "2")
                    {
                        operation = OperationType.Pow2;
                    }
                    else if (poverIndicator == "3")
                    {
                        operation = OperationType.Pow3;
                    }
                    else
                    {
                        Logger.Warn("Set wrong operation");
                        throw new ArgumentException(nameof(operation), "Wrong operation.");
                    }
                    Logger.Info("Set operation pocer indicator for operation {0}.", operationSymbol);
                }
                else if (operationSymbol == "√")
                {
                    operation = OperationType.Sqrt;
                    Logger.Info($"Set operation {operation}.");
                }
                else
                {
                    operation = (OperationType)Convert.ToChar(expressionMembers[2]);
                    Logger.Info("Set operstion {0}", operation);
                    secondNumber = Convert.ToDouble(expressionMembers[3]);
                    Logger.Info("Set  second number");
                }
            }
            catch (Exception ex)
            {
                Logger.Warn("GetExpressionMembers crashed down.");
                throw new InvalidOperationException(nameof(GetExpressionMembers), ex);
            }
        }

        public Arguments ReadArgs()
		{
			Arguments arguments = new Arguments(firstNumber, secondNumber);
			return arguments;
		}

		public OperationType ReadOperations()
		{
			return operation;
		}
	}
}
