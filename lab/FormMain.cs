using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using lab.User_Control;

namespace lab
{
    public partial class frmMain : Form
    {
        public string Username;
        public frmMain()
        {
            InitializeComponent();
        }

        private static frmMain InFrmMain = null;

        public static frmMain Instance()
        {
            return InFrmMain ?? new frmMain();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            MovePanel(btnRooms);
            userControlMain1.Hide();
            userControlCustomers1.Hide();
            userControlRoom1.Show();
            userControlReservation1.Hide();
            userControlAdmin1.Hide();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            MovePanel(btnReservation);
            userControlCustomers1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Show();
            userControlAdmin1.Hide();
            userControlMain1.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            MovePanel(btnCustomers);
            userControlCustomers1.Show();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlAdmin1.Hide();
            userControlMain1.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            MovePanel(btnAdmin);
            userControlCustomers1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlAdmin1.Show();
            userControlMain1.Hide();
        }

        private void labLgout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من تسجيل الخروج؟", "تسجيل الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmLogin f = new frmLogin();
                f.Show();
                this.Close();
            }
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labUserName.Text=Username;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MovePanel(btnMain);
            userControlCustomers1.Hide();
            userControlAdmin1.Hide();
            userControlMain1.Show();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
        }

        private void gunClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}