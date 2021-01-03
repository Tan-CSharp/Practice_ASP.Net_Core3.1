using _01_FirstApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_FirstApplication.Controllers
{
    public class FirstController : Controller
    {
        public string Index()
        {
            return "Index";
        }

        public IActionResult Hello()
        {
            ViewBag.Message = "Hello World";
            return View();
        }
        public IActionResult Info()
        {
            Person person = new Person();
            person.Name = "John";
            person.Age = 18;
            person.Location = "United States";
            return View(person);
        }
    }
}
