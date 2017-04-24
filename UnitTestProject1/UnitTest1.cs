using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MainApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        HelloConsole sayHello = new HelloConsole();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreSame("hellopath", sayHello.PathSelector());
        }

        [TestMethod]
        public void TestMethod2()
        {
            string path = sayHello.GetConfigurationPath();
            int i = path.CompareTo("..\\..\\..\\..\\helloCrowe\\helloCrowe\\bin\\Debug\\helloCrowe.exe");
            Assert.AreEqual(0, i);
        }
    }
}
