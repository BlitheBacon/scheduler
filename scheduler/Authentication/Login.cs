using MySql.Data.MySqlClient;
using scheduler.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduler.Authentication
{
    internal class Login
    {
        public static bool AuthenticateUser(string userName, string password)
        {
            string query = "Select * from user Where userName = @userName and password = @password";
            bool result = false;

            using (MySqlConnection conn = new MySqlConnection(DBConnection.connStr))
            {
                using(MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.Add("@userName", MySqlDbType.VarChar).Value = userName;
                    command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                    conn.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    result = reader.Read();
                }
            }

            if (result)
            {
                return result;
            }
            return result;
        }
    }
}