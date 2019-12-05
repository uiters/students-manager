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
    public class DAL_Nganh 
    {
        DAL_Xuly xuly = new DAL_Xuly();

        SqlParameter _MaNganh = new SqlParameter();
        SqlParameter _TenNganh = new SqlParameter();
        SqlParameter _Ghichu = new SqlParameter();
        SqlParameter _MaKhoa = new SqlParameter();

        public void ThemNganh(string manganh, string tennganh, string ghichu,string makhoa)
        {
            _MaNganh.SqlValue = manganh;
            _MaNganh.ParameterName = "@MaNganh";

            _TenNganh.SqlValue = tennganh;
            _TenNganh.ParameterName = "@TenNganh";

            _Ghichu.SqlValue = ghichu;
            _Ghichu.ParameterName = "@Ghichu";

            _Ghichu.SqlValue = ghichu;
            _Ghichu.ParameterName = "@MaKhoa";

            xuly.ThaoTacDuLieu("qlsv_ThemNganh", CommandType.StoredProcedure, _MaNganh, _TenNganh, _Ghichu,_MaKhoa);

        }
        public void CapNhatNganh(string manganh, string tennganh, string ghichu, string makhoa)
        {
            _MaNganh.SqlValue = manganh;
            _MaNganh.ParameterName = "@MaNganh";

            _TenNganh.SqlValue = tennganh;
            _TenNganh.ParameterName = "@TenNganh";

            _Ghichu.SqlValue = ghichu;
            _Ghichu.ParameterName = "@Ghichu";

            _Ghichu.SqlValue = ghichu;
            _Ghichu.ParameterName = "@MaKhoa";

            xuly.ThaoTacDuLieu("qlsv_CapNhatNganh", CommandType.StoredProcedure, _MaNganh, _TenNganh, _Ghichu, _MaKhoa);


        }

        public void XoaNganh(string manganh)
        {
            _MaNganh.SqlValue = manganh;
            _MaNganh.ParameterName = "@MaNganh";

            xuly.ThaoTacDuLieu("qlsv_XoaNganh", CommandType.StoredProcedure, _MaNganh);
        }

        public DataTable LoadDL()
        {
            DataTable dt = new DataTable();
            dt = xuly.LayDanhSach("Select * from Nganh");

            return dt;
        }

        public string TaoMaNganh()
        {
            string maNG = "";
            maNG = xuly.SinhMaTuDong("NG", "Select * from Nganh");
            return maNG;
        }
    }
}
