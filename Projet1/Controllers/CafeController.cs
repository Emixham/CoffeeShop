using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projet1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Projet1.Controllers
{
    public class CafeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var offres = new List<MachineACafe>()
            {
                new MachineACafe(1, "Mac 1"),
                new MachineACafe(2, "Mac 2"),
                new MachineACafe(3, "Mac 3")
            };
            return View(offres);
        }
    }
}
