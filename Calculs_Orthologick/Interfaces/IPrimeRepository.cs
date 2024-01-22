using Calculs_Orthologick.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculs_Orthologick.Interfaces
{
    public interface IPrimeRepository
    {
        Prime GetPrime(int id);
        List<Prime> GetAll();
        void UpdatePrime(Prime prime);
        void DeletePrime(int id);
        
    }
}
