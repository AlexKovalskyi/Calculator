using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
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
