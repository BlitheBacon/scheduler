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
            this.dgv_upcomingAppointments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_Schedule = new System.Windows.Forms.TabPage();
            this.lv_ScheduleTab_customerNames = new System.Windows.Forms.ListView();
            this.btn_ScheduleTab_Reset = new System.Windows.Forms.Button();
            this.btn_ScheduleTab_Save = new System.Windows.Forms.Button();
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
            this.btn_customerTab_New = new System.Windows.Forms.Button();
            this.btn_customerTab_Edit = new System.Windows.Forms.Button();
            this.btn_customerTab_Cancel = new System.Windows.Forms.Button();
            this.btn_customerTab_Save = new System.Windows.Forms.Button();
            this.lbl_customerTab_secondaryAddress = new System.Windows.Forms.Label();
            this.tb_customerTab_SecondaryAddress = new System.Windows.Forms.TextBox();
            this.lbl_customerTab_customerData = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_DateLocal = new System.Windows.Forms.Label();
            this.lbl_TimeLocal = new System.Windows.Forms.Label();
            this.timer_DateTimeLabel = new System.Windows.Forms.Timer(this.components);
            this.btn_customerTab_Delete = new System.Windows.Forms.Button();
            this.flpMain.SuspendLayout();
            this.pnl_Tabs.SuspendLayout();
            this.pnl_WindowButtons.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tab_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_upcomingAppointments)).BeginInit();
            this.tab_Schedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScheduleTab_Appointments)).BeginInit();
            this.tab_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerTab_Appointments)).BeginInit();
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
            this.tabControl_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Main.HotTrack = true;
            this.tabControl_Main.Location = new System.Drawing.Point(3, 82);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1389, 574);
            this.tabControl_Main.TabIndex = 2;
            // 
            // tab_Home
            // 
            this.tab_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tab_Home.Controls.Add(this.dgv_upcomingAppointments);
            this.tab_Home.Controls.Add(this.label1);
            this.tab_Home.ForeColor = System.Drawing.Color.Black;
            this.tab_Home.Location = new System.Drawing.Point(4, 33);
            this.tab_Home.Name = "tab_Home";
            this.tab_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Home.Size = new System.Drawing.Size(1381, 537);
            this.tab_Home.TabIndex = 0;
            this.tab_Home.Text = "Home";
            this.tab_Home.Click += new System.EventHandler(this.tab_Home_Click);
            // 
            // dgv_upcomingAppointments
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_upcomingAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_upcomingAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_upcomingAppointments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgv_upcomingAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_upcomingAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_upcomingAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_upcomingAppointments.ColumnHeadersHeight = 28;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_upcomingAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_upcomingAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgv_upcomingAppointments.Location = new System.Drawing.Point(6, 81);
            this.dgv_upcomingAppointments.Name = "dgv_upcomingAppointments";
            this.dgv_upcomingAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_upcomingAppointments.Size = new System.Drawing.Size(760, 282);
            this.dgv_upcomingAppointments.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upcoming Appointments";
            // 
            // tab_Schedule
            // 
            this.tab_Schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tab_Schedule.Controls.Add(this.lv_ScheduleTab_customerNames);
            this.tab_Schedule.Controls.Add(this.btn_ScheduleTab_Reset);
            this.tab_Schedule.Controls.Add(this.btn_ScheduleTab_Save);
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
            this.tab_Schedule.Location = new System.Drawing.Point(4, 33);
            this.tab_Schedule.Name = "tab_Schedule";
            this.tab_Schedule.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Schedule.Size = new System.Drawing.Size(1381, 537);
            this.tab_Schedule.TabIndex = 1;
            this.tab_Schedule.Text = "Schedule";
            // 
            // lv_ScheduleTab_customerNames
            // 
            this.lv_ScheduleTab_customerNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_ScheduleTab_customerNames.HideSelection = false;
            this.lv_ScheduleTab_customerNames.Location = new System.Drawing.Point(6, 71);
            this.lv_ScheduleTab_customerNames.Name = "lv_ScheduleTab_customerNames";
            this.lv_ScheduleTab_customerNames.Size = new System.Drawing.Size(160, 460);
            this.lv_ScheduleTab_customerNames.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_ScheduleTab_customerNames.TabIndex = 15;
            this.lv_ScheduleTab_customerNames.UseCompatibleStateImageBehavior = false;
            this.lv_ScheduleTab_customerNames.SelectedIndexChanged += new System.EventHandler(this.lv_ScheduleTab_customerNames_SelectedIndexChanged);
            // 
            // btn_ScheduleTab_Reset
            // 
            this.btn_ScheduleTab_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ScheduleTab_Reset.Location = new System.Drawing.Point(428, 480);
            this.btn_ScheduleTab_Reset.Name = "btn_ScheduleTab_Reset";
            this.btn_ScheduleTab_Reset.Size = new System.Drawing.Size(75, 25);
            this.btn_ScheduleTab_Reset.TabIndex = 14;
            this.btn_ScheduleTab_Reset.Text = "Reset";
            this.btn_ScheduleTab_Reset.UseVisualStyleBackColor = true;
            // 
            // btn_ScheduleTab_Save
            // 
            this.btn_ScheduleTab_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ScheduleTab_Save.Location = new System.Drawing.Point(268, 480);
            this.btn_ScheduleTab_Save.Name = "btn_ScheduleTab_Save";
            this.btn_ScheduleTab_Save.Size = new System.Drawing.Size(75, 25);
            this.btn_ScheduleTab_Save.TabIndex = 13;
            this.btn_ScheduleTab_Save.Text = "Save";
            this.btn_ScheduleTab_Save.UseVisualStyleBackColor = true;
            // 
            // dtPicker_ScheduleTab_EndTime
            // 
            this.dtPicker_ScheduleTab_EndTime.CustomFormat = "HH:mm";
            this.dtPicker_ScheduleTab_EndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker_ScheduleTab_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker_ScheduleTab_EndTime.Location = new System.Drawing.Point(492, 415);
            this.dtPicker_ScheduleTab_EndTime.Name = "dtPicker_ScheduleTab_EndTime";
            this.dtPicker_ScheduleTab_EndTime.ShowUpDown = true;
            this.dtPicker_ScheduleTab_EndTime.Size = new System.Drawing.Size(66, 24);
            this.dtPicker_ScheduleTab_EndTime.TabIndex = 12;
            this.dtPicker_ScheduleTab_EndTime.ValueChanged += new System.EventHandler(this.dtPicker_ScheduleTab_Time_ValueChanged);
            // 
            // dtPicker_ScheduleTab_StartTime
            // 
            this.dtPicker_ScheduleTab_StartTime.CustomFormat = "HH:mm";
            this.dtPicker_ScheduleTab_StartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker_ScheduleTab_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker_ScheduleTab_StartTime.Location = new System.Drawing.Point(492, 351);
            this.dtPicker_ScheduleTab_StartTime.Name = "dtPicker_ScheduleTab_StartTime";
            this.dtPicker_ScheduleTab_StartTime.ShowUpDown = true;
            this.dtPicker_ScheduleTab_StartTime.Size = new System.Drawing.Size(66, 24);
            this.dtPicker_ScheduleTab_StartTime.TabIndex = 11;
            this.dtPicker_ScheduleTab_StartTime.ValueChanged += new System.EventHandler(this.dtPicker_ScheduleTab_Time_ValueChanged);
            // 
            // cb_ScheduleTab_Type
            // 
            this.cb_ScheduleTab_Type.FormattingEnabled = true;
            this.cb_ScheduleTab_Type.Location = new System.Drawing.Point(382, 183);
            this.cb_ScheduleTab_Type.Name = "cb_ScheduleTab_Type";
            this.cb_ScheduleTab_Type.Size = new System.Drawing.Size(121, 32);
            this.cb_ScheduleTab_Type.TabIndex = 10;
            // 
            // tb_ScheduleTab_Contact
            // 
            this.tb_ScheduleTab_Contact.Location = new System.Drawing.Point(223, 183);
            this.tb_ScheduleTab_Contact.Name = "tb_ScheduleTab_Contact";
            this.tb_ScheduleTab_Contact.Size = new System.Drawing.Size(100, 29);
            this.tb_ScheduleTab_Contact.TabIndex = 9;
            // 
            // dtPicker_ScheduleTab_EndDate
            // 
            this.dtPicker_ScheduleTab_EndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker_ScheduleTab_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker_ScheduleTab_EndDate.Location = new System.Drawing.Point(214, 415);
            this.dtPicker_ScheduleTab_EndDate.Name = "dtPicker_ScheduleTab_EndDate";
            this.dtPicker_ScheduleTab_EndDate.Size = new System.Drawing.Size(257, 24);
            this.dtPicker_ScheduleTab_EndDate.TabIndex = 8;
            // 
            // dtPicker_ScheduleTab_StartDate
            // 
            this.dtPicker_ScheduleTab_StartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker_ScheduleTab_StartDate.CustomFormat = "";
            this.dtPicker_ScheduleTab_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker_ScheduleTab_StartDate.Location = new System.Drawing.Point(214, 351);
            this.dtPicker_ScheduleTab_StartDate.Name = "dtPicker_ScheduleTab_StartDate";
            this.dtPicker_ScheduleTab_StartDate.Size = new System.Drawing.Size(257, 24);
            this.dtPicker_ScheduleTab_StartDate.TabIndex = 7;
            // 
            // tb_ScheduleTab_Location
            // 
            this.tb_ScheduleTab_Location.Location = new System.Drawing.Point(458, 71);
            this.tb_ScheduleTab_Location.Name = "tb_ScheduleTab_Location";
            this.tb_ScheduleTab_Location.Size = new System.Drawing.Size(100, 29);
            this.tb_ScheduleTab_Location.TabIndex = 6;
            // 
            // tb_ScheduleTab_Url
            // 
            this.tb_ScheduleTab_Url.Location = new System.Drawing.Point(202, 235);
            this.tb_ScheduleTab_Url.Name = "tb_ScheduleTab_Url";
            this.tb_ScheduleTab_Url.Size = new System.Drawing.Size(366, 29);
            this.tb_ScheduleTab_Url.TabIndex = 5;
            // 
            // tb_ScheduleTab_Description
            // 
            this.tb_ScheduleTab_Description.Location = new System.Drawing.Point(202, 148);
            this.tb_ScheduleTab_Description.Name = "tb_ScheduleTab_Description";
            this.tb_ScheduleTab_Description.Size = new System.Drawing.Size(366, 29);
            this.tb_ScheduleTab_Description.TabIndex = 3;
            // 
            // tb_ScheduleTab_Title
            // 
            this.tb_ScheduleTab_Title.Location = new System.Drawing.Point(202, 71);
            this.tb_ScheduleTab_Title.Name = "tb_ScheduleTab_Title";
            this.tb_ScheduleTab_Title.Size = new System.Drawing.Size(185, 29);
            this.tb_ScheduleTab_Title.TabIndex = 2;
            // 
            // dgv_ScheduleTab_Appointments
            // 
            this.dgv_ScheduleTab_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ScheduleTab_Appointments.Location = new System.Drawing.Point(609, 71);
            this.dgv_ScheduleTab_Appointments.Name = "dgv_ScheduleTab_Appointments";
            this.dgv_ScheduleTab_Appointments.Size = new System.Drawing.Size(769, 460);
            this.dgv_ScheduleTab_Appointments.TabIndex = 1;
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
            this.tab_Customers.Controls.Add(this.lbl_customerTab_customerData);
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
            this.tab_Customers.Location = new System.Drawing.Point(4, 33);
            this.tab_Customers.Name = "tab_Customers";
            this.tab_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Customers.Size = new System.Drawing.Size(1381, 537);
            this.tab_Customers.TabIndex = 3;
            this.tab_Customers.Text = "Customers";
            // 
            // btn_customerTab_New
            // 
            this.btn_customerTab_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerTab_New.Location = new System.Drawing.Point(206, 473);
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
            this.btn_customerTab_Edit.Location = new System.Drawing.Point(321, 473);
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
            this.btn_customerTab_Cancel.Location = new System.Drawing.Point(433, 474);
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
            this.btn_customerTab_Save.Location = new System.Drawing.Point(206, 474);
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
            this.lbl_customerTab_secondaryAddress.Location = new System.Drawing.Point(204, 230);
            this.lbl_customerTab_secondaryAddress.Name = "lbl_customerTab_secondaryAddress";
            this.lbl_customerTab_secondaryAddress.Size = new System.Drawing.Size(148, 20);
            this.lbl_customerTab_secondaryAddress.TabIndex = 20;
            this.lbl_customerTab_secondaryAddress.Text = "Secondary Address";
            // 
            // tb_customerTab_SecondaryAddress
            // 
            this.tb_customerTab_SecondaryAddress.Enabled = false;
            this.tb_customerTab_SecondaryAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerTab_SecondaryAddress.Location = new System.Drawing.Point(208, 253);
            this.tb_customerTab_SecondaryAddress.Name = "tb_customerTab_SecondaryAddress";
            this.tb_customerTab_SecondaryAddress.Size = new System.Drawing.Size(300, 26);
            this.tb_customerTab_SecondaryAddress.TabIndex = 19;
            // 
            // lbl_customerTab_customerData
            // 
            this.lbl_customerTab_customerData.AutoSize = true;
            this.lbl_customerTab_customerData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_customerData.Location = new System.Drawing.Point(204, 44);
            this.lbl_customerTab_customerData.Name = "lbl_customerTab_customerData";
            this.lbl_customerTab_customerData.Size = new System.Drawing.Size(47, 24);
            this.lbl_customerTab_customerData.TabIndex = 18;
            this.lbl_customerTab_customerData.Text = "Data";
            // 
            // lbl_customerTab_country
            // 
            this.lbl_customerTab_country.AutoSize = true;
            this.lbl_customerTab_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_country.Location = new System.Drawing.Point(357, 383);
            this.lbl_customerTab_country.Name = "lbl_customerTab_country";
            this.lbl_customerTab_country.Size = new System.Drawing.Size(64, 20);
            this.lbl_customerTab_country.TabIndex = 17;
            this.lbl_customerTab_country.Text = "Country";
            // 
            // lbl_customerTab_city
            // 
            this.lbl_customerTab_city.AutoSize = true;
            this.lbl_customerTab_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_city.Location = new System.Drawing.Point(204, 383);
            this.lbl_customerTab_city.Name = "lbl_customerTab_city";
            this.lbl_customerTab_city.Size = new System.Drawing.Size(35, 20);
            this.lbl_customerTab_city.TabIndex = 16;
            this.lbl_customerTab_city.Text = "City";
            // 
            // lbl_customerTab_phoneNumber
            // 
            this.lbl_customerTab_phoneNumber.AutoSize = true;
            this.lbl_customerTab_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_phoneNumber.Location = new System.Drawing.Point(357, 305);
            this.lbl_customerTab_phoneNumber.Name = "lbl_customerTab_phoneNumber";
            this.lbl_customerTab_phoneNumber.Size = new System.Drawing.Size(115, 20);
            this.lbl_customerTab_phoneNumber.TabIndex = 15;
            this.lbl_customerTab_phoneNumber.Text = "Phone Number";
            // 
            // lbl_customerTab_postalCode
            // 
            this.lbl_customerTab_postalCode.AutoSize = true;
            this.lbl_customerTab_postalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_postalCode.Location = new System.Drawing.Point(204, 305);
            this.lbl_customerTab_postalCode.Name = "lbl_customerTab_postalCode";
            this.lbl_customerTab_postalCode.Size = new System.Drawing.Size(95, 20);
            this.lbl_customerTab_postalCode.TabIndex = 14;
            this.lbl_customerTab_postalCode.Text = "Postal Code";
            // 
            // lbl_customerTab_primaryAddress
            // 
            this.lbl_customerTab_primaryAddress.AutoSize = true;
            this.lbl_customerTab_primaryAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_primaryAddress.Location = new System.Drawing.Point(204, 161);
            this.lbl_customerTab_primaryAddress.Name = "lbl_customerTab_primaryAddress";
            this.lbl_customerTab_primaryAddress.Size = new System.Drawing.Size(124, 20);
            this.lbl_customerTab_primaryAddress.TabIndex = 13;
            this.lbl_customerTab_primaryAddress.Text = "Primary Address";
            // 
            // lbl_customerTab_ID
            // 
            this.lbl_customerTab_ID.AutoSize = true;
            this.lbl_customerTab_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_ID.Location = new System.Drawing.Point(404, 88);
            this.lbl_customerTab_ID.Name = "lbl_customerTab_ID";
            this.lbl_customerTab_ID.Size = new System.Drawing.Size(26, 20);
            this.lbl_customerTab_ID.TabIndex = 12;
            this.lbl_customerTab_ID.Text = "ID";
            // 
            // lbl_customerTab_name
            // 
            this.lbl_customerTab_name.AutoSize = true;
            this.lbl_customerTab_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_name.Location = new System.Drawing.Point(204, 88);
            this.lbl_customerTab_name.Name = "lbl_customerTab_name";
            this.lbl_customerTab_name.Size = new System.Drawing.Size(51, 20);
            this.lbl_customerTab_name.TabIndex = 11;
            this.lbl_customerTab_name.Text = "Name";
            // 
            // tb_customerTab_Country
            // 
            this.tb_customerTab_Country.Enabled = false;
            this.tb_customerTab_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerTab_Country.Location = new System.Drawing.Point(361, 406);
            this.tb_customerTab_Country.Name = "tb_customerTab_Country";
            this.tb_customerTab_Country.Size = new System.Drawing.Size(147, 26);
            this.tb_customerTab_Country.TabIndex = 10;
            // 
            // tb_customerTab_City
            // 
            this.tb_customerTab_City.Enabled = false;
            this.tb_customerTab_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerTab_City.Location = new System.Drawing.Point(206, 406);
            this.tb_customerTab_City.Name = "tb_customerTab_City";
            this.tb_customerTab_City.Size = new System.Drawing.Size(129, 26);
            this.tb_customerTab_City.TabIndex = 9;
            // 
            // tb_customerTab_PhoneNumber
            // 
            this.tb_customerTab_PhoneNumber.Enabled = false;
            this.tb_customerTab_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerTab_PhoneNumber.Location = new System.Drawing.Point(361, 328);
            this.tb_customerTab_PhoneNumber.Name = "tb_customerTab_PhoneNumber";
            this.tb_customerTab_PhoneNumber.Size = new System.Drawing.Size(147, 26);
            this.tb_customerTab_PhoneNumber.TabIndex = 8;
            // 
            // tb_customerTab_PostalCode
            // 
            this.tb_customerTab_PostalCode.Enabled = false;
            this.tb_customerTab_PostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerTab_PostalCode.Location = new System.Drawing.Point(206, 328);
            this.tb_customerTab_PostalCode.Name = "tb_customerTab_PostalCode";
            this.tb_customerTab_PostalCode.Size = new System.Drawing.Size(129, 26);
            this.tb_customerTab_PostalCode.TabIndex = 7;
            // 
            // tb_customerTab_PrimaryAddress
            // 
            this.tb_customerTab_PrimaryAddress.Enabled = false;
            this.tb_customerTab_PrimaryAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerTab_PrimaryAddress.Location = new System.Drawing.Point(208, 184);
            this.tb_customerTab_PrimaryAddress.Name = "tb_customerTab_PrimaryAddress";
            this.tb_customerTab_PrimaryAddress.Size = new System.Drawing.Size(300, 26);
            this.tb_customerTab_PrimaryAddress.TabIndex = 6;
            // 
            // tb_customerTab_Name
            // 
            this.tb_customerTab_Name.Enabled = false;
            this.tb_customerTab_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerTab_Name.Location = new System.Drawing.Point(208, 111);
            this.tb_customerTab_Name.Name = "tb_customerTab_Name";
            this.tb_customerTab_Name.Size = new System.Drawing.Size(174, 26);
            this.tb_customerTab_Name.TabIndex = 5;
            // 
            // tb_customerTab_ID
            // 
            this.tb_customerTab_ID.Enabled = false;
            this.tb_customerTab_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customerTab_ID.Location = new System.Drawing.Point(408, 111);
            this.tb_customerTab_ID.Name = "tb_customerTab_ID";
            this.tb_customerTab_ID.Size = new System.Drawing.Size(100, 26);
            this.tb_customerTab_ID.TabIndex = 4;
            // 
            // lbl_customerTab_Appointments
            // 
            this.lbl_customerTab_Appointments.AutoSize = true;
            this.lbl_customerTab_Appointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_Appointments.Location = new System.Drawing.Point(551, 44);
            this.lbl_customerTab_Appointments.Name = "lbl_customerTab_Appointments";
            this.lbl_customerTab_Appointments.Size = new System.Drawing.Size(126, 24);
            this.lbl_customerTab_Appointments.TabIndex = 3;
            this.lbl_customerTab_Appointments.Text = "Appointments";
            // 
            // lbl_customerTab_customerNames
            // 
            this.lbl_customerTab_customerNames.AutoSize = true;
            this.lbl_customerTab_customerNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTab_customerNames.Location = new System.Drawing.Point(6, 44);
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
            this.dgv_customerTab_Appointments.Location = new System.Drawing.Point(555, 71);
            this.dgv_customerTab_Appointments.Name = "dgv_customerTab_Appointments";
            this.dgv_customerTab_Appointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_customerTab_Appointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_customerTab_Appointments.Size = new System.Drawing.Size(809, 460);
            this.dgv_customerTab_Appointments.TabIndex = 1;
            // 
            // lv_customerTab_customerNames
            // 
            this.lv_customerTab_customerNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_customerTab_customerNames.HideSelection = false;
            this.lv_customerTab_customerNames.Location = new System.Drawing.Point(6, 71);
            this.lv_customerTab_customerNames.Name = "lv_customerTab_customerNames";
            this.lv_customerTab_customerNames.Size = new System.Drawing.Size(160, 460);
            this.lv_customerTab_customerNames.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_customerTab_customerNames.TabIndex = 0;
            this.lv_customerTab_customerNames.UseCompatibleStateImageBehavior = false;
            this.lv_customerTab_customerNames.SelectedIndexChanged += new System.EventHandler(this.lv_Names_SelectedIndexChanged);
            // 
            // tab_Reports
            // 
            this.tab_Reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tab_Reports.Location = new System.Drawing.Point(4, 33);
            this.tab_Reports.Name = "tab_Reports";
            this.tab_Reports.Size = new System.Drawing.Size(1381, 537);
            this.tab_Reports.TabIndex = 2;
            this.tab_Reports.Text = "Reports";
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
            // btn_customerTab_Delete
            // 
            this.btn_customerTab_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerTab_Delete.Location = new System.Drawing.Point(433, 474);
            this.btn_customerTab_Delete.Name = "btn_customerTab_Delete";
            this.btn_customerTab_Delete.Size = new System.Drawing.Size(75, 30);
            this.btn_customerTab_Delete.TabIndex = 25;
            this.btn_customerTab_Delete.Text = "Delete";
            this.btn_customerTab_Delete.UseVisualStyleBackColor = true;
            this.btn_customerTab_Delete.Click += new System.EventHandler(this.btn_customerTab_Delete_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_upcomingAppointments)).EndInit();
            this.tab_Schedule.ResumeLayout(false);
            this.tab_Schedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScheduleTab_Appointments)).EndInit();
            this.tab_Customers.ResumeLayout(false);
            this.tab_Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerTab_Appointments)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_upcomingAppointments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tab_Customers;
        private System.Windows.Forms.ListView lv_customerTab_customerNames;
        private System.Windows.Forms.TextBox tb_customerTab_PrimaryAddress;
        private System.Windows.Forms.TextBox tb_customerTab_Name;
        private System.Windows.Forms.TextBox tb_customerTab_ID;
        private System.Windows.Forms.Label lbl_customerTab_Appointments;
        private System.Windows.Forms.Label lbl_customerTab_customerNames;
        private System.Windows.Forms.DataGridView dgv_customerTab_Appointments;
        private System.Windows.Forms.Label lbl_customerTab_customerData;
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
        private System.Windows.Forms.ListView lv_ScheduleTab_customerNames;
        private System.Windows.Forms.Button btn_ScheduleTab_Reset;
        private System.Windows.Forms.Button btn_ScheduleTab_Save;
        private System.Windows.Forms.Button btn_customerTab_New;
        private System.Windows.Forms.Button btn_customerTab_Edit;
        private System.Windows.Forms.Button btn_customerTab_Delete;
    }
}