using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVCR1.Controllers
{
    //public class HomeController : Controller 
        public class MyController : Controller // п.1.3
    {
        // GET: HomeController
        // п.5
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //п.5
        //public string Index() // п.1.7
            public string Start() // п.1.7
        {
            int hour = DateTime.Now.Hour;
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            return Greeting;
        }
    }
}