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
using GUI_QLSV.UserControls;


namespace GUI_QLSV.UserControls
{
    public partial class UC_SinhVien_MonHoc_DKHP : UserControl
    {
        public UC_SinhVien_MonHoc_DKHP()
        {
            InitializeComponent();
        }

        string flag = "";// dùng để thêm hoặc sửa
        int index;

        DTO_SinhVien DTO_sv = new DTO_SinhVien();
        DTO_MonHoc DTO_mh = new DTO_MonHoc();
        DTO_DKMH DTO_dkmh = new DTO_DKMH();
        DTO_Lop DTO_lop = new DTO_Lop();

        BUS_Xuly BUS_xuly = new BUS_Xuly();
        BUS_SinhVien BUS_sv = new BUS_SinhVien();
        BUS_MonHoc BUS_mh = new BUS_MonHoc();
        BUS_DKMH BUS_dkmh = new BUS_DKMH();
        BUS_LOP BUS_lop = new BUS_LOP();
       
        #region hide and show txt
        public void DisEnable_SV()
        {
            btnLuu_SV.Visible = false;
            txtHotenSv.Enabled = false;
            dtp_NgaySinh.Enabled = false;
            txtNoiSinh.Enabled = false;
            txtQueQuan.Enabled = false;
            cbMaNganh.Enabled = false;
            btnBrowseHinh.Enabled = false;
            rdNam.Enabled = false;
            rdNu.Enabled = false;


        }
        public void Enable_SV()
        {
            btnLuu_SV.Visible = true;
            txtHotenSv.Enabled = true;
            dtp_NgaySinh.Enabled = true;
            txtNoiSinh.Enabled = true;
            txtQueQuan.Enabled = true;
            cbMaNganh.Enabled = true;
            btnBrowseHinh.Enabled = true;
            rdNam.Enabled = true;
            rdNu.Enabled = true;
            btnCancel_SV.Visible = true;

        }
        public void DisEnable_MH()
        {
            txtTenMh.Enabled = false;
            txtMaMH.Enabled = false;
            cmbMaKhoa_MH.Enabled = false;
            rdMonbatbuoc.Enabled = false;
            rdMontuchon.Enabled = false;
            numSoTietLT.Enabled = false;
            numSoTietTH.Enabled = false;
            btnLuu_MH.Visible = false;

        }
        public void Enable_MH()
        {
            txtTenMh.Enabled = true;
            txtMaMH.Enabled = true;
            cmbMaKhoa_MH.Enabled = true;
            rdMonbatbuoc.Enabled = true;
            rdMontuchon.Enabled = true;
            numSoTietLT.Enabled = true;
            numSoTietTH.Enabled = true;
            btnLuu_MH.Visible = true;
        }
        public void DisEnable_DKMH()
        {
            txtMSV_DKMH.Enabled = false;
            txtTenSV_DKMH.Enabled = false;
            txtMonHoc_DKMH.Enabled = false;
            txtTinChi_DKMH.Enabled = false;
            radioButton2.Enabled = false;
            radioButton1.Enabled = false;
        }
        public void Enable_DKMH()
        {
            txtMSV_DKMH.Enabled = true;
            txtTenSV_DKMH.Enabled = true;
            txtMonHoc_DKMH.Enabled = true;
            txtTinChi_DKMH.Enabled = true;
            radioButton2.Enabled = true;
            radioButton1.Enabled = true;
        }

        #endregion

        #region uc_Load

        private void UC_SinhVien_MonHoc_DKHP_Load(object sender, EventArgs e)
        {
            #region SinhVien
            dgv_SV.DataSource = BUS_sv.LoadDL();
            DTO_sv.CMB = cbMaNganh;
            BUS_sv.LayDLVaoComboboxMaNganh(DTO_sv.CMB);   
            DisEnable_SV();
            #endregion

            #region Monhoc
            DTO_mh.CMB = cmbMaKhoa_MH;
            BUS_mh.LoadDLVaoCombobox_cmbMaKhoa_MH(DTO_mh.CMB);
            dgvMonhoc.DataSource = BUS_mh.LoadDLMonHoc();
            DisEnable_MH();
            #endregion 

            #region DK môn học

            //dto
            //dgvDangkyMH.DataSource = BUS_dkmh.LoadDL_DKMonHoc();

            //DTO_dkmh.TXTTIM = txtTim_MSSV;
            //BUS_dkmh.GoiYTimKiem();
            //DTO_dkmh.TXTMSV = txtMSV_DKMH;
            //BUS_dkmh.GoiYMSSV();

            //DisEnable_DKMH();
            #endregion
        }
        private void tabSV_Mon_DKMH_Click(object sender, EventArgs e)
        {
            DTO_sv.CMB = cbMaNganh;
            BUS_sv.LayDLVaoComboboxMaNganh(DTO_sv.CMB);

            DTO_mh.CMB = cmbMaKhoa_MH;
            BUS_mh.LoadDLVaoCombobox_cmbMaKhoa_MH(DTO_mh.CMB);



            DisEnable_DKMH();
            DisEnable_MH();
            DisEnable_SV();


            groupBox1.Focus();
        }

        #endregion

        #region SV
        //input thông tin sv
        private void btnThem_SV_Click(object sender, EventArgs e)
        {
            Enable_SV();
            txtHotenSv.Focus();
            btnTakePhoto.Enabled = true;
            BUS_xuly.ClearAllTextBox(groupBox1);
            DTO_sv.CMB = cbMaNganh;
         //   btnLamlai.Visible = false;
        }
        //lưu thông tin sv
        private void btnLuu_SV_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if (rdNam.Checked == true)
            
                gioitinh = "Nam";
            
            else
                gioitinh = "Nữ";
            txtMSSV.Text = BUS_sv.TaoMaSinhVien();
            DTO_sv.SinhVien_MaSinhVien = txtMSSV.Text;
            DTO_sv.SinhVien_MaNganh = txtMSSV.Text;
            DTO_sv.SinhVien_HoTen = txtHotenSv.Text;
            DTO_sv.SinhVien_QueQuan = txtQueQuan.Text;
            DTO_sv.SinhVien_NgaySinh = dtp_NgaySinh.Value;
            DTO_sv.SinhVien_NoiSinh = txtNoiSinh.Text;
            DTO_sv.SinhVien_MaNganh = cbMaNganh.SelectedValue.ToString();
            DTO_sv.SinhVien_Hinh = txtHinh.Text;
            DTO_sv.SinhVien_GioiTinh = gioitinh;

            BUS_sv.ThemSinhVien(DTO_sv.SinhVien_MaSinhVien, DTO_sv.SinhVien_HoTen, DTO_sv.SinhVien_QueQuan, DTO_sv.SinhVien_NgaySinh, DTO_sv.SinhVien_NoiSinh, DTO_sv.SinhVien_GioiTinh, DTO_sv.SinhVien_MaNganh, DTO_sv.SinhVien_Hinh);
            dgv_SV.DataSource = BUS_sv.LoadDL();

            DisEnable_SV();
            btnThem_SV.Visible = true;
        //    btnLamlai.Visible = true;
        }
        //hủy quá trình đang thêm
        private void btnCancel_SV_Click(object sender, EventArgs e)
        {
            BUS_xuly.ClearAllTextBox(groupBox1);
            DisEnable_SV();
            btnThem_SV.Visible = true;
        }
        // mở frmQLSV quản lý sinh viên
        private void btnQuanLySV_Click(object sender, EventArgs e)
        {
            frmQLSV frmQLSV = new frmQLSV();
            frmQLSV.ShowDialog();
        }
        // tương tác dgv với TextBox
        private void dgv_SV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMSSV.Text = dgv_SV.CurrentRow.Cells[0].Value.ToString();
            txtHotenSv.Text = dgv_SV.CurrentRow.Cells[1].Value.ToString();
            txtQueQuan.Text = dgv_SV.CurrentRow.Cells[2].Value.ToString();
            cbMaNganh.SelectedValue= dgv_SV.CurrentRow.Cells[6].Value.ToString();
            if ((dgv_SV.CurrentRow.Cells[3].Value.ToString() == ""))
            { dtp_NgaySinh.Value = DateTime.Now; }
            else
                dtp_NgaySinh.Value = (DateTime)dgv_SV.CurrentRow.Cells[3].Value;
            txtNoiSinh.Text = dgv_SV.CurrentRow.Cells[4].Value.ToString();
            txtHinh.Text = dgv_SV.CurrentRow.Cells[7].Value.ToString();

            pcHinhSV.ImageLocation = txtHinh.Text;
            pcHinhSV.SizeMode = PictureBoxSizeMode.StretchImage;

            if (dgv_SV.CurrentRow.Cells[5].Value.ToString() == "Nam")
            {
                rdNam.Checked = true;
            }
            else if (dgv_SV.CurrentRow.Cells[5].Value.ToString() == "Nữ")
            {
                rdNu.Checked = true;
            }
            else
            {
                rdNam.Checked = false;
                rdNu.Checked = false;
            }
        }

                            #region chuẩn hoá


        private void txtHotenSv_TextChanged_1(object sender, EventArgs e)
        {
            txtHotenSv.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtHotenSv.Text);
            txtHotenSv.Select(txtHotenSv.Text.Length, 0);

        }

        private void txtNoiSinh_TextChanged_1(object sender, EventArgs e)
        {
            txtNoiSinh.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtNoiSinh.Text);
            txtNoiSinh.Select(txtNoiSinh.Text.Length, 0);
        }

        private void txtQueQuan_TextChanged_1(object sender, EventArgs e)
        {
            txtQueQuan.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtQueQuan.Text);
            txtQueQuan.Select(txtQueQuan.Text.Length, 0);
        }



        #endregion 

                            #region WEBCAME
        private void btnTakePhoto_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowseHinh_Click(object sender, EventArgs e)
        {

        }
        // 1 class nữa

        #endregion

        #endregion

        #region MH
        private void btnLuu_MH_Click(object sender, EventArgs e)
        {
            txtMaMH.Text = BUS_mh.TaoMaMonHoc();
            DTO_mh.MonHoc_MaMonHoc = txtMaMH.Text;
            DTO_mh.MonHoc_TenMonHoc = txtTenMh.Text;
            DTO_mh.MonHoc_MaKhoa = cmbMaKhoa_MH.SelectedValue.ToString();
            DTO_mh.MonHoc_TinChiLyThuyet = (int)numSoTietLT.Value;
            DTO_mh.MonHoc_TinChiThucHanh = (int)numSoTietTH.Value;

            bool hinhthuc = false;
            if (rdMonbatbuoc.Checked == true)
            {
                hinhthuc = true;
            }
            else if (rdMontuchon.Checked == true)
            {
                hinhthuc = false;
            }
            DTO_mh.MonHoc_LoaiMonHoc = hinhthuc;
            BUS_mh.ThemMonHoc(DTO_mh.MonHoc_MaMonHoc, DTO_mh.MonHoc_TenMonHoc, DTO_mh.MonHoc_LoaiMonHoc, DTO_mh.MonHoc_TinChiLyThuyet, DTO_mh.MonHoc_TinChiThucHanh, DTO_mh.MonHoc_MaKhoa);
            dgvMonhoc.DataSource = BUS_mh.LoadDLMonHoc();
            BUS_xuly.ClearAllTextBox(groupBox3);

            DisEnable_MH();
            btnThem_MH.Visible = true;
        }

        private void btnThem_MH_Click(object sender, EventArgs e)
        {
            Enable_MH();
            txtTenMh.Focus();
            BUS_xuly.ClearAllTextBox(groupBox3);
            btnThem_MH.Visible = false;
        }

        private void btnCancel_MH_Click(object sender, EventArgs e)
        {
            BUS_xuly.ClearAllTextBox(groupBox3);
            DisEnable_MH();
        }

        private void dgvMonhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = dgvMonhoc.CurrentRow.Cells[0].Value.ToString();
            txtTenMh.Text = dgvMonhoc.CurrentRow.Cells[1].Value.ToString();
            cmbMaKhoa_MH.SelectedValue = dgvMonhoc.CurrentRow.Cells[2].Value.ToString();
            //if (dgvMonhoc.CurrentRow.Cells[3].Value.ToString() == "")
            //{
            //    numSoTietLT.Value = 0;
            //    numSoTietTH.Value = 0;
            //}
            //else
            //{
            //    numSoTietLT.Value = (int)dgvMonhoc.CurrentRow.Cells[6].Value;
            //    numSoTietTH.Value = (int)dgvMonhoc.CurrentRow.Cells[7].Value;
            //}
            numSoTietLT.Value = (int)dgvMonhoc.CurrentRow.Cells[3].Value;
            numSoTietTH.Value = (int)dgvMonhoc.CurrentRow.Cells[4].Value;
            if ((bool)dgvMonhoc.CurrentRow.Cells[2].Value == true)
            {
                rdMonbatbuoc.Checked = true;
            }
            else if ((bool)dgvMonhoc.CurrentRow.Cells[2].Value == true)
            {
                rdMontuchon.Checked = true;
            }
            else
            {
                rdMontuchon.Checked = false;
                rdMonbatbuoc.Checked = false;
            }

        }

        private void btnQLMH_Click(object sender, EventArgs e)
        {
            frmQLMH frmQLMH = new frmQLMH();
            frmQLMH.ShowDialog();
        }

        #endregion

        #region QLMH



        #endregion

        private void btnTimDKMH_Click(object sender, EventArgs e)
        {
            DTO_dkmh.DKMH_MaSinhVien = txtTim_MSSV.Text;
            //BUS_dkmh.TimKiemSVDK(DTO_dkmh.DKMH_MaSinhVien);
            dgvDangkyMH.DataSource = BUS_dkmh.TimKiemSVDK(DTO_dkmh.DKMH_MaSinhVien);
            lblTenSV.Text = BUS_dkmh.LayTenSV();
            groupboxSVDKMH.Visible = true;
        }

        private void dgvDangkyMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMonHoc_DKMH.Text = dgvDangkyMH.CurrentRow.Cells[0].Value.ToString();
            txtMSV_DKMH.Text = dgvDangkyMH.CurrentRow.Cells[1].Value.ToString();
           /* txtTenSV_DKMH.Text == dgvDangkyMH.CurrentRow.Cells[2].Value.ToString();
            txtTinChi_DKMH.Text == dgvDangkyMH.CurrentRow.Cells[3].Value.ToString();
            if ((bool)dgvDangkyMH.CurrentRow.Cells[4].Value == true)
            {
                radioButton1.Checked = true;
            }
            else if ((bool)dgvDangkyMH.CurrentRow.Cells[4].Value == true)
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            txtTinChi_DKMH.Text = (int)dgvDangkyMH.CurrentRow.Cells[5].Value + (int)dgvDangkyMH.CurrentRow.Cells[6].Value;*/
        }

    }


}

