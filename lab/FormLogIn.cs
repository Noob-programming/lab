using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
			insta();
		}

		void insta()
		{
			ReadFile newf = ReadFile.InsFile();
		}

		private static frmLogin ins = null;
		public static frmLogin Instance()
		{
			return ins ?? (ins = new frmLogin());
		}

		private void tbxSeen_CheckedChanged(object sender, EventArgs e)
		{
			if (tbxSeen.Checked == true)
			{
				txtUserPassword.PasswordChar = (char)0;
			}
			else
			{
				txtUserPassword.PasswordChar = '*';
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (txtUserName.Text != string.Empty && txtUserPassword.Text != string.Empty)
			{
				try
				{
					string server_Name = @"ASMAALAP";
					string Database_Name = "Hotel";
					string cons = @"Data Source=" + server_Name + ";Initial Catalog=" + Database_Name
								  + ";Integrated Security=True";
					SqlConnection con = new SqlConnection(cons);
					con.Open();
					string Query =
						$"select *from Admin where username='{txtUserName.Text}' and password ='{txtUserPassword.Text}'";
					SqlCommand cmd = new SqlCommand(Query, con);
					SqlDataAdapter db = new SqlDataAdapter(cmd);
					DataTable datatable = new DataTable();
					db.Fill(datatable);
					if (datatable.Rows.Count > 0)
					{
						con.Close();
						frmMain f = new frmMain();
						f.Username = txtUserName.Text;
						f.Show();
						Hide();
					}
					else
					{
						MessageBox.Show(
							"خطأ في تسجيل الدخول الرجاء إدخال إسم المستخدم او كلمة المرور بصورة صحيحة",
							"خطأ في تسجيل الدخول",
							MessageBoxButtons.OK,
							MessageBoxIcon.Error);
						con.Close();
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show(text: $"{exception}");
					//MessageBox.Show("خطأ في الإتصال مع السيرفر يرجى الإتصال بالدعم الفني لحل هذه المشكلة", "خطأ في الإتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("يرجى ادخال معلومات", "خطأ ادخل البيانات المطلوبة", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("هل انت متأكد من الخروج من التطبيق؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				Application.Exit();
		}

		private void txtUserName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				txtUserPassword.Focus();
		}

		private void gunClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
