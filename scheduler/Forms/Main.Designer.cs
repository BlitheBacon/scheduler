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
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Tabs = new System.Windows.Forms.Panel();
            this.lbl_LoggedInUser = new System.Windows.Forms.Label();
            this.pnl_WindowButtons = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tab_Home = new System.Windows.Forms.TabPage();
            this.tab_Schedule = new System.Windows.Forms.TabPage();
            this.tab_Reports = new System.Windows.Forms.TabPage();
            this.lbl_TimeLocal = new System.Windows.Forms.Label();
            this.timer_DateTimeLabel = new System.Windows.Forms.Timer(this.components);
            this.lbl_DateLocal = new System.Windows.Forms.Label();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.lbl_userID = new System.Windows.Forms.Label();
            this.flpMain.SuspendLayout();
            this.pnl_Tabs.SuspendLayout();
            this.pnl_WindowButtons.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.pnl_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMain
            // 
            this.flpMain.Controls.Add(this.pnl_Tabs);
            this.flpMain.Controls.Add(this.tabControl_Main);
            this.flpMain.Controls.Add(this.pnl_Footer);
            this.flpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMain.Location = new System.Drawing.Point(0, 0);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(1600, 900);
            this.flpMain.TabIndex = 0;
            // 
            // pnl_Tabs
            // 
            this.pnl_Tabs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_Tabs.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Tabs.Controls.Add(this.lbl_userID);
            this.pnl_Tabs.Controls.Add(this.lbl_LoggedInUser);
            this.pnl_Tabs.Controls.Add(this.pnl_WindowButtons);
            this.pnl_Tabs.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tabs.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Tabs.Name = "pnl_Tabs";
            this.pnl_Tabs.Size = new System.Drawing.Size(1600, 77);
            this.pnl_Tabs.TabIndex = 1;
            this.pnl_Tabs.DoubleClick += new System.EventHandler(this.btn_MaximizeClick);
            this.pnl_Tabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_Event_MouseDown);
            this.pnl_Tabs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_Event_MouseMove);
            this.pnl_Tabs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_Event_MouseUp);
            // 
            // lbl_LoggedInUser
            // 
            this.lbl_LoggedInUser.AutoSize = true;
            this.lbl_LoggedInUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoggedInUser.Location = new System.Drawing.Point(8, 9);
            this.lbl_LoggedInUser.Name = "lbl_LoggedInUser";
            this.lbl_LoggedInUser.Size = new System.Drawing.Size(146, 25);
            this.lbl_LoggedInUser.TabIndex = 4;
            this.lbl_LoggedInUser.Text = "LoggedInUser";
            // 
            // pnl_WindowButtons
            // 
            this.pnl_WindowButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_WindowButtons.Controls.Add(this.btn_Close);
            this.pnl_WindowButtons.Controls.Add(this.btn_Maximize);
            this.pnl_WindowButtons.Controls.Add(this.btn_Minimize);
            this.pnl_WindowButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_WindowButtons.Location = new System.Drawing.Point(1495, 0);
            this.pnl_WindowButtons.Name = "pnl_WindowButtons";
            this.pnl_WindowButtons.Size = new System.Drawing.Size(105, 77);
            this.pnl_WindowButtons.TabIndex = 3;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.Color.Black;
            this.btn_Close.Location = new System.Drawing.Point(71, 6);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(28, 28);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_CloseClick);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maximize.ForeColor = System.Drawing.Color.Black;
            this.btn_Maximize.Location = new System.Drawing.Point(37, 6);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(28, 28);
            this.btn_Maximize.TabIndex = 1;
            this.btn_Maximize.Text = "◻";
            this.btn_Maximize.UseVisualStyleBackColor = false;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_MaximizeClick);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.ForeColor = System.Drawing.Color.Black;
            this.btn_Minimize.Location = new System.Drawing.Point(3, 6);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(28, 28);
            this.btn_Minimize.TabIndex = 0;
            this.btn_Minimize.Text = "_";
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_MinimizeClick);
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl_Main.Controls.Add(this.tab_Home);
            this.tabControl_Main.Controls.Add(this.tab_Schedule);
            this.tabControl_Main.Controls.Add(this.tab_Reports);
            this.tabControl_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Main.HotTrack = true;
            this.tabControl_Main.Location = new System.Drawing.Point(8, 80);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1583, 773);
            this.tabControl_Main.TabIndex = 2;
            // 
            // tab_Home
            // 
            this.tab_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tab_Home.ForeColor = System.Drawing.Color.Black;
            this.tab_Home.Location = new System.Drawing.Point(4, 33);
            this.tab_Home.Name = "tab_Home";
            this.tab_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Home.Size = new System.Drawing.Size(1575, 736);
            this.tab_Home.TabIndex = 0;
            this.tab_Home.Text = "Home";
            this.tab_Home.Click += new System.EventHandler(this.tab_Home_Click);
            // 
            // tab_Schedule
            // 
            this.tab_Schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tab_Schedule.Location = new System.Drawing.Point(4, 33);
            this.tab_Schedule.Name = "tab_Schedule";
            this.tab_Schedule.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Schedule.Size = new System.Drawing.Size(1589, 736);
            this.tab_Schedule.TabIndex = 1;
            this.tab_Schedule.Text = "Schedule";
            // 
            // tab_Reports
            // 
            this.tab_Reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tab_Reports.Location = new System.Drawing.Point(4, 33);
            this.tab_Reports.Name = "tab_Reports";
            this.tab_Reports.Size = new System.Drawing.Size(1589, 736);
            this.tab_Reports.TabIndex = 2;
            this.tab_Reports.Text = "Reports";
            // 
            // lbl_TimeLocal
            // 
            this.lbl_TimeLocal.AutoSize = true;
            this.lbl_TimeLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeLocal.Location = new System.Drawing.Point(161, 8);
            this.lbl_TimeLocal.Name = "lbl_TimeLocal";
            this.lbl_TimeLocal.Size = new System.Drawing.Size(77, 18);
            this.lbl_TimeLocal.TabIndex = 5;
            this.lbl_TimeLocal.Text = "LocalTime";
            // 
            // timer_DateTimeLabel
            // 
            this.timer_DateTimeLabel.Enabled = true;
            this.timer_DateTimeLabel.Interval = 500;
            this.timer_DateTimeLabel.Tick += new System.EventHandler(this.timer_DateTimeLabel_Tick);
            // 
            // lbl_DateLocal
            // 
            this.lbl_DateLocal.AutoSize = true;
            this.lbl_DateLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateLocal.Location = new System.Drawing.Point(7, 8);
            this.lbl_DateLocal.Name = "lbl_DateLocal";
            this.lbl_DateLocal.Size = new System.Drawing.Size(75, 18);
            this.lbl_DateLocal.TabIndex = 6;
            this.lbl_DateLocal.Text = "LocalDate";
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_Footer.Controls.Add(this.lbl_TimeLocal);
            this.pnl_Footer.Controls.Add(this.lbl_DateLocal);
            this.pnl_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Footer.Location = new System.Drawing.Point(3, 859);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(1594, 34);
            this.pnl_Footer.TabIndex = 3;
            // 
            // lbl_userID
            // 
            this.lbl_userID.AutoSize = true;
            this.lbl_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userID.Location = new System.Drawing.Point(12, 44);
            this.lbl_userID.Name = "lbl_userID";
            this.lbl_userID.Size = new System.Drawing.Size(46, 16);
            this.lbl_userID.TabIndex = 5;
            this.lbl_userID.Text = "userID";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
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
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
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
        private System.Windows.Forms.Label lbl_LoggedInUser;
        private System.Windows.Forms.Label lbl_TimeLocal;
        private System.Windows.Forms.Timer timer_DateTimeLabel;
        private System.Windows.Forms.Label lbl_DateLocal;
        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label lbl_userID;
    }
}