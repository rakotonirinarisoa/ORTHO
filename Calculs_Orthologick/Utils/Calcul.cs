using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculs_Orthologick.Interfaces;
using Calculs_Orthologick.Models;
using Calculs_Orthologick.Repositories;

namespace Calculs_Orthologick.Utils
{
    public class Calcul
    {
        public static double CalculPrimeNet(IPrimeRepository _prime, int idPrime, int NBJour)
        {
            Prime prime = _prime.GetPrime(idPrime);
            return prime.Valeur * NBJour;
        }

        public static double TotalPrimeNet(params double[] primes) 
        {
            return primes.Sum();
        }

        //total primes net + net (fiche de paie)
        public static double TotalNet(params double[] net)
        {
            return net.Sum();
        }

        public double BrutSubstraction(double totalBrut, double Brut)
        {
            return Brut - totalBrut;
        }

        public static double PrimeBrut(double difference, double netRub, double totalNet)
        {
            return (difference * netRub) / totalNet;
        }

    }
}
