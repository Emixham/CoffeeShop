using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Dapper;
using CoffeeShop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoffeeShop.Controllers
{
    public class CafeController : Controller
    {
        const string ChaineConnexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kenny\source\repos\CoffeeShop\Projet1\Data\DataCoffee.mdf;Integrated Security=True;Connect Timeout=30";
        private IMachineRepo repo;

        public CafeController(IMachineRepo repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View(repo.All);
        }

        public IActionResult Creer()
        {
            return View();
        }

        public IActionResult Details(int id)
        { 
            var machinecafe = repo.GetById(id);

            if (machinecafe == null)
            {
                return NotFound();
            }
            else
            {
                return View(machinecafe);
            }
     
        }

        [HttpPost] //Attribut
        public IActionResult Creer(MachineACafeEntity nouveau)
        {
            if (ModelState.IsValid)
            {


                nouveau.UserId = 1;
                repo.Save(nouveau);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }


    }
}
