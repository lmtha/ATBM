using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        public static OracleConnection ocn;
        public static string username, password;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            username = txbUsername.Text;
            password = txbPassword.Text;
            string connect = OracleDataProvider.stringConnection("10.211.55.4", 1521, "orcl3", username, password);
            try
            {
                OracleDataProvider.Connect(connect);
                if (username.Equals("QLBV"))
                {
                    var frm = new fAdmin();
                    frm.ShowDialog();
                }
            }
            catch 
            {

                MessageBox.Show("Dang nhap that bai");
            }
            if (txbUsername.Text == "admin" && txbPassword.Text == "admin")
            {
                fAdmin f = new fAdmin();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc password !", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
