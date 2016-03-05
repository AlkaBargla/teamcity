using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WebApplication1.Controllers;

namespace UnitTest_NUnit
{
    [TestFixture]
    public class Class1
    {
       [Test]
        public void DisplayCustomer()
        {
            MyFirstController obj = new MyFirstController();
            var result = obj.DisplayCustomer();
            Assert.AreEqual("DisplayCustomer", result.ViewName);
        }

    }
}
