using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QLSV;

namespace DAL_QLSV
{
    public class DAL_Khoa : DBConnect
    {
        DAL_Xuly xuly = new DAL_Xuly();
        SqlParameter _MaKhoa = new SqlParameter();
        SqlParameter _TenKhoa = new SqlParameter();
        SqlParameter _Ghichu = new SqlParameter();
        SqlParameter _MaKhoa_UserName = new SqlParameter();
        public void ThemKhoa(string makhoa, string tenkhoa, string ghichu,string username)
        {
            _MaKhoa.SqlValue = makhoa;
            _MaKhoa.ParameterName = "@MaKhoa";

            _TenKhoa.SqlValue = tenkhoa;
            _TenKhoa.ParameterName = "@TenKhoa";

            _Ghichu.SqlValue = ghichu;
            _Ghichu.ParameterName = "@GhiChu";

            _MaKhoa_UserName.SqlValue = username;
            _MaKhoa_UserName.ParameterName = "@Username";


            xuly.ThaoTacDuLieu("qlsv_ThemKhoa", CommandType.StoredProcedure, _MaKhoa, _TenKhoa, _Ghichu,_MaKhoa_UserName);
        }



        public void CapNhatKhoa(string makhoa, string tenkhoa, string ghichu, string username)
        {
            _MaKhoa.SqlValue = makhoa;
            _MaKhoa.ParameterName = "@MaKhoa";

            _TenKhoa.SqlValue = tenkhoa;
            _TenKhoa.ParameterName = "@TenKhoa";

            _Ghichu.SqlValue = ghichu;
            _Ghichu.ParameterName = "@GhiChu";

            _MaKhoa_UserName.SqlValue = username;
            _MaKhoa_UserName.ParameterName = "@Username";


            xuly.ThaoTacDuLieu("qlsv_CapNhatKhoa", CommandType.StoredProcedure, _MaKhoa, _TenKhoa, _Ghichu, _MaKhoa_UserName);
        }

        public void XoaKhoa(string makhoa)
        {
            _MaKhoa.SqlValue = makhoa;
            _MaKhoa.ParameterName = "@MaKhoa";

            xuly.ThaoTacDuLieu("qlsv_XoaKhoa", CommandType.StoredProcedure, _MaKhoa);
        }

        public DataTable LoadDLKhoa()
        {
            DataTable dt = new DataTable();
            dt = xuly.LayDanhSach("Select MaKhoa,TenKhoa,GhiChu from Khoa");
            return dt;
        }

        public string TaoMaKhoa()
        {
            string ma;
            ma = xuly.SinhMaTuDong("KA", "Select * from Khoa");
            return ma;
        }
    }
}
