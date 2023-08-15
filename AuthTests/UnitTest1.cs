using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AuthTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = ProyectoConsola2.Program.Something();
            Assert.AreEqual("algo", result);
        }

        [TestMethod]

        public void TestLoginTrue()
        {
            bool result = ProyectoConsola2.Program.Login("carlos1", "123456");
            Assert.AreEqual(true, result);
        }


    }
}
