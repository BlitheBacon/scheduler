using System;
using System.Drawing;
using System.Globalization;
using System.Resources;
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
            //Button Adjustments and Localization
            btn_Submit.FlatAppearance.BorderColor = Color.FromArgb(225, 114, 64);
            btn_Submit.Text = rm.GetString("Submit", culture);
            
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //Transparent Border

            //Label Adjustments and Localization
            lbl_Window.Left = (this.ClientSize.Width - lbl_Window.Size.Width) / 2; //Maintains centered label position
            lbl_Window.Text = rm.GetString("WindowTitle", culture);

            lbl_ErrorText.Text = rm.GetString("ErrLoginFail", culture);
            lbl_ErrorText.Left = (this.ClientSize.Width - lbl_ErrorText.Size.Width) / 2; //Maintains centered label position

            lbl_Username.Text = rm.GetString("Username", culture);
            lbl_Password.Text = rm.GetString("Password", culture);
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "" ||
                tb_Password.Text == "")
            {
                MessageBox.Show(rm.GetString("ErrEnterCredentials", culture));
            }
            else
            {
                bool result = Database.Authentication.Login.AuthenticateUser(
                    tb_Username.Text.Trim(),
                    tb_Password.Text.Trim());

                if (result)
                {
                    this.Close();
                }
                else
                {
                    
                    lbl_ErrorText.Show();
                }
            }
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
        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
