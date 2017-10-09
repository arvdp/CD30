using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var r = new Hi();
            Assert.AreEqual(r.result("HELLO"), "WORLD");
        }
        [TestMethod]
        public void TestMethod2()
        {
            var r = new Hi();
            Assert.AreEqual(r.result("ONZIN"), "INVALID");
        }
    }
}
