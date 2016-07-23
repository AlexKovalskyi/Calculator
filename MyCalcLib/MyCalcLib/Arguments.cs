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
        //TODO: Set access.
        public int A { get; set; }
        
        public int B { get; set; }

        public Arguments(int firstNumb, int secondNumb)
        {
            A = firstNumb;
            B = secondNumb;
        }
    }
}
