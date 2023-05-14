using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace lab.User_Control
{
    using System.Data.SqlClient;
    using System.Linq;

    public partial class UserControlEmployee : UserControl
    {
        public UserControlEmployee()
        {
            InitializeComponent();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtEmployeeID.Clear();
            txtEmployeeName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            crbFemale.Checked = false;
            crbMale.Checked = false;
            txtSalary.Clear();
            txtJob.Clear();
        }

        private void btnMDClear_Click(object sender, EventArgs e)
        {
            Clear1();
        }
        private void Clear1()
        {
            txtMDEmployeeID.Clear();
            txtMDEmployeeNmae.Clear();
            txtMDPhone.Clear();
            txtMDAddress.Clear();
            crbMDFemale.Checked = false;
            crbMale.Checked = false;
            crbMDMale.Checked = false;
            txtMDSalary.Clear();
            txtMDJub.Clear();
            txtSearch.Clear();
        }

        bool checkmode()
        {
            List<string> v = new List<string>() { txtMDEmployeeID.Text,txtMDEmployeeNmae.Text,
                                                  txtMDPhone.Text,txtMDAddress.Text,
                                                  crbMDFemale.Checked.ToString(),crbMDMale.Checked.ToString(),
                                                  txtMDSalary.Text,txtMDJub.Text,Convert.ToString(t)
                                                };
            return v.All(x => x != String.Empty);
        }

        bool checeAdd()
        {
            var v = new List<string>()
                        {
                            txtEmployeeID.Text,txtEmployeeName.Text,txtPhone.Text,
                            txtAddress.Text,crbFemale.Checked.ToString(),crbMale.Checked.ToString(),
                            txtSalary.Text,txtJob.Text
                        };
            return v.All(x => x != string.Empty);
        }

        private static SqlConnection Sqlcon()
        {
            var con = new SqlConnection(Properties.Settings.Default.con);
            return con;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (checeAdd())
                try
                {
                    var con = Sqlcon();
                    con.Open();
                    var name = new List<string>();
                    for (var index = 0; index < txtEmployeeName.Text.Split(' ').Length; index++)
                    {
                        var s = txtEmployeeName.Text.Split(' ')[index];
                        name.Add(s);
                    }
                    if (name.Count < 2)
                        name.Add(" ");
                    if (name.Count < 3)
                        name.Add(" ");
                    var gender = crbMale.Checked ? 'M' : 'F';
                    var age = dtpBurthDate.Value.ToString().Split(' ')[0];
                    var q = $@"INSERT INTO [dbo].[Office] ([Fname],[Surename],[Lastname],[SSN],[Salary],[Job]
                           ,[Address],[Age],[PNumber],[Gender]) VALUES('{name[0]}', '{name[1]}', '{name[2]}', '{txtEmployeeID.Text}
                           ', '{txtSalary.Text}', '{txtJob.Text}', '{txtAddress.Text}', '{age}','{txtPhone.Text}', '{gender}');";
                    var cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تمت الإضافة بنجاح", "تمت العملية بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showgrid();
                }

                catch (Exception exception)
                {
                    MessageBox.Show($"{exception}");
                }
            else
                MessageBox.Show("fall data for adding");
        }
        int t = 0;

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!checkmode())
            {
                MessageBox.Show("fall data to modified");
                return;
            }
            try
            {
                var con = Sqlcon();
                con.Open();
                var name = new List<string>();
                for (var index = 0; index < txtMDEmployeeNmae.Text.Split(' ').Length; index++)
                {
                    var s = txtMDEmployeeNmae.Text.Split(' ')[index];
                    name.Add(s);
                }
                if (name.Count < 2)
                    name.Add(" ");
                if (name.Count < 3)
                    name.Add(" ");
                var gender = crbMDMale.Checked ? 'M' : 'F';
                var age = txtMDBirthDate.Value.ToString().Split(' ')[0];
                var q = $@"UPDATE [dbo].[Office]SET [Fname] = '{name[0]}'
                ,[Surename] = '{name[1]}',[Lastname] = '{name[2]}'
            ,[SSN] = '{txtMDEmployeeID.Text}' ,[Salary] = '{txtMDSalary.Text}'
            ,[Job] = '{txtMDJub.Text}',[Address] = '{txtMDAddress.Text}',[Age] = '{age}'
            ,[PNumber] ='{txtMDPhone.Text}' ,[Gender] = '{gender}'WHERE[Enumber] ='{t}';";
                var cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                con.Close();
                showgrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من حذف الموظف؟", "حذف الحساب ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    var con = Sqlcon();
                    con.Open();
                    var q = $@"DELETE FROM [dbo].[Office] WHERE Enumber = '{t}'";
                    var cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showgrid();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"{exception}");
                }
            }
        }

        void showgrid()
        {
            var con = Sqlcon();
            con.Open();
            var Query = "select * from Office";
            var cmd = new SqlCommand(Query, con);
            var db = new SqlDataAdapter(cmd);
            var datatable = new DataTable();
            db.Fill(datatable);
            dgvEmployee.DataSource = datatable;
            con.Close();
        }

        private void UserControlAdmin_Load(object sender, EventArgs e)
        {
            showgrid();
        }

        private void tabPageAddEmployee_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageModifyEmployee_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t = (int)dgvEmployee.Rows[e.RowIndex].Cells[0].Value;

            txtMDEmployeeNmae.Text = dgvEmployee.Rows[e.RowIndex].Cells[1].Value + " " +
                                     dgvEmployee.Rows[e.RowIndex].Cells[2].Value + " " +
                                     dgvEmployee.Rows[e.RowIndex].Cells[3].Value;

            txtMDEmployeeID.Text = dgvEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();

            txtMDSalary.Text = dgvEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();

            txtMDJub.Text = dgvEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();

            txtMDAddress.Text = dgvEmployee.Rows[e.RowIndex].Cells[7].Value.ToString();

            txtMDBirthDate.Value = (DateTime)dgvEmployee.Rows[e.RowIndex].Cells[8].Value;

            txtMDPhone.Text = (string)dgvEmployee.Rows[e.RowIndex].Cells[9].Value;

            var x = dgvEmployee.Rows[e.RowIndex].Cells[10].Value.ToString();

            if (x.ToUpper() == "F") crbMDFemale.Checked = true;

            else crbMDMale.Checked = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var con = Sqlcon();
                con.Open();
                var s = $"select *from Office where [SSN] like '%{txtSearch.Text}%'";
                var cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
                var db = new SqlDataAdapter(cmd);
                var datable = new DataTable();
                db.Fill(datable);
                dgvEmployee.DataSource = datable;
                con.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception}");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Printer.PrintType = 2;
            frmPrint frm = new frmPrint();
            frm.Show();
        }
    }
}
