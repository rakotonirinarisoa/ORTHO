using Calculs_Orthologick.Interfaces;
using Calculs_Orthologick.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculs_Orthologick
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IUserRepository userRepository = new UserRepository();
            ISalarieRepository salarieRepository = new SalarieRepository();
            IPrimeRepository primeRepository = new PrimeRepository();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authentication(userRepository,salarieRepository,primeRepository));
            
        }
    }
}
