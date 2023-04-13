namespace lab.User_Control
{
    partial class UserControlRoom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlRoom));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet3 = new lab.HotelDataSet3();
            this.roomTableAdapter = new lab.HotelDataSet3TableAdapters.RoomTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbxStatus = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.labPrice = new Guna.UI.WinForms.GunaLabel();
            this.labStatus = new Guna.UI.WinForms.GunaLabel();
            this.labAvilableBed = new Guna.UI.WinForms.GunaLabel();
            this.labRoomNumber = new Guna.UI.WinForms.GunaLabel();
            this.tabControlRoom = new System.Windows.Forms.TabControl();
            this.tabPageAddRoom = new System.Windows.Forms.TabPage();
            this.labType = new Guna.UI.WinForms.GunaLabel();
            this.txtType = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAvilableBed = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelAddRoom = new System.Windows.Forms.Label();
            this.tabPageModifyRoom = new System.Windows.Forms.TabPage();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.labMDType = new Guna.UI.WinForms.GunaLabel();
            this.cbxMDStatus = new Guna.UI2.WinForms.Guna2CheckBox();
            this.labMDPrice = new Guna.UI.WinForms.GunaLabel();
            this.labMDRoomNumber = new Guna.UI.WinForms.GunaLabel();
            this.labMDStatus = new Guna.UI.WinForms.GunaLabel();
            this.labMDAvilableBed = new Guna.UI.WinForms.GunaLabel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnModify = new Guna.UI2.WinForms.Guna2Button();
            this.dgvRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.roomIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet4 = new lab.HotelDataSet4();
            this.labModify = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.txtMDType = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMDPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMDAvilableBed = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMDRoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.roomTableAdapter1 = new lab.HotelDataSet4TableAdapters.RoomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet3)).BeginInit();
            this.tabControlRoom.SuspendLayout();
            this.tabPageAddRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.tabPageModifyRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.hotelDataSet3;
            // 
            // hotelDataSet3
            // 
            this.hotelDataSet3.DataSetName = "HotelDataSet3";
            this.hotelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbxStatus
            // 
            this.cbxStatus.AutoSize = true;
            this.cbxStatus.CheckedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.cbxStatus.CheckedState.BorderRadius = 0;
            this.cbxStatus.CheckedState.BorderThickness = 0;
            this.cbxStatus.CheckedState.FillColor = System.Drawing.Color.MidnightBlue;
            this.cbxStatus.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.cbxStatus.Location = new System.Drawing.Point(1281, 422);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(81, 39);
            this.cbxStatus.TabIndex = 187;
            this.cbxStatus.Text = "متاح";
            this.cbxStatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbxStatus.UncheckedState.BorderRadius = 0;
            this.cbxStatus.UncheckedState.BorderThickness = 0;
            this.cbxStatus.UncheckedState.FillColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Animated = true;
            this.btnAddRoom.AutoRoundedCorners = true;
            this.btnAddRoom.BorderColor = System.Drawing.Color.Lavender;
            this.btnAddRoom.BorderRadius = 24;
            this.btnAddRoom.BorderThickness = 2;
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.HoverState.BorderColor = System.Drawing.Color.Lavender;
            this.btnAddRoom.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnAddRoom.HoverState.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Location = new System.Drawing.Point(1062, 589);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(300, 50);
            this.btnAddRoom.TabIndex = 186;
            this.btnAddRoom.Text = "إضافة ";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labPrice.Location = new System.Drawing.Point(1543, 338);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(75, 35);
            this.labPrice.TabIndex = 184;
            this.labPrice.Text = "السعر";
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labStatus.Location = new System.Drawing.Point(1491, 426);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(127, 35);
            this.labStatus.TabIndex = 182;
            this.labStatus.Text = "حالة الغرفة";
            // 
            // labAvilableBed
            // 
            this.labAvilableBed.AutoSize = true;
            this.labAvilableBed.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labAvilableBed.Location = new System.Drawing.Point(1417, 156);
            this.labAvilableBed.Name = "labAvilableBed";
            this.labAvilableBed.Size = new System.Drawing.Size(201, 35);
            this.labAvilableBed.TabIndex = 179;
            this.labAvilableBed.Text = "عدد الاسرة المتاحة";
            // 
            // labRoomNumber
            // 
            this.labRoomNumber.AutoSize = true;
            this.labRoomNumber.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labRoomNumber.Location = new System.Drawing.Point(1490, 74);
            this.labRoomNumber.Name = "labRoomNumber";
            this.labRoomNumber.Size = new System.Drawing.Size(128, 35);
            this.labRoomNumber.TabIndex = 177;
            this.labRoomNumber.Text = "رقم الغرفة ";
            // 
            // tabControlRoom
            // 
            this.tabControlRoom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlRoom.Controls.Add(this.tabPageAddRoom);
            this.tabControlRoom.Controls.Add(this.tabPageModifyRoom);
            this.tabControlRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlRoom.Location = new System.Drawing.Point(20, 40);
            this.tabControlRoom.Name = "tabControlRoom";
            this.tabControlRoom.SelectedIndex = 0;
            this.tabControlRoom.Size = new System.Drawing.Size(1652, 790);
            this.tabControlRoom.TabIndex = 190;
            // 
            // tabPageAddRoom
            // 
            this.tabPageAddRoom.Controls.Add(this.labType);
            this.tabPageAddRoom.Controls.Add(this.txtType);
            this.tabPageAddRoom.Controls.Add(this.txtPrice);
            this.tabPageAddRoom.Controls.Add(this.txtAvilableBed);
            this.tabPageAddRoom.Controls.Add(this.txtRoomNumber);
            this.tabPageAddRoom.Controls.Add(this.btnAddRoom);
            this.tabPageAddRoom.Controls.Add(this.cbxStatus);
            this.tabPageAddRoom.Controls.Add(this.btnClear);
            this.tabPageAddRoom.Controls.Add(this.labPrice);
            this.tabPageAddRoom.Controls.Add(this.labRoomNumber);
            this.tabPageAddRoom.Controls.Add(this.labStatus);
            this.tabPageAddRoom.Controls.Add(this.labAvilableBed);
            this.tabPageAddRoom.Controls.Add(this.guna2PictureBox1);
            this.tabPageAddRoom.Controls.Add(this.labelAddRoom);
            this.tabPageAddRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddRoom.Name = "tabPageAddRoom";
            this.tabPageAddRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddRoom.Size = new System.Drawing.Size(1644, 751);
            this.tabPageAddRoom.TabIndex = 0;
            this.tabPageAddRoom.Text = "إضافة غرفة";
            this.tabPageAddRoom.UseVisualStyleBackColor = true;
            this.tabPageAddRoom.Leave += new System.EventHandler(this.tabPageAddRoom_Leave);
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labType.Location = new System.Drawing.Point(1497, 252);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(121, 35);
            this.labType.TabIndex = 191;
            this.labType.Text = "نوع الغرفة";
            // 
            // txtType
            // 
            this.txtType.Animated = true;
            this.txtType.AutoRoundedCorners = true;
            this.txtType.BorderRadius = 22;
            this.txtType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtType.DefaultText = "";
            this.txtType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtType.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.txtType.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txtType.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtType.ForeColor = System.Drawing.Color.Black;
            this.txtType.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtType.IconRight = global::lab.Properties.Resources._3022148;
            this.txtType.Location = new System.Drawing.Point(1062, 241);
            this.txtType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtType.Name = "txtType";
            this.txtType.PasswordChar = '\0';
            this.txtType.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtType.PlaceholderText = "";
            this.txtType.SelectedText = "";
            this.txtType.Size = new System.Drawing.Size(300, 46);
            this.txtType.TabIndex = 190;
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
            this.txtPrice.Location = new System.Drawing.Point(1062, 328);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(300, 45);
            this.txtPrice.TabIndex = 183;
            // 
            // txtAvilableBed
            // 
            this.txtAvilableBed.Animated = true;
            this.txtAvilableBed.AutoRoundedCorners = true;
            this.txtAvilableBed.BorderRadius = 21;
            this.txtAvilableBed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAvilableBed.DefaultText = "";
            this.txtAvilableBed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAvilableBed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAvilableBed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAvilableBed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAvilableBed.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAvilableBed.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txtAvilableBed.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtAvilableBed.ForeColor = System.Drawing.Color.Black;
            this.txtAvilableBed.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtAvilableBed.IconRight = global::lab.Properties.Resources._3159474;
            this.txtAvilableBed.Location = new System.Drawing.Point(1062, 146);
            this.txtAvilableBed.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAvilableBed.Name = "txtAvilableBed";
            this.txtAvilableBed.PasswordChar = '\0';
            this.txtAvilableBed.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtAvilableBed.PlaceholderText = "";
            this.txtAvilableBed.SelectedText = "";
            this.txtAvilableBed.Size = new System.Drawing.Size(300, 45);
            this.txtAvilableBed.TabIndex = 178;
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
            this.txtRoomNumber.Location = new System.Drawing.Point(1062, 64);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.PasswordChar = '\0';
            this.txtRoomNumber.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtRoomNumber.PlaceholderText = "";
            this.txtRoomNumber.SelectedText = "";
            this.txtRoomNumber.Size = new System.Drawing.Size(300, 45);
            this.txtRoomNumber.TabIndex = 173;
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
            this.btnClear.Location = new System.Drawing.Point(1285, 480);
            this.btnClear.Name = "btnClear";
            this.btnClear.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClear.Size = new System.Drawing.Size(77, 56);
            this.btnClear.TabIndex = 185;
            this.btnClear.UseTransparentBackground = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::lab.Properties.Resources.Living_room_bro;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-76, -41);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1250, 827);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 192;
            this.guna2PictureBox1.TabStop = false;
            // 
            // labelAddRoom
            // 
            this.labelAddRoom.AutoSize = true;
            this.labelAddRoom.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddRoom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelAddRoom.Location = new System.Drawing.Point(1468, 3);
            this.labelAddRoom.Name = "labelAddRoom";
            this.labelAddRoom.Size = new System.Drawing.Size(150, 38);
            this.labelAddRoom.TabIndex = 135;
            this.labelAddRoom.Text = ":اضف غرفة";
            // 
            // tabPageModifyRoom
            // 
            this.tabPageModifyRoom.Controls.Add(this.btnPrint);
            this.tabPageModifyRoom.Controls.Add(this.labMDType);
            this.tabPageModifyRoom.Controls.Add(this.cbxMDStatus);
            this.tabPageModifyRoom.Controls.Add(this.labMDPrice);
            this.tabPageModifyRoom.Controls.Add(this.labMDRoomNumber);
            this.tabPageModifyRoom.Controls.Add(this.labMDStatus);
            this.tabPageModifyRoom.Controls.Add(this.labMDAvilableBed);
            this.tabPageModifyRoom.Controls.Add(this.btnDelete);
            this.tabPageModifyRoom.Controls.Add(this.btnModify);
            this.tabPageModifyRoom.Controls.Add(this.dgvRoom);
            this.tabPageModifyRoom.Controls.Add(this.labModify);
            this.tabPageModifyRoom.Controls.Add(this.guna2Button3);
            this.tabPageModifyRoom.Controls.Add(this.guna2Button4);
            this.tabPageModifyRoom.Controls.Add(this.txtMDType);
            this.tabPageModifyRoom.Controls.Add(this.txtMDPrice);
            this.tabPageModifyRoom.Controls.Add(this.txtMDAvilableBed);
            this.tabPageModifyRoom.Controls.Add(this.txtMDRoomNumber);
            this.tabPageModifyRoom.Controls.Add(this.btnClear1);
            this.tabPageModifyRoom.Controls.Add(this.txtSearch);
            this.tabPageModifyRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageModifyRoom.ForeColor = System.Drawing.Color.Black;
            this.tabPageModifyRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageModifyRoom.Name = "tabPageModifyRoom";
            this.tabPageModifyRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModifyRoom.Size = new System.Drawing.Size(1644, 751);
            this.tabPageModifyRoom.TabIndex = 1;
            this.tabPageModifyRoom.Text = "تعديل او حذف غرفة";
            this.tabPageModifyRoom.UseVisualStyleBackColor = true;
            this.tabPageModifyRoom.Leave += new System.EventHandler(this.tabPageModifyRoom_Leave);
            // 
            // btnPrint
            // 
            this.btnPrint.Animated = true;
            this.btnPrint.AutoRoundedCorners = true;
            this.btnPrint.BorderColor = System.Drawing.Color.Lavender;
            this.btnPrint.BorderRadius = 24;
            this.btnPrint.BorderThickness = 2;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.BorderColor = System.Drawing.Color.Lavender;
            this.btnPrint.HoverState.FillColor = System.Drawing.Color.Navy;
            this.btnPrint.HoverState.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(7, 681);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(210, 50);
            this.btnPrint.TabIndex = 216;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // labMDType
            // 
            this.labMDType.AutoSize = true;
            this.labMDType.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labMDType.Location = new System.Drawing.Point(1498, 252);
            this.labMDType.Name = "labMDType";
            this.labMDType.Size = new System.Drawing.Size(121, 35);
            this.labMDType.TabIndex = 202;
            this.labMDType.Text = "نوع الغرفة";
            // 
            // cbxMDStatus
            // 
            this.cbxMDStatus.AutoSize = true;
            this.cbxMDStatus.CheckedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.cbxMDStatus.CheckedState.BorderRadius = 0;
            this.cbxMDStatus.CheckedState.BorderThickness = 0;
            this.cbxMDStatus.CheckedState.FillColor = System.Drawing.Color.MidnightBlue;
            this.cbxMDStatus.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.cbxMDStatus.Location = new System.Drawing.Point(1281, 422);
            this.cbxMDStatus.Name = "cbxMDStatus";
            this.cbxMDStatus.Size = new System.Drawing.Size(81, 39);
            this.cbxMDStatus.TabIndex = 200;
            this.cbxMDStatus.Text = "متاح";
            this.cbxMDStatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbxMDStatus.UncheckedState.BorderRadius = 0;
            this.cbxMDStatus.UncheckedState.BorderThickness = 0;
            this.cbxMDStatus.UncheckedState.FillColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // labMDPrice
            // 
            this.labMDPrice.AutoSize = true;
            this.labMDPrice.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labMDPrice.Location = new System.Drawing.Point(1544, 338);
            this.labMDPrice.Name = "labMDPrice";
            this.labMDPrice.Size = new System.Drawing.Size(75, 35);
            this.labMDPrice.TabIndex = 198;
            this.labMDPrice.Text = "السعر";
            // 
            // labMDRoomNumber
            // 
            this.labMDRoomNumber.AutoSize = true;
            this.labMDRoomNumber.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labMDRoomNumber.Location = new System.Drawing.Point(1491, 74);
            this.labMDRoomNumber.Name = "labMDRoomNumber";
            this.labMDRoomNumber.Size = new System.Drawing.Size(128, 35);
            this.labMDRoomNumber.TabIndex = 193;
            this.labMDRoomNumber.Text = "رقم الغرفة ";
            // 
            // labMDStatus
            // 
            this.labMDStatus.AutoSize = true;
            this.labMDStatus.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labMDStatus.Location = new System.Drawing.Point(1486, 426);
            this.labMDStatus.Name = "labMDStatus";
            this.labMDStatus.Size = new System.Drawing.Size(127, 35);
            this.labMDStatus.TabIndex = 196;
            this.labMDStatus.Text = "حالة الغرفة";
            // 
            // labMDAvilableBed
            // 
            this.labMDAvilableBed.AutoSize = true;
            this.labMDAvilableBed.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labMDAvilableBed.Location = new System.Drawing.Point(1418, 156);
            this.labMDAvilableBed.Name = "labMDAvilableBed";
            this.labMDAvilableBed.Size = new System.Drawing.Size(201, 35);
            this.labMDAvilableBed.TabIndex = 195;
            this.labMDAvilableBed.Text = "عدد الاسرة المتاحة";
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
            this.btnDelete.Location = new System.Drawing.Point(1169, 681);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(210, 50);
            this.btnDelete.TabIndex = 191;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnModify.Location = new System.Drawing.Point(1409, 681);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(210, 50);
            this.btnModify.TabIndex = 190;
            this.btnModify.Text = "تعديل";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            this.dgvRoom.AllowUserToDeleteRows = false;
            this.dgvRoom.AllowUserToOrderColumns = true;
            this.dgvRoom.AllowUserToResizeColumns = false;
            this.dgvRoom.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.dgvRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRoom.AutoGenerateColumns = false;
            this.dgvRoom.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRoom.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRoom.ColumnHeadersHeight = 35;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIdDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.sizeRoomDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.viableDataGridViewTextBoxColumn});
            this.dgvRoom.DataSource = this.roomBindingSource1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoom.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRoom.GridColor = System.Drawing.Color.LightGray;
            this.dgvRoom.Location = new System.Drawing.Point(7, 132);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRoom.RowHeadersVisible = false;
            this.dgvRoom.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRoom.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRoom.RowTemplate.Height = 24;
            this.dgvRoom.Size = new System.Drawing.Size(1020, 527);
            this.dgvRoom.TabIndex = 182;
            this.dgvRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRoom.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRoom.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRoom.ThemeStyle.GridColor = System.Drawing.Color.LightGray;
            this.dgvRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.MidnightBlue;
            this.dgvRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRoom.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvRoom.ThemeStyle.ReadOnly = true;
            this.dgvRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRoom.ThemeStyle.RowsStyle.Height = 24;
            this.dgvRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick);
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            this.roomIdDataGridViewTextBoxColumn.DataPropertyName = "RoomId";
            this.roomIdDataGridViewTextBoxColumn.HeaderText = "RoomId";
            this.roomIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            this.roomIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            this.roomTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeRoomDataGridViewTextBoxColumn
            // 
            this.sizeRoomDataGridViewTextBoxColumn.DataPropertyName = "SizeRoom";
            this.sizeRoomDataGridViewTextBoxColumn.HeaderText = "SizeRoom";
            this.sizeRoomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sizeRoomDataGridViewTextBoxColumn.Name = "sizeRoomDataGridViewTextBoxColumn";
            this.sizeRoomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viableDataGridViewTextBoxColumn
            // 
            this.viableDataGridViewTextBoxColumn.DataPropertyName = "Viable";
            this.viableDataGridViewTextBoxColumn.HeaderText = "Viable";
            this.viableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.viableDataGridViewTextBoxColumn.Name = "viableDataGridViewTextBoxColumn";
            this.viableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomBindingSource1
            // 
            this.roomBindingSource1.DataMember = "Room";
            this.roomBindingSource1.DataSource = this.hotelDataSet4;
            // 
            // hotelDataSet4
            // 
            this.hotelDataSet4.DataSetName = "HotelDataSet4";
            this.hotelDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labModify
            // 
            this.labModify.AutoSize = true;
            this.labModify.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labModify.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labModify.Location = new System.Drawing.Point(1370, 3);
            this.labModify.Name = "labModify";
            this.labModify.Size = new System.Drawing.Size(249, 38);
            this.labModify.TabIndex = 148;
            this.labModify.Text = ":تعديل او حذف غرفة";
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BorderColor = System.Drawing.Color.Lavender;
            this.guna2Button3.BorderRadius = 29;
            this.guna2Button3.BorderThickness = 2;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.MidnightBlue;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.BorderColor = System.Drawing.Color.Lavender;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.Navy;
            this.guna2Button3.HoverState.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.Location = new System.Drawing.Point(544, 941);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(300, 60);
            this.guna2Button3.TabIndex = 137;
            this.guna2Button3.Text = "حذف نزيل";
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.AutoRoundedCorners = true;
            this.guna2Button4.BorderColor = System.Drawing.Color.Lavender;
            this.guna2Button4.BorderRadius = 29;
            this.guna2Button4.BorderThickness = 2;
            this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.MidnightBlue;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.BorderColor = System.Drawing.Color.Lavender;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.Navy;
            this.guna2Button4.HoverState.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.Location = new System.Drawing.Point(900, 941);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(300, 60);
            this.guna2Button4.TabIndex = 136;
            this.guna2Button4.Text = "تعديل معلومات نزيل";
            // 
            // txtMDType
            // 
            this.txtMDType.Animated = true;
            this.txtMDType.AutoRoundedCorners = true;
            this.txtMDType.BorderRadius = 22;
            this.txtMDType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMDType.DefaultText = "";
            this.txtMDType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMDType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMDType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMDType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMDType.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMDType.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txtMDType.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtMDType.ForeColor = System.Drawing.Color.Black;
            this.txtMDType.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtMDType.IconRight = global::lab.Properties.Resources._3022148;
            this.txtMDType.Location = new System.Drawing.Point(1062, 241);
            this.txtMDType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMDType.Name = "txtMDType";
            this.txtMDType.PasswordChar = '\0';
            this.txtMDType.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtMDType.PlaceholderText = "";
            this.txtMDType.SelectedText = "";
            this.txtMDType.Size = new System.Drawing.Size(300, 46);
            this.txtMDType.TabIndex = 201;
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
            this.txtMDPrice.Location = new System.Drawing.Point(1062, 328);
            this.txtMDPrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMDPrice.Name = "txtMDPrice";
            this.txtMDPrice.PasswordChar = '\0';
            this.txtMDPrice.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtMDPrice.PlaceholderText = "";
            this.txtMDPrice.SelectedText = "";
            this.txtMDPrice.Size = new System.Drawing.Size(300, 45);
            this.txtMDPrice.TabIndex = 197;
            // 
            // txtMDAvilableBed
            // 
            this.txtMDAvilableBed.Animated = true;
            this.txtMDAvilableBed.AutoRoundedCorners = true;
            this.txtMDAvilableBed.BorderRadius = 21;
            this.txtMDAvilableBed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMDAvilableBed.DefaultText = "";
            this.txtMDAvilableBed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMDAvilableBed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMDAvilableBed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMDAvilableBed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMDAvilableBed.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMDAvilableBed.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txtMDAvilableBed.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtMDAvilableBed.ForeColor = System.Drawing.Color.Black;
            this.txtMDAvilableBed.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtMDAvilableBed.IconRight = global::lab.Properties.Resources._3159474;
            this.txtMDAvilableBed.Location = new System.Drawing.Point(1062, 146);
            this.txtMDAvilableBed.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMDAvilableBed.Name = "txtMDAvilableBed";
            this.txtMDAvilableBed.PasswordChar = '\0';
            this.txtMDAvilableBed.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtMDAvilableBed.PlaceholderText = "";
            this.txtMDAvilableBed.SelectedText = "";
            this.txtMDAvilableBed.Size = new System.Drawing.Size(300, 45);
            this.txtMDAvilableBed.TabIndex = 194;
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
            this.txtMDRoomNumber.IconRight = global::lab.Properties.Resources._1834583;
            this.txtMDRoomNumber.Location = new System.Drawing.Point(1062, 64);
            this.txtMDRoomNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMDRoomNumber.Name = "txtMDRoomNumber";
            this.txtMDRoomNumber.PasswordChar = '\0';
            this.txtMDRoomNumber.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtMDRoomNumber.PlaceholderText = "";
            this.txtMDRoomNumber.SelectedText = "";
            this.txtMDRoomNumber.Size = new System.Drawing.Size(300, 45);
            this.txtMDRoomNumber.TabIndex = 192;
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
            this.btnClear1.Location = new System.Drawing.Point(1285, 483);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClear1.Size = new System.Drawing.Size(77, 56);
            this.btnClear1.TabIndex = 199;
            this.btnClear1.UseTransparentBackground = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(727, 64);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = ":البحث عن غرفة ";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(300, 45);
            this.txtSearch.TabIndex = 134;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // roomTableAdapter1
            // 
            this.roomTableAdapter1.ClearBeforeFill = true;
            // 
            // UserControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlRoom);
            this.Name = "UserControlRoom";
            this.Size = new System.Drawing.Size(2160, 1039);
            this.Load += new System.EventHandler(this.UserControlRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet3)).EndInit();
            this.tabControlRoom.ResumeLayout(false);
            this.tabPageAddRoom.ResumeLayout(false);
            this.tabPageAddRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.tabPageModifyRoom.ResumeLayout(false);
            this.tabPageModifyRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource roomBindingSource;
        private HotelDataSet3 hotelDataSet3;
        private HotelDataSet3TableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI2.WinForms.Guna2CheckBox cbxStatus;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2ImageButton btnClear;
        private Guna.UI.WinForms.GunaLabel labPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI.WinForms.GunaLabel labStatus;
        private Guna.UI.WinForms.GunaLabel labAvilableBed;
        private Guna.UI2.WinForms.Guna2TextBox txtAvilableBed;
        private Guna.UI.WinForms.GunaLabel labRoomNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomNumber;
        private System.Windows.Forms.TabControl tabControlRoom;
        private System.Windows.Forms.TabPage tabPageAddRoom;
        private System.Windows.Forms.Label labelAddRoom;
        private System.Windows.Forms.TabPage tabPageModifyRoom;
        private System.Windows.Forms.Label labModify;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI.WinForms.GunaLabel labType;
        private Guna.UI2.WinForms.Guna2TextBox txtType;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viableDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnModify;
        private Guna.UI.WinForms.GunaLabel labMDType;
        private Guna.UI2.WinForms.Guna2TextBox txtMDType;
        private Guna.UI2.WinForms.Guna2TextBox txtMDPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtMDAvilableBed;
        private Guna.UI2.WinForms.Guna2TextBox txtMDRoomNumber;
        private Guna.UI2.WinForms.Guna2CheckBox cbxMDStatus;
        private Guna.UI2.WinForms.Guna2ImageButton btnClear1;
        private Guna.UI.WinForms.GunaLabel labMDPrice;
        private Guna.UI.WinForms.GunaLabel labMDRoomNumber;
        private Guna.UI.WinForms.GunaLabel labMDStatus;
        private Guna.UI.WinForms.GunaLabel labMDAvilableBed;
        private System.Windows.Forms.BindingSource roomBindingSource1;
        private HotelDataSet4 hotelDataSet4;
        private HotelDataSet4TableAdapters.RoomTableAdapter roomTableAdapter1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
    }
}
