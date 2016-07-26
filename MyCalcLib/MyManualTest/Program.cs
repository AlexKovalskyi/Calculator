using System;
using CalcLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedCodeSnippets.RefTypePassing;

namespace SharedCodeSnippets
{
    public delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            ReferenceTypeUsage.Run();
        }
    }
}
