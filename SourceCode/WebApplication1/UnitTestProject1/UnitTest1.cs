using System;
using WebApplication1.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DisplayCustomer()
        {
            MyFirstController obj = new MyFirstController();
            var result = obj.DisplayCustomer();
            Assert.AreEqual("DisplayCustomer", result.ViewName);
        }
    }
}
