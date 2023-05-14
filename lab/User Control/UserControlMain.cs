using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab.User_Control
{
    public partial class UserControlMain : UserControl
    {
        public UserControlMain()
        {
            InitializeComponent();
        }
        private static SqlConnection Sqlcon()
        {
            var con = new SqlConnection(Properties.Settings.Default.con);
            return con;
        }
        private void Employee()
        {
            var con = Sqlcon();
            con.Open();
            var q = $"select *from Office";
            var cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            con.Close();
            labEmployeeCount.Text = dt.Rows.Count.ToString();
        }
        private void Customer()
        {
            var con = Sqlcon();
            con.Open();
            var q = $"select *from Guest";
            var cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            con.Close();
            labCustomerCount.Text = dt.Rows.Count.ToString();
        }
        private void Room()
        {
            var con = Sqlcon();
            con.Open();
            var q = $"select *from Room";
            var cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            con.Close();
            labRoomCount.Text = dt.Rows.Count.ToString();
        }

        private void UserControlMain_Load(object sender, EventArgs e)
        {
            Employee();
            Customer();
            Room();
        }
    }
}
