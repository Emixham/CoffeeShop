using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class MachineACafe
    {
        private string nom;
        private string marque;
        private string image;
        private float prix;
        private bool disponible;

        public MachineACafe()
        {

        }
        public MachineACafe(string nom, string marque, string image, float prix, bool disponible)
        {
            this.nom = nom;
            this.marque = marque;
            this.image = image;
            this.prix = prix;
            this.disponible = disponible;

        }

        public string GetNom()
        {
            return nom;
        }

        public string getNom2() => nom;

        public string Nom // Propriété avec getter et setter
        {
            get
            {
                return nom;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Le nom est trop court !");
                }
                nom = value;
            }
        }

        public string UrlHttps
        {
            get
            {
                return $"https://{image}";
            }
        }

    }
}
