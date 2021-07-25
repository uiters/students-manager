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
            DTO_sv.CMB = cmbMaLop;
            BUS_sv.LayDLVaoComboboxMaLop(DTO_sv.CMB);
            DisEnable_SV();
            dtp_NgaySinh.Value = DateTime.Now;
            #endregion

            #region Monhoc
            dgvMonhoc.DataSource = BUS_mh.LoadDLMonHoc();
            DTO_mh.CMB = cmbMaKhoa_MH;
            BUS_mh.LoadDLVaoCombobox_cmbMaKhoa_MH(DTO_mh.CMB);
            DisEnable_MH();
            #endregion

            #region DK môn học

           
            dgvDangkyMH.DataSource = BUS_dkmh.LoadDL_DKMonHoc();
            DisEnable_DKMH();
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
            txtMSSV.Text = BUS_sv.TaoMaSinhVien();
        }
        //lưu thông tin sv
        private void btnLuu_SV_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if (rdNam.Checked == true)
            
                gioitinh = "Nam";
            
            else
                gioitinh = "Nữ";
            
            DTO_sv.SinhVien_MaSinhVien = txtMSSV.Text;
            DTO_sv.SinhVien_HoTen = txtHotenSv.Text;
            DTO_sv.SinhVien_QueQuan = txtQueQuan.Text;
            DTO_sv.SinhVien_NgaySinh = dtp_NgaySinh.Value;
            DTO_sv.SinhVien_NoiSinh = txtNoiSinh.Text;
            DTO_sv.SinhVien_MaNganh = cbMaNganh.SelectedValue.ToString();
            DTO_sv.SinhVien_Hinh = txtHinh.Text;
            DTO_sv.SinhVien_GioiTinh = gioitinh;
            DTO_sv.SinhVien_MaLop = cmbMaLop.SelectedValue.ToString();

            BUS_sv.ThemSinhVien(DTO_sv.SinhVien_MaSinhVien, DTO_sv.SinhVien_HoTen, DTO_sv.SinhVien_QueQuan, DTO_sv.SinhVien_NgaySinh, DTO_sv.SinhVien_NoiSinh, DTO_sv.SinhVien_GioiTinh, DTO_sv.SinhVien_Hinh, DTO_sv.SinhVien_MaLop ,DTO_sv.SinhVien_MaNganh);
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
            if ((dgv_SV.CurrentRow.Cells[3].Value.ToString() == ""))
                dtp_NgaySinh.Value = DateTime.Now; 
            else
                dtp_NgaySinh.Value = (DateTime)dgv_SV.CurrentRow.Cells[3].Value;

            txtNoiSinh.Text = dgv_SV.CurrentRow.Cells[4].Value.ToString();

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
            txtHinh.Text = dgv_SV.CurrentRow.Cells[6].Value.ToString();
            pcHinhSV.ImageLocation = txtHinh.Text;
            pcHinhSV.SizeMode = PictureBoxSizeMode.StretchImage;
            cmbMaLop.SelectedValue = dgv_SV.CurrentRow.Cells[7].Value.ToString();
            cbMaNganh.SelectedValue= dgv_SV.CurrentRow.Cells[8].Value.ToString();       
            

           
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
            frmWebCam wb = new frmWebCam();
            wb.Show();

        }

        private void btnBrowseHinh_Click(object sender, EventArgs e)
        {
            oFD_Pic.ShowDialog();
        }
   

        private void oFD_Pic_FileOk(object sender, CancelEventArgs e)
        {
            txtHinh.Text = oFD_Pic.FileName.ToString();
            pcHinhSV.ImageLocation = txtHinh.Text;
            pcHinhSV.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        // 1 class nữa

        #endregion

        #endregion

        #region MH
        private void btnLuu_MH_Click(object sender, EventArgs e)
        {
            if (flag == "thêm")
            {
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

                int i;
                for (i = 0; i < dgvMonhoc.RowCount - 1; i++)
                {
                    if (dgvMonhoc.Rows[i].Cells[1].Value.ToString() == dgvMonhoc.Text)
                        break;
                }
                dgvMonhoc.CurrentCell = dgvMonhoc[0, i];


               

                DisEnable_MH();
                dgvMonhoc.Enabled = true;
                btnSua_MH.Enabled = true;
                btnCancel_MH.Enabled = true;
                btnThem_MH.Visible = true;
            }
            else if (flag == "sửa")
            {
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
                BUS_mh.CapNhatMonHoc(DTO_mh.MonHoc_MaMonHoc, DTO_mh.MonHoc_TenMonHoc, DTO_mh.MonHoc_LoaiMonHoc, DTO_mh.MonHoc_TinChiLyThuyet, DTO_mh.MonHoc_TinChiThucHanh, DTO_mh.MonHoc_MaKhoa);
                dgvMonhoc.DataSource = BUS_mh.LoadDLMonHoc();
                BUS_xuly.ClearAllTextBox(groupBox3);

                int i;
                for (i = 0; i < dgvMonhoc.RowCount - 1; i++)
                {
                    if (dgvMonhoc.Rows[i].Cells[1].Value.ToString() == dgvMonhoc.Text)
                        break;
                }
                dgvMonhoc.CurrentCell = dgvMonhoc[0, i];

                DisEnable_MH();
                dgvMonhoc.Enabled = true;
                btnSua_MH.Enabled = true;
                btnCancel_MH.Enabled = true;
                btnThem_MH.Visible = true;
            }
        }

        private void btnThem_MH_Click(object sender, EventArgs e)
        {

            flag = "thêm";
            BUS_xuly.ClearAllTextBox(groupBox3);
            txtMaMH.Text = BUS_mh.TaoMaMonHoc();
            Enable_MH();
            txtTenMh.Focus();
            btnSua_MH.Enabled = false;
            btnCancel_MH.Enabled = false;
            dgvMonhoc.Enabled = false;
        }

        private void btnSua_MH_Click(object sender, EventArgs e)
        {
            flag = "sửa";
            Enable_MH();
            txtTenMh.Focus();

            btnSua_MH.Enabled = false;
            btnCancel_MH.Enabled = false;
            dgvMonhoc.Enabled = false;
        }

        private void btnCancel_MH_Click(object sender, EventArgs e)
        {
            DTO_mh.MonHoc_MaMonHoc = txtMaMH.Text;
            BUS_mh.XoaMonHoc(DTO_mh.MonHoc_MaMonHoc);
            dgvMonhoc.DataSource = BUS_mh.LoadDLMonHoc();

            BUS_xuly.ClearAllTextBox(groupBox3);
            
            DisEnable_MH();
        }

        private void dgvMonhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = dgvMonhoc.CurrentRow.Cells[0].Value.ToString();
            txtTenMh.Text = dgvMonhoc.CurrentRow.Cells[1].Value.ToString();

            if(dgvMonhoc.CurrentRow.Cells[2].Value.ToString()=="")
            {
                rdMontuchon.Checked = false;
                rdMonbatbuoc.Checked = false;
            }

            else if ((bool)dgvMonhoc.CurrentRow.Cells[2].Value == true)
            {
                rdMonbatbuoc.Checked = true;
            }
            else if ((bool)dgvMonhoc.CurrentRow.Cells[2].Value == false)
            {
                rdMontuchon.Checked = true;
            }



            if (dgvMonhoc.CurrentRow.Cells[3].Value.ToString() == ""|| dgvMonhoc.CurrentRow.Cells[4].Value.ToString() == "")
            {
                numSoTietLT.Value = 0;
                numSoTietTH.Value = 0;
            }
            else
            {
                numSoTietLT.Value = (int)dgvMonhoc.CurrentRow.Cells[3].Value;
                numSoTietTH.Value = (int)dgvMonhoc.CurrentRow.Cells[4].Value;
            }

          
            cmbMaKhoa_MH.SelectedValue = dgvMonhoc.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnQLMH_Click(object sender, EventArgs e)
        {
            frmQLMH frmQLMH = new frmQLMH();
            frmQLMH.ShowDialog();
        }

        #endregion

        #region QLMH
        private void btnTimDKMH_Click(object sender, EventArgs e)
        {
            if (cmbTimKiem_DKMH.Text == "--Điều kiện tìm--")
            {
                MessageBox.Show("Chọn điều kiện tìm kiếm");
                return;
            }
            else
            {


                if (cmbTimKiem_DKMH.Text == "Tên sinh viên")

                {

                    DTO_dkmh.DKMH_MaSinhVien = txtTimKiem_DKMH.Text;

                    dgvDangkyMH.DataSource = BUS_dkmh.TimKiem("HoTen",DTO_dkmh.DKMH_MaSinhVien);
                    int n = dgvDangkyMH.Rows.Count - 1;
                    MessageBox.Show("Tìm thấy " + n + " kết quả! ");
                }
                else
                {
                    DTO_dkmh.DKMH_MaSinhVien = txtTimKiem_DKMH.Text;

                    dgvDangkyMH.DataSource = BUS_dkmh.TimKiem("SinhVien.MaSinhVien",DTO_dkmh.DKMH_MaSinhVien);
                    int n = dgvDangkyMH.Rows.Count - 1;
                    MessageBox.Show("Tìm thấy " + n + " kết quả! ");
                }
                groupboxSVDKMH.Visible = true;
            }
        }



            private void dgvDangkyMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDangkyMH.CurrentRow.Cells[0].Value.ToString() == "")
            {
                txtMonHoc_DKMH.Text = "NULL";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                txtTinChi_DKMH.Text = "0";
                txtMonHoc_DKMH.Text = dgvDangkyMH.CurrentRow.Cells[0].Value.ToString();
                txtMSV_DKMH.Text = dgvDangkyMH.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                txtMonHoc_DKMH.Text = dgvDangkyMH.CurrentRow.Cells[0].Value.ToString();
                txtMSV_DKMH.Text = dgvDangkyMH.CurrentRow.Cells[1].Value.ToString();
                txtTenSV_DKMH.Text = dgvDangkyMH.CurrentRow.Cells[2].Value.ToString();

                if (dgvDangkyMH.CurrentRow.Cells[3].Value.ToString() == "")
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                }
                else if ((bool)dgvDangkyMH.CurrentRow.Cells[3].Value == true)
                {
                    radioButton1.Checked = true;
                }
                else if ((bool)dgvDangkyMH.CurrentRow.Cells[3].Value == false)
                {
                    radioButton2.Checked = true;
                }


                int a = (int)dgvDangkyMH.CurrentRow.Cells[4].Value + (int)dgvDangkyMH.CurrentRow.Cells[5].Value;
                txtTinChi_DKMH.Text = a.ToString();
            }
        }


        #endregion

        private void txtTimKiem_DKMH_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbTimKiem_DKMH_TextChanged(object sender, EventArgs e)
        {
            DTO_dkmh.TXTTIM = txtTimKiem_DKMH;
            int col;
            string table = "";
            if (cmbTimKiem_DKMH.SelectedItem.ToString() == "Mã số sinh viên")
            {
                col = 0;
                
                BUS_dkmh.TuDongHoanThanh(DTO_dkmh.TXTTIM, table, col);
            }
            else
            {
                col = 1;
                
                BUS_dkmh.TuDongHoanThanh(DTO_dkmh.TXTTIM, table, col);
            }
        }
    }


}

