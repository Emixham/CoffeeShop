using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class MachineACafeEntity
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Marque { get; set; }
        public string Image { get; set; }
        public float Prix { get; set; }
        public bool Disponible { get; set; }
        public int UserId { get; set; }

        public string UrlHttps => $"https://{Image}";


    }
}
