namespace lab.User_Control
{
    partial class UserControlReservation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlReservation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.labPrice = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.labCardNumber = new Guna.UI.WinForms.GunaLabel();
            this.txtlabCardNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.labStartDate = new Guna.UI.WinForms.GunaLabel();
            this.labEndDate = new Guna.UI.WinForms.GunaLabel();
            this.labRoomID = new Guna.UI.WinForms.GunaLabel();
            this.btnClear = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnBook = new Guna.UI2.WinForms.Guna2Button();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtRoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtMDPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.labMDPrice = new Guna.UI.WinForms.GunaLabel();
            this.btnPrintBooks = new Guna.UI2.WinForms.Guna2Button();
            this.labModify = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtMDCardNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtMDEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtMDStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtMDRoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnModify = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dgvReservation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPrintAvilableRooms = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAvilableRooms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvilableRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(20, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1652, 790);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtPrice);
            this.tabPage1.Controls.Add(this.labPrice);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labCardNumber);
            this.tabPage1.Controls.Add(this.txtlabCardNumber);
            this.tabPage1.Controls.Add(this.labStartDate);
            this.tabPage1.Controls.Add(this.labEndDate);
            this.tabPage1.Controls.Add(this.labRoomID);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnBook);
            this.tabPage1.Controls.Add(this.dtpEndDate);
            this.tabPage1.Controls.Add(this.dtpStartDate);
            this.tabPage1.Controls.Add(this.txtRoomNumber);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1644, 751);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "الحجز";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Animated = true;
            this.txtPrice.AutoRoundedCorners = true;
            this.txtPrice.BorderRadius = 21;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtPrice.IconRight = global::lab.Properties.Resources._3037150;
            this.txtPrice.Location = new System.Drawing.Point(1074, 469);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(300, 45);
            this.txtPrice.TabIndex = 185;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labPrice.Location = new System.Drawing.Point(1553, 479);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(75, 35);
            this.labPrice.TabIndex = 186;
            this.labPrice.Text = "السعر";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(1505, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 38);
            this.label1.TabIndex = 149;
            this.label1.Text = "حجز غرفة";
            // 
            // labCardNumber
            // 
            this.labCardNumber.AutoSize = true;
            this.labCardNumber.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labCardNumber.Location = new System.Drawing.Point(1484, 172);
            this.labCardNumber.Name = "labCardNumber";
            this.labCardNumber.Size = new System.Drawing.Size(144, 35);
            this.labCardNumber.TabIndex = 139;
            this.labCardNumber.Text = "رقم الجنسية ";
            // 
            // txtlabCardNumber
            // 
            this.txtlabCardNumber.Animated = true;
            this.txtlabCardNumber.AutoRoundedCorners = true;
            this.txtlabCardNumber.BorderRadius = 21;
            this.txtlabCardNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlabCardNumber.DefaultText = "";
            this.txtlabCardNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtlabCardNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtlabCardNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlabCardNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlabCardNumber.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.txtlabCardNumber.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txtlabCardNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtlabCardNumber.ForeColor = System.Drawing.Color.Black;
            this.txtlabCardNumber.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtlabCardNumber.IconRight = ((System.Drawing.Image)(resources.GetObject("txtlabCardNumber.IconRight")));
            this.txtlabCardNumber.Location = new System.Drawing.Point(1074, 172);
            this.txtlabCardNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtlabCardNumber.Name = "txtlabCardNumber";
            this.txtlabCardNumber.PasswordChar = '\0';
            this.txtlabCardNumber.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtlabCardNumber.PlaceholderText = "";
            this.txtlabCardNumber.SelectedText = "";
            this.txtlabCardNumber.Size = new System.Drawing.Size(300, 45);
            this.txtlabCardNumber.TabIndex = 138;
            // 
            // labStartDate
            // 
            this.labStartDate.AutoSize = true;
            this.labStartDate.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labStartDate.Location = new System.Drawing.Point(1469, 268);
            this.labStartDate.Name = "labStartDate";
            this.labStartDate.Size = new System.Drawing.Size(159, 35);
            this.labStartDate.TabIndex = 132;
            this.labStartDate.Text = "تاريخ بدأ الحجز";
            // 
            // labEndDate
            // 
            this.labEndDate.AutoSize = true;
            this.labEndDate.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labEndDate.Location = new System.Drawing.Point(1445, 376);
            this.labEndDate.Name = "labEndDate";
            this.labEndDate.Size = new System.Drawing.Size(183, 35);
            this.labEndDate.TabIndex = 131;
            this.labEndDate.Text = "تاريخ إنتهاء الحجز";
            // 
            // labRoomID
            // 
            this.labRoomID.AutoSize = true;
            this.labRoomID.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labRoomID.Location = new System.Drawing.Point(1500, 82);
            this.labRoomID.Name = "labRoomID";
            this.labRoomID.Size = new System.Drawing.Size(128, 35);
            this.labRoomID.TabIndex = 130;
            this.labRoomID.Text = "رقم الغرفة ";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.HoverState.Image = global::lab.Properties.Resources._4355228;
            this.btnClear.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnClear.Image = global::lab.Properties.Resources._4355228;
            this.btnClear.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClear.ImageRotate = 0F;
            this.btnClear.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClear.Location = new System.Drawing.Point(1297, 545);
            this.btnClear.Name = "btnClear";
            this.btnClear.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClear.Size = new System.Drawing.Size(77, 56);
            this.btnClear.TabIndex = 137;
            this.btnClear.UseTransparentBackground = true;
            // 
            // btnBook
            // 
            this.btnBook.Animated = true;
            this.btnBook.AutoRoundedCorners = true;
            this.btnBook.BorderColor = System.Drawing.Color.Lavender;
            this.btnBook.BorderRadius = 24;
            this.btnBook.BorderThickness = 2;
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBook.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.HoverState.BorderColor = System.Drawing.Color.Lavender;
            this.btnBook.HoverState.FillColor = System.Drawing.Color.DarkBlue;
            this.btnBook.Location = new System.Drawing.Point(1074, 631);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(300, 50);
            this.btnBook.TabIndex = 136;
            this.btnBook.Text = "حجز";
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BorderRadius = 20;
            this.dtpEndDate.BorderThickness = 1;
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpEndDate.CheckedState.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.dtpEndDate.FillColor = System.Drawing.Color.White;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndDate.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.dtpEndDate.Location = new System.Drawing.Point(1074, 366);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(300, 45);
            this.dtpEndDate.TabIndex = 135;
            this.dtpEndDate.Value = new System.DateTime(2023, 2, 21, 17, 20, 10, 337);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BorderRadius = 20;
            this.dtpStartDate.BorderThickness = 1;
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpStartDate.CheckedState.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.dtpStartDate.FillColor = System.Drawing.Color.White;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.dtpStartDate.Location = new System.Drawing.Point(1074, 268);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(300, 45);
            this.dtpStartDate.TabIndex = 134;
            this.dtpStartDate.Value = new System.DateTime(2023, 2, 21, 17, 20, 10, 337);
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Animated = true;
            this.txtRoomNumber.AutoRoundedCorners = true;
            this.txtRoomNumber.BorderRadius = 21;
            this.txtRoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNumber.DefaultText = "";
            this.txtRoomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNumber.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRoomNumber.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txtRoomNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtRoomNumber.ForeColor = System.Drawing.Color.Black;
            this.txtRoomNumber.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtRoomNumber.IconRight = ((System.Drawing.Image)(resources.GetObject("txtRoomNumber.IconRight")));
            this.txtRoomNumber.Location = new System.Drawing.Point(1074, 82);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.PasswordChar = '\0';
            this.txtRoomNumber.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtRoomNumber.PlaceholderText = "";
            this.txtRoomNumber.SelectedText = "";
            this.txtRoomNumber.Size = new System.Drawing.Size(300, 45);
            this.txtRoomNumber.TabIndex = 129;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lab.Properties.Resources.Hotel_Booking_cuate;
            this.pictureBox1.Location = new System.Drawing.Point(-21, -74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1146, 846);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 140;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtMDPrice);
            this.tabPage2.Controls.Add(this.labMDPrice);
            this.tabPage2.Controls.Add(this.btnPrintBooks);
            this.tabPage2.Controls.Add(this.labModify);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.gunaLabel1);
            this.tabPage2.Controls.Add(this.txtMDCardNumber);
            this.tabPage2.Controls.Add(this.gunaLabel3);
            this.tabPage2.Controls.Add(this.gunaLabel4);
            this.tabPage2.Controls.Add(this.gunaLabel5);
            this.tabPage2.Controls.Add(this.txtMDEndDate);
            this.tabPage2.Controls.Add(this.txtMDStartDate);
            this.tabPage2.Controls.Add(this.txtMDRoomNumber);
            this.tabPage2.Controls.Add(this.btnModify);
            this.tabPage2.Controls.Add(this.btnClear1);
            this.tabPage2.Controls.Add(this.dgvReservation);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1644, 751);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "الحجوزات";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtMDPrice
            // 
            this.txtMDPrice.Animated = true;
            this.txtMDPrice.AutoRoundedCorners = true;
            this.txtMDPrice.BorderRadius = 21;
            this.txtMDPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMDPrice.DefaultText = "";
            this.txtMDPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMDPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMDPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMDPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMDPrice.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMDPrice.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txtMDPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtMDPrice.ForeColor = System.Drawing.Color.Black;
            this.txtMDPrice.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtMDPrice.IconRight = global::lab.Properties.Resources._3037150;
            this.txtMDPrice.Location = new System.Drawing.Point(1072, 452);
            this.txtMDPrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMDPrice.Name = "txtMDPrice";
            this.txtMDPrice.PasswordChar = '\0';
            this.txtMDPrice.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtMDPrice.PlaceholderText = "";
            this.txtMDPrice.SelectedText = "";
            this.txtMDPrice.Size = new System.Drawing.Size(300, 45);
            this.txtMDPrice.TabIndex = 216;
            // 
            // labMDPrice
            // 
            this.labMDPrice.AutoSize = true;
            this.labMDPrice.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labMDPrice.Location = new System.Drawing.Point(1530, 462);
            this.labMDPrice.Name = "labMDPrice";
            this.labMDPrice.Size = new System.Drawing.Size(75, 35);
            this.labMDPrice.TabIndex = 217;
            this.labMDPrice.Text = "السعر";
            // 
            // btnPrintBooks
            // 
            this.btnPrintBooks.Animated = true;
            this.btnPrintBooks.AutoRoundedCorners = true;
            this.btnPrintBooks.BorderColor = System.Drawing.Color.Lavender;
            this.btnPrintBooks.BorderRadius = 24;
            this.btnPrintBooks.BorderThickness = 2;
            this.btnPrintBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrintBooks.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnPrintBooks.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btnPrintBooks.ForeColor = System.Drawing.Color.White;
            this.btnPrintBooks.HoverState.BorderColor = System.Drawing.Color.Lavender;
            this.btnPrintBooks.HoverState.FillColor = System.Drawing.Color.Navy;
            this.btnPrintBooks.HoverState.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBooks.Location = new System.Drawing.Point(7, 681);
            this.btnPrintBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintBooks.Name = "btnPrintBooks";
            this.btnPrintBooks.Size = new System.Drawing.Size(210, 50);
            this.btnPrintBooks.TabIndex = 215;
            this.btnPrintBooks.Text = "طباعة";
            this.btnPrintBooks.Click += new System.EventHandler(this.btnPrintBooks_Click);
            // 
            // labModify
            // 
            this.labModify.AutoSize = true;
            this.labModify.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labModify.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labModify.Location = new System.Drawing.Point(1366, 13);
            this.labModify.Name = "labModify";
            this.labModify.Size = new System.Drawing.Size(239, 38);
            this.labModify.TabIndex = 214;
            this.labModify.Text = ":تعديل او حذف حجز";
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.BorderRadius = 24;
            this.btnDelete.BorderThickness = 2;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Lavender;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.btnDelete.Location = new System.Drawing.Point(1148, 681);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(210, 50);
            this.btnDelete.TabIndex = 213;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BorderRadius = 21;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtSearch.IconRight = global::lab.Properties.Resources._151773;
            this.txtSearch.Location = new System.Drawing.Point(738, 79);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = ":البحث عن نزيل ";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(300, 45);
            this.txtSearch.TabIndex = 212;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel1.Location = new System.Drawing.Point(1460, 177);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(144, 35);
            this.gunaLabel1.TabIndex = 211;
            this.gunaLabel1.Text = "رقم الجنسية ";
            // 
            // txtMDCardNumber
            // 
            this.txtMDCardNumber.Animated = true;
            this.txtMDCardNumber.AutoRoundedCorners = true;
            this.txtMDCardNumber.BorderRadius = 21;
            this.txtMDCardNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMDCardNumber.DefaultText = "";
            this.txtMDCardNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMDCardNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMDCardNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMDCardNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMDCardNumber.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMDCardNumber.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txtMDCardNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtMDCardNumber.ForeColor = System.Drawing.Color.Black;
            this.txtMDCardNumber.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtMDCardNumber.IconRight = ((System.Drawing.Image)(resources.GetObject("txtMDCardNumber.IconRight")));
            this.txtMDCardNumber.Location = new System.Drawing.Point(1073, 167);
            this.txtMDCardNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMDCardNumber.Name = "txtMDCardNumber";
            this.txtMDCardNumber.PasswordChar = '\0';
            this.txtMDCardNumber.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtMDCardNumber.PlaceholderText = "";
            this.txtMDCardNumber.SelectedText = "";
            this.txtMDCardNumber.Size = new System.Drawing.Size(300, 45);
            this.txtMDCardNumber.TabIndex = 210;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel3.Location = new System.Drawing.Point(1445, 263);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(159, 35);
            this.gunaLabel3.TabIndex = 206;
            this.gunaLabel3.Text = "تاريخ بدأ الحجز";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel4.Location = new System.Drawing.Point(1421, 361);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(183, 35);
            this.gunaLabel4.TabIndex = 205;
            this.gunaLabel4.Text = "تاريخ إنتهاء الحجز";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel5.Location = new System.Drawing.Point(1476, 89);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(128, 35);
            this.gunaLabel5.TabIndex = 204;
            this.gunaLabel5.Text = "رقم الغرفة ";
            // 
            // txtMDEndDate
            // 
            this.txtMDEndDate.BorderRadius = 20;
            this.txtMDEndDate.BorderThickness = 1;
            this.txtMDEndDate.Checked = true;
            this.txtMDEndDate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtMDEndDate.CheckedState.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMDEndDate.FillColor = System.Drawing.Color.White;
            this.txtMDEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMDEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtMDEndDate.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtMDEndDate.Location = new System.Drawing.Point(1073, 361);
            this.txtMDEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMDEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtMDEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtMDEndDate.Name = "txtMDEndDate";
            this.txtMDEndDate.Size = new System.Drawing.Size(300, 45);
            this.txtMDEndDate.TabIndex = 209;
            this.txtMDEndDate.Value = new System.DateTime(2023, 2, 21, 17, 20, 10, 337);
            // 
            // txtMDStartDate
            // 
            this.txtMDStartDate.BorderRadius = 20;
            this.txtMDStartDate.BorderThickness = 1;
            this.txtMDStartDate.Checked = true;
            this.txtMDStartDate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtMDStartDate.CheckedState.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMDStartDate.FillColor = System.Drawing.Color.White;
            this.txtMDStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMDStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtMDStartDate.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtMDStartDate.Location = new System.Drawing.Point(1073, 263);
            this.txtMDStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMDStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtMDStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtMDStartDate.Name = "txtMDStartDate";
            this.txtMDStartDate.Size = new System.Drawing.Size(300, 45);
            this.txtMDStartDate.TabIndex = 208;
            this.txtMDStartDate.Value = new System.DateTime(2023, 2, 21, 17, 20, 10, 337);
            // 
            // txtMDRoomNumber
            // 
            this.txtMDRoomNumber.Animated = true;
            this.txtMDRoomNumber.AutoRoundedCorners = true;
            this.txtMDRoomNumber.BorderRadius = 21;
            this.txtMDRoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMDRoomNumber.DefaultText = "";
            this.txtMDRoomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMDRoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMDRoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMDRoomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMDRoomNumber.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMDRoomNumber.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txtMDRoomNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtMDRoomNumber.ForeColor = System.Drawing.Color.Black;
            this.txtMDRoomNumber.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtMDRoomNumber.IconRight = ((System.Drawing.Image)(resources.GetObject("txtMDRoomNumber.IconRight")));
            this.txtMDRoomNumber.Location = new System.Drawing.Point(1073, 79);
            this.txtMDRoomNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMDRoomNumber.Name = "txtMDRoomNumber";
            this.txtMDRoomNumber.PasswordChar = '\0';
            this.txtMDRoomNumber.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtMDRoomNumber.PlaceholderText = "";
            this.txtMDRoomNumber.SelectedText = "";
            this.txtMDRoomNumber.Size = new System.Drawing.Size(300, 45);
            this.txtMDRoomNumber.TabIndex = 203;
            // 
            // btnModify
            // 
            this.btnModify.Animated = true;
            this.btnModify.AutoRoundedCorners = true;
            this.btnModify.BorderColor = System.Drawing.Color.Lavender;
            this.btnModify.BorderRadius = 24;
            this.btnModify.BorderThickness = 2;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModify.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.HoverState.BorderColor = System.Drawing.Color.Lavender;
            this.btnModify.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnModify.Location = new System.Drawing.Point(1395, 681);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(210, 50);
            this.btnModify.TabIndex = 200;
            this.btnModify.Text = "تعديل";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnClear1
            // 
            this.btnClear1.BackColor = System.Drawing.Color.Transparent;
            this.btnClear1.HoverState.Image = global::lab.Properties.Resources._4355228;
            this.btnClear1.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnClear1.Image = global::lab.Properties.Resources._4355228;
            this.btnClear1.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClear1.ImageRotate = 0F;
            this.btnClear1.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClear1.Location = new System.Drawing.Point(1296, 581);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClear1.Size = new System.Drawing.Size(77, 56);
            this.btnClear1.TabIndex = 201;
            this.btnClear1.UseTransparentBackground = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // dgvReservation
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.dgvReservation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvReservation.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReservation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvReservation.ColumnHeadersHeight = 35;
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservation.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvReservation.GridColor = System.Drawing.Color.LightGray;
            this.dgvReservation.Location = new System.Drawing.Point(7, 132);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservation.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvReservation.RowHeadersVisible = false;
            this.dgvReservation.RowHeadersWidth = 51;
            this.dgvReservation.RowTemplate.Height = 24;
            this.dgvReservation.Size = new System.Drawing.Size(1020, 527);
            this.dgvReservation.TabIndex = 0;
            this.dgvReservation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReservation.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReservation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReservation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReservation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReservation.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReservation.ThemeStyle.GridColor = System.Drawing.Color.LightGray;
            this.dgvReservation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.MidnightBlue;
            this.dgvReservation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReservation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReservation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReservation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReservation.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvReservation.ThemeStyle.ReadOnly = true;
            this.dgvReservation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReservation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReservation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReservation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvReservation.ThemeStyle.RowsStyle.Height = 24;
            this.dgvReservation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvReservation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservation_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnPrintAvilableRooms);
            this.tabPage3.Controls.Add(this.dgvAvilableRooms);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1644, 751);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "الغرف المتاحة";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnPrintAvilableRooms
            // 
            this.btnPrintAvilableRooms.Animated = true;
            this.btnPrintAvilableRooms.AutoRoundedCorners = true;
            this.btnPrintAvilableRooms.BorderColor = System.Drawing.Color.Lavender;
            this.btnPrintAvilableRooms.BorderRadius = 24;
            this.btnPrintAvilableRooms.BorderThickness = 2;
            this.btnPrintAvilableRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintAvilableRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintAvilableRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintAvilableRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintAvilableRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrintAvilableRooms.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnPrintAvilableRooms.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btnPrintAvilableRooms.ForeColor = System.Drawing.Color.White;
            this.btnPrintAvilableRooms.HoverState.BorderColor = System.Drawing.Color.Lavender;
            this.btnPrintAvilableRooms.HoverState.FillColor = System.Drawing.Color.Navy;
            this.btnPrintAvilableRooms.HoverState.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAvilableRooms.Location = new System.Drawing.Point(7, 681);
            this.btnPrintAvilableRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintAvilableRooms.Name = "btnPrintAvilableRooms";
            this.btnPrintAvilableRooms.Size = new System.Drawing.Size(210, 50);
            this.btnPrintAvilableRooms.TabIndex = 216;
            this.btnPrintAvilableRooms.Text = "طباعة";
            this.btnPrintAvilableRooms.Click += new System.EventHandler(this.btnPrintAvilableRooms_Click);
            // 
            // dgvAvilableRooms
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.dgvAvilableRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAvilableRooms.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAvilableRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvilableRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAvilableRooms.ColumnHeadersHeight = 35;
            this.dgvAvilableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvilableRooms.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAvilableRooms.GridColor = System.Drawing.Color.LightGray;
            this.dgvAvilableRooms.Location = new System.Drawing.Point(284, 45);
            this.dgvAvilableRooms.Name = "dgvAvilableRooms";
            this.dgvAvilableRooms.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvilableRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAvilableRooms.RowHeadersVisible = false;
            this.dgvAvilableRooms.RowHeadersWidth = 51;
            this.dgvAvilableRooms.RowTemplate.Height = 24;
            this.dgvAvilableRooms.Size = new System.Drawing.Size(1079, 587);
            this.dgvAvilableRooms.TabIndex = 1;
            this.dgvAvilableRooms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAvilableRooms.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAvilableRooms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAvilableRooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAvilableRooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAvilableRooms.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAvilableRooms.ThemeStyle.GridColor = System.Drawing.Color.LightGray;
            this.dgvAvilableRooms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.MidnightBlue;
            this.dgvAvilableRooms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAvilableRooms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAvilableRooms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAvilableRooms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAvilableRooms.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvAvilableRooms.ThemeStyle.ReadOnly = true;
            this.dgvAvilableRooms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAvilableRooms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAvilableRooms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAvilableRooms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAvilableRooms.ThemeStyle.RowsStyle.Height = 24;
            this.dgvAvilableRooms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvAvilableRooms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // UserControlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControlReservation";
            this.Size = new System.Drawing.Size(1684, 942);
            this.Leave += new System.EventHandler(this.UserControlReservation_Leave);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvilableRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI.WinForms.GunaLabel labCardNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtlabCardNumber;
        private Guna.UI.WinForms.GunaLabel labStartDate;
        private Guna.UI.WinForms.GunaLabel labEndDate;
        private Guna.UI.WinForms.GunaLabel labRoomID;
        private Guna.UI2.WinForms.Guna2ImageButton btnClear;
        private Guna.UI2.WinForms.Guna2Button btnBook;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReservation;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAvilableRooms;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtMDCardNumber;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtMDEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtMDStartDate;
        private Guna.UI2.WinForms.Guna2TextBox txtMDRoomNumber;
        private Guna.UI2.WinForms.Guna2Button btnModify;
        private Guna.UI2.WinForms.Guna2ImageButton btnClear1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labModify;
        private Guna.UI2.WinForms.Guna2Button btnPrintBooks;
        private Guna.UI2.WinForms.Guna2Button btnPrintAvilableRooms;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI.WinForms.GunaLabel labPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtMDPrice;
        private Guna.UI.WinForms.GunaLabel labMDPrice;
    }
}
