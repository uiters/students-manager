using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS_QLSV;
using DTO_QLSV;
namespace GUI_QLSV.Reports
{
    public partial class frmBaoCaoSinhVien : Form
    {
        BUS_Xuly BUS_Xuly = new BUS_Xuly();
        DTO_SinhVien DTO_SinhVien = new DTO_SinhVien();
        BUS_SinhVien BUS_SinhVien = new BUS_SinhVien();

        public frmBaoCaoSinhVien()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSinhVien_Load(object sender, EventArgs e)
        {
            BUS_SinhVien.LayDLVaoComboboxMaNganh(DTO_SinhVien.CMB=cmbKhoaHoc);
            BUS_SinhVien.LayDLVaoComboboxMaLop(DTO_SinhVien.CMB=cmbLop);
            dgvSinhVien.DataSource = BUS_SinhVien.LoadDL();
        }

        private void BtnDongY_Click(object sender, EventArgs e)
        {
            if(cmbKhoaHoc.Text!=null)
            {
                DTO_SinhVien.SinhVien_MaLop = cmbLop.SelectedValue.ToString();
                dgvSinhVien.DataSource = BUS_SinhVien.LoadDL();
                btnExcel.Enabled=true;
            }
            else
            {
                cmbLop.DisplayMember = "";
                MessageBox.Show("Không có môn học nào trong khóa này");
            }
        }
        private void cmbKhoa_SelectValueChanged(object sender, EventArgs e)
        {
            DTO_SinhVien.SinhVien_MaNganh = cmbKhoaHoc.SelectedValue.ToString();
            DTO_SinhVien.CMB = cmbLop;
            BUS_SinhVien.LayDLVaoComboboxMaLop(DTO_SinhVien.CMB);
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            DTO_SinhVien.CMB = cmbLop;
            SinhVien excel = new SinhVien();
            excel.Export(BUS_SinhVien.LoadDL(), "Danh sach", "Danh sách sinh viên");
        }

        private void CmbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
