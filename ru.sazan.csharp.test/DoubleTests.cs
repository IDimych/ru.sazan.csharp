using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ru.sazan.csharp.test
{
    [TestClass]
    public class DoubleTests
    {
        public double Price;
        public double Amount;

        [TestInitialize]
        public void Setup()
        {
            Amount = 10;
        }

        [TestMethod]
        public void doubles_multiplication_tests()
         {
            Price = 2.5;
            double sum = Price * Amount;
            Assert.AreEqual(25, sum);
        }

        [TestMethod]
        public void default_Price_value_test()
        {
            Assert.AreEqual(0, Price);
        }

        [TestMethod]
        public void change_Price_value_test()
        {
            Price = 55.01;
            Assert.AreEqual(55.01, Price);
        }
    }
}
