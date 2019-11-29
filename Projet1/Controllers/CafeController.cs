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
      
        public IActionResult Index()
        {
            using (var connection = new SqlConnection(ChaineConnexion))
            {
                var liste = connection.Query<MachineACafeEntity>("SELECT * FROM MachineACafe");

                return View(liste);
            }
        }

        public IActionResult Creer()
        {
            return View();
        }

        [HttpPost] //Attribut
        public IActionResult Creer(MachineACafeEntity nouveau)
        {
            if (ModelState.IsValid)
            {
                using (var connection = new SqlConnection(ChaineConnexion))
                {
                    nouveau.UserId = 1;
                    connection.Execute("INSERT INTO MachineACafe (Nom, Marque, Image, Prix, Disponible, UserId ) VALUES (@Nom, @Marque, @Image, @Prix, @Disponible, @UserId)", nouveau);
                }
                //Enregistrer les informations entrer dans le formulaire dans la bdd
                return RedirectToAction(nameof(Index));
            }
            return View();
        }


    }
}
