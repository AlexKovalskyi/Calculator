using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcLib
{
    public enum OperationType
    {
        One = 1,
        Two = 0,
        Three = 2,
        Four = 4,
        Nothing
    }

    public class CodeSample
    {
        public OperationType GetTypeFromSwitch()
        {
            var operationType = OperationType.Three;
            int returnedValueType = -1;

            switch (operationType)
            {
                    case OperationType.Three:
                        Console.WriteLine("Some methods...");
                    break;
                    case OperationType.Two:
                        returnedValueType = (int)OperationType.Two;
                    break;

            }

            return (OperationType)returnedValueType;
        }
    }

}
