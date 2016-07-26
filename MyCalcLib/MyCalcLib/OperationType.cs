using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcLib
{
    public enum OperationType
    {
        Sum = '+',
        Sub = '-',
        Mul = '*',
        Dev = '/',
        Mod = '%'
    }

	public class CodeSample
	{
		public OperationType GetTypeFromSwitch()
		{
			var operationType = OperationType.Sum;
			int returnedValueType = -1;

			switch (operationType)
			{
				case OperationType.Sum:
					op;
					break;
				case OperationType.Two:
					returnedValueType = (int)OperationType.Two;
					break;

			}

			return (OperationType)returnedValueType;
		}
	}

}
