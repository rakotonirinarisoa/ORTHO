using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Calculs_Orthologick
{
    public class dbContext
    {
        public static SqlConnection AppSql = new SqlConnection();
        public static SqlConnection SageSql = new SqlConnection();
        
        public static SqlConnection GetDBConnection(string datasource, string database, string username, string password, string pwd)
        {
            string connexionString = "";
            if (string.IsNullOrEmpty(username))
                connexionString = @"Data Source =" + datasource + ";Initial Catalog=" + database + ";Integrated Security=SSPI;";
            else
                connexionString = @"Data Source =" + datasource + ";Initial Catalog=" + database + ";User ID=" + username + ";" + (!string.IsNullOrEmpty(password) ? "Password=" + password : "PwdCrypt=" + pwd) + ";Integrated Security=SSPI;";

            SqlConnection conn = new SqlConnection(connexionString);
            conn.Open();
            conn.Close();
            return conn;
        }

        public static void GetAppDBConnection()
        {
            dbContext.AppSql = GetDBConnection("FID-INF-PC", "Orthologick","sa","Soft123well!","");
        }

        public static void GetSageDBConnection()
        {
            dbContext.SageSql = GetDBConnection("FID-INF-PC", "DEMO_PAIE", "sa", "Soft123well!", "");
        }

    }
}
