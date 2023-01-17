using System;
using MySql.Data.MySqlClient;
using scheduler.User;
using scheduler.Logging;

namespace scheduler.Database.Authentication
{
    internal class Login
    {
        public static bool AuthenticateUser(string userName, string password)
        {
            string userInfoQuery = @"SELECT userID, userName, password 
                                    FROM user 
                                    WHERE userName = @userName AND password = @password";
            string userAppointmentQuery = @"SELECT appointmentId 
                                            FROM appointment as a 
                                            LEFT JOIN (SELECT user.userId FROM USER) AS u 
                                            ON a.userId = u.userId
                                            WHERE a.userId = @userID";
            bool result = false;

            //Connection string is known at runtime and is stored in the DBConnection class
            using (MySqlConnection conn = new MySqlConnection(DBConnection.connStr))
            {
                //Connection opens for command execution
                conn.Open();

                //Retrieves userID and userName data
                using (MySqlCommand command = new MySqlCommand(userInfoQuery, conn))
                {
                    //Setting parameters for query string
                    command.Parameters.Add("@userName", MySqlDbType.VarChar).Value = userName;
                    command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                    //Sets the time stamp for log files
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
                        reader.Close();
                    }
                    else
                    {
                        //An unsuccessful login will return false, logging a failure to file.
                        Log.CreateLog(userName, queryTimestamp, result);
                        return result;
                    }
                }
                //Retrieves user appointment data using previously retrieved userID
                using (MySqlCommand command = new MySqlCommand(userAppointmentQuery, conn))
                {
                    //Setting parameters for query string
                    command.Parameters.Add("@userID", MySqlDbType.Int32).Value = ActiveUser.userInformation.UserID;

                    //Query data checks for a match and stores the result
                    MySqlDataReader reader = command.ExecuteReader();

                    //Loops through the reader and adding appointment IDs to ActiveUser appointment list
                    while (reader.Read())
                    {
                        ActiveUser.userInformation.appointments.Add((int)reader["appointmentId"]);
                    }
                }
            }
            //returns a successful Login attempt
            return result;
        }
    }
}