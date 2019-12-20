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

namespace GUI_QLSV.Reports
{
    public partial class frmBaoCaoMonHoc : Form
    {
        BUS_Xuly BUS_Xuly = new BUS_Xuly();
        BUS_MonHoc BUS_MonHoc = new BUS_MonHoc();
        DTO_MonHoc DTO_MonHoc = new DTO_MonHoc();
        public frmBaoCaoMonHoc()
        {
            InitializeComponent();
        }

        private void BtnDongY_Click(object sender, EventArgs e)
        {
            DTO_MonHoc.MonHoc_MaKhoa = cmbKhoa.SelectedValue.ToString();
            dgvMonHoc.DataSource = BUS_MonHoc.LoadDLMonHoc();
            btnExcel.Enabled = true;
        }
        private void frmBaoCaoMonHoc_Load(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = BUS_MonHoc.LoadDLMonHoc();
            DTO_MonHoc.CMB = cmbKhoa;
            BUS_MonHoc.LoadDLVaoCombobox_cmbMaKhoa_MH(DTO_MonHoc.CMB);
       
        }
        //load du lieu tu db len cmb
        private void BtnExcel_Click(object sender, EventArgs e)
        {
            DTO_MonHoc.MonHoc_MaKhoa = cmbKhoa.SelectedValue.ToString();
            MonHoc excel = new MonHoc();
            excel.Export(BUS_MonHoc.LoadDLMonHoc(), "Danh sach", "Danh sách môn học");
        }
    }
}
