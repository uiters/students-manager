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
            dgvDiem.DataSource = BUS_diem.TracuuDiem(DTO_diem.Diem_MaSinhVien); 
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
    }
}
