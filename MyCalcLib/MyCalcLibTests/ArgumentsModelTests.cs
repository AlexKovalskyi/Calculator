using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcLib;
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

        ////TODO: 2 Create property 'A' in the class with arguments.
        //[TestMethod]
        //public void CheckArgAPropeprty()
        //{
        //    var args = Activator.CreateInstance(typeof(Arguments));

        //    var exists = false;
        //    foreach (var prop in args.GetType().GetProperties())
        //    {
        //        if (prop.Name == "A")
        //        {
        //            if (prop.PropertyType != typeof(int))
        //            {
        //                throw new Exception("Property is not type of int.");
        //            }
        //        }
        //    }
        //    Assert.IsTrue(exists, "A property was not found.");
        //}

        ////TODO: 3 Create property 'B' in the class with arguments.
        //[TestMethod]
        //public void CheckArgBPropeprty()
        //{
        //    var args = Activator.CreateInstance(typeof(Arguments));

        //    var exists = false;
        //    foreach (var prop in args.GetType().GetProperties())
        //    {
        //        if (prop.Name == "B")
        //        {
        //            if (prop.PropertyType != typeof(int))
        //            {
        //                throw new Exception("Property is not type of int.");
        //            }
        //        }
        //    }

        //    Assert.IsTrue(exists, "B property was not found.");
        //}

        //TODO: 4.1 Uncomment this after above tests are passing.
        //TODO: 4.2 Create constructor with passing arguments 'a' and 'b' and assing them to properties.
        //[TestMethod]
        //public void CheckConstructor()
        //{
        //    var args = Activator.CreateInstance(typeof(UndefinedClass), 33, 33);

        //    Assert.AreEqual(args.A, 33);
        //    Assert.AreEqual(args.B, 33);
        //}
    }
}
