using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLSV;
using DTO_QLSV;

namespace GUI_QLSV.Reports
{
    public partial class frmBaoCaoDiem : Form
    {
        BUS_Xuly BUS_xuly = new BUS_Xuly();
        DTO_Diem DTO_diem = new DTO_Diem();
        BUS_Diem BUS_diem = new BUS_Diem();


        public frmBaoCaoDiem()
        {
            InitializeComponent();
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            DTO_diem.Diem_MaSinhVien = txtMSSV.Text;           
<<<<<<< HEAD
            dgvDiem.DataSource = BUS_diem.TracuuDiem(DTO_diem.Diem_MaSinhVien);
            btnExel.Enabled = true;
=======
            dgvDiem.DataSource = BUS_diem.TracuuDiem(DTO_diem.Diem_MaSinhVien); 
>>>>>>> 64479447fd0f2e3d67c8c0f3cf19401ead19d87d
        }

        private void frmBaoCaoDiem_Load(object sender, EventArgs e)
        {
            dgvDiem.DataSource = BUS_diem.LayDLDiem();
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            int column;
            string table;
            table = "SinhVien";
            column = 0;
            DTO_diem.txtTIMMSV = txtMSSV;
            BUS_diem.GoiYMaSinhVien(DTO_diem.txtTIMMSV, table, column);
        }
<<<<<<< HEAD

        private void BtnExel_Click(object sender, EventArgs e)
        {
            DTO_diem.Diem_MaSinhVien = txtMSSV.Text;
            XemDiem excel = new XemDiem();
            // excel.Export(BUS_diem.LayDLDiem(), "Danh Sach", "Bảng Điểm");
            excel.Export(BUS_diem.TracuuDiem(DTO_diem.Diem_MaSinhVien), "Danh Sach", "Bảng Điểm");
        }
=======
>>>>>>> 64479447fd0f2e3d67c8c0f3cf19401ead19d87d
    }
}
