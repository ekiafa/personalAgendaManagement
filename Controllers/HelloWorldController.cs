using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace personal_agenda_management
{
    public class HelloWorldController : Controller
    {

        //GET: /HelloWorld
        public IActionResult Index()
        {
            return View();
        }
        //GET: /HelloWorld/Welcome
        public IActionResult Welcome(string name,int number = 8)

        {
            ViewData["Message"] = "Hello" + name;
            ViewData["Message"]=number;
            return View();
        }



    }

}
