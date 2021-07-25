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
    public class DAL_GiaoVien 
    {
        DAL_Xuly xuly = new DAL_Xuly(); 

        SqlParameter _Magiaovien = new SqlParameter();
        SqlParameter _Tengiaovien = new SqlParameter();
        SqlParameter _Makhoa = new SqlParameter();
        SqlParameter _Ghichu = new SqlParameter();

        public void ThemGiaoVien(string magv, string tengv,  string ghichu,string makhoa)
        {
            _Magiaovien.SqlValue = magv;
            _Magiaovien.ParameterName = "@Magiaovien";

            _Tengiaovien.SqlValue = tengv;
            _Tengiaovien.ParameterName = "@TenGiaoVien";

            _Ghichu.SqlValue = ghichu;
            _Ghichu.ParameterName = "@GhiChu";


            _Makhoa.SqlValue = makhoa;
            _Makhoa.ParameterName = "@MaKhoa";

            xuly.ThaoTacDuLieu("qlsv_ThemGiaoVien", CommandType.StoredProcedure, _Magiaovien, _Tengiaovien, _Ghichu, _Makhoa);
        }

        public void CapNhatGiaoVien(string magv, string tengv,  string ghichu, string makhoa)
        {
            _Magiaovien.SqlValue = magv;
            _Magiaovien.ParameterName = "@Magiaovien";

            _Tengiaovien.SqlValue = tengv;
            _Tengiaovien.ParameterName = "@TenGiaoVien";

            _Ghichu.SqlValue = ghichu;
            _Ghichu.ParameterName = "@GhiChu";

            _Makhoa.SqlValue = makhoa;
            _Makhoa.ParameterName = "@MaKhoa";

            xuly.ThaoTacDuLieu("qlsv_CapNhatGiaoVien", CommandType.StoredProcedure, _Magiaovien, _Tengiaovien,  _Ghichu, _Makhoa);
        }

        public void XoaGiaoVien(string magv)
        {
            _Magiaovien.SqlValue = magv;
            _Magiaovien.ParameterName = "@Magiaovien";

            xuly.ThaoTacDuLieu("qlsv_XoaGiaoVien", CommandType.StoredProcedure, _Magiaovien);
        }

        public DataTable LoadDL_GiaoVien()
        {
            DataTable dt = new DataTable();
            dt = xuly.LayDanhSach("Select * from GiaoVien");
            return dt;
        }

        public string TaoMaGiaoVien()
        {
            string ma = "";
            ma = xuly.SinhMaTuDong("GV", "Select * from GiaoVien");
            return ma;
        }

        public void LayDLVaoCombobox_MaKhoa(ComboBox cmb)
        {
            xuly.LoadDLVaoCombobox("Select * from Khoa", cmb, "TenKhoa", "MaKhoa");

        }

        public DataTable TimKiemGiaoVien(string columnName, string DuLieuTim)   
        {
            DataTable dt = new DataTable();
            dt = xuly.LayDanhSach("Select * from GiaoVien where " + columnName + " = N'" + DuLieuTim + "'");
            return dt;
        }

       
    }
}

