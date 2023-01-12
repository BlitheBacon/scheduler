using scheduler.Database;
using scheduler.User;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace scheduler.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            //Labels
            lbl_LoggedInUser.Text = ActiveUser.userInformation.UserName;
            lbl_userID.Text = ActiveUser.userInformation.UserID.ToString();

            //Form Component Adjustments
            //Button Adjustments and Localization
            btn_Minimize.FlatAppearance.BorderColor = Color.FromArgb(252, 245, 245);
            btn_Maximize.FlatAppearance.BorderColor = Color.FromArgb(252, 245, 245);
            btn_Close.FlatAppearance.BorderColor    = Color.FromArgb(252, 245, 245);
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Call required DB queries
            Customer.PopulateData();
        }

        /* Enables window click-and-drag functionality without a title bar */
        //Variables
        private bool mouseDown;
        private Point lastLocation;

        //Functions
        private void Main_Event_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void Main_Event_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void Main_Event_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void timer_DateTimeLabel_Tick(object sender, EventArgs e)
        {
            lbl_TimeLocal.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_DateLocal.Text = DateTime.Now.ToString("dddd | MM-dd-yyyy |");
        }
        //-----------------------------------------------------------------------

        /* Task bar buttons */
        private void btn_MinimizeClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        private void btn_MaximizeClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        private void btn_CloseClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //----------------------------------------------------------------------------

        private void tab_Home_Click(object sender, EventArgs e)
        {

        }
    }
}
