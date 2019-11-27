using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet1.Models
{
    public class MachineACafe
    {
        private string titre;
        private int id;

        public MachineACafe(int id, string titre)
        {
            this.titre = titre;
            this.id = id;


        }
        public int Id => id;
        public string Titre => titre;

    }
}
