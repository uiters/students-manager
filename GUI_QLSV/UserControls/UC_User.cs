using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLSV;
using BUS_QLSV;


namespace GUI_QLSV.UserControls
{
    public partial class UC_User : UserControl
    {
        DTO_tb_User DTO_tb_user = new DTO_tb_User();
        BUS_tb_User BUS_user = new BUS_tb_User();
        public UC_User()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_tb_user.USER = txtUserName.Text;
            DTO_tb_user.PASS = txtPass.Text;
            DTO_tb_user.ID = Convert.ToBoolean(chk_Usertype.CheckState);
            BUS_user.CreateUser(DTO_tb_user.USER,DTO_tb_user.PASS,DTO_tb_user.ID);            
            dgvUser.DataSource = BUS_user.LoadDL();
            DTO_tb_user.TXT = txtTenTimKiem;
            BUS_user.TextBoxAutoComplete(DTO_tb_user.TXT, DTO_tb_user.Table, DTO_tb_user.Column);


            txtUserName.Text = null;
            txtPass.Text = null;
            chk_Usertype.Checked = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_tb_user.USER = txtUserName.Text;
            DTO_tb_user.NEWPASS = txtNewPass.Text;
            DTO_tb_user.PASS = txtPass.Text;
            DTO_tb_user.ID = Convert.ToBoolean(chk_Usertype.CheckState);          
            BUS_user.UpdateUser(DTO_tb_user.USER, DTO_tb_user.PASS, DTO_tb_user.NEWPASS, DTO_tb_user.ID);
            dgvUser.DataSource = BUS_user.LoadDL();

            txtUserName.Text = null;
            txtPass.Text = null;
            chk_Usertype.Checked = false;
            txtNewPass.Text = null;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_tb_user.USER = txtUserName.Text;
            BUS_user.DeleteUser(DTO_tb_user.USER);
            dgvUser.DataSource = BUS_user.LoadDL();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTenTimKiem.Text != "")
            {
                DTO_tb_user.USER = txtTenTimKiem.Text;
                DTO_tb_user.TXT = txtTenTimKiem;
                BUS_user.TextBoxAutoComplete(DTO_tb_user.TXT, DTO_tb_user.Table, DTO_tb_user.Column);
                dgvUser.DataSource = BUS_user.TimKiem(DTO_tb_user.USER);
                int n = BUS_user.TimKiem(DTO_tb_user.USER).Rows.Count;

                MessageBox.Show("Tìm thấy " + n + " kết quả");

            }
            else
            {
                MessageBox.Show("Không có đủ dữ kiện tìm kiếm. Vui lòng thử lại!");
                txtTenTimKiem.Focus();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvUser.DataSource = BUS_user.LoadDL();
            
        }

        private void UC_User_Load(object sender, EventArgs e)
        {
            if (rdTaoUser.Checked)
            {
                lblTacvu.Text = "Thêm mới người dùng";
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
                lblMatkhaumoi.Visible = false;
                txtNewPass.Visible = false;
                txtTenTimKiem.Text = "";
            }
            dgvUser.DataSource = BUS_user.LoadDL();
            DTO_tb_user.TXT = txtTenTimKiem;
            BUS_user.TextBoxAutoComplete(DTO_tb_user.TXT, DTO_tb_user.Table, DTO_tb_user.Column);
        }

        #region radio button

        private void rdDoiMatkhau_CheckedChanged(object sender, EventArgs e)
        {
            lblTacvu.Text = "Đổi mật khẩu";
            btnSua.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            lblMatkhaumoi.Visible = true;
            txtNewPass.Visible = true;
            lblPassword.Text = "Nhập mật khẩu cũ:";
            lblPassword.Visible = true;
            txtPass.Visible = true;
            txtPass.Text = "";
        }

        private void rdTaoUser_CheckedChanged(object sender, EventArgs e)
        {
            lblTacvu.Text = "Thêm mới người dùng";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lblMatkhaumoi.Visible = false;
            txtNewPass.Visible = false;
            btnThem.Enabled = true;
            lblPassword.Visible = true;
            txtPass.Visible = true;
            lblPassword.Text = "Password:";
        }

        private void rdXoa_CheckedChanged(object sender, EventArgs e)
        {
            lblTacvu.Text = "Xóa tài khoản";
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            lblMatkhaumoi.Visible = false;
            txtNewPass.Visible = false;
            lblPassword.Visible = false;
            txtPass.Visible = false;

        }

        #endregion

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();           
        }
    }
}
