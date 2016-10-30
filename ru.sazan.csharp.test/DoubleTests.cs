using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ru.sazan.csharp.test
{
    [TestClass]
    public class DoubleTests
    {
        public double Price;

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
