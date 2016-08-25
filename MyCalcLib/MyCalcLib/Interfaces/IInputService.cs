using CalculatorLib.CommonTypes;

namespace CalculatorLib.Interfaces
{
    public interface IInputService
    {
        Arguments ReadArgs();
        OperationType ReadOperations();
    }
}