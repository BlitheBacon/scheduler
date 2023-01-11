using MySql.Data.MySqlClient;
using scheduler.Database;
using System;
using System.Windows.Forms;

namespace scheduler.Authentication
{
    internal class Login
    {
        public static bool AuthenticateUser(string userName, string password)
        {
            string query = "Select userID, userName, password from user Where userName = @userName and password = @password";
            bool result = false;

            //Connection string is known at runtime and is stored in the DBConnection class
            using (MySqlConnection conn = new MySqlConnection(DBConnection.connStr))
            {
                using(MySqlCommand command = new MySqlCommand(query, conn))
                {
                    //Setting parameters for query string.
                    command.Parameters.Add("@userName", MySqlDbType.VarChar).Value = userName;
                    command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                    //Connection opens for command execution
                    conn.Open();

                    //Query data checks for a match and stores the result
                    MySqlDataReader reader = command.ExecuteReader();
                    result = reader.Read();

                    /*
                    *  When authentication succeeds, an activeUser is initialized and stored in the associated class with
                    *  the associated userID, userName, and password. The positive boolean is then returned to the
                    *  caller. Otherwise, will return a negative result and prompt user for correct credentials.
                    */
                    if (result)
                    {
                        uint userID = reader.GetUInt32(0); //Assigned to userID the 0th column value: "userID"
                        ActiveUserInformation.activeUser = new ActiveUserInformation(userID, userName, password);
                        return result;
                    }
                    return result;
                }
            }
        }
    }
}