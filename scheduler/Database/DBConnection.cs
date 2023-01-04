﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduler.Database
{
    public class DBConnection
    {
        public static MySqlConnection conn { get; set; }

        public static void startConnection()
        {
            try
            {
                //Initialize and open the connection.
                string connStr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

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