using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstAPP.Models;

namespace firstAPP.Controllers
{
    public class personalController : Controller
    {
       

        public IActionResult Index ()
    { 
      personal personal = new personal();
        personal.name = "Erick";
        personal.lastname = "Cano";
        personal.age = 30;

        return View(personal);
        
     }   
    }
}