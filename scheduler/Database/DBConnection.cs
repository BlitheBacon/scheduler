using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace scheduler.Database
{
    public class DBConnection
    {
        public static MySqlConnection conn { get; set; }

        //Found within the 'App.config' file.
        public static string connStr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        public static void startConnection()
        {
            try
            {
                //Initialize and open the connection.
                conn = new MySqlConnection(connStr);
                conn.Open();

                //Debugging messages
                //MessageBox.Show("Conection is open.");
            }
            catch (MySqlException mysqlEx)
            {
                //Generic MySQLException handler.
                MessageBox.Show(mysqlEx.Message);
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();

                    //Debugging messages
                    //MessageBox.Show("Connection Closed.");
                }
            }
            catch (MySqlException mySqlException)
            {
                //Generic MySQLException handler.
                MessageBox.Show(mySqlException.Message);
            }
            
        }
    }
}
