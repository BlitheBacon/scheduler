using scheduler.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduler
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Create database connection prior to the running of the first window
            //to ensure is usable immediately.
            DBConnection.startConnection();

            //The login form for authentication.
            Application.Run(new Login());

            Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.CreateSpecificCulture("de");

            //Main window hidden until authentication is confirmed.

            //Database connection is severed after the application is closed.
            DBConnection.closeConnection();
        }
    }
}
