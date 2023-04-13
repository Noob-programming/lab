using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            const string Cons =@"Data Source = ASMAALAP; Initial Catalog=Hotel; Integrated Security=True; User ID=name; Password=123456";
            var con = new SqlConnection(Cons);
            return con;
        }

        private int Rowduble()
        {
            var con = Sqlcon();
            con.Open();
            var q = $@"select * from Room where RoomNumber = '{this.txtRoomNumber.Text}'";
            var cmd = new SqlCommand(q, con);
            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt.Rows.Count;
        }

        private bool CheckAdd()
        {
            var a = this.cbxStatus.Checked ? "1" : "0";
            var list = new List<string>()
                           {
                               this.txtRoomNumber.Text,this.txtAvilableBed.Text,
                               this.txtPrice.Text,this.txtType.Text,a
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
                if (!this.CheckAdd()) { MessageBox.Show("fall the data"); return; }
                if (this.Rowduble() != 0) { MessageBox.Show("double number of room"); return; }
                var con = Sqlcon();
                con.Open();
                var s = this.cbxStatus.Checked ? "1" : "0";
                var q = $@"INSERT INTO [dbo].[Room] ([RoomNumber],[RoomType],[SizeRoom],[Price],[Viable]) 
                            VALUES('{this.txtRoomNumber.Text}','{this.txtType.Text}','{this.txtAvilableBed.Text}
                            ','{this.txtPrice.Text}','{s}')";
                var cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تمت الإضافة بنجاح", "تمت العملية بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ShowGrid();
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
            this.dgvRoom.DataSource = datable;
            con.Close();
        }

        private void UserControlRoom_Load(object sender, EventArgs e)
        {
            this.ShowGrid();
        }
        private string roomid = null;

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.roomid = this.dgvRoom.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txtMDRoomNumber.Text = this.dgvRoom.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.txtMDType.Text = this.dgvRoom.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.txtMDAvilableBed.Text = this.dgvRoom.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.txtMDPrice.Text = this.dgvRoom.Rows[e.RowIndex].Cells[4].Value.ToString();
            var c = this.dgvRoom.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.cbxMDStatus.Checked = c == "1";
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.CheckEdit()) { MessageBox.Show("fall the data"); return; }
                var con = Sqlcon();
                con.Open();
                var s = this.cbxMDStatus.Checked ? '1' : '0';
                var quarry =
                    $@"UPDATE [dbo].[Room] SET [RoomNumber] = '{this.txtMDRoomNumber.Text}',[RoomType] = '{this.txtMDType.Text}',
                        [SizeRoom] = '{this.txtMDAvilableBed.Text}', [Price] = '{this.txtMDPrice.Text}',
                            [Viable] = '{s}' WHERE [RoomId] = '{this.roomid}'; ";
                var cmd = new SqlCommand(quarry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                this.ShowGrid();

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
                    var quarry = $@"DELETE FROM [dbo].[Room] WHERE RoomId ='{this.roomid}';";
                    var cmd = new SqlCommand(quarry, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.ShowGrid();

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
                var s = $"select *from Room where [RoomNumber] like '%{this.txtSearch.Text}%'";
                var cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
                var db = new SqlDataAdapter(cmd);
                var datable = new DataTable();
                db.Fill(datable);
                this.dgvRoom.DataSource = datable;
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
