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
    public partial class fUserAlter : Form
    {
        public fUserAlter()
        {
            InitializeComponent();
        }
        static string host = "10.211.55.4";
        static int port = 1521;
        static string sid = "orcl3";
        static string user = "QLBV";
        static string password = "1";
        string connect = OracleDataProvider.stringConnection(host, port, sid, user, password);
        private void fUserAlter_Load(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(connect);
            // string sql = "select * from PHIEUKHAM";
            string sql = "select USERNAME from dba_users where account_status = " + "\'OPEN\'" + "and default_tablespace = " + "\'USERS\'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            cbxUserAlter.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxUserAlter.Items.Add(dt.Rows[i][0].ToString());
            }
            OracleDataProvider.conn.Open();
            sql = "select * from user_role_privs where GRANTED_ROLE like \'%BV_%\'";
            dt = OracleDataProvider.GetDataTable(sql);
            cbxUserAlterRoleMoi.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxUserAlterRoleMoi.Items.Add(dt.Rows[i][1].ToString());
            }
        }

        private void cbxUserAlter_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(connect);
            //select * from dba_role_privs where GRANTED_ROLE like '%BV_%' and GRANTEE =
            cbxUserAlter.Text = cbxUserAlter.SelectedItem.ToString();
            string sql = "select * from dba_role_privs where GRANTED_ROLE like '%BV_%' and GRANTEE ='" + cbxUserAlter.SelectedItem.ToString()+"'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            cbxUserAlterRoleCu.Text = "";
            if (dt.Rows.Count > 0 )
            {
                cbxUserAlterRoleCu.Text = (dt.Rows[0][1].ToString());
            
            }
        }

        private void btnUserAlterOK_Click(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(connect);
            string sql = null;
                if (cbxUserAlterRoleCu.Text != "")
	            {
		                  sql = "revoke " + cbxUserAlterRoleCu.Text + " from " + cbxUserAlter.SelectedItem.ToString();
           // sql += "; grant " + cbxUserAlterRoleMoi.SelectedItem.ToString() + " to " + cbxUserAlter.SelectedItem.ToString()+";";
            OracleCommand cmd = new OracleCommand(sql, OracleDataProvider.conn);
            int ret = cmd.ExecuteNonQuery();
	            }
            cbxUserAlterRoleCu.Text = "";
            //OracleDataProvider.conn.Open();
            sql = "grant " + cbxUserAlterRoleMoi.SelectedItem.ToString() + " to " + cbxUserAlter.SelectedItem.ToString();
            OracleCommand cmd1 = new OracleCommand(sql, OracleDataProvider.conn);
            int ret1 = cmd1.ExecuteNonQuery();
            OracleDataProvider.DisConnect();
        }
    }
}
