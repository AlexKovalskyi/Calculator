namespace CalculatorLib.CommonTypes
{
    public class Arguments
    {
        public double A { get; private set; }
        
        public double B { get; private set; }

		public Arguments(double firstNumb) : this(firstNumb, 0) { }

        public Arguments (double firstNumb, double secondNumb)
        {
            A = firstNumb;
            B = secondNumb;
        }
    }
}
