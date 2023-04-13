namespace lab.User_Control
{
    partial class frmPrint
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrint));
            this.roomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.room = new lab.Room();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet3 = new lab.HotelDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.roomTableAdapter = new lab.HotelDataSet3TableAdapters.RoomTableAdapter();
            this.customer = new lab.customer();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.office1 = new lab.office();
            this.office1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repo1 = new lab.repo();
            this.repo1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet3)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.office1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.office1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // roomBindingSource1
            // 
            this.roomBindingSource1.DataSource = this.room;
            this.roomBindingSource1.Position = 0;
            // 
            // room
            // 
            this.room.DataSetName = "Room";
            this.room.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // reportViewer1
            // 
            reportDataSource1.Name = "Room";
            reportDataSource1.Value = this.roomBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "lab.bin.Debug.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 61);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1330, 750);
            this.reportViewer1.TabIndex = 0;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 12;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunClose
            // 
            this.gunClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunClose.BackColor = System.Drawing.Color.White;
            this.gunClose.FillColor = System.Drawing.Color.Transparent;
            this.gunClose.IconColor = System.Drawing.Color.MidnightBlue;
            this.gunClose.Location = new System.Drawing.Point(1323, 3);
            this.gunClose.Name = "gunClose";
            this.gunClose.Size = new System.Drawing.Size(43, 40);
            this.gunClose.TabIndex = 25;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.MidnightBlue;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1274, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(43, 40);
            this.guna2ControlBox1.TabIndex = 26;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.gunClose);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1378, 38);
            this.guna2Panel1.TabIndex = 27;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // customer
            // 
            this.customer.DataSetName = "customer";
            this.customer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = this.customer;
            this.customerBindingSource.Position = 0;
            // 
            // office1
            // 
            this.office1.DataSetName = "office";
            this.office1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // office1BindingSource
            // 
            this.office1BindingSource.DataSource = this.office1;
            this.office1BindingSource.Position = 0;
            // 
            // repo1
            // 
            this.repo1.DataSetName = "repo";
            this.repo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repo1BindingSource
            // 
            this.repo1BindingSource.DataSource = this.repo1;
            this.repo1BindingSource.Position = 0;
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1379, 830);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrint";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet3)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.office1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.office1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox gunClose;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private HotelDataSet3 hotelDataSet3;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private HotelDataSet3TableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.BindingSource roomBindingSource1;
        private Room room;
        private customer customer;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private office office1;
        private System.Windows.Forms.BindingSource office1BindingSource;
        private repo repo1;
        private System.Windows.Forms.BindingSource repo1BindingSource;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}