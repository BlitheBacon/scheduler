using scheduler.Database;
using scheduler.Forms;
using System;
using System.Windows.Forms;

namespace scheduler
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Create database connection prior to the running of the first window
            //to ensure it is usable immediately.
            DbConnection.StartConnection();

            //The login form for authentication.
            var formLogin = new Login();
            formLogin.ShowDialog();

            //Start the main application
            Application.Run(new Main());


            //Database connection is severed after the application is closed.
            DbConnection.CloseConnection();
        }
    }
}
