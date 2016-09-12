namespace CalculatorLib.Interfaces
{
    public interface IOutputService
    {
        void Print(double firstNumb, char operation, double secondNumb, double result);
        void PrintUnaryOperation(double firstNumb, char operation, double result);
    }
}