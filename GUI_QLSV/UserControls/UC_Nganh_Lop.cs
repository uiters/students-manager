using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLSV;
using DTO_QLSV;
namespace GUI_QLSV.UserControls
{
    public partial class UC_Nganh_Lop : UserControl
    {
        public UC_Nganh_Lop()
        {
            InitializeComponent();
        }

        string flag = "";// dùng để thêm hoặc sửa
        int index;

        
        DTO_Lop DTO_lop = new DTO_Lop();
        DTO_Nganh DTO_Nganh = new DTO_Nganh();
        BUS_Xuly BUS_xuly = new BUS_Xuly();
        BUS_Nganh Bus_Nganh = new BUS_Nganh();
        BUS_LOP BUS_Lop = new BUS_LOP();

        #region hide and show txt

        public void DisEnable_LOP()
        {

            btnLuu_Lop.Visible = false;
            txtMaLop.Enabled = false;
            txtTenLop.Enabled = false;
            rdb_1.Enabled = false;
            rdb_2.Enabled = false;
            txtNienKhoa_Lop.Enabled = false;
            dtpNgayBatDau_Lop.Enabled = false;
            dtpNgayKetThuc_Lop.Enabled = false;
            cmbGiaoVien_Lop.Enabled = false;
            cmbMonHoc_Lop.Enabled = false;

        }
        public void Enable_LOP()
        {
            btnLuu_Lop.Visible = true;            
            txtTenLop.Enabled = true;
            rdb_1.Enabled = true;
            rdb_2.Enabled = true;
            txtNienKhoa_Lop.Enabled = true;
            dtpNgayBatDau_Lop.Enabled = true;
            dtpNgayKetThuc_Lop.Enabled = true;
            cmbGiaoVien_Lop.Enabled = true;
            cmbMonHoc_Lop.Enabled = true;
            btnCancel_LOP.Visible = true;
        }
        public void Enable_NGANH()
        {
            btnLuu_NGANH.Visible = true;
            txtTenNganh.Enabled = true;
            cmbMaKhoa.Enabled = true;
            txtGhiChu_Nganh.Enabled = true;
            btnCancel_NGANH.Visible = true;
        }
        public void DisEnable_NGANH()
        {
            btnLuu_NGANH.Visible = false;
            txtTenNganh.Enabled = false;
            cmbMaKhoa.Enabled = false;
            txtMaNganh.Enabled = false;
            txtGhiChu_Nganh.Enabled = false;
        }
        #endregion

        #region UC_Load
        private void UC_Nganh_Lop_Load(object sender, EventArgs e)
        {

            dgvLop.DataSource = BUS_Lop.LoadDL_dgvLop();

            DTO_Nganh.Nganh_cmbMaKhoa = cmbMaKhoa;
            Bus_Nganh.LoadDLVao_cmbMaKhoa(DTO_Nganh.Nganh_cmbMaKhoa);
            dgvNganh.DataSource = Bus_Nganh.LoadDL();

            //ko cho thao tác 
            DisEnable_LOP();

            DisEnable_NGANH();          

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

        }

        private void tabKhoaHoc_Nganh_Lop_Click(object sender, EventArgs e)
        {
            DTO_lop.cmbMaGiaoVien = cmbGiaoVien_Lop;
            BUS_Lop.LoadDLVaoCombobox_GiaoVien(DTO_lop.cmbMaGiaoVien);
            DTO_lop.cmbMaMonHoc = cmbMonHoc_Lop;
            BUS_Lop.LoadDLVaoCombobox_MonHoc(DTO_lop.cmbMaMonHoc);
            dgvLop.DataSource = BUS_Lop.LoadDL_dgvLop();

            DTO_Nganh.Nganh_cmbMaKhoa = cmbMaKhoa;
            Bus_Nganh.LoadDLVao_cmbMaKhoa(DTO_Nganh.Nganh_cmbMaKhoa);
            dgvNganh.DataSource = Bus_Nganh.LoadDL();

            btnThemLop.Visible = true;
            DisEnable_LOP();
            DisEnable_NGANH();
        }
        #endregion

        #region LOP
        private void btnLuu_Lop_Click(object sender, EventArgs e)
        {
            bool loailop = false;
            if (flag == "thêm")
            {
              
                DTO_lop.Lop_MaLop = txtMaLop.Text;
                DTO_lop.Lop_TenLop = txtTenLop.Text;

                
                if (rdb_1.Checked == true)

                    loailop = true;

                else
                    loailop = true;

                DTO_lop.Lop_LoaiLop = loailop;

                DTO_lop.Lop_NienKhoa = txtNienKhoa_Lop.Text;
                DTO_lop.Lop_NgayBatDau = dtpNgayBatDau_Lop.Value;
                DTO_lop.Lop_NgayKetThuc = dtpNgayKetThuc_Lop.Value;
                DTO_lop.Lop_MaGiaoVien = cmbGiaoVien_Lop.SelectedValue.ToString();
                DTO_lop.Lop_MaMonHoc = cmbGiaoVien_Lop.SelectedValue.ToString();
                if (dtpNgayKetThuc_Lop.Value.Day- dtpNgayBatDau_Lop.Value.Day>0)
                {
                    
                }
                else
                {
                    MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu ");
                    DTO_lop.Lop_NgayBatDau = dtpNgayBatDau_Lop.Value;
                    DTO_lop.Lop_NgayKetThuc = dtpNgayKetThuc_Lop.Value;
                }
                BUS_Lop.ThemLop(DTO_lop.Lop_MaLop, DTO_lop.Lop_TenLop, DTO_lop.Lop_LoaiLop, DTO_lop.Lop_NienKhoa, DTO_lop.Lop_NgayBatDau, DTO_lop.Lop_NgayKetThuc, DTO_lop.Lop_MaMonHoc,DTO_lop.Lop_MaGiaoVien);

                dgvLop.DataSource = BUS_Lop.LoadDL_dgvLop();
                BUS_xuly.ClearAllTextBox(groupboxLOP);

                DisEnable_LOP();

                btnThemLop.Visible = true;
                btnLamlai_Lop.Enabled = true;
                btnCancel_LOP.Enabled = true;
                dgvLop.Enabled = true;

                int i;
                for (i = 0; i < dgvLop.RowCount - 1; i++)
                {
                    if (dgvLop.Rows[i].Cells[1].Value.ToString() == txtMaLop.Text)
                        break;
                }
                dgvLop.CurrentCell = dgvLop[0, i];

            }
            else if (flag == "sửa")
            {

                txtMaLop.Text = BUS_Lop.TaoMaLop();
                DTO_lop.Lop_MaLop = txtMaLop.Text;
                DTO_lop.Lop_TenLop = txtTenLop.Text;
                if (rdb_1.Checked == true)

                    loailop = true;

                else
                    loailop = true;

                DTO_lop.Lop_LoaiLop = loailop;
                DTO_lop.Lop_NienKhoa = txtNienKhoa_Lop.Text;
                DTO_lop.Lop_NgayBatDau = dtpNgayBatDau_Lop.Value;
                DTO_lop.Lop_NgayKetThuc = dtpNgayKetThuc_Lop.Value;
                if (dtpNgayKetThuc_Lop.Value.Day - dtpNgayBatDau_Lop.Value.Day > 0)
                {
                 
                }
                else
                {
                    MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu ");
                    DTO_lop.Lop_NgayBatDau = dtpNgayBatDau_Lop.Value;
                    DTO_lop.Lop_NgayKetThuc = dtpNgayKetThuc_Lop.Value;
                }
                BUS_Lop.CapNhatLop(DTO_lop.Lop_MaLop, DTO_lop.Lop_TenLop, DTO_lop.Lop_LoaiLop, DTO_lop.Lop_NienKhoa, DTO_lop.Lop_NgayBatDau, DTO_lop.Lop_NgayKetThuc, DTO_lop.Lop_MaMonHoc, DTO_lop.Lop_MaGiaoVien);
                dgvLop.DataSource = BUS_Lop.LoadDL_dgvLop();
                BUS_xuly.ClearAllTextBox(groupboxLOP);
                DisEnable_LOP();

                btnThemLop.Visible = true;
                btnLamlai_Lop.Enabled = true;
                btnCancel_LOP.Enabled = true;
                dgvLop.Enabled = true;

                //focus
                dgvLop.CurrentCell = dgvLop[0, index];
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
           
            flag = "thêm";
            //button
            btnThemLop.Visible = false;
            btnLamlai_Lop.Enabled = false;
            btnCancel_LOP.Enabled = false;
            dgvLop.Enabled = false;

            BUS_xuly.ClearAllTextBox(groupboxLOP);
            txtMaLop.Text = BUS_Lop.TaoMaLop();
            Enable_LOP();
        }

        private void btnLamlai_Lop_Click(object sender, EventArgs e)
        {
            flag = "sửa";
            //button
            btnThemLop.Visible = false;
            btnCancel_LOP.Enabled = false;
            dgvLop.Enabled = false;

            Enable_LOP();
        }

        private void btnCancel_LOP_Click(object sender, EventArgs e)
        {
            DTO_lop.Lop_MaLop = txtMaLop.Text;
            BUS_Lop.XoaLop(DTO_lop.Lop_MaLop);
            dgvLop.DataSource = BUS_Lop.LoadDL_dgvLop();
            BUS_xuly.ClearAllTextBox(groupboxLOP);
            DisEnable_LOP();

        }

        private void btnTimLop_Click(object sender, EventArgs e)
        {
            if (cmbTimLop.Text == "-- Chọn điều kiện --")
            {
                MessageBox.Show("Vui lòng chọn điều kiện tìm kiếm ! ");
                return;
            }
            else
            {
                if (txtTimLop.Text == "")
                {
                    dgvLop.DataSource = BUS_Lop.LoadDL_dgvLop();
                }
                else
                {
                    DTO_lop.DKTIM = txtTimLop.Text;
                    dgvLop.DataSource = BUS_Lop.TimKiemLop("TenLop", DTO_lop.DKTIM);
                    int n = BUS_Lop.TimKiemLop("TenLop", DTO_lop.DKTIM).Rows.Count;
                    MessageBox.Show("Tìm thấy " + n + " kết quả");
                }
            }
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            txtMaLop.Text = dgvLop.CurrentRow.Cells[0].Value.ToString();
            txtTenLop.Text = dgvLop.CurrentRow.Cells[1].Value.ToString();
            if ((bool)dgvLop.CurrentRow.Cells[2].Value == true )
            {
                rdb_1.Checked = true;
            }
            else if ((bool)dgvLop.CurrentRow.Cells[2].Value == false)
            {
                rdb_2.Checked = true;
            }
            else
            {
                rdb_1.Checked = false;
                rdb_2.Checked = false;
            }

            txtNienKhoa_Lop.Text = dgvLop.CurrentRow.Cells[3].Value.ToString();

            if ((dgvLop.CurrentRow.Cells[4].Value.ToString() == ""))
            { dtpNgayBatDau_Lop.Value = DateTime.Now; }
            else
                dtpNgayBatDau_Lop.Value = (DateTime)dgvLop.CurrentRow.Cells[4].Value;

            if ((dgvLop.CurrentRow.Cells[5].Value.ToString() == ""))
            { dtpNgayKetThuc_Lop.Value = DateTime.Now; }
            else
                dtpNgayKetThuc_Lop.Value = (DateTime)dgvLop.CurrentRow.Cells[5].Value;
           

        }

        private void cmbTimLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cotgoiy = 0;
            string table = "";
            if (cmbTimLop.SelectedItem.ToString() == "Tên Lớp")
            {
                cotgoiy = 3;
                DTO_lop.COTGOIY = cotgoiy;
                DTO_lop.COTIMKIEM = "TenLop";

                DTO_lop.TXTGOIY = txtTimLop;
                BUS_Lop.GoiYTimKiem(DTO_lop.TXTGOIY,table,cotgoiy);
            }
            else if (cmbTimLop.SelectedItem.ToString() == "Mã Ngành")
            {
                cotgoiy = 2;
                DTO_lop.COTGOIY = cotgoiy;
                DTO_lop.COTIMKIEM = "MaNganh";

                DTO_lop.TXTGOIY = txtTimLop;
                BUS_Lop.GoiYTimKiem(DTO_lop.TXTGOIY, table, cotgoiy);
            }

        }

        #endregion

        #region NGANH
        private void btnLuu_NGANH_Click(object sender, EventArgs e)
        {
            if (flag == "thêm")
            {
              
                DTO_Nganh.Nganh_MaNganh = txtMaNganh.Text;
                DTO_Nganh.Nganh_TenNganh = txtTenNganh.Text;
                DTO_Nganh.Nganh_GhiChu = txtGhiChu_Nganh.Text;
                if (cmbMaKhoa.Text.ToString() == "")
                {
                    MessageBox.Show("Bạn chưa chọn Khoa");
                    DisEnable_NGANH();
                    dgvNganh.Enabled = true;
                    btnLamlai_Nganh.Enabled = true;
                    btnCancel_NGANH.Enabled = true;
                    return;
                }
                else
                {
                    DTO_Nganh.Nganh_MaKhoa = cmbMaKhoa.SelectedValue.ToString();
                }
                Bus_Nganh.ThemNganh(DTO_Nganh.Nganh_MaNganh,DTO_Nganh.Nganh_TenNganh,DTO_Nganh.Nganh_GhiChu, DTO_Nganh.Nganh_MaKhoa);
                dgvNganh.DataSource = Bus_Nganh.LoadDL();
                BUS_xuly.ClearAllTextBox(groupBox7);

                DisEnable_NGANH();
                btnThem_Nganh.Visible = true;
                btnLamlai_Nganh.Enabled = true;
                btnCancel_NGANH.Enabled = true;
                dgvNganh.Enabled = true;
                int i;
                for (i = 0; i < dgvNganh.RowCount - 1; i++)
                {
                    if (dgvNganh.Rows[i].Cells[1].Value.ToString() == txtMaNganh.Text)
                        break;
                }
                dgvNganh.CurrentCell = dgvNganh[0, i];

            }
            else if (flag == "sửa")
            {

                DTO_Nganh.Nganh_MaNganh = txtMaNganh.Text;
                DTO_Nganh.Nganh_TenNganh = txtTenNganh.Text;
                DTO_Nganh.Nganh_GhiChu = txtGhiChu_Nganh.Text;
                if (cmbMaKhoa.Text.ToString() == "")
                {
                    MessageBox.Show("Bạn chưa chọn Khoa");
                    DisEnable_NGANH();
                    dgvNganh.Enabled = true;
                    btnLamlai_Nganh.Enabled = true;
                    btnCancel_NGANH.Enabled = true;
                    return;
                }
                else
                {
                    DTO_Nganh.Nganh_MaKhoa = cmbMaKhoa.SelectedValue.ToString();
                }
                Bus_Nganh.CapNhatNganh(DTO_Nganh.Nganh_MaNganh, DTO_Nganh.Nganh_TenNganh, DTO_Nganh.Nganh_GhiChu, DTO_Nganh.Nganh_MaKhoa);                
                dgvNganh.DataSource = Bus_Nganh.LoadDL();
                BUS_xuly.ClearAllTextBox(groupBox7);

                DisEnable_NGANH();
                btnThem_Nganh.Visible = true;
                btnLamlai_Nganh.Enabled = true;
                btnCancel_NGANH.Enabled = true;
                dgvNganh.Enabled = true;
                //focus
                dgvNganh.CurrentCell = dgvNganh[0, index];
            }
        }

        private void btnThem_Nganh_Click(object sender, EventArgs e)
        {
            flag = "thêm";
            //button
            btnThem_Nganh.Visible = false;
            btnLamlai_Nganh.Enabled = false;
            btnCancel_NGANH.Enabled = false;
            dgvNganh.Enabled = false;

            BUS_xuly.ClearAllTextBox(groupBox7);

            Enable_NGANH();
            txtMaNganh.Text = Bus_Nganh.TaoMaNganh();
        }

        private void btnLamlai_Nganh_Click(object sender, EventArgs e)
        {

            flag = "sửa";
            //button
            btnThem_Nganh.Visible = false;
            btnCancel_NGANH.Enabled = false;
            dgvNganh.Enabled = false;

            Enable_NGANH();
        }

        private void btnCancel_NGANH_Click(object sender, EventArgs e)
        {
            DTO_Nganh.Nganh_MaNganh = txtMaNganh.Text;
            Bus_Nganh.XoaNganh(DTO_Nganh.Nganh_MaNganh);
            dgvNganh.DataSource = Bus_Nganh.LoadDL();
            BUS_xuly.ClearAllTextBox(groupBox7);
            DisEnable_NGANH();
        }

        private void dgvNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            txtMaNganh.Text = dgvNganh.CurrentRow.Cells[0].Value.ToString();
            txtTenNganh.Text = dgvNganh.CurrentRow.Cells[1].Value.ToString();
            txtGhiChu_Nganh.Text = dgvNganh.CurrentRow.Cells[2].Value.ToString();
            cmbMaKhoa.Text = dgvNganh.CurrentRow.Cells[3].Value.ToString();
            //
        
        }

        #endregion

      
    }
}
