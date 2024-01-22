using Calculs_Orthologick.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculs_Orthologick.Interfaces
{
    public interface ISalarieRepository
    {
        List<Salarie> GetAllSalarie();
        void UpdatePrimeSalarie(string MatriculeSalarie, List<Prime> primes);
        Salarie GetSalarieByMatricule(string matricule);

    }
}
