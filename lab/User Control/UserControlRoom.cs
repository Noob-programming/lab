using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace lab.User_Control
{
    public partial class UserControlRoom : UserControl
    {
        public UserControlRoom()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtRoomNumber.Clear();
            txtAvilableBed.Clear();
            txtPrice.Clear();
            cbxStatus.Checked = false;
            txtType.Clear();
        }

        public void Clear1()
        {
            txtMDRoomNumber.Clear();
            txtMDAvilableBed.Clear();
            txtMDPrice.Clear();
            cbxMDStatus.Checked = false;
            txtSearch.Clear();
            txtMDType.Clear();
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            Clear1();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageModifyRoom_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private static SqlConnection Sqlcon()
        {
            var con = new SqlConnection(Properties.Settings.Default.con);
            return con;
        }
        private int Rowduble()
        {
            var con = Sqlcon();
            con.Open();
            var q = $@"select * from Room where RoomNumber = '{txtRoomNumber.Text}'";
            var cmd = new SqlCommand(q, con);
            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt.Rows.Count;
        }

        private bool CheckAdd()
        {
            var a = cbxStatus.Checked ? "1" : "0";
            var list = new List<string>()
                           {
                               txtRoomNumber.Text,txtAvilableBed.Text,
                               txtPrice.Text,txtType.Text,a
                           };

            return list.All(x => x != string.Empty);
        }

        private bool CheckEdit()
        {

            List<string> v = new List<string>() { txtMDRoomNumber.Text,txtMDAvilableBed.Text,
                                                  txtMDType.Text,txtMDPrice.Text,cbxMDStatus.Checked.ToString(),
                                                };
            return v.All(x => x != String.Empty);
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckAdd()) { MessageBox.Show("fall the data"); return; }
                if (Rowduble() != 0) { MessageBox.Show("double number of room"); return; }
                var con = Sqlcon();
                con.Open();
                var s = cbxStatus.Checked ? "1" : "0";
                var q = $@"INSERT INTO [dbo].[Room] ([RoomNumber],[RoomType],[SizeRoom],[Price],[Viable]) 
                            VALUES('{txtRoomNumber.Text}','{txtType.Text}','{txtAvilableBed.Text}
                            ','{txtPrice.Text}','{s}')";
                var cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تمت الإضافة بنجاح", "تمت العملية بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception}");
            }
        }

        private void ShowGrid()
        {
            var con = Sqlcon();
            con.Open();
            var query = "select * from Room";
            var cmd = new SqlCommand(query, con);
            var db = new SqlDataAdapter(cmd);
            var datable = new DataTable();
            db.Fill(datable);
            dgvRoom.DataSource = datable;
            con.Close();
        }

        private void UserControlRoom_Load(object sender, EventArgs e)
        {
            ShowGrid();
        }
        private string roomid = null;

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            roomid = dgvRoom.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMDRoomNumber.Text = dgvRoom.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMDType.Text = dgvRoom.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMDAvilableBed.Text = dgvRoom.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtMDPrice.Text = dgvRoom.Rows[e.RowIndex].Cells[4].Value.ToString();
            var c = dgvRoom.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbxMDStatus.Checked = c == "1";
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckEdit()) { MessageBox.Show("fall the data"); return; }
                var con = Sqlcon();
                con.Open();
                var s = cbxMDStatus.Checked ? '1' : '0';
                var quarry =
                    $@"UPDATE [dbo].[Room] SET [RoomNumber] = '{txtMDRoomNumber.Text}',[RoomType] = '{txtMDType.Text}',
                        [SizeRoom] = '{txtMDAvilableBed.Text}', [Price] = '{txtMDPrice.Text}',
                            [Viable] = '{s}' WHERE [RoomId] = '{roomid}'; ";
                var cmd = new SqlCommand(quarry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                ShowGrid();

            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من حذف الغرفة؟", "حذف غرفة ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    var con = Sqlcon();
                    con.Open();
                    var quarry = $@"DELETE FROM [dbo].[Room] WHERE RoomId ='{roomid}';";
                    var cmd = new SqlCommand(quarry, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ShowGrid();

                }
                catch (Exception exception)
                {
                    MessageBox.Show($"{exception}");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var con = Sqlcon();
                con.Open();
                var s = $"select *from Room where [RoomNumber] like '%{txtSearch.Text}%'";
                var cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
                var db = new SqlDataAdapter(cmd);
                var datable = new DataTable();
                db.Fill(datable);
                dgvRoom.DataSource = datable;
                con.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception}");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Printer.PrintType = 1;
            frmPrint frm = new frmPrint();
            frm.Show();
        }
    }
}
