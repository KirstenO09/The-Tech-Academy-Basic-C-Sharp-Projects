using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\hf3984\sample\log.txt", text);

            //Random rnd = new Random(10);
            //int num = rnd.Next();

            //ViewBag.RandomNumber = num;
            //if (num > 20000)
            //{
            //    return View();
            //}
            // return Content("Hello");
            //return RedirectToAction("Contact");

            //List<string> names = new List<string>()
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett",                
            //};
            //return View(names);

            //int number = 5;
            //return View(number);

            User user = new User();
            user.Id = 1;
            user.FirstName = "Kirsten";
            user.LastName = "Osborne";
            user.Age = 23;
            return View(user);


            //return View();
        }

        public ActionResult About()
        {
            //throw new Exception("Invalid Page");
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(/*int id=0*/)
        {
            //ViewBag.Message = id;
            
            ViewBag.Message = "Your contact page.";
            
            return View();
        }
    }
}