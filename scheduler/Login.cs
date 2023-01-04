using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduler
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            //Form Component Adjustments
            //Buttons
            btn_Submit.FlatAppearance.BorderColor = Color.FromArgb(225, 114, 64);

            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //Transparent Border
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
          Enables window click-and-drag functionality without a title bar
        */
        //-----------------------------------------------------------------------
        //Variables
        private bool mouseDown;
        private Point lastLocation;

        //Functions
        private void LogIn_Event_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void LogIn_Event_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void LogIn_Event_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        //-----------------------------------------------------------------------

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
