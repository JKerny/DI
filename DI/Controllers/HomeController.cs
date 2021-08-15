using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DI.Models;
using DI.Services;

namespace DI.Controllers
{
    public class HomeController : Controller
    {        
        private readonly ICounter Counter;
        public HomeController(ICounter counter)
        {
            Counter = counter;
        }

        [HttpGet]
        public IActionResult Index()
        {                      
            return View();
        }

        [HttpPost]
        public IActionResult Index(CountModel model)
        {
            Counter.Count++;            
            return View();
        }       
    }
}
