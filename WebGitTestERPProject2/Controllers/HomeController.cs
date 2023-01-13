using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGitTestERPProject2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.data1 = "Hello Ganesh.........";
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact() 
        {
            TempData["key1"]="TempData value1";
            return View();
        }   
    }
}