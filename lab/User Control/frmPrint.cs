using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab.User_Control
{
    public partial class frmPrint : Form
    {
        private readonly SqlConnection con = new SqlConnection(
            "Data Source=ASMAALAP;Initial Catalog=Hotel;Integrated Security=True");
        public frmPrint()
        {
            InitializeComponent();
        }

        private static frmPrint instrFrmPrint = null;

        public static frmPrint InstraFrmPrint1()
        {
            return instrFrmPrint ?? (instrFrmPrint = new frmPrint());
        }

        private void Costemer()
        {
            this.reportViewer1.RefreshReport();
            try
            {
                var cmd = new SqlCommand("select *from Guest;", this.con);
                var dl = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                dl.Fill(dt);
                this.reportViewer1.LocalReport.DataSources.Clear();
                var source = new ReportDataSource("customer", dt);
                this.reportViewer1.LocalReport.ReportPath = @"Customer.rdlc";
                this.reportViewer1.LocalReport.DataSources.Add(source);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"{exception}");
            }
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {

            switch (Printer.PrintType)
            {
                case 1:
                    RoomReport();
                    break;
                case 2:
                    Office();
                    break;
                case 3:
                    Costemer();
                    break;
                case 4:
                    Repo();
                    break;
            }
        }
        private void Office()
        {
            this.reportViewer1.RefreshReport();
            try
            {
                var cmd = new SqlCommand("select *from Office;", this.con);
                var dl = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                dl.Fill(dt);
                this.reportViewer1.LocalReport.DataSources.Clear();
                var source = new ReportDataSource("office", dt);
                this.reportViewer1.LocalReport.ReportPath = @"office.rdlc";
                this.reportViewer1.LocalReport.DataSources.Add(source);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"{exception}");
            }
        }

        private void Repo()
        {
            this.reportViewer1.RefreshReport();
            try
            {
                var cmd = new SqlCommand("select *from repo;", this.con);
                var dl = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                dl.Fill(dt);
                this.reportViewer1.LocalReport.DataSources.Clear();
                var source = new ReportDataSource("repo", dt);
                this.reportViewer1.LocalReport.ReportPath = @"repo.rdlc";
                this.reportViewer1.LocalReport.DataSources.Add(source);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"{exception}");
            }
        }

        private void RoomReport()
        {
            this.reportViewer1.RefreshReport();
            try
            {
                var cmd = new SqlCommand("select *from Room;", this.con);
                var dl = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                dl.Fill(dt);
                this.reportViewer1.LocalReport.DataSources.Clear();
                var source = new ReportDataSource("Room", dt);
                this.reportViewer1.LocalReport.ReportPath = @"Report1.rdlc";
                this.reportViewer1.LocalReport.DataSources.Add(source);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"{exception}");
            }
        }

    }
}
