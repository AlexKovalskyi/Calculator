using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyManualTest
{
    public static class DelegateExample
    {
        public static void Run()
        { 
            MyDelegate del = new MyDelegate(Print);
            del += Print;
            del += Print;
            del += Print;
            del += Print;
            del += Print;
            del += Print;
            del += Print;

            foreach (var methodToInvoke in del.GetInvocationList())
            {
                Console.WriteLine(methodToInvoke.Method);
            }

            //del.Invoke(); 
        }

        static void Print()
        {
            Console.WriteLine("Print was invoked ... ");
        }
    }
}
