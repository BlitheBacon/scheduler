namespace scheduler
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_Window = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_ErrorText = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Window
            // 
            resources.ApplyResources(this.lbl_Window, "lbl_Window");
            this.lbl_Window.Name = "lbl_Window";
            // 
            // tb_Username
            // 
            this.tb_Username.BackColor = System.Drawing.Color.White;
            this.tb_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tb_Username, "tb_Username");
            this.tb_Username.Name = "tb_Username";
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.White;
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tb_Password, "tb_Password");
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // lbl_ErrorText
            // 
            resources.ApplyResources(this.lbl_ErrorText, "lbl_ErrorText");
            this.lbl_ErrorText.Name = "lbl_ErrorText";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btn_Submit, "btn_Submit");
            this.btn_Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btn_Close, "btn_Close");
            this.btn_Close.ForeColor = System.Drawing.Color.Black;
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.TabStop = false;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Username
            // 
            resources.ApplyResources(this.lbl_Username, "lbl_Username");
            this.lbl_Username.Name = "lbl_Username";
            // 
            // lbl_Password
            // 
            resources.ApplyResources(this.lbl_Password, "lbl_Password");
            this.lbl_Password.Name = "lbl_Password";
            // 
            // Login
            // 
            this.AcceptButton = this.btn_Submit;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.CancelButton = this.btn_Close;
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_ErrorText);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Window);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogIn_Event_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogIn_Event_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LogIn_Event_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Window;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_ErrorText;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
    }
}

