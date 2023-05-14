using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
namespace lab.User_Control
{
	public partial class UserControlCustomers : UserControl
	{
		public UserControlCustomers()
		{
			InitializeComponent();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void btnClear2_Click(object sender, EventArgs e)
		{
			Clear1();
		}
		private int t = 0;

		bool checkedit()
		{
			var s = new List<string>
						{
							crbMDMale.Text, crbMDFemale.Text, txtMDPhone.Text,
							txtMDCustomerName.Text,txtMDCardNumber.Text,txtMDAddress.Text
						};

			return s.All(x => x != string.Empty);
		}

		private void btnModify_Click(object sender, EventArgs e)
		{
			if (checkedit() != true) MessageBox.Show("FALL ALL DATA BEFORE");
			else
				try
				{
					var con = Sqlcon();
					con.Open();
					var gender = crbMDMale.Checked ? 'M' : 'F';
					var a = txtMDCustomerName.Text.Split(' ');
					var s = a.ToList();
					if (s.Count < 3)
					{
						MessageBox.Show("FALL THE NAME CASE");
						return;
					}

					if (!checkidfind(txtMDCardNumber.Text)) return;
					var b = txtMDBurthDate.Value.ToString().Split(' ')[0];
					var quary = $@"UPDATE [dbo].[Guest]
                            SET [FirstName] ='{s[0]}' ,[SureName]='{s[1]}' ,[LastName]='{s[2]}' ,[Date_of_Birth]='{b}' ,[Gender] = '{gender}',
                            [Pnumber] ='{txtMDPhone.Text}' ,[City] = '{txtMDAddress.Text}',[Id_identity] ='{txtMDCardNumber.Text}' 
                                WHERE  [Guest_id] = '{t}'";
					var sqlcommand = new SqlCommand(quary, con);
					sqlcommand.ExecuteNonQuery();
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
			if (MessageBox.Show("هل انت متأكد من حذف النزيل؟", "حذف الحساب ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				try
				{
					var con = Sqlcon();
					con.Open();
					var q = $@"DELETE FROM [dbo].[Guest] WHERE Guest_id ='{t}';";
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
			var Query = "select * from Guest";
			var cmd = new SqlCommand(Query, con);
			var db = new SqlDataAdapter(cmd);
			var datatable = new DataTable();
			db.Fill(datatable);
			dgvCustomer.DataSource = datatable;
			con.Close();
		}

		private void UserControlCustomers_Load(object sender, EventArgs e)
		{
			showgrid();
		}

		private bool checksave()
		{
			var s = new List<string>
						{
							crbMale.Text, crbFemale.Text, txtPhone.Text, txtCustomerName.Text,
							txtCardNumber.Text,txtAddress.Text
						};

			return s.All(x => x != string.Empty);
		}

		bool chekage18()
		{
			var selectedDate = dtpBurthDate.Value;
			var currentDate = DateTime.Now;

			var age = currentDate.Year - selectedDate.Year;

			if (currentDate.Month < selectedDate.Month || (currentDate.Month == selectedDate.Month && currentDate.Day < selectedDate.Day))
			{
				age--;
			}

			return age >= 18;
		}
		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			if (!checksave()) MessageBox.Show("Fall all data to save");
			else
			{
				try
				{
					var con = Sqlcon();
					con.Open();
					var c = txtCustomerName.Text.Split(' ');
					var s = c.ToList();
					if (s.Count < 2)
						s.Add(" ");
					if (s.Count < 3)
						s.Add(" ");
					//check phone number is legal
					if (!checkphone())
					{
						MessageBox.Show(@"the phone number is unlegal");
						return;
					}
					//double id card
					if (!checkidfind(txtCardNumber.Text))
					{
						MessageBox.Show(@"id card is double");
						return;
					}
					//check age of customer
					if (!chekage18())
					{
						MessageBox.Show(@"Age less than 18");
						return;
					}


					var Age = dtpBurthDate.Value.ToString().Split(' ')[0];
					var gender = crbMale.Checked ? 'M' : 'F';

					//var states = sing.Checked ? 'S' : 'M';

					var qu = $@"INSERT INTO [dbo].[Guest]([FirstName],[SureName],[LastName],[Date_of_Birth],[Gender],[Pnumber],[City],[Id_identity])
                    VALUES('{s[0]}','{s[1]}','{s[2]}','{Age}','{gender}','{txtPhone.Text}','{txtAddress.Text}','{txtCardNumber.Text}')";
					var Sqlcommand = new SqlCommand(qu, con);
					Sqlcommand.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("تمت الإضافة بنجاح", "تمت العملية بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
					showgrid();
				}
				catch (Exception exception)
				{
					MessageBox.Show($"{exception}");
				}
			}
		}

		private bool checkphone()
		{
			int result;

			try
			{
				var input = txtPhone.Text;
				return int.TryParse(input, out result);

			}
			catch (Exception e)
			{
				MessageBox.Show($@"{e}");
				return false;
			}
		}

		private bool checkidfind(string id)
		{
			try
			{
				var con = Sqlcon();
				con.Open();
				var quandary = $@"select *from Guest where [Id_identity] = {id}";
				var cmd = new SqlCommand(quandary, con);
				var reader = cmd.ExecuteReader();
				con.Close();
				return !reader.HasRows;
			}
			catch (Exception e)
			{
				MessageBox.Show($@"{e}");
				return false;
			}
		}

		private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			t = (int)dgvCustomer.Rows[e.RowIndex].Cells[0].Value;
			txtMDCustomerName.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value + " "
										  + (string)dgvCustomer.Rows[e.RowIndex].Cells[2].Value + " "
										  + (string)dgvCustomer.Rows[e.RowIndex].Cells[3].Value;
			txtMDBurthDate.Value = (DateTime)dgvCustomer.Rows[e.RowIndex].Cells[4].Value;
			var s = dgvCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();
			if (s.ToUpper() == "F")
				crbMDFemale.Checked = true;
			else
				crbMDMale.Checked = true;
			txtMDPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[6].Value.ToString();
			txtMDAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells[7].Value.ToString();
			txtMDCardNumber.Text = dgvCustomer.Rows[e.RowIndex].Cells[8].Value.ToString();
		}
		private void Clear()
		{
			txtCustomerName.Clear();
			txtPhone.Clear();
			txtAddress.Clear();
			txtCardNumber.Clear();
			crbFemale.Checked = false;
			crbMale.Checked = false;
		}
		private void Clear1()
		{
			txtMDCustomerName.Clear();
			txtMDPhone.Clear();
			txtMDAddress.Clear();
			crbMDMale.Checked = false;
			crbMDFemale.Checked = false;
			txtSearch.Clear();
			txtMDCardNumber.Clear();
		}

		private void tabPageAddCustomer_Leave(object sender, EventArgs e)
		{
			Clear();
		}

		private void tabPageModifyCustomer_Leave(object sender, EventArgs e)
		{
			Clear1();
		}

		private static SqlConnection Sqlcon()
		{
			var con = new SqlConnection(Properties.Settings.Default.con);
			return con;
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				var con = Sqlcon();
				con.Open();
				var s = $"select *from Guest where [Id_identity] like '%{txtSearch.Text}%'";
				var cmd = new SqlCommand(s, con);
				cmd.ExecuteNonQuery();
				var db = new SqlDataAdapter(cmd);
				var datable = new DataTable();
				db.Fill(datable);
				dgvCustomer.DataSource = datable;
				con.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show($"{exception}");
			}
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			Printer.PrintType = 3;
			frmPrint frm = new frmPrint();
			frm.Show();
		}
	}
}
