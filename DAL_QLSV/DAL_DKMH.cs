using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QLSV;
using System.Windows.Forms;

namespace DAL_QLSV
{
    public class DAL_DKMH
    {
        DAL_Xuly xuly = new DAL_Xuly();
        public DataTable LoadDL_DKMonHoc()
        {
            DataTable dt = new DataTable();
            dt = xuly.LayDanhSach("Select * from DK_MonHoc");
            return dt;
        }

        public DataTable TimKiemMHDK(string MaSV)
        {
            DataTable dt = new DataTable();
            dt = xuly.LayDanhSach("Select * from DK_MonHoc where MaSinhVien = '" + MaSV + "'");
            return dt;
        }

        public void LoadDLVaoCombobox(ComboBox cmb)
        {
            xuly.LoadDLVaoCombobox("Select * from MonHoc", cmb, "TenMonHoc", "MaMonHoc");
        }



        public string LayTenSV(string Masv)
        {
            string ten = "";
            ten = xuly.LayTen("Select Hoten from SinhVien Where MaSinhVien = '" + Masv + "'");
            return ten;
        }
    }
}
