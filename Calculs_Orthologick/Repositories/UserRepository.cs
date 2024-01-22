using Calculs_Orthologick.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculs_Orthologick.Repositories
{
    public class UserRepository : IUserRepository
    {
        int IUserRepository.Login(string Username, string Password)
        {
            string sql = "SELECT Id FROM Users WHERE Username=@Username and Password=@Password";
            SqlCommand cmd = new SqlCommand(sql, dbContext.AppSql);

            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            dbContext.AppSql.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    int Id = Convert.ToInt32(reader["Id"]);
                    return Id;
                }
            }
            dbContext.AppSql.Close();
            return 0;
        }
    }
}
