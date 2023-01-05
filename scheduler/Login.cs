using MySql.Data.MySqlClient;
using scheduler.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduler
{
    public partial class Login : Form
    {
        //Localization Variables
        ResourceManager rm = new ResourceManager("scheduler.Resources.Login.Strings", typeof(Login).Assembly);
        CultureInfo culture = CultureInfo.CurrentCulture;
        
        public Login()
        {
            InitializeComponent();

            //Form Component Adjustments
            //Buttons
            btn_Submit.FlatAppearance.BorderColor = Color.FromArgb(225, 114, 64);

            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //Transparent Border
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Localization
            culture = CultureInfo.CurrentCulture;

            //Labels
            lbl_Window.Text = rm.GetString("WindowTitle", culture);
            lbl_Window.Left = (this.ClientSize.Width - lbl_Window.Size.Width) / 2; //Maintains centered label position
            lbl_Username.Text = rm.GetString("Username", culture);
            lbl_Password.Text = rm.GetString("Password", culture);

            //Buttons
            btn_Submit.Text = rm.GetString("Submit", culture);
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "" ||
                tb_Password.Text == "")
            {
                MessageBox.Show("Please enter a username and password.");
            }
            else
            {
                bool result = Authentication.Login.AuthenticateUser(
                    tb_Username.Text.Trim(),
                    tb_Password.Text.Trim());

                if (result)
                {
                    MessageBox.Show("Login Successful!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login failed.");
                    lbl_ErrorText.Show();
                }
            }
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
    }
}
