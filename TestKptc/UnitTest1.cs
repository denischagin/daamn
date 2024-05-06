using KptcLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestKptc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 3;
            int b = Class1.LibraryTestMethod(1, 2);
            Assert.AreEqual(a, b, "Сложение не работает");
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = -3;
            int b = Class1.LibraryTestMethod(-1, -2);
            Assert.AreEqual(a, b, "Сложение не работает");
        }
        [TestMethod]
        public void TestMethod3()
        {
            int a = -3;
            int b = Class1.LibraryTestMethod(1, 3);
            Assert.AreNotEqual(a, b, "Сложение не работает");
        }
        [TestMethod]
        public void TestMethod4()
        {
            int a = -1;
            int b = Class1.LibraryTestMethod(1, -2);
            Assert.AreEqual(a, b, "Сложение не работает");
        }

    }
}
