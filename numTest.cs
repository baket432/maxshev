using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace num.Test
{
    [TestClass]
    public class numTest
    {
        [TestMethod]
        public void SumTest()
        {
            string x = "А321УЕ76";

            bool expected = true;

            num a = new num();
            bool actual = a.qwe(x);

            Assert.AreEqual(expected, actual);

        }
    }
}
