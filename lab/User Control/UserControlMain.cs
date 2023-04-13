using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace lab.User_Control
{
    public partial class UserControlMain : UserControl
    {
        public UserControlMain()
        {
            InitializeComponent();
        }
        public void Employee()
        {
            const string Cons = @"Data Source = ASMAALAP; Initial Catalog=Hotel; Integrated Security=True; User ID=name; Password=123456";
            var con = new SqlConnection(Cons);
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
        public void Customer()
        {
            const string Cons = @"Data Source = ASMAALAP; Initial Catalog=Hotel; Integrated Security=True; User ID=name; Password=123456";
            var con = new SqlConnection(Cons);
            con.Open();
            var q = $"select *from Guest";
            var cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            con.Close();
            this.labCustomerCount.Text = dt.Rows.Count.ToString();
        }
        public void Room()
        {
            const string Cons = @"Data Source = ASMAALAP; Initial Catalog=Hotel; Integrated Security=True; User ID=name; Password=123456";
            var con = new SqlConnection(Cons);
            con.Open();
            var q = $"select *from Room";
            var cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            con.Close();
            this.labRoomCount.Text = dt.Rows.Count.ToString();
        }

        private void UserControlMain_Load(object sender, EventArgs e)
        {
            Employee();
            Customer();
            Room();
        }
    }
}
