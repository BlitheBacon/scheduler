using scheduler.Customers;
using scheduler.Reports;
using scheduler.User;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace scheduler.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            //Queries for data needed at initialization
            #region Queries

            //Populates Customers
            Database.Query.Select.CustomerData();
            Database.Query.Select.CountryData();

            //Populates Appointment data for customers relevant to ActiveUser
            Database.Query.Select.AppointmentData(ActiveUser.UserInformation.UserId);

            #endregion

            /* Tab Initial Setup */
            #region HomeTab
            //User ID
            lbl_userID.Text = $"User ID: {ActiveUser.UserInformation.UserId}";

            //Form Component Adjustments
            //Title bar button styling
            btn_Minimize.FlatAppearance.BorderColor = Color.FromArgb(252, 245, 245);
            btn_Maximize.FlatAppearance.BorderColor = Color.FromArgb(252, 245, 245);
            btn_Close.FlatAppearance.BorderColor = Color.FromArgb(252, 245, 245);

            //DGV Style
            dgv_allAppointments.DefaultCellStyle.Font = new Font("Arial", 12);
            dgv_allAppointments.AutoResizeColumns();

            //Sets the dateTimePicker defaults to Today - A week from today
            dt_homeTab_from.Value = DateTime.Today;
            dt_homeTab_to.Value = DateTime.Today.AddDays(7);

            //Initializes the sources of the table and DGV
            var allAppointmentsTable = new BindingSource();
            allAppointmentsTable.DataSource = Appointment.AllAppointmentsSource;
            dgv_allAppointments.DataSource = allAppointmentsTable;

            //Welcome message
            lbl_LoggedInUserMsg.Text = $"Welcome back, {ActiveUser.UserInformation.UserName}. " +
                                       $"It's {DateTime.Now.ToString("dddd")}, the {DateTime.Now.ToString("dd")}. ";
            #endregion

            #region ScheduleTab
            //Setting the source for the type combo box
            cb_ScheduleTab_Type.DataSource = Appointment.AppointmentTypes;

            //Styling the DataGridView
            dgv_ScheduleTab_Appointments.DefaultCellStyle.Font = new Font("Arial", 12);

            //Styling the ListView
            lv_scheduleTab_customerNames.View = View.Details;
            lv_scheduleTab_customerNames.Columns.Add("Name");
            lv_scheduleTab_customerNames.Columns[0].Width = -1;

            //Populating the ListView
            foreach (var customer in Customer.CustomerDict)
            {
                lv_scheduleTab_customerNames.Items.Add(customer.Value.CustomerName);
            }
            #endregion

            #region CustomerTab
            dgv_customerTab_Appointments.DefaultCellStyle.Font = new Font("Arial", 12);

            lv_customerTab_customerNames.View = View.Details;
            lv_customerTab_customerNames.Columns.Add("Name");
            lv_customerTab_customerNames.Columns[0].Width = -1;

            foreach (var customer in Customer.CustomerDict)
            {
                lv_customerTab_customerNames.Items.Add(customer.Value.CustomerName);
            }
            #endregion

            #region ReportTab
            //Appointment Type Report
            cb_reportsTab_type.DataSource = Appointment.AppointmentTypes;
            cb_reportsTab_month.DataSource = DateTimeFormatInfo.CurrentInfo.MonthNames;

            //Report DataGridView
            var reportsTable = new BindingSource();
            reportsTable.DataSource = null;
            dgv_reportsTab_reportTable.DataSource = reportsTable;
            #endregion
        }
        /* Custom title bar buttons */
        #region TitleBar
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
        #endregion
        
        /* Contains  */
        #region MainFormEvents
        private void Main_Load(object sender, EventArgs e)
        {
        }
        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void timer_DateTimeLabel_Tick(object sender, EventArgs e)
        {
            //Keeps the clock label updating in realtime
            lbl_TimeLocal.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_DateLocal.Text = DateTime.Now.ToString("MM-dd-yyyy");
        }
        #endregion

        /* Enables window click-and-drag functionality without a title bar */
        #region ClickAndDrag
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
        #endregion

        /* Home Tab controls and Events */
        #region HomeTab
        private void Main_Shown(object sender, EventArgs e)
        {
            //Runs the appointment notification check
            foreach (var appointment in Appointment.AllAppointments)
            {
                TimeSpan difference = appointment.Start.Subtract(DateTime.Now);
                if (difference > new TimeSpan(0, 0, 0, 0) && difference <= new TimeSpan(0, 0, 15, 0))
                {
                    MessageBox.Show($"You have an upcoming appointment with {appointment.Name} in {difference.Minutes} minutes.");
                }
            }
        }
        private void dt_homeTab_ValueChanged(object sender, EventArgs e)
        {
            //Checking for TZ difference and applying offset for business hours if one exists
            var offset = TimeZoneInfo.Local.BaseUtcOffset;
            offset = offset.Add(new TimeSpan(5, 0, 0));

            Appointment.AllAppointmentsSource.Clear();
            foreach (var appointment in Appointment.AllAppointments)
            {
                var dt_homeTab_toCheck = dt_homeTab_to.Value.Date.AddHours(18 + offset.Hours);
                var dt_homeTab_fromCheck = dt_homeTab_from.Value.Date.AddHours(10 + offset.Hours);
                if (DateTime.Compare(appointment.Start, dt_homeTab_toCheck) <= 0 &&
                    DateTime.Compare(appointment.Start, dt_homeTab_fromCheck) >= 0
                    && appointment.End > DateTime.Now)
                {
                    Appointment.AllAppointmentsSource.Add(appointment);
                }
            }
        }
        private void tabControl_Main_TabIndexChanged(object sender, EventArgs e)
        {
            //Checking for TZ difference and applying offset for business hours if one exists
            var offset = TimeZoneInfo.Local.BaseUtcOffset;
            offset = offset.Add(new TimeSpan(5, 0, 0));

            Appointment.AllAppointmentsSource.Clear();
            foreach (var appointment in Appointment.AllAppointments)
            {
                var dt_homeTab_toCheck = dt_homeTab_to.Value.Date.AddHours(18 + offset.Hours);
                var dt_homeTab_fromCheck = dt_homeTab_from.Value.Date.AddHours(10 + offset.Hours);
                if (DateTime.Compare(appointment.Start, dt_homeTab_toCheck) <= 0 &&
                    DateTime.Compare(appointment.Start, dt_homeTab_fromCheck) >= 0
                    && appointment.End > DateTime.Now)
                {
                    Appointment.AllAppointmentsSource.Add(appointment);
                }
            }
        }

        private void dgv_allAppointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is DateTime dt)
            {
                e.Value = dt.ToUniversalTime();
                e.Value = dt.ToLocalTime();
            }
        }
        #endregion

        /* Schedule Tab Controls and Events */
        #region ScheduleTab
        Customer _customer;

        //Will fire on t_scheduleTab_DtPickers_Tick
        private void dtPicker_ScheduleTab_Time_ValueChanged(object sender, EventArgs e)
        {
            //Forces minimum start date to current date
            if (dtPicker_ScheduleTab_StartDate.Value.Date < DateTime.Now.Date)
            {
                dtPicker_ScheduleTab_StartDate.Value = DateTime.Now.Date;
            }
            //Forces minimum start time to current time
            if (dtPicker_ScheduleTab_StartTime.Value.TimeOfDay < DateTime.Now.TimeOfDay)
            {
                dtPicker_ScheduleTab_StartTime.Value = DateTime.Now;
            }
        }

        private void lv_ScheduleTab_customerNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears the appointment list to ensure no duplicates are created
            Customer.Appointments.Clear();

            //Creates a DataGridView based on selected customer in ListView
            if (lv_scheduleTab_customerNames.SelectedItems.Count > 0)
            {
                try
                {
                    //Grabs the currently selected customer's information
                    _customer = Customer.CustomerLookup(lv_scheduleTab_customerNames.SelectedItems[0].Text);

                    //Binds the data source of the newly created DataGridView based on selected customer
                    var scheduleAppointmentsTable = new BindingSource();
                    scheduleAppointmentsTable.DataSource = Customer.FillAppointments(_customer.CustomerId); //Creates a temp list of relevant appointments
                    dgv_ScheduleTab_Appointments.DataSource = scheduleAppointmentsTable;

                    dgv_ScheduleTab_Appointments.AutoResizeColumns();
                    dgv_ScheduleTab_Appointments.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgv_ScheduleTab_Appointments_SelectionChanged(object sender, EventArgs e)
        {
            //Creates a DataGridView based on selected customer in ListView
            if (dgv_ScheduleTab_Appointments.SelectedRows.Count > 0)
            {
                try
                {
                    //Grabs the currently selected customer's information
                    var appointment = Customer.AppointmentLookup((int)dgv_ScheduleTab_Appointments.SelectedRows[0].Cells[0].Value);

                    //Textboxes for relevant customer data
                    tb_ScheduleTab_Title.Text            = appointment.Title;
                    tb_ScheduleTab_Description.Text      = appointment.Description;
                    tb_ScheduleTab_Contact.Text          = appointment.Contact;
                    tb_ScheduleTab_Location.Text         = appointment.Location;
                    cb_ScheduleTab_Type.Text             = appointment.Type;
                    tb_ScheduleTab_Url.Text              = appointment.Url;
                    dtPicker_ScheduleTab_StartDate.Value = appointment.Start.Date;
                    dtPicker_ScheduleTab_EndDate.Value   = appointment.End.Date;
                    dtPicker_ScheduleTab_StartTime.Value = appointment.Start;
                    dtPicker_ScheduleTab_EndTime.Value   = appointment.End;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_scheduleTab_New_Click(object sender, EventArgs e)
        {
            //Show/hide context specific buttons
            btn_scheduleTab_New.Visible = false;
            btn_scheduleTab_Edit.Visible = false;
            btn_scheduleTab_Delete.Visible = false;
            btn_scheduleTab_Save.Visible = true;
            btn_scheduleTab_Cancel.Visible = true;

            //Allows editability
            tb_ScheduleTab_Title.Enabled = true;
            tb_ScheduleTab_Location.Enabled = true;
            tb_ScheduleTab_Description.Enabled = true;
            tb_ScheduleTab_Contact.Enabled = true;
            cb_ScheduleTab_Type.Enabled = true;
            tb_ScheduleTab_Url.Enabled = true;
            dtPicker_ScheduleTab_StartDate.Enabled = true;
            dtPicker_ScheduleTab_StartTime.Enabled = true;
            dtPicker_ScheduleTab_EndDate.Enabled = true;
            dtPicker_ScheduleTab_EndTime.Enabled = true;
            
            if (dgv_ScheduleTab_Appointments.Rows.Count > 0)
            {
                //Clears selected appointment to allow for contextual save function
                dgv_ScheduleTab_Appointments.ClearSelection();
                tb_ScheduleTab_Title.Clear();
                tb_ScheduleTab_Location.Clear();
                tb_ScheduleTab_Description.Clear();
                tb_ScheduleTab_Contact.Clear();
                tb_ScheduleTab_Url.Clear();
                dtPicker_ScheduleTab_StartDate.Value = DateTime.Now;
                dtPicker_ScheduleTab_EndDate.Value = DateTime.Now;
            }
        }

        private void btn_ScheduleTab_Save_Click(object sender, EventArgs e)
        {
            var appointmentId = (dgv_ScheduleTab_Appointments.SelectedRows.Count > 0) ? (int)dgv_ScheduleTab_Appointments.SelectedRows[0].Cells[0].Value : -1;
            //Outputs error messages if appointment fails any check, otherwise save appointment
            switch (Appointment.ValidAppointmentChecks(_customer, appointmentId, 
                        dtPicker_ScheduleTab_StartDate.Value, dtPicker_ScheduleTab_StartTime.Value,
                        dtPicker_ScheduleTab_EndDate.Value, dtPicker_ScheduleTab_EndTime.Value))
            {
                case -1:
                    MessageBox.Show("Appointment must be between Monday through Friday.");
                    return;
                case -2:
                    MessageBox.Show("Appointment must be within business hours:\n10AM - 6PM.");
                    return;
                case -3:
                    MessageBox.Show("Please select a customer.");
                    return;
                case -4:
                    MessageBox.Show("Appointment cannot start before it ends.");
                    return;
                case -5:
                    MessageBox.Show("Appointments cannot overlap.");
                    return;
                case 0:
                    //Show/hide context specific buttons
                    btn_scheduleTab_New.Visible = true;
                    btn_scheduleTab_Edit.Visible = true;
                    btn_scheduleTab_Delete.Visible = true;
                    btn_scheduleTab_Save.Visible = false;
                    btn_scheduleTab_Cancel.Visible = false;

                    //If a user is selected, update the selected user's record, otherwise, insert a new record
                    if (dgv_ScheduleTab_Appointments.SelectedRows.Count > 0)
                    {
                        Database.Query.Update.AppointmentData(
                            _customer.CustomerId,
                            (int)dgv_ScheduleTab_Appointments.SelectedRows[0].Cells[0].Value,
                            tb_ScheduleTab_Title.Text,
                            tb_ScheduleTab_Location.Text,
                            tb_ScheduleTab_Description.Text,
                            tb_ScheduleTab_Contact.Text,
                            cb_ScheduleTab_Type.Text,
                            tb_ScheduleTab_Url.Text,
                            dtPicker_ScheduleTab_StartDate.Value,
                            dtPicker_ScheduleTab_StartTime.Value,
                            dtPicker_ScheduleTab_EndDate.Value,
                            dtPicker_ScheduleTab_EndTime.Value
                        );

                        //Removes editability
                        tb_ScheduleTab_Title.Enabled = false;
                        tb_ScheduleTab_Location.Enabled = false;
                        tb_ScheduleTab_Description.Enabled = false;
                        tb_ScheduleTab_Contact.Enabled = false;
                        cb_ScheduleTab_Type.Enabled = false;
                        tb_ScheduleTab_Url.Enabled = false;
                        dtPicker_ScheduleTab_StartDate.Enabled = false;
                        dtPicker_ScheduleTab_StartTime.Enabled = false;
                        dtPicker_ScheduleTab_EndDate.Enabled = false;
                        dtPicker_ScheduleTab_EndTime.Enabled = false;
                    }
                    else
                    {
                        Database.Query.Insert.AppointmentData(
                            _customer.CustomerId,
                            tb_ScheduleTab_Title.Text,
                            tb_ScheduleTab_Location.Text,
                            tb_ScheduleTab_Description.Text,
                            tb_ScheduleTab_Contact.Text,
                            cb_ScheduleTab_Type.Text,
                            tb_ScheduleTab_Url.Text,
                            dtPicker_ScheduleTab_StartDate.Value,
                            dtPicker_ScheduleTab_StartTime.Value,
                            dtPicker_ScheduleTab_EndDate.Value,
                            dtPicker_ScheduleTab_EndTime.Value
                        );

                        //Removes editability
                        tb_ScheduleTab_Title.Enabled = false;
                        tb_ScheduleTab_Location.Enabled = false;
                        tb_ScheduleTab_Description.Enabled = false;
                        tb_ScheduleTab_Contact.Enabled = false;
                        cb_ScheduleTab_Type.Enabled = false;
                        tb_ScheduleTab_Url.Enabled = false;
                        dtPicker_ScheduleTab_StartDate.Enabled = false;
                        dtPicker_ScheduleTab_StartTime.Enabled = false;
                        dtPicker_ScheduleTab_EndDate.Enabled = false;
                        dtPicker_ScheduleTab_EndTime.Enabled = false;
                    }
                    break;
            }

            //Retrieves updated Appointment information and then clears the outdated lists
            ActiveUser.UserInformation.Appointments.Clear();
            Customer.Appointments.Clear();
            Database.Query.Select.AppointmentData(ActiveUser.UserInformation.UserId);

            //Binds the data source of the newly created DataGridView based on selected customer
            var scheduleAppointmentsTable = new BindingSource();

            //Creates a temp list of relevant appointments
            scheduleAppointmentsTable.DataSource = Customer.FillAppointments(_customer.CustomerId); 
            dgv_ScheduleTab_Appointments.DataSource = scheduleAppointmentsTable;

            //Repopulates the User Appointment List
            foreach (var appointment in Appointment.AllAppointments)
            {
                ActiveUser.UserInformation.Appointments.Add(appointment.AppointmentId);
            }
            //Restyles the DataGridView
            dgv_ScheduleTab_Appointments.AutoResizeColumns();
            dgv_ScheduleTab_Appointments.ClearSelection();
        }

        private void btn_scheduleTab_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_ScheduleTab_Appointments.SelectedRows.Count > 0)
            {
                //Show/hide context specific buttons
                btn_scheduleTab_New.Visible = false;
                btn_scheduleTab_Edit.Visible = false;
                btn_scheduleTab_Delete.Visible = false;
                btn_scheduleTab_Save.Visible = true;
                btn_scheduleTab_Cancel.Visible = true;

                //Allows editability
                tb_ScheduleTab_Title.Enabled = true;
                tb_ScheduleTab_Location.Enabled = true;
                tb_ScheduleTab_Description.Enabled = true;
                tb_ScheduleTab_Contact.Enabled = true;
                cb_ScheduleTab_Type.Enabled = true;
                tb_ScheduleTab_Url.Enabled = true;
                dtPicker_ScheduleTab_StartDate.Enabled = true;
                dtPicker_ScheduleTab_StartTime.Enabled = true;
                dtPicker_ScheduleTab_EndDate.Enabled = true;
                dtPicker_ScheduleTab_EndTime.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select a customer record to edit.");
            }
        }

        private void btn_scheduleTab_Delete_Click(object sender, EventArgs e)
        {
            //Checks if no customer is selected, then if selected customer has any appointments.
            //Deletion occurs if both are false
            if (dgv_ScheduleTab_Appointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to delete.");
                return;
            }

            //Requires the user to confirm the deletion
            DialogResult dialogResult = MessageBox.Show(
                $"Are you sure you want to delete {tb_customerTab_Name.Text}?",
                "Confirm: Delete Customer", MessageBoxButtons.YesNo);
            
            //If confirmed, continue with appointment deletion
            if (dialogResult == DialogResult.Yes)
            {
                Database.Query.Delete.AppointmentData((int)dgv_ScheduleTab_Appointments.SelectedRows[0].Cells[0].Value);
            }

            //Show/hide context specific buttons
            btn_scheduleTab_New.Visible = true;
            btn_scheduleTab_Edit.Visible = true;
            btn_scheduleTab_Delete.Visible = true;
            btn_scheduleTab_Save.Visible = false;
            btn_scheduleTab_Cancel.Visible = false;

            //Removes editability
            tb_ScheduleTab_Title.Enabled = false;
            tb_ScheduleTab_Location.Enabled = false;
            tb_ScheduleTab_Description.Enabled = false;
            tb_ScheduleTab_Contact.Enabled = false;
            cb_ScheduleTab_Type.Enabled = false;
            tb_ScheduleTab_Url.Enabled = false;
            dtPicker_ScheduleTab_StartDate.Enabled = false;
            dtPicker_ScheduleTab_StartTime.Enabled = false;
            dtPicker_ScheduleTab_EndDate.Enabled = false;
            dtPicker_ScheduleTab_EndTime.Enabled = false;

            //Retrieves updated Appointment information and then clears the outdated lists
            ActiveUser.UserInformation.Appointments.Clear();
            Customer.Appointments.Clear();
            Database.Query.Select.AppointmentData(ActiveUser.UserInformation.UserId);

            //Binds the data source of the newly created DataGridView based on selected customer
            var scheduleAppointmentsTable = new BindingSource();
            scheduleAppointmentsTable.DataSource = Customer.FillAppointments(_customer.CustomerId); //Creates a temp list of relevant appointments
            dgv_ScheduleTab_Appointments.DataSource = scheduleAppointmentsTable;

            //Repopulates the User Appointment List
            foreach (var appointment in Appointment.AllAppointments)
            {
                ActiveUser.UserInformation.Appointments.Add(appointment.AppointmentId);
            }

            //Restyles the DataGridView
            dgv_ScheduleTab_Appointments.AutoResizeColumns();
            dgv_ScheduleTab_Appointments.ClearSelection();
        }

        private void btn_ScheduleTab_Cancel_Click(object sender, EventArgs e)
        {
            //Show/hide context specific buttons
            btn_scheduleTab_New.Visible = true;
            btn_scheduleTab_Edit.Visible = true;
            btn_scheduleTab_Delete.Visible = true;
            btn_scheduleTab_Save.Visible = false;
            btn_scheduleTab_Cancel.Visible = false;

            //Removes editability
            tb_ScheduleTab_Title.Enabled = false;
            tb_ScheduleTab_Location.Enabled = false;
            tb_ScheduleTab_Description.Enabled = false;
            tb_ScheduleTab_Contact.Enabled = false;
            cb_ScheduleTab_Type.Enabled = false;
            tb_ScheduleTab_Url.Enabled = false;
            dtPicker_ScheduleTab_StartDate.Enabled = false;
            dtPicker_ScheduleTab_StartTime.Enabled = false;
            dtPicker_ScheduleTab_EndDate.Enabled = false;
            dtPicker_ScheduleTab_EndTime.Enabled = false;

            //Clears selected appointment to allow for contextual save function
            tb_ScheduleTab_Title.Clear();
            tb_ScheduleTab_Location.Clear();
            tb_ScheduleTab_Description.Clear();
            tb_ScheduleTab_Contact.Clear();
            tb_ScheduleTab_Url.Clear();
            dtPicker_ScheduleTab_StartDate.Value = DateTime.Now;
            dtPicker_ScheduleTab_EndDate.Value = DateTime.Now;
        }

        private void btn_scheduleTab_ViewCustomerRecord_Click(object sender, EventArgs e)
        {
            //Ensures null result cannot be searched
            if (_customer == null) return;

            //Switches to customer tab focused on the selected customer
            tabControl_Main.SelectedTab = tab_Customers;
            lv_customerTab_customerNames.FindItemWithText(_customer.CustomerName).Selected = true;

            //Returns _customer to null value
            _customer = null;
        }
        private void dgv_ScheduleTab_Appointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is DateTime dt)
            {
                e.Value = dt.ToUniversalTime();
                e.Value = dt.ToLocalTime();
            }
        }
        #endregion

        /* Customer Tab Controls and Events */
        #region CustomerTab
        private void lv_customerTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears the appointment list to ensure no duplicates are created
            Customer.ClearAppointment();

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
                    dgv_customerTab_Appointments.ClearSelection(); //Removes row selection for a cleaner appearance

                    //Lazily queries relevant address data for the selected customer to populate the textboxes
                    Database.Query.Select.AddressData(customer.CustomerId);

                    //Textboxes for relevant customer data
                    tb_customerTab_Name.Text = customer.CustomerName;
                    tb_customerTab_ID.Text = customer.CustomerId.ToString();
                    tb_customerTab_PrimaryAddress.Text = customer.PrimaryAddress.AddressOne;
                    tb_customerTab_SecondaryAddress.Text = customer.PrimaryAddress.AddressTwo;
                    tb_customerTab_PostalCode.Text = customer.PrimaryAddress.PostalCode;
                    tb_customerTab_PhoneNumber.Text = customer.PrimaryAddress.PhoneNumber;
                    tb_customerTab_City.Text = customer.PrimaryAddress.City;
                    tb_customerTab_Country.Text = customer.PrimaryAddress.Country;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btn_customerTab_New_Click(object sender, EventArgs e)
        {
            //Show/hide context specific buttons
            btn_customerTab_New.Visible = false;
            btn_customerTab_Edit.Visible = false;
            btn_customerTab_Delete.Visible = false;
            btn_customerTab_Save.Visible = true;
            btn_customerTab_Cancel.Visible = true;

            //Allows editability
            tb_customerTab_Name.Enabled = true;
            tb_customerTab_ID.Enabled = true;
            tb_customerTab_PrimaryAddress.Enabled = true;
            tb_customerTab_SecondaryAddress.Enabled = true;
            tb_customerTab_PostalCode.Enabled = true;
            tb_customerTab_PhoneNumber.Enabled = true;
            tb_customerTab_City.Enabled = true;
            tb_customerTab_Country.Enabled = true;

            //Clears selected customer to allow for contextual save function
            lv_customerTab_customerNames.SelectedItems.Clear();
            tb_customerTab_Name.Clear();
            tb_customerTab_ID.Clear();
            tb_customerTab_PrimaryAddress.Clear();
            tb_customerTab_SecondaryAddress.Clear();
            tb_customerTab_PostalCode.Clear();
            tb_customerTab_PhoneNumber.Clear();
            tb_customerTab_City.Clear();
            tb_customerTab_Country.Clear();

            //Repopulates the customer list
            lv_customerTab_customerNames.Items.Clear();
            foreach (var customer in Customer.CustomerDict)
            {
                lv_customerTab_customerNames.Items.Add(customer.Value.CustomerName);
            }
        }

        private void btn_customerTab_Edit_Click(object sender, EventArgs e)
        {
            if (lv_customerTab_customerNames.SelectedItems.Count > 0)
            {
                //Show/hide context specific buttons
                btn_customerTab_New.Visible = false;
                btn_customerTab_Edit.Visible = false;
                btn_customerTab_Delete.Visible = false;
                btn_customerTab_Save.Visible = true;
                btn_customerTab_Cancel.Visible = true;

                //Allows editability
                tb_customerTab_Name.Enabled = true;
                tb_customerTab_ID.Enabled = true;
                tb_customerTab_PrimaryAddress.Enabled = true;
                tb_customerTab_SecondaryAddress.Enabled = true;
                tb_customerTab_PostalCode.Enabled = true;
                tb_customerTab_PhoneNumber.Enabled = true;
                tb_customerTab_City.Enabled = true;
                tb_customerTab_Country.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select a user record to edit.");
            }
        }

        private void btn_customerTab_Save_Click(object sender, EventArgs e)
        {
            //Checks for empty textboxes for customer data
            if (tb_customerTab_Name.Text == "" || tb_customerTab_PrimaryAddress.Text == "" ||
                tb_customerTab_Country.Text == "" || tb_customerTab_City.Text == "" ||
                tb_customerTab_PostalCode.Text == "" || tb_customerTab_PhoneNumber.Text == "")
            {
                MessageBox.Show("Customer data cannot be empty.");
                return;
            }

            //Show/hide context specific buttons
            btn_customerTab_New.Visible = true;
            btn_customerTab_Edit.Visible = true;
            btn_customerTab_Delete.Visible = true;
            btn_customerTab_Save.Visible = false;
            btn_customerTab_Cancel.Visible = false;

            //If a user is selected, update the selected user's record, otherwise, insert a new record
            if (lv_customerTab_customerNames.SelectedItems.Count > 0)
            {
                Database.Query.Update.CustomerData(
                    int.Parse(tb_customerTab_ID.Text),
                    tb_customerTab_Name.Text,
                    tb_customerTab_PrimaryAddress.Text,
                    tb_customerTab_SecondaryAddress.Text,
                    tb_customerTab_City.Text,
                    tb_customerTab_Country.Text,
                    tb_customerTab_PostalCode.Text,
                    tb_customerTab_PhoneNumber.Text
                );

                //Removes editability
                tb_customerTab_Name.Enabled = false;
                tb_customerTab_ID.Enabled = false;
                tb_customerTab_PrimaryAddress.Enabled = false;
                tb_customerTab_SecondaryAddress.Enabled = false;
                tb_customerTab_PostalCode.Enabled = false;
                tb_customerTab_PhoneNumber.Enabled = false;
                tb_customerTab_City.Enabled = false;
                tb_customerTab_Country.Enabled = false;
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
            //Removes editability
            tb_customerTab_Name.Enabled = false;
            tb_customerTab_ID.Enabled = false;
            tb_customerTab_PrimaryAddress.Enabled = false;
            tb_customerTab_SecondaryAddress.Enabled = false;
            tb_customerTab_PostalCode.Enabled = false;
            tb_customerTab_PhoneNumber.Enabled = false;
            tb_customerTab_City.Enabled = false;
            tb_customerTab_Country.Enabled = false;

            Customer.ClearAppointment();
            Customer.CustomerDict.Clear();
            Database.Query.Select.CustomerData();
            Appointment.AllAppointments.Clear();
            Database.Query.Select.AppointmentData(ActiveUser.UserInformation.UserId);

            lv_customerTab_customerNames.Items.Clear();
            lv_scheduleTab_customerNames.Items.Clear();
            foreach (var customer in Customer.CustomerDict)
            {
                lv_customerTab_customerNames.Items.Add(customer.Value.CustomerName);
                lv_scheduleTab_customerNames.Items.Add(customer.Value.CustomerName);
            }
        }

        private void btn_customerTab_Cancel_Click(object sender, EventArgs e)
        {
            //Show/hide context specific buttons
            btn_customerTab_New.Visible = true;
            btn_customerTab_Edit.Visible = true;
            btn_customerTab_Delete.Visible = true;
            btn_customerTab_Save.Visible = false;
            btn_customerTab_Cancel.Visible = false;

            //Clears textboxes of information entered and removes editability
            tb_customerTab_Name.Clear();
            tb_customerTab_Name.Enabled = false;
            tb_customerTab_ID.Clear();
            tb_customerTab_ID.Enabled = false;
            tb_customerTab_PrimaryAddress.Clear();
            tb_customerTab_PrimaryAddress.Enabled = false;
            tb_customerTab_SecondaryAddress.Clear();
            tb_customerTab_SecondaryAddress.Enabled = false;
            tb_customerTab_City.Clear();
            tb_customerTab_City.Enabled = false;
            tb_customerTab_Country.Clear();
            tb_customerTab_Country.Enabled = false;
            tb_customerTab_PostalCode.Clear();
            tb_customerTab_PostalCode.Enabled = false;
            tb_customerTab_PhoneNumber.Clear();
            tb_customerTab_PhoneNumber.Enabled = false;

            //Remembers the selected customer and repopulates textboxes with that customer's data when cancel is clicked
            if (lv_customerTab_customerNames.FocusedItem != null)
            {
                var item = lv_customerTab_customerNames.FocusedItem.Index;
                lv_customerTab_customerNames.Select();
                lv_customerTab_customerNames.Items[0].Selected = true;
                lv_customerTab_customerNames.Items[0].Selected = false;
                lv_customerTab_customerNames.Items[item].Selected = true;
            }
        }

        private void btn_customerTab_Delete_Click(object sender, EventArgs e)
        {
            //Checks if no customer is selected, then if selected customer has any appointments.
            //Deletion occurs if both are false
            if (lv_customerTab_customerNames.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            if (dgv_customerTab_Appointments.RowCount != 0)
            {
                MessageBox.Show("A customer cannot be deleted with outstanding appointments.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                $"Are you sure you want to delete {tb_customerTab_Name.Text}?",
                "Confirm: Delete Customer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Database.Query.Delete.CustomerData(int.Parse(tb_customerTab_ID.Text));
            }

            //Show/hide context specific buttons
            btn_customerTab_New.Visible = true;
            btn_customerTab_Edit.Visible = true;
            btn_customerTab_Delete.Visible = true;
            btn_customerTab_Save.Visible = false;
            btn_customerTab_Cancel.Visible = false;

            //Removes editability
            tb_customerTab_Name.Enabled = false;
            tb_customerTab_ID.Enabled = false;
            tb_customerTab_PrimaryAddress.Enabled = false;
            tb_customerTab_SecondaryAddress.Enabled = false;
            tb_customerTab_PostalCode.Enabled = false;
            tb_customerTab_PhoneNumber.Enabled = false;
            tb_customerTab_City.Enabled = false;
            tb_customerTab_Country.Enabled = false;

            //Repopulates the customer list
            lv_customerTab_customerNames.Items.Clear();
            lv_scheduleTab_customerNames.Items.Clear();
            foreach (var customer in Customer.CustomerDict)
            {
                lv_customerTab_customerNames.Items.Add(customer.Value.CustomerName);
                lv_scheduleTab_customerNames.Items.Add(customer.Value.CustomerName);
            }
        }
        private void dgv_customerTab_Appointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is DateTime dt)
            {
                e.Value = dt.ToUniversalTime();
                e.Value = dt.ToLocalTime();
            }
        }
        #endregion

        /* Reports Tab Controls and Events */
        #region ReportsTab
        private void btn_reportsTab_generateReport_Click(object sender, EventArgs e)
        {
            if (rb_reportsTab_consultantSchedule.Checked)
            {
                //Sets the style and data for the DGV to display the report
                dgv_reportsTab_reportTable.DataSource = Appointment.AllAppointments; //Report data
                dgv_reportsTab_reportTable.AutoResizeColumns();
                dgv_reportsTab_reportTable.ClearSelection();
            }
            else if (rb_reportsTab_appointmentByType.Checked)
            {
                //Generates the report
                var report = Report.GenerateAppointmentByType(cb_reportsTab_month.SelectedValue.ToString(), 
                                                              cb_reportsTab_type.SelectedValue.ToString());
                
                //Sets the style and data for the DGV to display the report
                dgv_reportsTab_reportTable.DataSource = report.ToArray();              //Report data
                dgv_reportsTab_reportTable.Columns[0].HeaderText = "Appointment Type"; //Column 0
                dgv_reportsTab_reportTable.Columns[1].HeaderText = "Amount";           //Column 1
                dgv_reportsTab_reportTable.AutoResizeColumns();
                dgv_reportsTab_reportTable.ClearSelection();
            }
            else if (rb_reportsTab_appointmentsByCustomer.Checked)
            {
                var report = Report.GenerateAppointmentByCustomer();

                dgv_reportsTab_reportTable.DataSource = report.ToArray();               //Report data
                dgv_reportsTab_reportTable.Columns[0].HeaderText = "Customer";          //Column 0
                dgv_reportsTab_reportTable.Columns[1].HeaderText = "# of Appointments"; //Column 1
                dgv_reportsTab_reportTable.AutoResizeColumns();
                dgv_reportsTab_reportTable.ClearSelection();
            }
        }

        //Clears the selected report from the grid
        private void btn_reportsTab_clearSelection_Click(object sender, EventArgs e)
        {
            if (rb_reportsTab_consultantSchedule.Checked)
            {
                rb_reportsTab_consultantSchedule.Checked = false;
                dgv_reportsTab_reportTable.DataSource = null;
            }
            else if (rb_reportsTab_appointmentByType.Checked)
            {
                rb_reportsTab_appointmentByType.Checked = false;
                dgv_reportsTab_reportTable.DataSource = null;
            }
            else if (rb_reportsTab_appointmentsByCustomer.Checked)
            {
                rb_reportsTab_appointmentsByCustomer.Checked = false;
                dgv_reportsTab_reportTable.DataSource = null;
            }
        }
        private void dgv_reportsTab_reportTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is DateTime dt)
            {
                e.Value = dt.ToUniversalTime();
                e.Value = dt.ToLocalTime();
            }
        }
        #endregion
    }
}