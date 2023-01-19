using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace scheduler.Database
{
    public class DbConnection
    {
        public static MySqlConnection Conn { get; set; }

        //Found within the 'App.config' file.
        public static string ConnStr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        public static void StartConnection()
        {
            try
            {
                //Initialize and open the connection.
                Conn = new MySqlConnection(ConnStr);
                Conn.Open();

                //Debugging messages
                //MessageBox.Show("Connection is open.");
            }
            catch (MySqlException mysqlEx)
            {
                //Generic MySQLException handler.
                MessageBox.Show(mysqlEx.Message);
            }
        }

        public static void CloseConnection()
        {
            try
            {
                if (Conn != null)
                {
                    Conn.Close();

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
