using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab.User_Control
{
    public partial class frmPrint : Form
    {
        private static SqlConnection Sqlcon()
        {
            var con = new SqlConnection(Properties.Settings.Default.con);
            return con;
        }


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
            reportViewer1.RefreshReport();
            try
            {
                var cmd = new SqlCommand("select *from Guest;", Sqlcon());
                var dl = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                dl.Fill(dt);
                reportViewer1.LocalReport.DataSources.Clear();
                var source = new ReportDataSource("customer", dt);
                reportViewer1.LocalReport.ReportPath = @"Customer.rdlc";
                reportViewer1.LocalReport.DataSources.Add(source);
                reportViewer1.RefreshReport();
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
            reportViewer1.RefreshReport();
            try
            {
                var cmd = new SqlCommand("select *from Office;", Sqlcon());
                var dl = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                dl.Fill(dt);
                reportViewer1.LocalReport.DataSources.Clear();
                var source = new ReportDataSource("office", dt);
                reportViewer1.LocalReport.ReportPath = @"office.rdlc";
                reportViewer1.LocalReport.DataSources.Add(source);
                reportViewer1.RefreshReport();
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"{exception}");
            }
        }

        private void Repo()
        {
            reportViewer1.RefreshReport();
            try
            {
                var cmd = new SqlCommand("select *from repo;", Sqlcon());
                var dl = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                dl.Fill(dt);
                reportViewer1.LocalReport.DataSources.Clear();
                var source = new ReportDataSource("repo", dt);
                reportViewer1.LocalReport.ReportPath = @"repo.rdlc";
                reportViewer1.LocalReport.DataSources.Add(source);
                reportViewer1.RefreshReport();
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"{exception}");
            }
        }

        private void RoomReport()
        {
            reportViewer1.RefreshReport();
            try
            {
                var cmd = new SqlCommand("select *from Room;", Sqlcon());
                var dl = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                dl.Fill(dt);
                reportViewer1.LocalReport.DataSources.Clear();
                var source = new ReportDataSource("Room", dt);
                reportViewer1.LocalReport.ReportPath = @"Report1.rdlc";
                reportViewer1.LocalReport.DataSources.Add(source);
                reportViewer1.RefreshReport();
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"{exception}");
            }
        }

    }
}
