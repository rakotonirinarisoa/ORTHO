using Calculs_Orthologick.Interfaces;
using Calculs_Orthologick.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculs_Orthologick.Utils;

namespace Calculs_Orthologick
{
    public partial class Home : Form
    {
        private readonly ISalarieRepository salarie;
        private readonly IPrimeRepository prime;
        public Salarie sal;
        public Home(ISalarieRepository _salarie, IPrimeRepository _prime)
        {
            salarie = _salarie;
            prime = _prime;
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            dbContext.GetSageDBConnection();
            //var test = salarie.GetAllSalarie();
            //var sal = salarie.GetSalarieByMatricule("T022"); 
            //var tst = prime.GetAll();
            sal = salarie.GetSalarieByMatricule("T022");
           
            List<Prime> ar= new List<Prime>();
            ar.Add(new Prime()
            {
                Valeur = 40000,
                Type = "Cantine"
            });
            ar.Add(new Prime()
            {
                Valeur = 25000,
                Type = "Ecolage"
            });

            sal.Primes = ar;

            salarie.UpdatePrimeSalarie("T022",sal.Primes);
        }

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
