using Calculs_Orthologick.Interfaces;
using Calculs_Orthologick.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Calculs_Orthologick.Repositories
{
    public class PrimeRepository : IPrimeRepository
    {
        void IPrimeRepository.DeletePrime(int Id)
        {
            try
            {
                string sql = "DELETE FROM Primes where Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, dbContext.AppSql);

                dbContext.AppSql.Open();
                cmd.Parameters.AddWithValue("Id", Id);

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
            }
            finally
            {
                dbContext.AppSql.Close();
            }
        }

        List<Prime> IPrimeRepository.GetAll()
        {
            string sql = "SELECT Id, Type, Valeur FROM Primes";
            SqlCommand cmd = new SqlCommand(sql, dbContext.AppSql);

            dbContext.AppSql.Open();
            List<Prime> PrimeList = new List<Prime>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    PrimeList.Add(new Prime()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Type = reader["Type"].ToString(),
                        Valeur = float.Parse(reader["Valeur"].ToString())
                        //Valeur = Convert.ToDouble(reader["Value"])
                    });

                }
            }
            dbContext.AppSql.Close();
            return PrimeList;
        }

        Prime IPrimeRepository.GetPrime(int id)
        {
            string sql = "SELECT Id, Type, Valeur FROM Primes where Id=@Id";
            SqlCommand cmd = new SqlCommand(sql, dbContext.AppSql);

            cmd.Parameters.AddWithValue("Id", id);
            dbContext.AppSql.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                   Prime prime = new Prime()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Type = reader["Type"].ToString(),
                        Valeur = float.Parse(reader["Valeur"].ToString())
                    };
                    dbContext.AppSql.Close();
                    return prime;
                }
            }
            dbContext.AppSql.Close();
            return null;
           
        }

        void IPrimeRepository.UpdatePrime(Prime prime)
        {
            try
            {
                string sql = "UPDATE Primes SET Type=@Type, Valeur=@Valeur where Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, dbContext.AppSql);

                dbContext.AppSql.Open();
                cmd.Parameters.AddWithValue("Id", prime.Id);
                cmd.Parameters.AddWithValue("Type", prime.Type);
                cmd.Parameters.AddWithValue("Valeur", prime.Valeur);

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
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
