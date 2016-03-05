using System;
using WebApplication1.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;



namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void DisplayCustomer()
        {
            MyFirstController obj = new MyFirstController();
            var result = obj.DisplayCustomer();
            NUnit.Framework.Assert.AreEqual("DisplayCustomer", result.ViewName);
        }
    }
}
