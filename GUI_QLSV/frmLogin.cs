using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS_QLSV;
using DTO_QLSV;

namespace GUI_QLSV
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        // thao tác xử lý đăng nhập 
        DTO_tb_User xl_user = new DTO_tb_User();
        BUS_tb_User bus_xl_user = new BUS_tb_User();
        public delegate void EnableGroupbox(bool kq);
        public EnableGroupbox setGroupbox;
        public string PQ;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            xl_user.USER = txtUser.Text;
            xl_user.PASS = txtPass.Text;
            if (bus_xl_user.Login() == "Admin")
            {
                PQ = "Admin";
                this.Close();
                setGroupbox(true);
                MessageBox.Show("Đăng nhập thành công");

            }
            else if (bus_xl_user.Login() == "User")
            {
                PQ = "User";
                this.Close();
                setGroupbox(true);
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                PQ = "";
                MessageBox.Show("Đăng nhập thất bại");
                return;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            txtPass.Text = "";
            txtUser.Text = "";
            txtUser.Focus();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }
    }
}
