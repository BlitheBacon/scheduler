namespace scheduler.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Tabs = new System.Windows.Forms.Panel();
            this.lbl_userID = new System.Windows.Forms.Label();
            this.lbl_LoggedInUserMsg = new System.Windows.Forms.Label();
            this.pnl_WindowButtons = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tab_Home = new System.Windows.Forms.TabPage();
            this.lbl_homeTab_to = new System.Windows.Forms.Label();
            this.lbl_homeTab_from = new System.Windows.Forms.Label();
            this.dt_homeTab_to = new System.Windows.Forms.DateTimePicker();
            this.dt_homeTab_from = new System.Windows.Forms.DateTimePicker();
            this.dgv_allAppointments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_Schedule = new System.Windows.Forms.TabPage();
            this.btn_scheduleTab_ViewCustomerRecord = new System.Windows.Forms.Button();
            this.btn_scheduleTab_New = new System.Windows.Forms.Button();
            this.btn_scheduleTab_Edit = new System.Windows.Forms.Button();
            this.btn_scheduleTab_Delete = new System.Windows.Forms.Button();
            this.lbl_scheduleTab_Appointments = new System.Windows.Forms.Label();
            this.lbl_scheduleTab_Customers = new System.Windows.Forms.Label();
            this.lbl_scheduleTab_End = new System.Windows.Forms.Label();
            this.lbl_scheduleTab_Start = new System.Windows.Forms.Label();
            this.lbl_scheduleTab_Url = new System.Windows.Forms.Label();
            this.lbl_scheduleTab_Type = new System.Windows.Forms.Label();
            this.lbl_scheduleTab_Contact = new System.Windows.Forms.Label();
            this.lbl_scheduleTab_Description = new System.Windows.Forms.Label();
            this.lbl_scheduleTab_Location = new System.Windows.Forms.Label();
            this.lbl_scheduleTab_Title = new System.Windows.Forms.Label();
            this.lv_scheduleTab_customerNames = new System.Windows.Forms.ListView();
            this.btn_scheduleTab_Cancel = new System.Windows.Forms.Button();
            this.btn_scheduleTab_Save = new System.Windows.Forms.Button();
            this.dtPicker_ScheduleTab_EndTime = new System.Windows.Forms.DateTimePicker();
            this.dtPicker_ScheduleTab_StartTime = new System.Windows.Forms.DateTimePicker();
            this.cb_ScheduleTab_Type = new System.Windows.Forms.ComboBox();
            this.tb_ScheduleTab_Contact = new System.Windows.Forms.TextBox();
            this.dtPicker_ScheduleTab_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtPicker_ScheduleTab_StartDate = new System.Windows.Forms.DateTimePicker();
            this.tb_ScheduleTab_Location = new System.Windows.Forms.TextBox();
            this.tb_ScheduleTab_Url = new System.Windows.Forms.TextBox();
            this.tb_ScheduleTab_Description = new System.Windows.Forms.TextBox();
            this.tb_ScheduleTab_Title = new System.Windows.Forms.TextBox();
            this.dgv_ScheduleTab_Appointments = new System.Windows.Forms.DataGridView();
            this.tab_Customers = new System.Windows.Forms.TabPage();
            this.btn_customerTab_Delete = new System.Windows.Forms.Button();
            this.btn_customerTab_New = new System.Windows.Forms.Button();
            this.btn_customerTab_Edit = new System.Windows.Forms.Button();
            this.btn_customerTab_Cancel = new System.Windows.Forms.Button();
            this.btn_customerTab_Save = new System.Windows.Forms.Button();
            this.lbl_customerTab_secondaryAddress = new System.Windows.Forms.Label();
            this.tb_customerTab_SecondaryAddress = new System.Windows.Forms.TextBox();
            this.lbl_customerTab_country = new System.Windows.Forms.Label();
            this.lbl_customerTab_city = new System.Windows.Forms.Label();
            this.lbl_customerTab_phoneNumber = new System.Windows.Forms.Label();
            this.lbl_customerTab_postalCode = new System.Windows.Forms.Label();
            this.lbl_customerTab_primaryAddress = new System.Windows.Forms.Label();
            this.lbl_customerTab_ID = new System.Windows.Forms.Label();
            this.lbl_customerTab_name = new System.Windows.Forms.Label();
            this.tb_customerTab_Country = new System.Windows.Forms.TextBox();
            this.tb_customerTab_City = new System.Windows.Forms.TextBox();
            this.tb_customerTab_PhoneNumber = new System.Windows.Forms.TextBox();
            this.tb_customerTab_PostalCode = new System.Windows.Forms.TextBox();
            this.tb_customerTab_PrimaryAddress = new System.Windows.Forms.TextBox();
            this.tb_customerTab_Name = new System.Windows.Forms.TextBox();
            this.tb_customerTab_ID = new System.Windows.Forms.TextBox();
            this.lbl_customerTab_Appointments = new System.Windows.Forms.Label();
            this.lbl_customerTab_customerNames = new System.Windows.Forms.Label();
            this.dgv_customerTab_Appointments = new System.Windows.Forms.DataGridView();
            this.lv_customerTab_customerNames = new System.Windows.Forms.ListView();
            this.tab_Reports = new System.Windows.Forms.TabPage();
            this.pnl_reportsTab_reports = new System.Windows.Forms.Panel();
            this.dgv_reportsTab_reportTable = new System.Windows.Forms.DataGridView();
            this.pnl_reportsTab_options = new System.Windows.Forms.Panel();
            this.rb_reportsTab_consultantSchedule = new System.Windows.Forms.RadioButton();
            this.cb_reportsTab_type = new System.Windows.Forms.ComboBox();
            this.cb_reportsTab_month = new System.Windows.Forms.ComboBox();
            this.rb_reportsTab_appointmentByType = new System.Windows.Forms.RadioButton();
            this.rb_reportsTab_appointmentsByCustomer = new System.Windows.Forms.RadioButton();
            this.btn_reportsTab_clearSelection = new System.Windows.Forms.Button();
            this.btn_reportsTab_generateReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_DateLocal = new System.Windows.Forms.Label();
            this.lbl_TimeLocal = new System.Windows.Forms.Label();
            this.timer_DateTimeLabel = new System.Windows.Forms.Timer(this.components);
            this.t_scheduleTab_DtPickers = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flpMain.SuspendLayout();
            this.pnl_Tabs.SuspendLayout();
            this.pnl_WindowButtons.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tab_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allAppointments)).BeginInit();
            this.tab_Schedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScheduleTab_Appointments)).BeginInit();
            this.tab_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerTab_Appointments)).BeginInit();
            this.tab_Reports.SuspendLayout();
            this.pnl_reportsTab_reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reportsTab_reportTable)).BeginInit();
            this.pnl_reportsTab_options.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMain
            // 
            this.flpMain.Controls.Add(this.pnl_Tabs);
            this.flpMain.Controls.Add(this.pnl_Footer);
            this.flpMain.Controls.Add(this.tabControl_Main);
            this.flpMain.Controls.Add(this.panel1);
            this.flpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMain.Location = new System.Drawing.Point(0, 0);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(1400, 700);
            this.flpMain.TabIndex = 0;
            // 
            // pnl_Tabs
            // 
            this.pnl_Tabs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_Tabs.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Tabs.Controls.Add(this.lbl_userID);
            this.pnl_Tabs.Controls.Add(this.lbl_LoggedInUserMsg);
            this.pnl_Tabs.Controls.Add(this.pnl_WindowButtons);
            this.pnl_Tabs.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tabs.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Tabs.Name = "pnl_Tabs";
            this.pnl_Tabs.Size = new System.Drawing.Size(1400, 63);
            this.pnl_Tabs.TabIndex = 1;
            this.pnl_Tabs.DoubleClick += new System.EventHandler(this.btn_MaximizeClick);
            this.pnl_Tabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_Event_MouseDown);
            this.pnl_Tabs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_Event_MouseMove);
            this.pnl_Tabs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_Event_MouseUp);
            // 
            // lbl_userID
            // 
            this.lbl_userID.AutoSize = true;
            this.lbl_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userID.Location = new System.Drawing.Point(10, 36);
            this.lbl_userID.Name = "lbl_userID";
            this.lbl_userID.Size = new System.Drawing.Size(46, 16);
            this.lbl_userID.TabIndex = 5;
            this.lbl_userID.Text = "userID";
            // 
            // lbl_LoggedInUserMsg
            // 
            this.lbl_LoggedInUserMsg.AutoSize = true;
            this.lbl_LoggedInUserMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoggedInUserMsg.Location = new System.Drawing.Point(8, 7);
            this.lbl_LoggedInUserMsg.Name = "lbl_LoggedInUserMsg";
            this.lbl_LoggedInUserMsg.Size = new System.Drawing.Size(165, 24);
            this.lbl_LoggedInUserMsg.TabIndex = 4;
            this.lbl_LoggedInUserMsg.Text = "LoggedInUserMsg";
            // 
            // pnl_WindowButtons
            // 
            this.pnl_WindowButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_WindowButtons.Controls.Add(this.btn_Close);
            this.pnl_WindowButtons.Controls.Add(this.btn_Minimize);
            this.pnl_WindowButtons.Controls.Add(this.btn_Maximize);
            this.pnl_WindowButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_WindowButtons.Location = new System.Drawing.Point(1248, 0);
            this.pnl_WindowButtons.Name = "pnl_WindowButtons";
            this.pnl_WindowButtons.Size = new System.Drawing.Size(152, 63);
            this.pnl_WindowButtons.TabIndex = 3;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.Color.Black;
            this.btn_Close.Location = new System.Drawing.Point(104, 6);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(40, 40);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_CloseClick);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.ForeColor = System.Drawing.Color.Black;
            this.btn_Minimize.Location = new System.Drawing.Point(58, 6);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(40, 40);
            this.btn_Minimize.TabIndex = 0;
            this.btn_Minimize.Text = "_";
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_MinimizeClick);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Maximize.Enabled = false;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maximize.ForeColor = System.Drawing.Color.Black;
            this.btn_Maximize.Location = new System.Drawing.Point(58, 6);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(40, 40);
            this.btn_Maximize.TabIndex = 1;
            this.btn_Maximize.Text = "◻";
            this.btn_Maximize.UseVisualStyleBackColor = false;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_MaximizeClick);
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_Footer.Location = new System.Drawing.Point(3, 66);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(1397, 10);
            this.pnl_Footer.TabIndex = 3;
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tab_Home);
            this.tabControl_Main.Controls.Add(this.tab_Schedule);
            this.tabControl_Main.Controls.Add(this.tab_Customers);
            this.tabControl_Main.Controls.Add(this.tab_Reports);
            this.tabControl_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Main.HotTrack = true;
            this.tabControl_Main.Location = new System.Drawing.Point(3, 82);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1389, 574);
            this.tabControl_Main.TabIndex = 2;
            this.tabControl_Main.SelectedIndexChanged += new System.EventHandler(this.tabControl_Main_TabIndexChanged);
            // 
            // tab_Home
            // 
            this.tab_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tab_Home.Controls.Add(this.lbl_homeTab_to);
            this.tab_Home.Controls.Add(this.lbl_homeTab_from);
            this.tab_Home.Controls.Add(this.dt_homeTab_to);
            this.tab_Home.Controls.Add(this.dt_homeTab_from);
            this.tab_Home.Controls.Add(this.dgv_allAppointments);
            this.tab_Home.Controls.Add(this.label1);
            this.tab_Home.ForeColor = System.Drawing.Color.Black;
            this.tab_Home.Location = new System.Drawing.Point(4, 29);
            this.tab_Home.Name = "tab_Home";
            this.tab_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Home.Size = new System.Drawing.Size(1381, 541);
            this.tab_Home.TabIndex = 0;
            this.tab_Home.Text = "Home";
            // 
            // lbl_homeTab_to
            // 
            this.lbl_homeTab_to.AutoSize = true;
            this.lbl_homeTab_to.Location = new System.Drawing.Point(374, 32);
            this.lbl_homeTab_to.Name = "lbl_homeTab_to";
            this.lbl_homeTab_to.Size = new System.Drawing.Size(31, 20);
            this.lbl_homeTab_to.TabIndex = 5;
            this.lbl_homeTab_to.Text = "To:";
            // 
            // lbl_homeTab_from
            // 
            this.lbl_homeTab_from.AutoSize = true;
            this.lbl_homeTab_from.Location = new System.Drawing.Point(172, 32);
            this.lbl_homeTab_from.Name = "lbl_homeTab_from";
            this.lbl_homeTab_from.Size = new System.Drawing.Size(50, 20);
            this.lbl_homeTab_from.TabIndex = 4;
            this.lbl_homeTab_from.Text = "From:";
            // 
            // dt_homeTab_to
            // 
            this.dt_homeTab_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_homeTab_to.Location = new System.Drawing.Point(411, 32);
            this.dt_homeTab_to.Name = "dt_homeTab_to";
            this.dt_homeTab_to.Size = new System.Drawing.Size(117, 26);
            this.dt_homeTab_to.TabIndex = 3;
            this.dt_homeTab_to.ValueChanged += new System.EventHandler(this.dt_homeTab_ValueChanged);
            // 
            // dt_homeTab_from
            // 
            this.dt_homeTab_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_homeTab_from.Location = new System.Drawing.Point(228, 32);
            this.dt_homeTab_from.Name = "dt_homeTab_from";
            this.dt_homeTab_from.Size = new System.Drawing.Size(117, 26);
            this.dt_homeTab_from.TabIndex = 2;
            this.dt_homeTab_from.ValueChanged += new System.EventHandler(this.dt_homeTab_ValueChanged);
            // 
            // dgv_allAppointments
            // 
            this.dgv_allAppointments.AllowUserToAddRows = false;
            this.dgv_allAppointments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_allAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_allAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_allAppointments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgv_allAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_allAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_allAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_allAppointments.ColumnHeadersHeight = 28;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_allAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_allAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgv_allAppointments.Location = new System.Drawing.Point(18, 80);
            this.dgv_allAppointments.Name = "dgv_allAppointments";
            this.dgv_allAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_allAppointments.Size = new System.Drawing.Size(1321, 446);
            this.dgv_allAppointments.TabIndex = 1;
            this.dgv_allAppointments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_allAppointments_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointments";
            // 
            // tab_Schedule
            // 
            this.tab_Schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tab_Schedule.Controls.Add(this.btn_scheduleTab_ViewCustomerRecord);
            this.tab_Schedule.Controls.Add(this.btn_scheduleTab_New);
            this.tab_Schedule.Controls.Add(this.btn_scheduleTab_Edit);
            this.tab_Schedule.Controls.Add(this.btn_scheduleTab_Delete);
            this.tab_Schedule.Controls.Add(this.lbl_scheduleTab_Appointments);
            this.tab_Schedule.Controls.Add(this.lbl_scheduleTab_Customers);
            this.tab_Schedule.Controls.Add(this.lbl_scheduleTab_End);
            this.tab_Schedule.Controls.Add(this.lbl_scheduleTab_Start);
            this.tab_Schedule.Controls.Add(this.lbl_scheduleTab_Url);
            this.tab_Schedule.Controls.Add(this.lbl_scheduleTab_Type);
            this.tab_Schedule.Controls.Add(this.lbl_scheduleTab_Contact);
            this.tab_Schedule.Controls.Add(this.lbl_scheduleTab_Description);
            this.tab_Schedule.Controls.Add(this.lbl_scheduleTab_Location);
            this.tab_Schedule.Controls.Add(this.lbl_scheduleTab_Title);
            this.tab_Schedule.Controls.Add(this.lv_scheduleTab_customerNames);
            this.tab_Schedule.Controls.Add(this.btn_scheduleTab_Cancel);
            this.tab_Schedule.Controls.Add(this.btn_scheduleTab_Save);
            this.tab_Schedule.Controls.Add(this.dtPicker_ScheduleTab_EndTime);
            this.tab_Schedule.Controls.Add(this.dtPicker_ScheduleTab_StartTime);
            this.tab_Schedule.Controls.Add(this.cb_ScheduleTab_Type);
            this.tab_Schedule.Controls.Add(this.tb_ScheduleTab_Contact);
            this.tab_Schedule.Controls.Add(this.dtPicker_ScheduleTab_EndDate);
            this.tab_Schedule.Controls.Add(this.dtPicker_ScheduleTab_StartDate);
            this.tab_Schedule.Controls.Add(this.tb_ScheduleTab_Location);
            this.tab_Schedule.Controls.Add(this.tb_ScheduleTab_Url);
            this.tab_Schedule.Controls.Add(this.tb_ScheduleTab_Description);
            this.tab_Schedule.Controls.Add(this.tb_ScheduleTab_Title);
            this.tab_Schedule.Controls.Add(this.dgv_ScheduleTab_Appointments);
            this.tab_Schedule.Location = new System.Drawing.Point(4, 29);
            this.tab_Schedule.Name = "tab_Schedule";
            this.tab_Schedule.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Schedule.Size = new System.Drawing.Size(1381, 541);
            this.tab_Schedule.TabIndex = 1;
            this.tab_Schedule.Text = "Schedule";
            // 
            // btn_scheduleTab_ViewCustomerRecord
            // 
            this.btn_scheduleTab_ViewCustomerRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scheduleTab_ViewCustomerRecord.Location = new System.Drawing.Point(19, 467);
            this.btn_scheduleTab_ViewCustomerRecord.Name = "btn_scheduleTab_ViewCustomerRecord";
            this.btn_scheduleTab_ViewCustomerRecord.Size = new System.Drawing.Size(131, 51);
            this.btn_scheduleTab_ViewCustomerRecord.TabIndex = 29;
            this.btn_scheduleTab_ViewCustomerRecord.Text = "View Customer Record";
            this.btn_scheduleTab_ViewCustomerRecord.UseVisualStyleBackColor = true;
            this.btn_scheduleTab_ViewCustomerRecord.Click += new System.EventHandler(this.btn_scheduleTab_ViewCustomerRecord_Click);
            // 
            // btn_scheduleTab_New
            // 
            this.btn_scheduleTab_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scheduleTab_New.Location = new System.Drawing.Point(199, 488);
            this.btn_scheduleTab_New.Name = "btn_scheduleTab_New";
            this.btn_scheduleTab_New.Size = new System.Drawing.Size(75, 30);
            this.btn_scheduleTab_New.TabIndex = 28;
            this.btn_scheduleTab_New.Text = "New";
            this.btn_scheduleTab_New.UseVisualStyleBackColor = true;
            this.btn_scheduleTab_New.Click += new System.EventHandler(this.btn_scheduleTab_New_Click);
            // 
            // btn_scheduleTab_Edit
            // 
            this.btn_scheduleTab_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scheduleTab_Edit.Location = new System.Drawing.Point(328, 488);
            this.btn_scheduleTab_Edit.Name = "btn_scheduleTab_Edit";
            this.btn_scheduleTab_Edit.Size = new System.Drawing.Size(75, 30);
            this.btn_scheduleTab_Edit.TabIndex = 27;
            this.btn_scheduleTab_Edit.Text = "Edit";
            this.btn_scheduleTab_Edit.UseVisualStyleBackColor = true;
            this.btn_scheduleTab_Edit.Click += new System.EventHandler(this.btn_scheduleTab_Edit_Click);
            // 
            // btn_scheduleTab_Delete
            // 
            this.btn_scheduleTab_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scheduleTab_Delete.Location = new System.Drawing.Point(450, 488);
            this.btn_scheduleTab_Delete.Name = "btn_scheduleTab_Delete";
            this.btn_scheduleTab_Delete.Size = new System.Drawing.Size(75, 30);
            this.btn_scheduleTab_Delete.TabIndex = 26;
            this.btn_scheduleTab_Delete.Text = "Delete";
            this.btn_scheduleTab_Delete.UseVisualStyleBackColor = true;
            this.btn_scheduleTab_Delete.Click += new System.EventHandler(this.btn_scheduleTab_Delete_Click);
            // 
            // lbl_scheduleTab_Appointments
            // 
            this.lbl_scheduleTab_Appointments.AutoSize = true;
            this.lbl_scheduleTab_Appointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scheduleTab_Appointments.Location = new System.Drawing.Point(554, 31);
            this.lbl_scheduleTab_Appointments.Name = "lbl_scheduleTab_Appointments";
            this.lbl_scheduleTab_Appointments.Size = new System.Drawing.Size(126, 24);
            this.lbl_scheduleTab_Appointments.TabIndex = 25;
            this.lbl_scheduleTab_Appointments.Text = "Appointments";
            // 
            // lbl_scheduleTab_Customers
            // 
            this.lbl_scheduleTab_Customers.AutoSize = true;
            this.lbl_scheduleTab_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scheduleTab_Customers.Location = new System.Drawing.Point(6, 31);
            this.lbl_scheduleTab_Customers.Name = "lbl_scheduleTab_Customers";
            this.lbl_scheduleTab_Customers.Size = new System.Drawing.Size(100, 24);
            this.lbl_scheduleTab_Customers.TabIndex = 24;
            this.lbl_scheduleTab_Customers.Text = "Customers";
            // 
            // lbl_scheduleTab_End
            // 
            this.lbl_scheduleTab_End.AutoSize = true;
            this.lbl_scheduleTab_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scheduleTab_End.Location = new System.Drawing.Point(199, 403);
            this.lbl_scheduleTab_End.Name = "lbl_scheduleTab_End";
            this.lbl_scheduleTab_End.Size = new System.Drawing.Size(38, 20);
            this.lbl_scheduleTab_End.TabIndex = 23;
            this.lbl_scheduleTab_End.Text = "End";
            // 
            // lbl_scheduleTab_Start
            // 
            this.lbl_scheduleTab_Start.AutoSize = true;
            this.lbl_scheduleTab_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scheduleTab_Start.Location = new System.Drawing.Point(195, 346);
            this.lbl_scheduleTab_Start.Name = "lbl_scheduleTab_Start";
            this.lbl_scheduleTab_Start.Size = new System.Drawing.Size(44, 20);
            this.lbl_scheduleTab_Start.TabIndex = 22;
            this.lbl_scheduleTab_Start.Text = "Start";
            // 
            // lbl_scheduleTab_Url
            // 
            this.lbl_scheduleTab_Url.AutoSize = true;
            this.lbl_scheduleTab_Url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scheduleTab_Url.Location = new System.Drawing.Point(195, 283);
            this.lbl_scheduleTab_Url.Name = "lbl_scheduleTab_Url";
            this.lbl_scheduleTab_Url.Size = new System.Drawing.Size(42, 20);
            this.lbl_scheduleTab_Url.TabIndex = 21;
            this.lbl_scheduleTab_Url.Text = "URL";
            // 
            // lbl_scheduleTab_Type
            // 
            this.lbl_scheduleTab_Type.AutoSize = true;
            this.lbl_scheduleTab_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scheduleTab_Type.Location = new System.Drawing.Point(400, 222);
            this.lbl_scheduleTab_Type.Name = "lbl_scheduleTab_Type";
            this.lbl_scheduleTab_Type.Size = new System.Drawing.Size(43, 20);
            this.lbl_scheduleTab_Type.TabIndex = 20;
            this.lbl_scheduleTab_Type.Text = "Type";
            // 
            // lbl_scheduleTab_Contact
            // 
            this.lbl_scheduleTab_Contact.AutoSize = true;
            this.lbl_scheduleTab_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scheduleTab_Contact.Location = new System.Drawing.Point(195, 222);
            this.lbl_scheduleTab_Contact.Name = "lbl_scheduleTab_Contact";
            this.lbl_scheduleTab_Contact.Size = new System.Drawing.Size(65, 20);
            this.lbl_scheduleTab_Contact.TabIndex = 19;
            this.lbl_scheduleTab_Contact.Text = "Contact";
            // 
            // lbl_scheduleTab_Description
            // 
            this.lbl_scheduleTab_Description.AutoSize = true;
            this.lbl_scheduleTab_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scheduleTab_Description.Location = new System.Drawing.Point(195, 97);
            this.lbl_scheduleTab_Description.Name = "lbl_scheduleTab_Description";
            this.lbl_scheduleTab_Description.Size = new System.Drawing.Size(89, 20);
            this.lbl_scheduleTab_Description.TabIndex = 18;
            this.lbl_scheduleTab_Description.Text = "Description";
            // 
            // lbl_scheduleTab_Location
            // 
            this.lbl_scheduleTab_Location.AutoSize = true;
            this.lbl_scheduleTab_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scheduleTab_Location.Location = new System.Drawing.Point(421, 35);
            this.lbl_scheduleTab_Location.Name = "lbl_scheduleTab_Location";
            this.lbl_scheduleTab_Location.Size = new System.Drawing.Size(70, 20);
            this.lbl_scheduleTab_Location.TabIndex = 17;
            this.lbl_scheduleTab_Location.Text = "Location";
            // 
            // lbl_scheduleTab_Title
            // 
            this.lbl_scheduleTab_Title.AutoSize = true;
            this.lbl_scheduleTab_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scheduleTab_Title.Location = new System.Drawing.Point(195, 35);
            this.lbl_scheduleTab_Title.Name = "lbl_scheduleTab_Title";
            this.lbl_scheduleTab_Title.Size = new System.Drawing.Size(38, 20);
            this.lbl_scheduleTab_Title.TabIndex = 16;
            this.lbl_scheduleTab_Title.Text = "Title";
            // 
            // lv_scheduleTab_customerNames
            // 
            this.lv_scheduleTab_customerNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_scheduleTab_customerNames.HideSelection = false;
            this.lv_scheduleTab_customerNames.Location = new System.Drawing.Point(6, 58);
            this.lv_scheduleTab_customerNames.Name = "lv_scheduleTab_customerNames";
            this.lv_scheduleTab_customerNames.Size = new System.Drawing.Size(160, 392);
            this.lv_scheduleTab_customerNames.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_scheduleTab_customerNames.TabIndex = 15;
            this.lv_scheduleTab_customerNames.UseCompatibleStateImageBehavior = false;
            this.lv_scheduleTab_customerNames.SelectedIndexChanged += new System.EventHandler(this.lv_ScheduleTab_customerNames_SelectedIndexChanged);
            // 
            // btn_scheduleTab_Cancel
            // 
            this.btn_scheduleTab_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scheduleTab_Cancel.Location = new System.Drawing.Point(392, 488);
            this.btn_scheduleTab_Cancel.Name = "btn_scheduleTab_Cancel";
            this.btn_scheduleTab_Cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_scheduleTab_Cancel.TabIndex = 14;
            this.btn_scheduleTab_Cancel.Text = "Cancel";
            this.btn_scheduleTab_Cancel.UseVisualStyleBackColor = true;
            this.btn_scheduleTab_Cancel.Visible = false;
            this.btn_scheduleTab_Cancel.Click += new System.EventHandler(this.btn_ScheduleTab_Cancel_Click);
            // 
            // btn_scheduleTab_Save
            // 
            this.btn_scheduleTab_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scheduleTab_Save.Location = new System.Drawing.Point(262, 488);
            this.btn_scheduleTab_Save.Name = "btn_scheduleTab_Save";
            this.btn_scheduleTab_Save.Size = new System.Drawing.Size(75, 30);
            this.btn_scheduleTab_Save.TabIndex = 13;
            this.btn_scheduleTab_Save.Text = "Save";
            this.btn_scheduleTab_Save.UseVisualStyleBackColor = true;
            this.btn_scheduleTab_Save.Visible = false;
            this.btn_scheduleTab_Save.Click += new System.EventHandler(this.btn_ScheduleTab_Save_Click);
            // 
            // dtPicker_ScheduleTab_EndTime
            // 
            this.dtPicker_ScheduleTab_EndTime.CustomFormat = "HH:mm";
            this.dtPicker_ScheduleTab_EndTime.Enabled = false;
            this.dtPicker_ScheduleTab_EndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker_ScheduleTab_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker_ScheduleTab_EndTime.Location = new System.Drawing.Point(459, 426);
            this.dtPicker_ScheduleTab_EndTime.Name = "dtPicker_ScheduleTab_EndTime";
            this.dtPicker_ScheduleTab_EndTime.ShowUpDown = true;
            this.dtPicker_ScheduleTab_EndTime.Size = new System.Drawing.Size(66, 24);
            this.dtPicker_ScheduleTab_EndTime.TabIndex = 12;
            this.dtPicker_ScheduleTab_EndTime.Value = new System.DateTime(2023, 1, 23, 15, 13, 49, 0);
            this.dtPicker_ScheduleTab_EndTime.ValueChanged += new System.EventHandler(this.dtPicker_ScheduleTab_Time_ValueChanged);
            // 
            // dtPicker_ScheduleTab_StartTime
            // 
            this.dtPicker_ScheduleTab_StartTime.CustomFormat = "HH:mm";
            this.dtPicker_ScheduleTab_StartTime.Enabled = false;
            this.dtPicker_ScheduleTab_StartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker_ScheduleTab_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker_ScheduleTab_StartTime.Location = new System.Drawing.Point(459, 369);
            this.dtPicker_ScheduleTab_StartTime.Name = "dtPicker_ScheduleTab_StartTime";
            this.dtPicker_ScheduleTab_StartTime.ShowUpDown = true;
            this.dtPicker_ScheduleTab_StartTime.Size = new System.Drawing.Size(66, 24);
            this.dtPicker_ScheduleTab_StartTime.TabIndex = 11;
            this.dtPicker_ScheduleTab_StartTime.Value = new System.DateTime(2023, 1, 23, 15, 13, 44, 0);
            this.dtPicker_ScheduleTab_StartTime.ValueChanged += new System.EventHandler(this.dtPicker_ScheduleTab_Time_ValueChanged);
            // 
            // cb_ScheduleTab_Type
            // 
            this.cb_ScheduleTab_Type.Enabled = false;
            this.cb_ScheduleTab_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ScheduleTab_Type.FormattingEnabled = true;
            this.cb_ScheduleTab_Type.Location = new System.Drawing.Point(404, 242);
            this.cb_ScheduleTab_Type.Name = "cb_ScheduleTab_Type";
            this.cb_ScheduleTab_Type.Size = new System.Drawing.Size(121, 28);
            this.cb_ScheduleTab_Type.TabIndex = 10;
            // 
            // tb_ScheduleTab_Contact
            // 
            this.tb_ScheduleTab_Contact.Enabled = false;
            this.tb_ScheduleTab_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ScheduleTab_Contact.Location = new System.Drawing.Point(199, 245);
            this.tb_ScheduleTab_Contact.Name = "tb_ScheduleTab_Contact";
            this.tb_ScheduleTab_Contact.Size = new System.Drawing.Size(184, 26);
            this.tb_ScheduleTab_Contact.TabIndex = 9;
            // 
            // dtPicker_ScheduleTab_EndDate
            // 
            this.dtPicker_ScheduleTab_EndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker_ScheduleTab_EndDate.Enabled = false;
            this.dtPicker_ScheduleTab_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker_ScheduleTab_EndDate.Location = new System.Drawing.Point(199, 426);
            this.dtPicker_ScheduleTab_EndDate.Name = "dtPicker_ScheduleTab_EndDate";
            this.dtPicker_ScheduleTab_EndDate.Size = new System.Drawing.Size(257, 24);
            this.dtPicker_ScheduleTab_EndDate.TabIndex = 8;
            this.dtPicker_ScheduleTab_EndDate.Value = new System.DateTime(2023, 1, 23, 15, 25, 40, 0);
            // 
            // dtPicker_ScheduleTab_StartDate
            // 
            this.dtPicker_ScheduleTab_StartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker_ScheduleTab_StartDate.CustomFormat = "";
            this.dtPicker_ScheduleTab_StartDate.Enabled = false;
            this.dtPicker_ScheduleTab_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker_ScheduleTab_StartDate.Location = new System.Drawing.Point(199, 369);
            this.dtPicker_ScheduleTab_StartDate.Name = "dtPicker_ScheduleTab_StartDate";
            this.dtPicker_ScheduleTab_StartDate.Size = new System.Drawing.Size(257, 24);
            this.dtPicker_ScheduleTab_StartDate.TabIndex = 7;
            this.dtPicker_ScheduleTab_StartDate.Value = new System.DateTime(2023, 1, 23, 15, 25, 34, 0);
            // 
            // tb_ScheduleTab_Location
            // 
            this.tb_ScheduleTab_Location.Enabled = false;
            this.tb_ScheduleTab_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ScheduleTab_Location.Location = new System.Drawing.Point(404, 58);
            this.tb_ScheduleTab_Location.Name = "tb_ScheduleTab_Location";
            this.tb_ScheduleTab_Location.Size = new System.Drawing.Size(121, 26);
            this.tb_ScheduleTab_Location.TabIndex = 6;
            // 
            // tb_ScheduleTab_Url
            // 
            this.tb_ScheduleTab_Url.Enabled = false;
            this.tb_ScheduleTab_Url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ScheduleTab_Url.Location = new System.Drawing.Point(199, 306);
            this.tb_ScheduleTab_Url.Name = "tb_ScheduleTab_Url";
            this.tb_ScheduleTab_Url.Size = new System.Drawing.Size(326, 26);
            this.tb_ScheduleTab_Url.TabIndex = 5;
            // 
            // tb_ScheduleTab_Description
            // 
            this.tb_ScheduleTab_Description.Enabled = false;
            this.tb_ScheduleTab_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ScheduleTab_Description.Location = new System.Drawing.Point(199, 120);
            this.tb_ScheduleTab_Description.Multiline = true;
            this.tb_ScheduleTab_Description.Name = "tb_ScheduleTab_Description";
            this.tb_ScheduleTab_Description.Size = new System.Drawing.Size(326, 93);
            this.tb_ScheduleTab_Description.TabIndex = 3;
            // 
            // tb_ScheduleTab_Title
            // 
            this.tb_ScheduleTab_Title.Enabled = false;
            this.tb_ScheduleTab_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ScheduleTab_Title.Location = new System.Drawing.Point(199, 58);
            this.tb_ScheduleTab_Title.Name = "tb_ScheduleTab_Title";
            this.tb_ScheduleTab_Title.Size = new System.Drawing.Size(184, 26);
            this.tb_ScheduleTab_Title.TabIndex = 2;
            // 
            // dgv_ScheduleTab_Appointments
            // 
            this.dgv_ScheduleTab_Appointments.AllowUserToAddRows = false;
            this.dgv_ScheduleTab_Appointments.AllowUserToDeleteRows = false;
            this.dgv_ScheduleTab_Appointments.AllowUserToResizeColumns = false;
            this.dgv_ScheduleTab_Appointments.AllowUserToResizeRows = false;
            this.dgv_ScheduleTab_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ScheduleTab_Appointments.Location = new System.Drawing.Point(558, 58);
            this.dgv_ScheduleTab_Appointments.MultiSelect = false;
            this.dgv_ScheduleTab_Appointments.Name = "dgv_ScheduleTab_Appointments";
            this.dgv_ScheduleTab_Appointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ScheduleTab_Appointments.Size = new System.Drawing.Size(820, 392);
            this.dgv_ScheduleTab_Appointments.TabIndex = 1;
            this.dgv_ScheduleTab_Appointments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_ScheduleTab_Appointments_CellFormatting);
            this.dgv_ScheduleTab_Appointments.SelectionChanged += new System.EventHandler(this.dgv_ScheduleTab_Appointments_SelectionChanged);
            // 
            // tab_Customers
            // 
            this.tab_Customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tab_Customers.Controls.Add(this.btn_customerTab_Delete);
            this.tab_Customers.Controls.Add(this.btn_customerTab_New);
            this.tab_Customers.Controls.Add(this.btn_customerTab_Edit);
            this.tab_Customers.Controls.Add(this.btn_customerTab_Cancel);
            this.tab_Customers.Controls.Add(this.btn_customerTab_Save);
            this.tab_Customers.Controls.Add(this.lbl_customerTab_secondaryAddress);
            this.tab_Customers.Controls.Add(this.tb_customerTab_SecondaryAddress);
            this.tab_Customers.Controls.Add(this.lbl_customerTab_country);
            this.tab_Customers.Controls.Add(this.lbl_customerTab_city);
            this.tab_Customers.Controls.Add(this.lbl_customerTab_phoneNumber);
            this.tab_Customers.Controls.Add(this.lbl_customerTab_postalCode);
            this.tab_Customers.Controls.Add(this.lbl_customerTab_primaryAddress);
            this.tab_Customers.Controls.Add(this.lbl_customerTab_ID);
            this.tab_Customers.Controls.Add(this.lbl_customerTab_name);
            this.tab_Customers.Controls.Add(this.tb_customerTab_Country);
            this.tab_Customers.Controls.Add(this.tb_customerTab_City);
            this.tab_Customers.Controls.Add(this.tb_customerTab_PhoneNumber);
            this.tab_Customers.Controls.Add(this.tb_customerTab_PostalCode);
            this.tab_Customers.Controls.Add(this.tb_customerTab_PrimaryAddress);
            this.tab_Customers.Controls.Add(this.tb_customerTab_Name);
            this.tab_Customers.Controls.Add(this.tb_customerTab_ID);
            this.tab_Customers.Controls.Add(this.lbl_customerTab_Appointments);
            this.tab_Customers.Controls.Add(this.lbl_customerTab_customerNames);
            this.tab_Customers.Controls.Add(this.dgv_customerTab_Appointments);
            this.tab_Customers.Controls.Add(this.lv_customerTab_customerNames);
            this.tab_Customers.Location = new System.Drawing.Point(4, 29);
            this.tab_Customers.Name = "tab_Customers";
            this.tab_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Customers.Size = new System.Drawing.Size(1381, 541);
            this.tab_Customers.TabIndex = 3;
            this.tab_Customers.Text = "Customers";
            // 
            // btn_customerTab_Delete
            // 
            this.btn_customerTab_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerTab_Delete.Location = new System.Drawing.Point(437, 484);
            this.btn_customerTab_Delete.Name = "btn_customerTab_Delete";
            this.btn_customerTab_Delete.Size = new System.Drawing.Size(75, 30);
            this.btn_customerTab_Delete.TabIndex = 25;
            this.btn_customerTab_Delete.Text = "Delete";
            this.btn_customerTab_Delete.UseVisualStyleBackColor = true;
            this.btn_customerTab_Delete.Click += new System.EventHandler(this.btn_customerTab_Delete_Click);
            // 
            // btn_customerTab_New
            // 
            this.btn_customerTab_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerTab_New.Location = new System.Drawing.Point(210, 483);
            this.btn_customerTab_New.Name = "btn_customerTab_New";
            this.btn_customerTab_New.Size = new System.Drawing.Size(75, 30);
            this.btn_customerTab_New.TabIndex = 24;
            this.btn_customerTab_New.Text = "New";
            this.btn_customerTab_New.UseVisualStyleBackColor = true;
            this.btn_customerTab_New.Click += new System.EventHandler(this.btn_customerTab_New_Click);
            // 
            // btn_customerTab_Edit
            // 
            this.btn_customerTab_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerTab_Edit.Location = new System.Drawing.Point(325, 483);
            this.btn_customerTab_Edit.Name = "btn_customerTab_Edit";
            this.btn_customerTab_Edit.Size = new System.Drawing.Size(75, 30);
            this.btn_customerTab_Edit.TabIndex = 23;
            this.btn_customerTab_Edit.Text = "Edit";
            this.btn_customerTab_Edit.UseVisualStyleBackColor = true;
            this.btn_customerTab_Edit.Click += new System.EventHandler(this.btn_customerTab_Edit_Click);
            // 
            // btn_customerTab_Cancel
            // 
            this.btn_customerTab_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerTab_Cancel.Location = new System.Drawing.Point(437, 484);
            this.btn_customerTab_Cancel.Name = "btn_customerTab_Cancel";
            this.btn_customerTab_Cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_customerTab_Cancel.TabIndex = 22;
            this.btn_customerTab_Cancel.Text = "Cancel";
            this.btn_customerTab_Cancel.UseVisualStyleBackColor = true;
            this.btn_customerTab_Cancel.Visible = false;
            this.btn_customerTab_Cancel.Click += new System.EventHandler(this.btn_customerTab_Cancel_Click);
            // 
            // btn_customerTab_Save
            // 
            this.btn_customerTab_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerTab_Save.Location = new System.Drawing.Point(210, 484);
            this.btn_customerTab_Save.Name = "btn_customerTab_Save";
            this.btn_customerTab_Save.Size = new System.Drawing.Size(75, 30);
            this.btn_customerTab_Save.TabIndex = 21;
            this.btn_customerTab_Save.Text = "Save";
            this.btn_customerTab_Save.UseVisualStyleBackColor = true;
            this.btn_customerTab_Save.Visible = false;
            this.btn_customerTab_Save.Click += new System.EventHandler(this.btn_customerTab_Save_Click);
            // 
            // lbl_customerTab_secondaryAddress
            // 
            this.lbl_customerTab_secondaryAddress.AutoSize = true;
            this.lbl_customerTab_secondaryAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_secondaryAddress.Location = new System.Drawing.Point(207, 185);
            this.lbl_customerTab_secondaryAddress.Name = "lbl_customerTab_secondaryAddress";
            this.lbl_customerTab_secondaryAddress.Size = new System.Drawing.Size(148, 20);
            this.lbl_customerTab_secondaryAddress.TabIndex = 20;
            this.lbl_customerTab_secondaryAddress.Text = "Secondary Address";
            // 
            // tb_customerTab_SecondaryAddress
            // 
            this.tb_customerTab_SecondaryAddress.Enabled = false;
            this.tb_customerTab_SecondaryAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerTab_SecondaryAddress.Location = new System.Drawing.Point(211, 208);
            this.tb_customerTab_SecondaryAddress.Name = "tb_customerTab_SecondaryAddress";
            this.tb_customerTab_SecondaryAddress.Size = new System.Drawing.Size(300, 26);
            this.tb_customerTab_SecondaryAddress.TabIndex = 19;
            // 
            // lbl_customerTab_country
            // 
            this.lbl_customerTab_country.AutoSize = true;
            this.lbl_customerTab_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_country.Location = new System.Drawing.Point(360, 321);
            this.lbl_customerTab_country.Name = "lbl_customerTab_country";
            this.lbl_customerTab_country.Size = new System.Drawing.Size(64, 20);
            this.lbl_customerTab_country.TabIndex = 17;
            this.lbl_customerTab_country.Text = "Country";
            // 
            // lbl_customerTab_city
            // 
            this.lbl_customerTab_city.AutoSize = true;
            this.lbl_customerTab_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_city.Location = new System.Drawing.Point(207, 321);
            this.lbl_customerTab_city.Name = "lbl_customerTab_city";
            this.lbl_customerTab_city.Size = new System.Drawing.Size(35, 20);
            this.lbl_customerTab_city.TabIndex = 16;
            this.lbl_customerTab_city.Text = "City";
            // 
            // lbl_customerTab_phoneNumber
            // 
            this.lbl_customerTab_phoneNumber.AutoSize = true;
            this.lbl_customerTab_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_phoneNumber.Location = new System.Drawing.Point(360, 253);
            this.lbl_customerTab_phoneNumber.Name = "lbl_customerTab_phoneNumber";
            this.lbl_customerTab_phoneNumber.Size = new System.Drawing.Size(115, 20);
            this.lbl_customerTab_phoneNumber.TabIndex = 15;
            this.lbl_customerTab_phoneNumber.Text = "Phone Number";
            // 
            // lbl_customerTab_postalCode
            // 
            this.lbl_customerTab_postalCode.AutoSize = true;
            this.lbl_customerTab_postalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_postalCode.Location = new System.Drawing.Point(207, 253);
            this.lbl_customerTab_postalCode.Name = "lbl_customerTab_postalCode";
            this.lbl_customerTab_postalCode.Size = new System.Drawing.Size(95, 20);
            this.lbl_customerTab_postalCode.TabIndex = 14;
            this.lbl_customerTab_postalCode.Text = "Postal Code";
            // 
            // lbl_customerTab_primaryAddress
            // 
            this.lbl_customerTab_primaryAddress.AutoSize = true;
            this.lbl_customerTab_primaryAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_primaryAddress.Location = new System.Drawing.Point(207, 116);
            this.lbl_customerTab_primaryAddress.Name = "lbl_customerTab_primaryAddress";
            this.lbl_customerTab_primaryAddress.Size = new System.Drawing.Size(124, 20);
            this.lbl_customerTab_primaryAddress.TabIndex = 13;
            this.lbl_customerTab_primaryAddress.Text = "Primary Address";
            // 
            // lbl_customerTab_ID
            // 
            this.lbl_customerTab_ID.AutoSize = true;
            this.lbl_customerTab_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_ID.Location = new System.Drawing.Point(407, 53);
            this.lbl_customerTab_ID.Name = "lbl_customerTab_ID";
            this.lbl_customerTab_ID.Size = new System.Drawing.Size(26, 20);
            this.lbl_customerTab_ID.TabIndex = 12;
            this.lbl_customerTab_ID.Text = "ID";
            // 
            // lbl_customerTab_name
            // 
            this.lbl_customerTab_name.AutoSize = true;
            this.lbl_customerTab_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_name.Location = new System.Drawing.Point(207, 53);
            this.lbl_customerTab_name.Name = "lbl_customerTab_name";
            this.lbl_customerTab_name.Size = new System.Drawing.Size(51, 20);
            this.lbl_customerTab_name.TabIndex = 11;
            this.lbl_customerTab_name.Text = "Name";
            // 
            // tb_customerTab_Country
            // 
            this.tb_customerTab_Country.Enabled = false;
            this.tb_customerTab_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerTab_Country.Location = new System.Drawing.Point(364, 344);
            this.tb_customerTab_Country.Name = "tb_customerTab_Country";
            this.tb_customerTab_Country.Size = new System.Drawing.Size(147, 26);
            this.tb_customerTab_Country.TabIndex = 10;
            // 
            // tb_customerTab_City
            // 
            this.tb_customerTab_City.Enabled = false;
            this.tb_customerTab_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerTab_City.Location = new System.Drawing.Point(209, 344);
            this.tb_customerTab_City.Name = "tb_customerTab_City";
            this.tb_customerTab_City.Size = new System.Drawing.Size(129, 26);
            this.tb_customerTab_City.TabIndex = 9;
            // 
            // tb_customerTab_PhoneNumber
            // 
            this.tb_customerTab_PhoneNumber.Enabled = false;
            this.tb_customerTab_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerTab_PhoneNumber.Location = new System.Drawing.Point(364, 276);
            this.tb_customerTab_PhoneNumber.Name = "tb_customerTab_PhoneNumber";
            this.tb_customerTab_PhoneNumber.Size = new System.Drawing.Size(147, 26);
            this.tb_customerTab_PhoneNumber.TabIndex = 8;
            // 
            // tb_customerTab_PostalCode
            // 
            this.tb_customerTab_PostalCode.Enabled = false;
            this.tb_customerTab_PostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerTab_PostalCode.Location = new System.Drawing.Point(209, 276);
            this.tb_customerTab_PostalCode.Name = "tb_customerTab_PostalCode";
            this.tb_customerTab_PostalCode.Size = new System.Drawing.Size(129, 26);
            this.tb_customerTab_PostalCode.TabIndex = 7;
            // 
            // tb_customerTab_PrimaryAddress
            // 
            this.tb_customerTab_PrimaryAddress.Enabled = false;
            this.tb_customerTab_PrimaryAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerTab_PrimaryAddress.Location = new System.Drawing.Point(211, 139);
            this.tb_customerTab_PrimaryAddress.Name = "tb_customerTab_PrimaryAddress";
            this.tb_customerTab_PrimaryAddress.Size = new System.Drawing.Size(300, 26);
            this.tb_customerTab_PrimaryAddress.TabIndex = 6;
            // 
            // tb_customerTab_Name
            // 
            this.tb_customerTab_Name.Enabled = false;
            this.tb_customerTab_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerTab_Name.Location = new System.Drawing.Point(211, 76);
            this.tb_customerTab_Name.Name = "tb_customerTab_Name";
            this.tb_customerTab_Name.Size = new System.Drawing.Size(174, 26);
            this.tb_customerTab_Name.TabIndex = 5;
            // 
            // tb_customerTab_ID
            // 
            this.tb_customerTab_ID.Enabled = false;
            this.tb_customerTab_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerTab_ID.Location = new System.Drawing.Point(411, 76);
            this.tb_customerTab_ID.Name = "tb_customerTab_ID";
            this.tb_customerTab_ID.Size = new System.Drawing.Size(100, 26);
            this.tb_customerTab_ID.TabIndex = 4;
            // 
            // lbl_customerTab_Appointments
            // 
            this.lbl_customerTab_Appointments.AutoSize = true;
            this.lbl_customerTab_Appointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_Appointments.Location = new System.Drawing.Point(554, 31);
            this.lbl_customerTab_Appointments.Name = "lbl_customerTab_Appointments";
            this.lbl_customerTab_Appointments.Size = new System.Drawing.Size(126, 24);
            this.lbl_customerTab_Appointments.TabIndex = 3;
            this.lbl_customerTab_Appointments.Text = "Appointments";
            // 
            // lbl_customerTab_customerNames
            // 
            this.lbl_customerTab_customerNames.AutoSize = true;
            this.lbl_customerTab_customerNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_customerNames.Location = new System.Drawing.Point(2, 31);
            this.lbl_customerTab_customerNames.Name = "lbl_customerTab_customerNames";
            this.lbl_customerTab_customerNames.Size = new System.Drawing.Size(70, 24);
            this.lbl_customerTab_customerNames.TabIndex = 2;
            this.lbl_customerTab_customerNames.Text = "Names";
            // 
            // dgv_customerTab_Appointments
            // 
            this.dgv_customerTab_Appointments.AllowUserToAddRows = false;
            this.dgv_customerTab_Appointments.AllowUserToDeleteRows = false;
            this.dgv_customerTab_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customerTab_Appointments.Location = new System.Drawing.Point(558, 58);
            this.dgv_customerTab_Appointments.Name = "dgv_customerTab_Appointments";
            this.dgv_customerTab_Appointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_customerTab_Appointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_customerTab_Appointments.Size = new System.Drawing.Size(823, 460);
            this.dgv_customerTab_Appointments.TabIndex = 1;
            this.dgv_customerTab_Appointments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_customerTab_Appointments_CellFormatting);
            // 
            // lv_customerTab_customerNames
            // 
            this.lv_customerTab_customerNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_customerTab_customerNames.HideSelection = false;
            this.lv_customerTab_customerNames.Location = new System.Drawing.Point(6, 58);
            this.lv_customerTab_customerNames.Name = "lv_customerTab_customerNames";
            this.lv_customerTab_customerNames.Size = new System.Drawing.Size(160, 460);
            this.lv_customerTab_customerNames.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_customerTab_customerNames.TabIndex = 0;
            this.lv_customerTab_customerNames.UseCompatibleStateImageBehavior = false;
            this.lv_customerTab_customerNames.SelectedIndexChanged += new System.EventHandler(this.lv_customerTab_SelectedIndexChanged);
            // 
            // tab_Reports
            // 
            this.tab_Reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tab_Reports.Controls.Add(this.pnl_reportsTab_reports);
            this.tab_Reports.Controls.Add(this.pnl_reportsTab_options);
            this.tab_Reports.Location = new System.Drawing.Point(4, 29);
            this.tab_Reports.Name = "tab_Reports";
            this.tab_Reports.Size = new System.Drawing.Size(1381, 541);
            this.tab_Reports.TabIndex = 2;
            this.tab_Reports.Text = "Reports";
            // 
            // pnl_reportsTab_reports
            // 
            this.pnl_reportsTab_reports.Controls.Add(this.dgv_reportsTab_reportTable);
            this.pnl_reportsTab_reports.Location = new System.Drawing.Point(275, 6);
            this.pnl_reportsTab_reports.Name = "pnl_reportsTab_reports";
            this.pnl_reportsTab_reports.Size = new System.Drawing.Size(1103, 535);
            this.pnl_reportsTab_reports.TabIndex = 3;
            // 
            // dgv_reportsTab_reportTable
            // 
            this.dgv_reportsTab_reportTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgv_reportsTab_reportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reportsTab_reportTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgv_reportsTab_reportTable.Location = new System.Drawing.Point(3, 3);
            this.dgv_reportsTab_reportTable.Name = "dgv_reportsTab_reportTable";
            this.dgv_reportsTab_reportTable.Size = new System.Drawing.Size(1097, 529);
            this.dgv_reportsTab_reportTable.TabIndex = 0;
            this.dgv_reportsTab_reportTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_reportsTab_reportTable_CellFormatting);
            // 
            // pnl_reportsTab_options
            // 
            this.pnl_reportsTab_options.Controls.Add(this.rb_reportsTab_consultantSchedule);
            this.pnl_reportsTab_options.Controls.Add(this.cb_reportsTab_type);
            this.pnl_reportsTab_options.Controls.Add(this.cb_reportsTab_month);
            this.pnl_reportsTab_options.Controls.Add(this.rb_reportsTab_appointmentByType);
            this.pnl_reportsTab_options.Controls.Add(this.rb_reportsTab_appointmentsByCustomer);
            this.pnl_reportsTab_options.Controls.Add(this.btn_reportsTab_clearSelection);
            this.pnl_reportsTab_options.Controls.Add(this.btn_reportsTab_generateReport);
            this.pnl_reportsTab_options.Location = new System.Drawing.Point(6, 6);
            this.pnl_reportsTab_options.Name = "pnl_reportsTab_options";
            this.pnl_reportsTab_options.Size = new System.Drawing.Size(266, 535);
            this.pnl_reportsTab_options.TabIndex = 2;
            // 
            // rb_reportsTab_consultantSchedule
            // 
            this.rb_reportsTab_consultantSchedule.AutoSize = true;
            this.rb_reportsTab_consultantSchedule.Location = new System.Drawing.Point(12, 184);
            this.rb_reportsTab_consultantSchedule.Name = "rb_reportsTab_consultantSchedule";
            this.rb_reportsTab_consultantSchedule.Size = new System.Drawing.Size(203, 24);
            this.rb_reportsTab_consultantSchedule.TabIndex = 7;
            this.rb_reportsTab_consultantSchedule.TabStop = true;
            this.rb_reportsTab_consultantSchedule.Text = "Schedule Per Consultant";
            this.rb_reportsTab_consultantSchedule.UseVisualStyleBackColor = true;
            // 
            // cb_reportsTab_type
            // 
            this.cb_reportsTab_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_reportsTab_type.FormattingEnabled = true;
            this.cb_reportsTab_type.Location = new System.Drawing.Point(133, 84);
            this.cb_reportsTab_type.Name = "cb_reportsTab_type";
            this.cb_reportsTab_type.Size = new System.Drawing.Size(111, 28);
            this.cb_reportsTab_type.TabIndex = 6;
            // 
            // cb_reportsTab_month
            // 
            this.cb_reportsTab_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_reportsTab_month.FormattingEnabled = true;
            this.cb_reportsTab_month.Location = new System.Drawing.Point(12, 84);
            this.cb_reportsTab_month.Name = "cb_reportsTab_month";
            this.cb_reportsTab_month.Size = new System.Drawing.Size(111, 28);
            this.cb_reportsTab_month.TabIndex = 5;
            // 
            // rb_reportsTab_appointmentByType
            // 
            this.rb_reportsTab_appointmentByType.AutoSize = true;
            this.rb_reportsTab_appointmentByType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_reportsTab_appointmentByType.Location = new System.Drawing.Point(12, 56);
            this.rb_reportsTab_appointmentByType.Name = "rb_reportsTab_appointmentByType";
            this.rb_reportsTab_appointmentByType.Size = new System.Drawing.Size(173, 22);
            this.rb_reportsTab_appointmentByType.TabIndex = 4;
            this.rb_reportsTab_appointmentByType.Text = "Appointments By Type";
            this.rb_reportsTab_appointmentByType.UseVisualStyleBackColor = true;
            // 
            // rb_reportsTab_appointmentsByCustomer
            // 
            this.rb_reportsTab_appointmentsByCustomer.AutoSize = true;
            this.rb_reportsTab_appointmentsByCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_reportsTab_appointmentsByCustomer.Location = new System.Drawing.Point(12, 140);
            this.rb_reportsTab_appointmentsByCustomer.Name = "rb_reportsTab_appointmentsByCustomer";
            this.rb_reportsTab_appointmentsByCustomer.Size = new System.Drawing.Size(250, 22);
            this.rb_reportsTab_appointmentsByCustomer.TabIndex = 3;
            this.rb_reportsTab_appointmentsByCustomer.Text = "Appointment Totals Per Customer";
            this.rb_reportsTab_appointmentsByCustomer.UseVisualStyleBackColor = true;
            // 
            // btn_reportsTab_clearSelection
            // 
            this.btn_reportsTab_clearSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportsTab_clearSelection.Location = new System.Drawing.Point(133, 482);
            this.btn_reportsTab_clearSelection.Name = "btn_reportsTab_clearSelection";
            this.btn_reportsTab_clearSelection.Size = new System.Drawing.Size(75, 31);
            this.btn_reportsTab_clearSelection.TabIndex = 1;
            this.btn_reportsTab_clearSelection.Text = "Clear";
            this.btn_reportsTab_clearSelection.UseVisualStyleBackColor = true;
            this.btn_reportsTab_clearSelection.Click += new System.EventHandler(this.btn_reportsTab_clearSelection_Click);
            // 
            // btn_reportsTab_generateReport
            // 
            this.btn_reportsTab_generateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportsTab_generateReport.Location = new System.Drawing.Point(31, 482);
            this.btn_reportsTab_generateReport.Name = "btn_reportsTab_generateReport";
            this.btn_reportsTab_generateReport.Size = new System.Drawing.Size(75, 31);
            this.btn_reportsTab_generateReport.TabIndex = 0;
            this.btn_reportsTab_generateReport.Text = "Generate";
            this.btn_reportsTab_generateReport.UseVisualStyleBackColor = true;
            this.btn_reportsTab_generateReport.Click += new System.EventHandler(this.btn_reportsTab_generateReport_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_DateLocal);
            this.panel1.Controls.Add(this.lbl_TimeLocal);
            this.panel1.Location = new System.Drawing.Point(3, 662);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1397, 33);
            this.panel1.TabIndex = 4;
            // 
            // lbl_DateLocal
            // 
            this.lbl_DateLocal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_DateLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateLocal.Location = new System.Drawing.Point(0, 1);
            this.lbl_DateLocal.Name = "lbl_DateLocal";
            this.lbl_DateLocal.Size = new System.Drawing.Size(121, 29);
            this.lbl_DateLocal.TabIndex = 6;
            this.lbl_DateLocal.Text = "LocalDate";
            this.lbl_DateLocal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_TimeLocal
            // 
            this.lbl_TimeLocal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_TimeLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeLocal.Location = new System.Drawing.Point(1258, 1);
            this.lbl_TimeLocal.Name = "lbl_TimeLocal";
            this.lbl_TimeLocal.Size = new System.Drawing.Size(127, 29);
            this.lbl_TimeLocal.TabIndex = 5;
            this.lbl_TimeLocal.Text = "LocalTime";
            this.lbl_TimeLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer_DateTimeLabel
            // 
            this.timer_DateTimeLabel.Enabled = true;
            this.timer_DateTimeLabel.Interval = 500;
            this.timer_DateTimeLabel.Tick += new System.EventHandler(this.timer_DateTimeLabel_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Controls.Add(this.flpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_Event_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_Event_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_Event_MouseUp);
            this.flpMain.ResumeLayout(false);
            this.pnl_Tabs.ResumeLayout(false);
            this.pnl_Tabs.PerformLayout();
            this.pnl_WindowButtons.ResumeLayout(false);
            this.tabControl_Main.ResumeLayout(false);
            this.tab_Home.ResumeLayout(false);
            this.tab_Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allAppointments)).EndInit();
            this.tab_Schedule.ResumeLayout(false);
            this.tab_Schedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScheduleTab_Appointments)).EndInit();
            this.tab_Customers.ResumeLayout(false);
            this.tab_Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerTab_Appointments)).EndInit();
            this.tab_Reports.ResumeLayout(false);
            this.pnl_reportsTab_reports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reportsTab_reportTable)).EndInit();
            this.pnl_reportsTab_options.ResumeLayout(false);
            this.pnl_reportsTab_options.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Panel pnl_Tabs;
        private System.Windows.Forms.Panel pnl_WindowButtons;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tab_Home;
        private System.Windows.Forms.TabPage tab_Schedule;
        private System.Windows.Forms.TabPage tab_Reports;
        private System.Windows.Forms.Label lbl_LoggedInUserMsg;
        private System.Windows.Forms.Label lbl_TimeLocal;
        private System.Windows.Forms.Timer timer_DateTimeLabel;
        private System.Windows.Forms.Label lbl_DateLocal;
        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label lbl_userID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_allAppointments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tab_Customers;
        private System.Windows.Forms.ListView lv_customerTab_customerNames;
        private System.Windows.Forms.TextBox tb_customerTab_PrimaryAddress;
        private System.Windows.Forms.TextBox tb_customerTab_Name;
        private System.Windows.Forms.TextBox tb_customerTab_ID;
        private System.Windows.Forms.Label lbl_customerTab_Appointments;
        private System.Windows.Forms.Label lbl_customerTab_customerNames;
        private System.Windows.Forms.DataGridView dgv_customerTab_Appointments;
        private System.Windows.Forms.Label lbl_customerTab_country;
        private System.Windows.Forms.Label lbl_customerTab_city;
        private System.Windows.Forms.Label lbl_customerTab_phoneNumber;
        private System.Windows.Forms.Label lbl_customerTab_postalCode;
        private System.Windows.Forms.Label lbl_customerTab_primaryAddress;
        private System.Windows.Forms.Label lbl_customerTab_ID;
        private System.Windows.Forms.Label lbl_customerTab_name;
        private System.Windows.Forms.TextBox tb_customerTab_Country;
        private System.Windows.Forms.TextBox tb_customerTab_City;
        private System.Windows.Forms.TextBox tb_customerTab_PhoneNumber;
        private System.Windows.Forms.TextBox tb_customerTab_PostalCode;
        private System.Windows.Forms.Label lbl_customerTab_secondaryAddress;
        private System.Windows.Forms.TextBox tb_customerTab_SecondaryAddress;
        private System.Windows.Forms.Button btn_customerTab_Cancel;
        private System.Windows.Forms.Button btn_customerTab_Save;
        private System.Windows.Forms.DataGridView dgv_ScheduleTab_Appointments;
        private System.Windows.Forms.ComboBox cb_ScheduleTab_Type;
        private System.Windows.Forms.TextBox tb_ScheduleTab_Contact;
        private System.Windows.Forms.DateTimePicker dtPicker_ScheduleTab_EndDate;
        private System.Windows.Forms.DateTimePicker dtPicker_ScheduleTab_StartDate;
        private System.Windows.Forms.TextBox tb_ScheduleTab_Location;
        private System.Windows.Forms.TextBox tb_ScheduleTab_Url;
        private System.Windows.Forms.TextBox tb_ScheduleTab_Description;
        private System.Windows.Forms.TextBox tb_ScheduleTab_Title;
        private System.Windows.Forms.DateTimePicker dtPicker_ScheduleTab_EndTime;
        private System.Windows.Forms.DateTimePicker dtPicker_ScheduleTab_StartTime;
        private System.Windows.Forms.ListView lv_scheduleTab_customerNames;
        private System.Windows.Forms.Button btn_scheduleTab_Cancel;
        private System.Windows.Forms.Button btn_scheduleTab_Save;
        private System.Windows.Forms.Button btn_customerTab_New;
        private System.Windows.Forms.Button btn_customerTab_Edit;
        private System.Windows.Forms.Button btn_customerTab_Delete;
        private System.Windows.Forms.Button btn_scheduleTab_Edit;
        private System.Windows.Forms.Button btn_scheduleTab_Delete;
        private System.Windows.Forms.Label lbl_scheduleTab_Appointments;
        private System.Windows.Forms.Label lbl_scheduleTab_Customers;
        private System.Windows.Forms.Label lbl_scheduleTab_End;
        private System.Windows.Forms.Label lbl_scheduleTab_Start;
        private System.Windows.Forms.Label lbl_scheduleTab_Url;
        private System.Windows.Forms.Label lbl_scheduleTab_Type;
        private System.Windows.Forms.Label lbl_scheduleTab_Contact;
        private System.Windows.Forms.Label lbl_scheduleTab_Description;
        private System.Windows.Forms.Label lbl_scheduleTab_Location;
        private System.Windows.Forms.Label lbl_scheduleTab_Title;
        private System.Windows.Forms.Button btn_scheduleTab_New;
        private System.Windows.Forms.Timer t_scheduleTab_DtPickers;
        private System.Windows.Forms.Button btn_scheduleTab_ViewCustomerRecord;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnl_reportsTab_reports;
        private System.Windows.Forms.Panel pnl_reportsTab_options;
        private System.Windows.Forms.RadioButton rb_reportsTab_appointmentByType;
        private System.Windows.Forms.RadioButton rb_reportsTab_appointmentsByCustomer;
        private System.Windows.Forms.Button btn_reportsTab_clearSelection;
        private System.Windows.Forms.Button btn_reportsTab_generateReport;
        private System.Windows.Forms.DataGridView dgv_reportsTab_reportTable;
        private System.Windows.Forms.RadioButton rb_reportsTab_consultantSchedule;
        private System.Windows.Forms.ComboBox cb_reportsTab_type;
        private System.Windows.Forms.ComboBox cb_reportsTab_month;
        private System.Windows.Forms.Label lbl_homeTab_to;
        private System.Windows.Forms.Label lbl_homeTab_from;
        private System.Windows.Forms.DateTimePicker dt_homeTab_to;
        private System.Windows.Forms.DateTimePicker dt_homeTab_from;
    }
}