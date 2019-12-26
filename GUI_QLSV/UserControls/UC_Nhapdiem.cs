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
    public partial class UC_Nhapdiem : UserControl
    {
        public UC_Nhapdiem()
        {
            InitializeComponent();
        }

        DTO_Diem DTO_diem = new DTO_Diem();
        BUS_Diem BUS_diem = new BUS_Diem();
        BUS_Xuly BUS_xuly = new BUS_Xuly();
        string table = "";
        int column = 0;
        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = dgvDiem.CurrentRow.Cells[0].Value.ToString();
            txtMaSV.Text = dgvDiem.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
           DTO_diem.MSSV = txtTimKiem_MSSV.Text;
           dgvDiem.DataSource = BUS_diem.TracuuDiem(DTO_diem.MSSV);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_diem.Diem_MaMonHoc = txtMaMH.Text;
            DTO_diem.Diem_MaSinhVien = txtMaSV.Text;
            if (txtDiem.Text == null)
            {

                DTO_diem.Diem_SoDiem = 0;
            }
            else
            {
                DTO_diem.Diem_SoDiem = float.Parse(txtDiem.Text);
            }
            if (txtLanThi.Text == null)
            {
                DTO_diem.Diem_LanThi = 0;
            }
            else
            {
                DTO_diem.Diem_SoDiem = float.Parse(txtLanThi.Text);
            }

            BUS_diem.CapNhatDiem(DTO_diem.Diem_MaMonHoc, DTO_diem.Diem_MaSinhVien, DTO_diem.Diem_SoDiem, DTO_diem.Diem_LanThi);

            dgvDiem.DataSource = BUS_diem.LayDLDiem();
            BUS_xuly.ClearAllTextBox(groupBox3);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_diem.Diem_MaMonHoc = txtMaMH.Text;
            DTO_diem.Diem_MaSinhVien = txtMaSV.Text;
            BUS_diem.XoaDiem(DTO_diem.Diem_MaMonHoc, DTO_diem.Diem_MaSinhVien);
            //refresh lai du lieu
            dgvDiem.DataSource = BUS_diem.LayDLDiem();
            BUS_xuly.ClearAllTextBox(groupBox3);
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaMH.Enabled = false;
            DTO_diem.Diem_MaMonHoc = txtMaMH.Text;
            DTO_diem.Diem_MaSinhVien = txtMaSV.Text;
            if (txtDiem.Text == null)
            {
                
                DTO_diem.Diem_SoDiem = 0;
            }
            else
            {
                DTO_diem.Diem_SoDiem = float.Parse(txtDiem.Text);
            }
            if (txtLanThi.Text == null)
            {
                DTO_diem.Diem_LanThi = 0;
            }
              else
            {
                DTO_diem.Diem_SoDiem = float.Parse(txtLanThi.Text);
            }

            BUS_diem.NhapDiem(DTO_diem.Diem_MaMonHoc, DTO_diem.Diem_MaSinhVien, DTO_diem.Diem_SoDiem, DTO_diem.Diem_LanThi);

            dgvDiem.DataSource = BUS_diem.LayDLDiem();
            BUS_xuly.ClearAllTextBox(groupBox3);
        }

        private void UC_Nhapdiem_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = BUS_diem.LayDuLieuKhoa();
            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "MaKhoa";
            dgvDiem.DataSource = BUS_diem.LayDLDiem();

            
            table = "SinhVien";
            column = 0;
            DTO_diem.txtTIMMSV = txtTimKiem_MSSV;
            BUS_diem.GoiYMaSinhVien(DTO_diem.txtTIMMSV,table,column);
            BUS_diem.LayDanhSachMonHocVaoListBox(lbMonHoc, cmbKhoa.SelectedValue.ToString());
        }

        private void cmbKhoa_TextChanged(object sender, EventArgs e)
        {
            BUS_diem.LayDanhSachMonHocVaoListBox(lbMonHoc, cmbKhoa.SelectedValue.ToString());
            dgvDiem.DataSource = BUS_diem.LayDLDiem();
        }

        private void lbMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbMonHoc.SelectedValue != null)
            {
                txtMaMH.Text = lbMonHoc.SelectedValue.ToString();
                groupBox3.Enabled = true;
            }
        }
    }
}
