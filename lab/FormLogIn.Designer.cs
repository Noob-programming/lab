namespace lab
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.gunAddUser = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gunClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataSet = new lab.loginDataSet();
            this.usersTableAdapter = new lab.loginDataSetTableAdapters.usersTableAdapter();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.tbxSeen = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.txtUserPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.picLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // gunAddUser
            // 
            this.gunAddUser.BorderRadius = 20;
            this.gunAddUser.TargetControl = this;
            // 
            // gunClose
            // 
            this.gunClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gunClose.FillColor = System.Drawing.Color.Transparent;
            this.gunClose.IconColor = System.Drawing.Color.MidnightBlue;
            this.gunClose.Location = new System.Drawing.Point(1887, 12);
            this.gunClose.Name = "gunClose";
            this.gunClose.Size = new System.Drawing.Size(43, 40);
            this.gunClose.TabIndex = 23;
            this.gunClose.Click += new System.EventHandler(this.gunClose_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.MidnightBlue;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1838, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(43, 40);
            this.guna2ControlBox1.TabIndex = 24;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "users";
            this.bindingSource1.DataSource = this.loginDataSet;
            // 
            // loginDataSet
            // 
            this.loginDataSet.DataSetName = "loginDataSet";
            this.loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.AutoRoundedCorners = true;
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExit.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.BorderRadius = 26;
            this.btnExit.BorderThickness = 2;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Lavender;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.HoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.btnExit.HoverState.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1654, 609);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 55);
            this.btnExit.TabIndex = 81;
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLogin.BorderColor = System.Drawing.Color.Lavender;
            this.btnLogin.BorderRadius = 26;
            this.btnLogin.BorderThickness = 2;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.BorderColor = System.Drawing.Color.Lavender;
            this.btnLogin.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.DarkBlue;
            this.btnLogin.HoverState.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(1654, 533);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 55);
            this.btnLogin.TabIndex = 83;
            this.btnLogin.Text = "تسجيل الدخول";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxSeen
            // 
            this.tbxSeen.BackColor = System.Drawing.Color.Transparent;
            this.tbxSeen.CheckedState.Image = global::lab.Properties.Resources._9055153;
            this.tbxSeen.Image = global::lab.Properties.Resources._535193;
            this.tbxSeen.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxSeen.ImageRotate = 0F;
            this.tbxSeen.Location = new System.Drawing.Point(1873, 352);
            this.tbxSeen.Name = "tbxSeen";
            this.tbxSeen.Size = new System.Drawing.Size(38, 24);
            this.tbxSeen.TabIndex = 40;
            this.tbxSeen.UseTransparentBackground = true;
            this.tbxSeen.CheckedChanged += new System.EventHandler(this.tbxSeen_CheckedChanged);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Animated = true;
            this.txtUserPassword.AutoRoundedCorners = true;
            this.txtUserPassword.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtUserPassword.BorderRadius = 24;
            this.txtUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPassword.DefaultText = "";
            this.txtUserPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserPassword.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUserPassword.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txtUserPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtUserPassword.ForeColor = System.Drawing.Color.Black;
            this.txtUserPassword.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtUserPassword.IconRight = ((System.Drawing.Image)(resources.GetObject("txtUserPassword.IconRight")));
            this.txtUserPassword.Location = new System.Drawing.Point(1654, 333);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtUserPassword.PlaceholderText = ": كلمة المرور ";
            this.txtUserPassword.SelectedText = "";
            this.txtUserPassword.Size = new System.Drawing.Size(300, 50);
            this.txtUserPassword.TabIndex = 38;
            // 
            // txtUserName
            // 
            this.txtUserName.Animated = true;
            this.txtUserName.AutoRoundedCorners = true;
            this.txtUserName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtUserName.BorderRadius = 24;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtUserName.IconRight = global::lab.Properties.Resources._86394142;
            this.txtUserName.Location = new System.Drawing.Point(1654, 241);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtUserName.PlaceholderText = ":اسم المستخدم ";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(300, 50);
            this.txtUserName.TabIndex = 37;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // picLogin
            // 
            this.picLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.picLogin.BorderRadius = 20;
            this.picLogin.Image = global::lab.Properties.Resources.Tablet_login_amico;
            this.picLogin.ImageRotate = 0F;
            this.picLogin.Location = new System.Drawing.Point(2, 2);
            this.picLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(2048, 1059);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogin.TabIndex = 84;
            this.picLogin.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.gunClose);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbxSeen);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.picLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse gunAddUser;
        private Guna.UI2.WinForms.Guna2ControlBox gunClose;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox tbxSeen;
        private Guna.UI2.WinForms.Guna2TextBox txtUserPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private loginDataSet loginDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private loginDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2PictureBox picLogin;
    }
}