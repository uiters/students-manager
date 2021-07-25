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
        DTO_tb_User DTO_User = new DTO_tb_User();
        BUS_tb_User BUS_User = new BUS_tb_User();

        frmMain frmmain = new frmMain();
        public delegate void EnableGroupbox(bool kq);
        public EnableGroupbox setGroupbox; // hiển thị groupboxleft
        public string PQ;//phân quyền

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DTO_User.USER = txtUser.Text;
            DTO_User.PASS = txtPass.Text;
            if (BUS_User.Login(DTO_User.USER, DTO_User.PASS, DTO_User.ID) == "Admin")
            {
                PQ = "Admin";
                this.Close();
                setGroupbox(true);               
                MessageBox.Show("Đăng nhập thành công");

            }
            else if (BUS_User.Login(DTO_User.USER, DTO_User.PASS, DTO_User.ID) == "User")
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
            frmmain.pan_Main.BackgroundImage = Properties.Resources.school;

           
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
