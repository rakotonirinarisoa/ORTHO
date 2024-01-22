using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculs_Orthologick.Models
{
    public class Salarie
    {
        public string MatriculeSalarie { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public virtual List<Prime> Primes { get; set; }

    }
}
