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
    public partial class UC_GiaoVien_Khoa : UserControl
    {
        string flag = "";
        int index;
        BUS_GiaoVien Bus_GV = new BUS_GiaoVien();
        BUS_Khoa Bus_Khoa = new BUS_Khoa();
        DTO_GiaoVien DTO_GV = new DTO_GiaoVien();
        DTO_Khoa DTO_khoa = new DTO_Khoa();
        BUS_Xuly BUS_xuly = new BUS_Xuly();
        int col = 0;
        string table;

        public UC_GiaoVien_Khoa()
        {
            InitializeComponent();
        }
        #region hide and show 
        public void Enable_Giaovien()
        {
            
            txtTenGiaoVien.Enabled = true;
            cmbMaKhoa.Enabled = true;
            txtGhiChu.Enabled = true;
            btnLuuGV.Visible = true;

        }
        public void DisEnable_GiaoVien()
        {

            txtTenGiaoVien.Enabled = false;
            cmbMaKhoa.Enabled = false;
            txtGhiChu.Enabled = false;
            btnLuuGV.Visible = false;

        }
        public void Enable_khoa()
        {

            txtTenKhoa.Enabled = true;
            txtGhiChu_Khoa.Enabled = true;
            btnLuuKhoa.Visible = true;
        }
        public void DisEnable_khoa()
        {

            txtTenKhoa.Enabled = false;
            txtGhiChu_Khoa.Enabled = false;
            btnLuuKhoa.Visible = false;
        }
        #endregion

        #region UC_Load
        private void tabGV_Khoa_Click(object sender, EventArgs e)
        {
            DisEnable_GiaoVien();
            DisEnable_khoa();

            DTO_GV.cmbMAKHOA = cmbMaKhoa;
            Bus_GV.LoadDLVao_cmbMaKhoa(DTO_GV.cmbMAKHOA);
        }

        private void UC_GiaoVien_Khoa_Load(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = Bus_Khoa.LoadDLKhoa();
            dgvGiaoVien.DataSource = Bus_GV.LoadDLGiaoVien();
            DTO_GV.cmbMAKHOA = cmbMaKhoa;
            Bus_GV.LoadDLVao_cmbMaKhoa(DTO_GV.cmbMAKHOA);
            DTO_GV.TXT = txtThongTinTimKiem_GV;
            Bus_GV.GoiYTimKiem(DTO_GV.TXT,table, DTO_GV.COLUMN);
            //khoá thao tác txt
            DisEnable_GiaoVien();
            DisEnable_khoa();

        }
        #endregion

        #region giáo viên

        private void btnLuuGV_Click_1(object sender, EventArgs e)
        {
            if (flag == "thêm")
            {
               

                DTO_GV.GiaoVien_MaGiaoVien = txtMaGiaoVien.Text;
                DTO_GV.GiaoVien_TenGiaoVien = txtTenGiaoVien.Text;
                DTO_GV.GiaoVien_GhiChu = txtGhiChu.Text;
                if (cmbMaKhoa.Text.ToString() == "")
                {
                    MessageBox.Show("Bạn chưa chọn Khoa");
                    DisEnable_GiaoVien();
                    dgvGiaoVien.Enabled = true;
                    btnLamlai.Enabled = true;
                    btnXoa_GV.Enabled = true;
                    return;
                }
                else
                {
                    DTO_GV.GiaoVien_MaKhoa = cmbMaKhoa.SelectedValue.ToString();
                }
                Bus_GV.ThemGiaoVien(DTO_GV.GiaoVien_MaGiaoVien, DTO_GV.GiaoVien_TenGiaoVien, DTO_GV.GiaoVien_GhiChu, DTO_GV.GiaoVien_MaKhoa);
                dgvGiaoVien.DataSource = Bus_GV.LoadDLGiaoVien();
                BUS_xuly.ClearAllTextBox(groupboxGV);

                //DTO_GV.TXT = txtThongTinTimKiem_GV;
                //Bus_GV.GoiYGiaoVien(DTO_GV.TXT);


                int i;
                for (i = 0; i < dgvGiaoVien.RowCount - 1; i++)
                {
                    if (dgvGiaoVien.Rows[i].Cells[1].Value.ToString() == dgvGiaoVien.Text)
                        break;
                }
                dgvGiaoVien.CurrentCell = dgvGiaoVien[0, i];


                DisEnable_GiaoVien();
                dgvGiaoVien.Enabled = true;
                btnLamlai.Enabled = true;
                btnXoa_GV.Enabled = true;
            }
            else if (flag == "sửa")
            {

                DTO_GV.GiaoVien_MaGiaoVien = txtMaGiaoVien.Text;
                DTO_GV.GiaoVien_TenGiaoVien = txtTenGiaoVien.Text;
                DTO_GV.GiaoVien_GhiChu = txtGhiChu.Text;
                DTO_GV.GiaoVien_MaKhoa = cmbMaKhoa.SelectedValue.ToString();

                Bus_GV.CapNhatGiaoVien(DTO_GV.GiaoVien_MaGiaoVien, DTO_GV.GiaoVien_TenGiaoVien, DTO_GV.GiaoVien_GhiChu, DTO_GV.GiaoVien_MaKhoa);
                dgvGiaoVien.DataSource = Bus_GV.LoadDLGiaoVien();
                BUS_xuly.ClearAllTextBox(groupboxGV);

                //DTO_GV.TXT = txtThongTinTimKiem_GV;
                //Bus_GV.GoiYGiaoVien();

                dgvGiaoVien.CurrentCell = dgvGiaoVien[0, index];

                DisEnable_GiaoVien();
                dgvGiaoVien.Enabled = true;
                btnLamlai.Enabled = true;
                btnXoa_GV.Enabled = true;
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
           

            flag = "thêm";
            Enable_Giaovien();
            txtTenGiaoVien.Focus();
            BUS_xuly.ClearAllTextBox(groupboxGV);
            txtMaGiaoVien.Text = Bus_GV.TaoMaGV();

            btnLamlai.Enabled = false;
            btnXoa_GV.Enabled = false;
            dgvGiaoVien.Enabled = false;

        }

        private void btnLamlai_Click_1(object sender, EventArgs e)
        {
            flag = "sửa";
            Enable_Giaovien();
            txtTenGiaoVien.Focus();

            btnLamlai.Enabled = false;
            btnXoa_GV.Enabled = false;
            dgvGiaoVien.Enabled = false;
        }

        private void btnXoa_GV_Click_1(object sender, EventArgs e)
        {
            Bus_GV.XoaGiaoVien(DTO_GV.GiaoVien_MaGiaoVien=txtMaGiaoVien.Text);
            dgvGiaoVien.DataSource = Bus_GV.LoadDLGiaoVien();
            BUS_xuly.ClearAllTextBox(groupboxGV);

            DTO_GV.cmbMAKHOA = cmbMaKhoa;
            Bus_GV.LoadDLVao_cmbMaKhoa(DTO_GV.cmbMAKHOA);
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            if (cmbDieuKienTim.Text == "-- Chọn điều kiện --")
            {
                MessageBox.Show("Vui lòng chọn điều kiện tìm kiếm");
                return;
            }
            else
            {

                if (cmbDieuKienTim.Text == "Tên Giáo Viên")
                {
                    DTO_GV.TENTIMKIEM = txtThongTinTimKiem_GV.Text;
                   // DTO_GV.TXT = txtThongTinTimKiem_GV;
                    dgvGiaoVien.DataSource = Bus_GV.TimKiemGV("TenGiaoVien", DTO_GV.TENTIMKIEM);// where 'column_name' = 'value'
                }
                else
                {
                    DTO_GV.TENTIMKIEM = txtThongTinTimKiem_GV.Text;
                   // DTO_GV.TXT = txtThongTinTimKiem_GV;
                    dgvGiaoVien.DataSource = Bus_GV.TimKiemGV("MaGiaoVien", DTO_GV.TENTIMKIEM);// where 'column_name' = 'value'

                }
                int n = dgvGiaoVien.Rows.Count - 1;
                MessageBox.Show("Tìm thấy " + n + " kết quả! ");
            }
        }

        private void cmbDieuKienTim_TextChanged(object sender, EventArgs e)
        {
            DTO_GV.TXT = txtThongTinTimKiem_GV;

            if (cmbDieuKienTim.SelectedItem.ToString() == "Mã Giáo Viên")
            {                   
                col = 0;
                DTO_GV.COLUMN = col;
                Bus_GV.GoiYTimKiem(DTO_GV.TXT,table, DTO_GV.COLUMN);
            }
            if (cmbDieuKienTim.SelectedItem.ToString() == "Tên Giáo Viên")
            {                
                col = 1;
                DTO_GV.COLUMN = col; 
                Bus_GV.GoiYTimKiem(DTO_GV.TXT, table,DTO_GV.COLUMN);
            }
        }

        private void dgvGiaoVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            txtMaGiaoVien.Text = dgvGiaoVien.CurrentRow.Cells[0].Value.ToString();
            txtTenGiaoVien.Text = dgvGiaoVien.CurrentRow.Cells[1].Value.ToString();
            txtGhiChu.Text = dgvGiaoVien.CurrentRow.Cells[2].Value.ToString();

            if (dgvGiaoVien.CurrentRow.Cells[3].Value.ToString() != "")
            {
                cmbMaKhoa.SelectedValue = dgvGiaoVien.CurrentRow.Cells[3].Value;
                
            }
            else
            {
                cmbMaKhoa.SelectedValue = "";
            }

            //DTO_GV.GiaoVien_MaKhoa = cmbMaKhoa.SelectedValue.ToString();
            //DTO_GV.GiaoVien_MaGiaoVien = txtMaGiaoVien.Text;
            //DTO_GV.GiaoVien_TenGiaoVien = txtTenGiaoVien.Text;
            //DTO_GV.GiaoVien_GhiChu = txtGhiChu.Text;

        }

        #endregion

        #region Khoa

      

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {          
            flag = "thêm";
            Enable_khoa();
            BUS_xuly.ClearAllTextBox(groupboxKhoa);
            txtTenKhoa.Focus();
            btnNhaplaiKhoa.Enabled = false;
            btndelete_K.Enabled = false;
            txtMaKhoa.Text = Bus_Khoa.TaoMaKhoa();

        }

        private void btnNhaplaiKhoa_Click(object sender, EventArgs e)
        {
            flag = "sửa";
            Enable_khoa();
            txtTenKhoa.Focus();
            btnNhaplaiKhoa.Enabled = false;
            btndelete_K.Enabled = false;
        }
        private void btnLuuKhoa_Click(object sender, EventArgs e)
        {
            if (flag == "thêm")
            {

                DTO_khoa.Khoa_MaKhoa = txtMaKhoa.Text;
                DTO_khoa.Khoa_TenKhoa = txtTenKhoa.Text;                    
                DTO_khoa.Khoa_GhiChu = txtGhiChu_Khoa.Text;

                Bus_Khoa.ThemKhoa(DTO_khoa.Khoa_MaKhoa, DTO_khoa.Khoa_TenKhoa, DTO_khoa.Khoa_GhiChu);
                dgvKhoa.DataSource = Bus_Khoa.LoadDLKhoa();


                DTO_GV.cmbMAKHOA = cmbMaKhoa;
                Bus_GV.LoadDLVao_cmbMaKhoa(DTO_GV.cmbMAKHOA);

                int i;
                for (i = 0; i < dgvKhoa.RowCount - 1; i++)
                {
                    if (dgvKhoa.Rows[i].Cells[1].Value.ToString() == dgvKhoa.Text)
                        break;
                }
                dgvKhoa.CurrentCell = dgvKhoa[0, i];


                DisEnable_khoa();
                btnNhaplaiKhoa.Enabled = true;
                btndelete_K.Enabled = true;
            }
            else if (flag == "sửa")
            {
                DTO_khoa.Khoa_MaKhoa = txtMaKhoa.Text;
                DTO_khoa.Khoa_TenKhoa = txtTenKhoa.Text;
                DTO_khoa.Khoa_GhiChu = txtGhiChu_Khoa.Text;

                Bus_Khoa.CapNhatKhoa(DTO_khoa.Khoa_MaKhoa, DTO_khoa.Khoa_TenKhoa, DTO_khoa.Khoa_GhiChu);
                dgvKhoa.DataSource = Bus_Khoa.LoadDLKhoa();
                BUS_xuly.ClearAllTextBox(groupboxKhoa);

                DTO_GV.cmbMAKHOA = cmbMaKhoa;
                Bus_GV.LoadDLVao_cmbMaKhoa(DTO_GV.cmbMAKHOA);

                dgvKhoa.CurrentCell = dgvKhoa[0, index];

                DisEnable_khoa();
                btnNhaplaiKhoa.Enabled = true;
                btndelete_K.Enabled = true;
            }
        }
        private void btndelete_K_Click(object sender, EventArgs e)
        {
            Bus_Khoa.XoaKhoa(DTO_khoa.Khoa_MaKhoa);
            dgvKhoa.DataSource = Bus_Khoa.LoadDLKhoa();
            BUS_xuly.ClearAllTextBox(groupboxKhoa);

            DTO_GV.cmbMAKHOA = cmbMaKhoa;
            Bus_GV.LoadDLVao_cmbMaKhoa(DTO_GV.cmbMAKHOA);


        }
        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            txtMaKhoa.Text = dgvKhoa.CurrentRow.Cells[0].Value.ToString();
            txtTenKhoa.Text = dgvKhoa.CurrentRow.Cells[1].Value.ToString();
            txtGhiChu_Khoa.Text = dgvKhoa.CurrentRow.Cells[2].Value.ToString();

            DTO_khoa.Khoa_MaKhoa = txtMaKhoa.Text;
            DTO_khoa.Khoa_TenKhoa = txtTenKhoa.Text;
            DTO_khoa.Khoa_GhiChu = txtGhiChu_Khoa.Text;

        }

        #endregion

        #region chuẩn hoá

        private void txtTenGiaoVien_TextChanged_1(object sender, EventArgs e)
        {
            txtTenGiaoVien.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtTenGiaoVien.Text);
            txtTenGiaoVien.Select(txtTenGiaoVien.Text.Length, 0);
        }

        private void txtTenKhoa_TextChanged_1(object sender, EventArgs e)
        {

            txtTenKhoa.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtTenKhoa.Text);
            txtTenKhoa.Select(txtTenKhoa.Text.Length, 0);
        }

        private void txtThongTinTimKiem_GV_TextChanged(object sender, EventArgs e)
        {
            txtThongTinTimKiem_GV.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtThongTinTimKiem_GV.Text);
            txtThongTinTimKiem_GV.Select(txtThongTinTimKiem_GV.Text.Length, 0);
        }

        #endregion


    }
}
