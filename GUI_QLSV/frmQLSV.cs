using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLSV;
using BUS_QLSV;
using GUI_QLSV.UserControls;
namespace GUI_QLSV
{
    public partial class frmQLSV : Form
    {
        public frmQLSV()
        {
            InitializeComponent();
        }

        DTO_SinhVien DTO_sv = new DTO_SinhVien();
        
        DTO_Lop DTO_lop = new DTO_Lop();

        BUS_Xuly BUS_xuly = new BUS_Xuly();
        BUS_SinhVien BUS_sv = new BUS_SinhVien();
        
        BUS_LOP BUS_lop = new BUS_LOP();

        UC_SinhVien_MonHoc_DKHP userControl = new UC_SinhVien_MonHoc_DKHP();
        
        int col = 0;
        string table;
        #region hide and show txt
        public void DisEnable_SV()
        {
           
            txtHotenSv.Enabled = false;
            dtp_NgaySinh.Enabled = false;
            txtNoiSinh.Enabled = false;
            txtQueQuan.Enabled = false;
            cmbNganh_sv.Enabled = false;
            btnBrowseHinh.Enabled = false;
            rdNam.Enabled = false;
            rdNu.Enabled = false;
            btnLuu.Visible = false;



        }
        public void Enable_SV()
        {
          
            txtHotenSv.Enabled = true;
            dtp_NgaySinh.Enabled = true;
            txtNoiSinh.Enabled = true;
            txtQueQuan.Enabled = true;
            cmbNganh_sv.Enabled = true;
            btnBrowseHinh.Enabled = true;
            rdNam.Enabled = true;
            rdNu.Enabled = true;
            btnXoa.Visible = true;
        }
       
        #endregion

        private void btnLuu_Click(object sender, EventArgs e)
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
            DTO_sv.SinhVien_MaNganh = cmbNganh_sv.SelectedValue.ToString();
            DTO_sv.SinhVien_Hinh = txtHinh.Text;
            DTO_sv.SinhVien_GioiTinh = gioitinh;
            DTO_sv.SinhVien_MaLop = cmbMaLop.SelectedValue.ToString();
            BUS_sv.CapNhatSinhVien(DTO_sv.SinhVien_MaSinhVien, DTO_sv.SinhVien_HoTen, DTO_sv.SinhVien_QueQuan, DTO_sv.SinhVien_NgaySinh, DTO_sv.SinhVien_NoiSinh, DTO_sv.SinhVien_GioiTinh, DTO_sv.SinhVien_Hinh, DTO_sv.SinhVien_MaLop, DTO_sv.SinhVien_MaNganh);
            dgvSinhVien.DataSource = userControl.dgv_SV.DataSource = BUS_sv.LoadDL();
           
            BUS_xuly.ClearAllTextBox(grouptextBox);
            DisEnable_SV();
            groupBox2.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            Enable_SV();
            groupBox2.Enabled = false;
            btnLuu.Visible = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
           
            DTO_sv.SinhVien_MaSinhVien = txtMSSV.Text;
            BUS_sv.XoaSinhVien(DTO_sv.SinhVien_MaSinhVien);
            dgvSinhVien.DataSource = userControl.dgv_SV.DataSource = BUS_sv.LoadDL();

            BUS_xuly.ClearAllTextBox(grouptextBox);          

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cmbDKTimKiem.Text == "-- Nhập điều kiện --")
            {
                MessageBox.Show("Chọn điều kiện tìm kiếm");
                return;
            }
            else
            {
              
               
                    if (cmbDKTimKiem.Text == "Tên Sinh Viên")

                    {
                        DTO_sv.FIELD = "HoTen";
                        DTO_sv.DKTIM = txtNoidungTimKiem.ToString();
                        
                        dgvSinhVien.DataSource = BUS_sv.TimKiemSV(DTO_sv.FIELD, DTO_sv.DKTIM);
                    int n = dgvSinhVien.Rows.Count - 1;
                        MessageBox.Show("Tìm thấy " + n + " kết quả! ");
                    }
                    else
                    {
                        DTO_sv.FIELD = "MaSinhVien";
                        DTO_sv.DKTIM = txtNoidungTimKiem.ToString();
                         dgvSinhVien.DataSource = BUS_sv.TimKiemSV(DTO_sv.FIELD, DTO_sv.DKTIM);
                         int n = dgvSinhVien.Rows.Count - 1;
                        MessageBox.Show("Tìm thấy " + n + " kết quả! ");
                    }
                
               
            }
          

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = BUS_sv.LoadDL();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMSSV.Text = dgvSinhVien.CurrentRow.Cells[0].Value.ToString();
            txtHotenSv.Text = dgvSinhVien.CurrentRow.Cells[1].Value.ToString();
            txtQueQuan.Text = dgvSinhVien.CurrentRow.Cells[2].Value.ToString();
            if ((dgvSinhVien.CurrentRow.Cells[3].Value.ToString() == ""))
                dtp_NgaySinh.Value = DateTime.Now;
            else
                dtp_NgaySinh.Value = (DateTime)dgvSinhVien.CurrentRow.Cells[3].Value;

            txtNoiSinh.Text = dgvSinhVien.CurrentRow.Cells[4].Value.ToString();

            if (dgvSinhVien.CurrentRow.Cells[5].Value.ToString() == "Nam")
            {
                rdNam.Checked = true;
            }
            else if (dgvSinhVien.CurrentRow.Cells[5].Value.ToString() == "Nữ")
            {
                rdNu.Checked = true;
            }
            else
            {
                rdNam.Checked = false;
                rdNu.Checked = false;
            }
            txtHinh.Text = dgvSinhVien.CurrentRow.Cells[6].Value.ToString();
            //pcHinhSV.ImageLocation = txtHinh.Text;
            //pcHinhSV.SizeMode = PictureBoxSizeMode.StretchImage;
            cmbMaLop.SelectedValue = dgvSinhVien.CurrentRow.Cells[7].Value.ToString();

            cmbNganh_sv.SelectedValue = dgvSinhVien.CurrentRow.Cells[8].Value.ToString();


        }

        

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = userControl.dgv_SV.DataSource = BUS_sv.LoadDL();

            DTO_sv.CMB = cmbNganh_sv;
            BUS_sv.LayDLVaoComboboxMaNganh(DTO_sv.CMB);
            DTO_sv.CMB = cmbMaLop;
            BUS_sv.LayDLVaoComboboxMaLop(DTO_sv.CMB);

            DisEnable_SV();
        }

     

        private void cmbDKTimKiem_TextChanged(object sender, EventArgs e)
        {
            DTO_sv.TXT = txtNoidungTimKiem;
            table = "SinhVien";      
            if (cmbDKTimKiem.SelectedItem.ToString() == "Mã số Sinh Viên")
                {
                    col = 0;
                    DTO_sv.COLUMN = col;
                    BUS_sv.TextBoxAutoComplete(DTO_sv.TXT, table, DTO_sv.COLUMN);
                }
            if (cmbDKTimKiem.SelectedItem.ToString() == "Tên Sinh Viên")
            {
                col = 1;
                DTO_sv.COLUMN = col;
                BUS_sv.TextBoxAutoComplete(DTO_sv.TXT, table, DTO_sv.COLUMN);

            }
        }

        #region chuẩn hoá
        private void txtNoidungTimKiem_TextChanged(object sender, EventArgs e)
        {

            txtNoidungTimKiem.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtNoidungTimKiem.Text);
            txtNoidungTimKiem.Select(txtNoidungTimKiem.Text.Length, 0);

        }

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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txtHinh.Text = openFileDialog1.FileName;
        }

        private void btnBrowseHinh_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
