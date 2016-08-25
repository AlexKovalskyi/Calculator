using CalculatorLib;
using CalculatorLib.CommonTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcLibTests
{
    [TestClass]
    public class ArgumentsModelTests
    {
        [TestMethod]
        public void CheckClassName()
        {
            var expectedName = "Arguments";

            var actualName = nameof(Arguments);

            Assert.AreEqual(expectedName, actualName);
        }
        
        [TestMethod]
        public void CheckArgAPropeprty()
        {
            var args = Activator.CreateInstance(typeof(Arguments), 33,1 );

            var exists = false;
            foreach (var prop in args.GetType().GetProperties())
            {
                if (prop.Name == "A")
                {
                    if (prop.PropertyType != typeof(int))
                    {
                        throw new Exception("Property is not type of int.");
                    }
                    exists = true;
                }
            }
            Assert.IsTrue(exists, "A property was not found.");
        }
        
        [TestMethod]
        public void CheckArgBPropeprty()
        {
            var args = Activator.CreateInstance(typeof(Arguments), 33, 1);

            var exists = false;
            foreach (var prop in args.GetType().GetProperties())
            {
                if (prop.Name == "B")
                {
                    if (prop.PropertyType != typeof(int))
                    {
                        throw new Exception("Property is not type of int.");
                    }
                    exists = true;
                }
            }

            Assert.IsTrue(exists, "B property was not found.");
        }

        [TestMethod]
        public void CheckConstructor()
        {
            var args = (Arguments)Activator.CreateInstance(typeof(Arguments), 33, 33);

            Assert.AreEqual(args.A, 33);
            Assert.AreEqual(args.B, 33);
        }
    }
}
