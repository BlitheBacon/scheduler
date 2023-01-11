using System;
using MySql.Data.MySqlClient;
using scheduler.Database;
using scheduler.Logging;

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
                    DateTime queryTimestamp = DateTime.UtcNow;

                    //Query data checks for a match and stores the result
                    MySqlDataReader reader = command.ExecuteReader();
                    result = reader.Read();

                    /*
                    *  When authentication succeeds, an activeUser is initialized and stored with
                    *  the associated userID and userName. A log of the successful attempt is written to 
                    *  file. The positive boolean is then returned to the caller.
                    */
                    if (result)
                    {
                        uint userID = reader.GetUInt32(0); //Assigned to userID the 0th column value: "userID"
                        ActiveUser.userInformation = new ActiveUser(userID, userName);

                        Log.CreateLog(userName, queryTimestamp, result);
                        return result;
                    }

                    //An unsuccessful login will return false, logging a failure to file.
                    Log.CreateLog(userName, queryTimestamp, result);
                    return result;
                }
            }
        }
    }
}