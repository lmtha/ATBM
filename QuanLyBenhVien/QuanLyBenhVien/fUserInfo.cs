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
    public partial class fUserInfo : Form
    {
        public fUserInfo()
        {
            InitializeComponent();
        }
        static string host = "10.211.55.4";
        static int port = 1521;
        static string sid = "orcl3";
        static string user = "QLBV";
        static string password = "1";
        string connect = OracleDataProvider.stringConnection(host, port, sid, user, password);
        private void btnDsUser_Click(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(connect);
           // string sql = "select * from PHIEUKHAM";
            string sql = "select * from dba_users where account_status = " + "\'OPEN\'" + "and default_tablespace = " + "\'USERS\'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dataGridViewInfoUser.DataSource = dt;

        }

        private void btnInfoPrivilleges_Click(object sender, EventArgs e)
        {
            //select * from user_tab_privs where GRANTEE like '%BV_%';
            OracleDataProvider.Connect(connect);
            // string sql = "select * from PHIEUKHAM";
            string sql = "select * from user_tab_privs where GRANTEE like \'%BV_%\'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dataGridViewInfoUser.DataSource = dt;
        }
    }
}
