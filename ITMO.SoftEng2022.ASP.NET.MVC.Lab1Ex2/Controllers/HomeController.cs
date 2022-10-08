using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVCR1.Controllers
{
    //public class HomeController : Controller 
        public class MyController : Controller
    {
        // GET: HomeController
        // п.5
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //п.5
        //public string Index() //
        //public string Start() //  п.1.7, п.2.2
        public string Index(string hel) // п.2.2
        {
            int hour = DateTime.Now.Hour;
            //string Greeting = hour < 12 ? "Доброе утро" : "Добрый день"; // п.2.2
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день" + ", " + hel; // п.2.2
            return Greeting;
        }
    }
}