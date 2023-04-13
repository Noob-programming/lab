using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab.User_Control
{
    public partial class UserControlReservation : UserControl
    {
        private byte checter;

        private string id = string.Empty;

        private bool fallData(int flace)
        {
            if (flace == 1)
            {
                return new List<string> { txtRoomNumber.Text, txtlabCardNumber.Text, txtPrice.Text }.All(
                    x => x != string.Empty);
            }
            else
            {
                return new List<string> { txtMDCardNumber.Text,
                                                txtMDRoomNumber.Text,txtMDPrice.Text}.All(x => x != string.Empty);
            }
        }

        public UserControlReservation()
        {
            InitializeComponent();
        }

        private static SqlConnection SqlCon()
        {
            const string Cons =
                @"Data Source = ASMAALAP; Initial Catalog=Hotel; Integrated Security=True; User ID=name; Password=123456";
            var con = new SqlConnection(Cons);
            return con;
        }

        private void AvailbleRoom()
        {
            var con = SqlCon();
            con.Open();
            const string Query = "SELECT * FROM[dbo].[Room] where Viable = '0'; ";
            var cmd = new SqlCommand(Query, con);
            var db = new SqlDataAdapter(cmd);
            var datable = new DataTable();
            db.Fill(datable);
            dgvAvilableRooms.DataSource = datable;
            con.Close();
        }

        public void Clear()
        {
            txtRoomNumber.Clear();
            txtlabCardNumber.Clear();
        }
        public void Clear1()
        {
            txtMDRoomNumber.Clear();
            txtMDCardNumber.Clear();
            txtSearch.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void UserControlReservation_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            Clear1();
        }


        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (fallData(1))
                {
                    MessageBox.Show(@"{Fall Data and Save}");
                    return;
                }

                if (!checkRoom(txtRoomNumber.Text))
                {
                    MessageBox.Show("ERROR Room Number");
                    return;
                }

                ViableRoom(1, txtRoomNumber.Text);
                if (checter != 1) return;
                var star = dtpStartDate.Value.ToString(CultureInfo.InvariantCulture).Split(' ')[0];
                var end = dtpEndDate.Value.ToString(CultureInfo.InvariantCulture).Split(' ')[0];
                var con = SqlCon();
                con.Open();
                var quarry = $@"INSERT INTO [dbo].[repo] ([GeastID], [RoomID], [StartDate], [EndDate], [amont])
        VALUES('{txtlabCardNumber.Text}', '{txtRoomNumber.Text}', '{star}', '{end}', '{txtPrice.Text}')";
                var cmd = new SqlCommand(quarry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                checter = 0;
                ShowGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"{exception}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var con = SqlCon();
                con.Open();
                var quarry = $@"DELETE FROM [dbo].[repo] WHERE Id = '{id}';";
                var cmd = new SqlCommand(quarry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                ShowGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"{exception}");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (fallData(2))
                {
                    MessageBox.Show(@"Fall data and update");
                    return;
                }
                var con = SqlCon();
                con.Open();
                var quarry = $@"UPDATE [dbo].[repo]
        SET [GeastID] = '{txtMDCardNumber.Text}',[RoomID] = '{txtMDRoomNumber.Text}',
        [StartDate] = '{txtMDStartDate.Value.ToString(CultureInfo.InvariantCulture).Split(' ')[0]}',
        [EndDate] = '{txtMDEndDate.Value.ToString(CultureInfo.InvariantCulture).Split(' ')[0]}' ,
        [amont] = '{txtPrice.Text}' WHERE Id = '{id}'";
                var cmd = new SqlCommand(quarry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                ShowGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"{exception}");
            }
        }
        private bool checkRoom(string RoomId)
        {
            var q = $@"SELECT * FROM [dbo].[Room] where [RoomNumber] = '{RoomId}';";
            var con = SqlCon();
            con.Open();
            var cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt.Rows.Count > 0;
        }

        private void dgvReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = dgvReservation.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMDCardNumber.Text = dgvReservation.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMDRoomNumber.Text = dgvReservation.Rows[e.RowIndex].Cells[2].Value.ToString();

                txtMDStartDate.Value = (DateTime)dgvReservation.Rows[e.RowIndex].Cells[3].Value;
                txtMDEndDate.Value = (DateTime)dgvReservation.Rows[e.RowIndex].Cells[4].Value;

                txtMDPrice.Text = dgvReservation.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"{exception}");
            }
        }
        private void ShowGrid()
        {
            var con = SqlCon();
            con.Open();
            const string Query = "select * from repo";
            var cmd = new SqlCommand(Query, con);
            var db = new SqlDataAdapter(cmd);
            var datable = new DataTable();
            db.Fill(datable);
            dgvReservation.DataSource = datable;
            con.Close();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            try
            {
                AvailbleRoom();
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"{exception}");
            }
        }
        private void ViableRoom(int number, string roomid)
        {
            if (number != 1)
            {
                MessageBox.Show(@"Can't use This Method");
                return;
            }
            var qu = $@"SELECT * FROM[dbo].[Room] where Viable = '0' and RoomNumber = {roomid};";
            var cont = SqlCon();
            cont.Open();
            var cmd = new SqlCommand(qu, cont);
            cmd.ExecuteNonQuery();
            cont.Close();
            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("room not avablie");
                checter = 0;
                return;
            }
            var q = $@"UPDATE [dbo].[Room] SET [Viable] = '1' WHERE RoomNumber = '{roomid}'";
            var con = SqlCon();
            con.Open();
            var cms = new SqlCommand(q, con);
            cms.ExecuteNonQuery();
            con.Close();
            checter = 1;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var con = SqlCon();
                con.Open();
                var query = $@"select * from repo where GeastID like %'{this.txtSearch.Text}'%";
                var cmd = new SqlCommand(query, con);
                var db = new SqlDataAdapter(cmd);
                var datable = new DataTable();
                db.Fill(datable);
                this.dgvReservation.DataSource = datable;
                con.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"{exception}");
            }
        }

        private void btnPrintBooks_Click(object sender, EventArgs e)
        {
            Printer.PrintType = 4;
            frmPrint frm = new frmPrint();
            frm.Show();
        }

        private void btnPrintAvilableRooms_Click(object sender, EventArgs e)
        {
            frmPrint frm = new frmPrint();
            frm.Show();
        }
    }
}
