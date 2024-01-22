using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculs_Orthologick.Interfaces;
using Calculs_Orthologick.Models;

namespace Calculs_Orthologick
{
    public partial class Authentication : Form
    {
        private readonly IUserRepository user;
        private readonly ISalarieRepository salarie;
        private readonly IPrimeRepository prime;
        public Authentication(IUserRepository _user, ISalarieRepository _salarie, IPrimeRepository _prime)
        {
            user = _user;
            salarie = _salarie;
            prime = _prime;
            InitializeComponent();
            //this.prime = prime;
        }

        private void Authentication_Load(object sender, EventArgs e)
        {
            dbContext.GetAppDBConnection();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string Username = tb_Username.Text;
            string Password = tb_Password.Text;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Veuillez remplir les champs");
                return;
            }

            int id = user.Login(Username, Password);
            if (id != 0)
            {
                Home home = new Home(salarie,prime);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Une erreur s'est produite. Vérifiez vos identifiants");
            }
        }

		private void tb_Password_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
