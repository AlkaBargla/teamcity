using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MyFirstController : Controller
    {
        // GET: MyFirst
        public ActionResult Index()
        {
            ViewData["CurrentTime"] = DateTime.Now.ToString();
            return View("HelloView");
        }

        public ActionResult SayHello()
        {
            return View("HelloView");
        }

        public ViewResult DisplayCustomer()
        {
            Customer objcust = new Customer();
            objcust.Id = 12;
            objcust.CustomerCode = "1001";
            objcust.Amount = 90.34;

            return View("DisplayCustomer", objcust);
        }
        
    }
}