using Calculs_Orthologick.Interfaces;
using Calculs_Orthologick.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Calculs_Orthologick.Repositories
{
    public class SalarieRepository : ISalarieRepository
    {
        public Salarie GetSalarieByMatricule(string matricule)
        {
            string sql = "SELECT MatriculeSalarie, Nom, Prenom FROM T_SAL where MatriculeSalarie=@MatriculeSalarie";
            SqlCommand cmd = new SqlCommand(sql,dbContext.SageSql);

            cmd.Parameters.AddWithValue("@MatriculeSalarie", matricule);
            dbContext.SageSql.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Salarie salarie = new Salarie()
                    {
                        MatriculeSalarie = reader["MatriculeSalarie"].ToString(),
                        Nom = reader["Nom"].ToString(),
                        Prenom = reader["Prenom"].ToString()
                    };
                    return salarie;
                }
            }
            dbContext.SageSql.Close();
            return null;
        }

        List<Salarie> ISalarieRepository.GetAllSalarie()
        {
            string sql = "SELECT MatriculeSalarie, Nom, Prenom FROM T_SAL";
            SqlCommand cmd = new SqlCommand(sql, dbContext.SageSql);

            dbContext.SageSql.Open();
            List<Salarie> SalarieList = new List<Salarie>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    SalarieList.Add(new Salarie()
                    {
                        MatriculeSalarie = reader["MatriculeSalarie"].ToString(),
                        Nom = reader["Nom"].ToString(),
                        Prenom = reader["Prenom"].ToString()
                    });
                   
                }
            }
            dbContext.SageSql.Close();
            return SalarieList;
                      
        }

        void ISalarieRepository.UpdatePrimeSalarie(string MatriculeSalarie,List<Prime> primes)
        {
            try
            {
                 dbContext.AppSql.Open();
                foreach (Prime prime in primes)
                {
                    string sql = "SELECT IdPrime_Sal FROM Primes_Sal WHERE Id=@Id AND MatriculeSalarie=@MatriculeSalarie";
                    SqlCommand cmd = new SqlCommand(sql, dbContext.AppSql);

                    cmd.Parameters.AddWithValue("Id", prime.Id);
                    cmd.Parameters.AddWithValue("MatriculeSalarie", MatriculeSalarie);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string sql1 = "UPDATE Primes_Sal SET Valeur=@Valeur WHERE Id=@Id AND MatriculeSalarie=@MatriculeSalarie";
                            SqlCommand cmd1 = new SqlCommand(sql1, dbContext.AppSql);
                            cmd.Parameters.AddWithValue("Id", prime.Id);
                            cmd.Parameters.AddWithValue("MatriculeSalarie", MatriculeSalarie);
                            cmd1.ExecuteNonQuery();
                        }
                        else
                        {
                            string sql1 = "INSERT INTO Primes_Sal (Id,MatriculeSalarie) values(@Id,@MatriculeSalarie)";
                            SqlCommand cmd1 = new SqlCommand(sql1, dbContext.AppSql);
                            cmd.Parameters.AddWithValue("Id", prime.Id);
                            cmd.Parameters.AddWithValue("MatriculeSalarie", MatriculeSalarie);
                            cmd1.ExecuteNonQuery();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
            }
            finally
            {
                dbContext.AppSql.Close();
            }
        }
    }
}
