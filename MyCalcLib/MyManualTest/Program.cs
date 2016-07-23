using System;
using CalcLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyManualTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Arguments arguments = new Arguments(33, 3);

            SomeCode(arguments);

            Console.WriteLine(arguments.A + " " + arguments.B);
            var res = arguments.A * arguments.B;
            Assert.AreEqual(res, 99);
            Console.WriteLine(res);
        }













        static void SomeCode(Arguments arg)
        {
            Console.WriteLine(arg.A);
            Console.WriteLine(arg.A);
        }
    }
}
