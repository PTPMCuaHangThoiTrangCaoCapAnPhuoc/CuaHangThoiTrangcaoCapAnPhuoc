using BLL;
using CuaHangAnPhuoc.frmNhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangAnPhuoc
{
    public partial class frmDangNhap : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            BLLuser blluser = new BLLuser(connectionString);
            if(blluser.dangnhap(username, password))
            {
                this.Hide();
                if (username.Equals("nhanvien"))
                {
                    frmNVMain frm = new frmNVMain();
                    frm.Show();
                } else if (username.Equals("admin"))
                {
                    MessageBox.Show("Show frm admin");
                }
                
            } else
            {
                MessageBox.Show("Tài khoản không tôn tại");
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
