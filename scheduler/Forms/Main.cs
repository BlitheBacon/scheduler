using scheduler.Customers;
using scheduler.User;
using System;
using scheduler.Database;
using System.Drawing;
using System.Windows.Forms;

namespace scheduler.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            //Queries
            //Populates ActiveUser
            Database.Query.Select.CustomerData();

            //Populates Appointment data for customers relevant to ActiveUser
            Database.Query.Select.AppointmentData(ActiveUser.UserInformation.UserId);

            /* Tab Control - Tab Initialization */
            //Home Tab----------------------------

            //Upcoming Appointments DGV
            //DGV Styling
            dgv_upcomingAppointments.AutoGenerateColumns = false;
            dgv_upcomingAppointments.DefaultCellStyle.Font = new Font("Arial", 12);
            dgv_upcomingAppointments.ColumnCount = 4;
            dgv_upcomingAppointments.AutoResizeColumns();

            //Setting the Data Source
            var upcomingAppointmentsTable = new BindingSource();
            upcomingAppointmentsTable.DataSource = Appointment.AllAppointments;
            dgv_upcomingAppointments.DataSource = upcomingAppointmentsTable;

            //Adjusting Show Columns
            dgv_upcomingAppointments.Columns[0].Name = "Appointment Time";                      //Start Time
            dgv_upcomingAppointments.Columns[0].DataPropertyName = "Start";
            dgv_upcomingAppointments.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy HH:MM";

            dgv_upcomingAppointments.Columns[1].Name = "Customer";                              //Customer Name
            dgv_upcomingAppointments.Columns[1].DataPropertyName = "Name";

            dgv_upcomingAppointments.Columns[2].Name = "Title";                                 //Appointment Title
            dgv_upcomingAppointments.Columns[2].DataPropertyName = "Title";

            dgv_upcomingAppointments.Columns[3].Name = "Type";                                  //Appointment Type
            dgv_upcomingAppointments.Columns[3].DataPropertyName = "Type";

            //Customers Tab-----------------------



            //Customer Names LV
            dgv_customerTab_Appointments.DefaultCellStyle.Font = new Font("Arial", 12);

            lv_customerTab_customerNames.View = View.Details;
            lv_customerTab_customerNames.Columns.Add("Name");
            lv_customerTab_customerNames.Columns[0].Width = -1;

            foreach (var customer in Customer.CustomerDict)
            {
                lv_customerTab_customerNames.Items.Add(customer.Value.CustomerName);
            }

            //Schedule Tab-----------------------
            dtPicker_ScheduleTab_StartDate.MinDate = DateTime.Now;
            dtPicker_ScheduleTab_StartTime.MinDate = DateTime.Now.AddMinutes(30);

            lv_ScheduleTab_customerNames.View = View.Details;
            lv_ScheduleTab_customerNames.Columns.Add("Name");
            lv_ScheduleTab_customerNames.Columns[0].Width = -1;

            foreach (var customer in Customer.CustomerDict)
            {
                lv_ScheduleTab_customerNames.Items.Add(customer.Value.CustomerName);
            }






            //Labels
            //Welcome message
            lbl_LoggedInUserMsg.Text = $"Welcome back, {ActiveUser.UserInformation.UserName}. " + 
                                       $"It's {DateTime.Now.ToString("dddd")}, the {DateTime.Now.ToString("dd")}. " +
                                       $"You have {ActiveUser.UserInformation.Appointments.Count} upcoming appointments.";
            //User ID
            lbl_userID.Text = $"User ID: {ActiveUser.UserInformation.UserId.ToString()}";

            //Form Component Adjustments
            //Title bar button styling
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
        }


        /* Enables window click-and-drag functionality without a title bar */
        //Variables
        private bool _mouseDown;
        private Point _lastLocation;

        //Functions
        private void Main_Event_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }
        private void Main_Event_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_mouseDown) return;
            this.Location = new Point(
                (this.Location.X - _lastLocation.X) + e.X,
                (this.Location.Y - _lastLocation.Y) + e.Y);
            this.Update();
        }
        private void Main_Event_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void timer_DateTimeLabel_Tick(object sender, EventArgs e)
        {
            lbl_TimeLocal.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_DateLocal.Text = DateTime.Now.ToString("MM-dd-yyyy");
        }
        //-----------------------------------------------------------------------

        /* Task bar buttons */
        private void btn_MinimizeClick(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Minimized : FormWindowState.Normal;
        }
        private void btn_MaximizeClick(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }
        private void btn_CloseClick(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        //----------------------------------------------------------------------------

        private void tab_Home_Click(object sender, EventArgs e)
        {

        }

        private void lv_Names_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Creates a DataGridView based on selected customer in ListView
            if (lv_customerTab_customerNames.SelectedItems.Count > 0)
            {
                try
                {
                    //Grabs the currently selected customer's information
                    var customer = Customer.CustomerLookup(lv_customerTab_customerNames.SelectedItems[0].Text);
  
                    //Binds the data source of the newly created DataGridView based on selected customer
                    var customerAppointmentsTable = new BindingSource();
                    customerAppointmentsTable.DataSource = Customer.FillAppointments(customer.CustomerId); //Creates a temp list of relevant appointments
                    dgv_customerTab_Appointments.DataSource = customerAppointmentsTable;

                    dgv_customerTab_Appointments.AutoResizeColumns();
                    dgv_customerTab_Appointments.ClearSelection();                                         //Removes row selection for a cleaner appearance

                    //Lazily queries relevant address data for the selected customer to populate the textboxes
                    Database.Query.Select.AddressData(customer.CustomerId);
                    
                    //Textboxes for relevant customer data
                    tb_customerTab_Name.Text             = customer.CustomerName;
                    tb_customerTab_ID.Text               = customer.CustomerId.ToString();
                    tb_customerTab_PrimaryAddress.Text   = customer.PrimaryAddress.AddressOne;
                    tb_customerTab_SecondaryAddress.Text = customer.PrimaryAddress.AddressTwo;
                    tb_customerTab_PostalCode.Text       = customer.PrimaryAddress.PostalCode;
                    tb_customerTab_PhoneNumber.Text      = customer.PrimaryAddress.PhoneNumber;
                    tb_customerTab_City.Text             = customer.PrimaryAddress.City;
                    tb_customerTab_Country.Text          = customer.PrimaryAddress.Country;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_customerTab_Save_Click(object sender, EventArgs e)
        {
            if (lv_customerTab_customerNames.SelectedItems.Count > 0)
            {
                //Passes Textbox text as parameters to the CustomerData Function which are passed as query parameters.
                Database.Query.Update.CustomerData(
                    int.Parse(tb_customerTab_ID.Text),
                    tb_customerTab_PrimaryAddress.Text,
                    tb_customerTab_SecondaryAddress.Text,
                    tb_customerTab_City.Text,
                    tb_customerTab_Country.Text,
                    tb_customerTab_PostalCode.Text,
                    tb_customerTab_PhoneNumber.Text
                );
            }
            else
            {
                Database.Query.Insert.CustomerData(
                    ActiveUser.UserInformation.UserName,
                    tb_customerTab_Name.Text,
                    tb_customerTab_PrimaryAddress.Text,
                    tb_customerTab_SecondaryAddress.Text,
                    tb_customerTab_City.Text,
                    tb_customerTab_Country.Text,
                    tb_customerTab_PostalCode.Text,
                    tb_customerTab_PhoneNumber.Text
                );
            }


            //Show/hide context specific buttons
            btn_customerTab_Edit.Visible = true;
            btn_customerTab_New.Visible = true;
            btn_customerTab_Save.Visible = false;
            btn_customerTab_Cancel.Visible = false;
        }

        private void dtPicker_ScheduleTab_Time_ValueChanged(object sender, EventArgs e)
        {
            //Reference objects for readability
            DateTime start = dtPicker_ScheduleTab_StartTime.Value;
            DateTime end = dtPicker_ScheduleTab_EndTime.Value;

            TimeSpan ts = new TimeSpan(0, 15, 0); //A 15 minute time span

            //Determines if end time occurs within timespan
            if (end.Date - start.Date < ts)       
            {
                //If true, add the absolute value of that difference to end.Hours
                var diff = end.Hour - start.Hour;
                if (diff < 0) { end = end.AddHours(Math.Abs(diff)); }
                
            }
            //Sets the minimum day to Now and time to (start + timespan)
            dtPicker_ScheduleTab_EndDate.MinDate = DateTime.Now;
            dtPicker_ScheduleTab_EndTime.MinDate = start.Add(ts);
        }

        private void lv_ScheduleTab_customerNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Creates a DataGridView based on selected customer in ListView
            if (lv_ScheduleTab_customerNames.SelectedItems.Count > 0)
            {
                try
                {
                    //Grabs the currently selected customer's information
                    var customer = Customer.CustomerLookup(lv_ScheduleTab_customerNames.SelectedItems[0].Text);
                    /*
                    //Binds the data source of the newly created DataGridView based on selected customer
                    var customerAppointmentsTable = new BindingSource();
                    customerAppointmentsTable.DataSource = Customer.FillAppointments(customer.CustomerId); //Creates a temp list of relevant appointments
                    dgv_customerTab_Appointments.DataSource = customerAppointmentsTable;

                    dgv_customerTab_Appointments.AutoResizeColumns();
                    dgv_customerTab_Appointments.ClearSelection();                                         //Removes row selection for a cleaner appearance
                    */
                    //Lazily queries relevant address data for the selected customer to populate the textboxes

                    //Textboxes for relevant customer data
                    tb_ScheduleTab_Title.Text = Appointment.AllAppointments[customer.CustomerId].Title;
                    tb_ScheduleTab_Description.Text = Appointment.AllAppointments[customer.CustomerId].Description;
                    tb_ScheduleTab_Contact.Text = Appointment.AllAppointments[customer.CustomerId].Contact;
                    tb_ScheduleTab_Location.Text = Appointment.AllAppointments[customer.CustomerId].Location;
                    cb_ScheduleTab_Type.Text = Appointment.AllAppointments[customer.CustomerId].Type;
                    tb_ScheduleTab_Url.Text = Appointment.AllAppointments[customer.CustomerId].Url;
                    dtPicker_ScheduleTab_StartDate.Value = Appointment.AllAppointments[customer.CustomerId].Start;
                    dtPicker_ScheduleTab_EndDate.Value = Appointment.AllAppointments[customer.CustomerId].End;
                    dtPicker_ScheduleTab_StartTime.Value = Appointment.AllAppointments[customer.CustomerId].Start;
                    dtPicker_ScheduleTab_EndTime.Value = Appointment.AllAppointments[customer.CustomerId].End;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_customerTab_New_Click(object sender, EventArgs e)
        {
            lv_customerTab_customerNames.SelectedItems.Clear();

            tb_customerTab_Name.Clear();
            tb_customerTab_ID.Clear();
            tb_customerTab_PrimaryAddress.Clear();
            tb_customerTab_SecondaryAddress.Clear();
            tb_customerTab_PostalCode.Clear();
            tb_customerTab_PhoneNumber.Clear();
            tb_customerTab_City.Clear();
            tb_customerTab_Country.Clear();

            //Show/hide context specific buttons
            btn_customerTab_Edit.Visible = false;
            btn_customerTab_New.Visible = false;
            btn_customerTab_Save.Visible = true;
            btn_customerTab_Cancel.Visible = true;

        }

        private void btn_customerTab_Edit_Click(object sender, EventArgs e)
        {
            //Show/hide context specific buttons
            btn_customerTab_Edit.Visible = false;
            btn_customerTab_New.Visible = false;
            btn_customerTab_Save.Visible = true;
            btn_customerTab_Cancel.Visible = true;
        }

        private void btn_customerTab_Cancel_Click(object sender, EventArgs e)
        {
            //Show/hide context specific buttons
            btn_customerTab_Edit.Visible = true;
            btn_customerTab_New.Visible = true;
            btn_customerTab_Save.Visible = false;
            btn_customerTab_Cancel.Visible = false;
        }
    }
}
