namespace lab
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gunClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMain = new Guna.UI2.WinForms.Guna2Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReservation = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnRooms = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labUserName = new System.Windows.Forms.Label();
            this.labWelcome = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labDateTime = new System.Windows.Forms.Label();
            this.labLogOut = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.userControlMain1 = new lab.User_Control.UserControlMain();
            this.userControlRoom1 = new lab.User_Control.UserControlRoom();
            this.userControlAdmin1 = new lab.User_Control.UserControlEmployee();
            this.userControlReservation1 = new lab.User_Control.UserControlReservation();
            this.userControlCustomers1 = new lab.User_Control.UserControlCustomers();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunClose
            // 
            this.gunClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gunClose.FillColor = System.Drawing.Color.White;
            this.gunClose.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gunClose.IconColor = System.Drawing.Color.MidnightBlue;
            this.gunClose.Location = new System.Drawing.Point(1651, 11);
            this.gunClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunClose.Name = "gunClose";
            this.gunClose.Size = new System.Drawing.Size(43, 39);
            this.gunClose.TabIndex = 13;
            this.gunClose.Click += new System.EventHandler(this.gunClose_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.MidnightBlue;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1588, 11);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(43, 39);
            this.guna2ControlBox1.TabIndex = 14;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnMain);
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnReservation);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnRooms);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 1040);
            this.panel1.TabIndex = 0;
            // 
            // btnMain
            // 
            this.btnMain.Animated = true;
            this.btnMain.AutoRoundedCorners = true;
            this.btnMain.BackColor = System.Drawing.Color.Transparent;
            this.btnMain.BorderColor = System.Drawing.Color.Lavender;
            this.btnMain.BorderRadius = 29;
            this.btnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMain.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMain.FillColor = System.Drawing.Color.Transparent;
            this.btnMain.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.White;
            this.btnMain.HoverState.BorderColor = System.Drawing.Color.Lavender;
            this.btnMain.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnMain.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnMain.HoverState.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnMain.Image = global::lab.Properties.Resources.icons8_menu_squared_50;
            this.btnMain.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMain.Location = new System.Drawing.Point(40, 260);
            this.btnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(192, 60);
            this.btnMain.TabIndex = 39;
            this.btnMain.Text = "الرئيسية";
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(24, 259);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(10, 61);
            this.panelSlide.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 227);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 27);
            this.label2.TabIndex = 43;
            this.label2.Text = "System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 27);
            this.label1.TabIndex = 42;
            this.label1.Text = "Hotel Management";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::lab.Properties.Resources.house_xxl;
            this.pictureBox2.Location = new System.Drawing.Point(40, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // btnReservation
            // 
            this.btnReservation.Animated = true;
            this.btnReservation.AutoRoundedCorners = true;
            this.btnReservation.BackColor = System.Drawing.Color.Transparent;
            this.btnReservation.BorderColor = System.Drawing.Color.Lavender;
            this.btnReservation.BorderRadius = 29;
            this.btnReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReservation.FillColor = System.Drawing.Color.Transparent;
            this.btnReservation.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.HoverState.BorderColor = System.Drawing.Color.Lavender;
            this.btnReservation.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnReservation.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnReservation.HoverState.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Image = global::lab.Properties.Resources.icons8_reservation_50;
            this.btnReservation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReservation.Location = new System.Drawing.Point(40, 334);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(192, 60);
            this.btnReservation.TabIndex = 38;
            this.btnReservation.Text = "الحجز";
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Animated = true;
            this.btnAdmin.AutoRoundedCorners = true;
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.BorderColor = System.Drawing.Color.Lavender;
            this.btnAdmin.BorderRadius = 29;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdmin.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.HoverState.BorderColor = System.Drawing.Color.Lavender;
            this.btnAdmin.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAdmin.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAdmin.HoverState.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = global::lab.Properties.Resources.icons8_businessman_50;
            this.btnAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdmin.Location = new System.Drawing.Point(40, 572);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(192, 60);
            this.btnAdmin.TabIndex = 39;
            this.btnAdmin.Text = "الموظفين";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Animated = true;
            this.btnCustomers.AutoRoundedCorners = true;
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.BorderColor = System.Drawing.Color.Lavender;
            this.btnCustomers.BorderRadius = 29;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomers.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.HoverState.BorderColor = System.Drawing.Color.Lavender;
            this.btnCustomers.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnCustomers.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomers.HoverState.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Image = global::lab.Properties.Resources.icons8_customer_50;
            this.btnCustomers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomers.Location = new System.Drawing.Point(40, 412);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(192, 60);
            this.btnCustomers.TabIndex = 37;
            this.btnCustomers.Text = " النزلاء";
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Animated = true;
            this.btnRooms.AutoRoundedCorners = true;
            this.btnRooms.BackColor = System.Drawing.Color.Transparent;
            this.btnRooms.BorderColor = System.Drawing.Color.Lavender;
            this.btnRooms.BorderRadius = 29;
            this.btnRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRooms.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnRooms.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnRooms.ForeColor = System.Drawing.Color.White;
            this.btnRooms.HoverState.BorderColor = System.Drawing.Color.Lavender;
            this.btnRooms.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnRooms.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnRooms.HoverState.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRooms.Image = global::lab.Properties.Resources.icons8_room_50;
            this.btnRooms.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRooms.Location = new System.Drawing.Point(40, 488);
            this.btnRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(192, 60);
            this.btnRooms.TabIndex = 35;
            this.btnRooms.Text = " الغرف";
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.labUserName);
            this.panel3.Controls.Add(this.labWelcome);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(321, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1721, 204);
            this.panel3.TabIndex = 0;
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.ForeColor = System.Drawing.Color.White;
            this.labUserName.Location = new System.Drawing.Point(133, 160);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(128, 27);
            this.labUserName.TabIndex = 43;
            this.labUserName.Text = "UserName";
            // 
            // labWelcome
            // 
            this.labWelcome.AutoSize = true;
            this.labWelcome.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWelcome.ForeColor = System.Drawing.Color.White;
            this.labWelcome.Location = new System.Drawing.Point(6, 160);
            this.labWelcome.Name = "labWelcome";
            this.labWelcome.Size = new System.Drawing.Size(121, 27);
            this.labWelcome.TabIndex = 42;
            this.labWelcome.Text = "Welcome";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.gunClose);
            this.panel4.Controls.Add(this.guna2ControlBox1);
            this.panel4.Controls.Add(this.labDateTime);
            this.panel4.Controls.Add(this.labLogOut);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1721, 92);
            this.panel4.TabIndex = 0;
            // 
            // labDateTime
            // 
            this.labDateTime.AutoSize = true;
            this.labDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDateTime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDateTime.Location = new System.Drawing.Point(20, 55);
            this.labDateTime.Name = "labDateTime";
            this.labDateTime.Size = new System.Drawing.Size(70, 25);
            this.labDateTime.TabIndex = 41;
            this.labDateTime.Text = "label3";
            // 
            // labLogOut
            // 
            this.labLogOut.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.labLogOut.AutoSize = true;
            this.labLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labLogOut.DisabledLinkColor = System.Drawing.Color.MidnightBlue;
            this.labLogOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLogOut.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labLogOut.LinkColor = System.Drawing.Color.MidnightBlue;
            this.labLogOut.Location = new System.Drawing.Point(1426, 53);
            this.labLogOut.Name = "labLogOut";
            this.labLogOut.Size = new System.Drawing.Size(108, 23);
            this.labLogOut.TabIndex = 0;
            this.labLogOut.TabStop = true;
            this.labLogOut.Text = "تسجيل الخروج";
            this.labLogOut.VisitedLinkColor = System.Drawing.Color.MidnightBlue;
            this.labLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labLgout_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::lab.Properties.Resources._3685999;
            this.pictureBox1.Location = new System.Drawing.Point(1362, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.userControlMain1);
            this.panel5.Controls.Add(this.userControlRoom1);
            this.panel5.Controls.Add(this.userControlAdmin1);
            this.panel5.Controls.Add(this.userControlReservation1);
            this.panel5.Controls.Add(this.userControlCustomers1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(321, 204);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1721, 836);
            this.panel5.TabIndex = 0;
            // 
            // userControlMain1
            // 
            this.userControlMain1.BackColor = System.Drawing.Color.White;
            this.userControlMain1.Location = new System.Drawing.Point(0, 0);
            this.userControlMain1.Name = "userControlMain1";
            this.userControlMain1.Size = new System.Drawing.Size(1709, 836);
            this.userControlMain1.TabIndex = 6;
            // 
            // userControlRoom1
            // 
            this.userControlRoom1.BackColor = System.Drawing.Color.White;
            this.userControlRoom1.Location = new System.Drawing.Point(0, 0);
            this.userControlRoom1.Name = "userControlRoom1";
            this.userControlRoom1.Size = new System.Drawing.Size(1669, 836);
            this.userControlRoom1.TabIndex = 5;
            // 
            // userControlAdmin1
            // 
            this.userControlAdmin1.BackColor = System.Drawing.Color.White;
            this.userControlAdmin1.Location = new System.Drawing.Point(0, 0);
            this.userControlAdmin1.Name = "userControlAdmin1";
            this.userControlAdmin1.Size = new System.Drawing.Size(1669, 836);
            this.userControlAdmin1.TabIndex = 4;
            // 
            // userControlReservation1
            // 
            this.userControlReservation1.BackColor = System.Drawing.Color.White;
            this.userControlReservation1.Location = new System.Drawing.Point(0, 0);
            this.userControlReservation1.Name = "userControlReservation1";
            this.userControlReservation1.Size = new System.Drawing.Size(1669, 836);
            this.userControlReservation1.TabIndex = 3;
            // 
            // userControlCustomers1
            // 
            this.userControlCustomers1.BackColor = System.Drawing.Color.White;
            this.userControlCustomers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlCustomers1.Location = new System.Drawing.Point(0, 0);
            this.userControlCustomers1.Name = "userControlCustomers1";
            this.userControlCustomers1.Size = new System.Drawing.Size(1721, 836);
            this.userControlCustomers1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2042, 1040);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ControlBox gunClose;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnAdmin;
        private Guna.UI2.WinForms.Guna2Button btnReservation;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Button btnRooms;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel labLogOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labWelcome;
        private System.Windows.Forms.Label labDateTime;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelSlide;
        private Guna.UI2.WinForms.Guna2Button btnMain;
        private User_Control.UserControlCustomers userControlCustomers1;
        private User_Control.UserControlReservation userControlReservation1;
        private User_Control.UserControlEmployee userControlAdmin1;
        private User_Control.UserControlRoom userControlRoom1;
        private User_Control.UserControlMain userControlMain1;
    }
}

