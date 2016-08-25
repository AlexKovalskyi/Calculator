namespace CalculatorLib.CommonTypes
{
    public class Arguments
    {
        public int A { get; private set; }
        
        public int B { get; private set; }

        public Arguments (int firstNumb, int secondNumb)
        {
            A = firstNumb;
            B = secondNumb;
        }
    }
}
