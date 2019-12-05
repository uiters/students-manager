using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DTO_QLSV;

namespace DAL_QLSV
{
    public class DAL_MonHoc : DBConnect
    {
        DAL_Xuly xuly = new DAL_Xuly();

        SqlParameter _MonHoc_MaMonHoc = new SqlParameter();
        SqlParameter _MonHoc_TenMonHoc = new SqlParameter();       
        SqlParameter _MonHoc_LoaiMonHoc = new SqlParameter();      
        SqlParameter _MonHoc_TinChiLyThuyet = new SqlParameter();
        SqlParameter _MonHoc_TinChiThucHanh = new SqlParameter();
        SqlParameter _MonHoc_MaKhoa = new SqlParameter();

        public void ThemMonHoc(string mamh, string tenmh, bool hinhthuc , int sotietLT, int sotietTH, string makhoa)
        {
            _MonHoc_MaMonHoc.SqlValue = mamh;
            _MonHoc_MaMonHoc.ParameterName = "@MaMonHoc";

            _MonHoc_TenMonHoc.SqlValue = tenmh;
            _MonHoc_TenMonHoc.ParameterName = "@TenMonHoc";

            _MonHoc_MaKhoa.SqlValue = makhoa;
            _MonHoc_MaKhoa.ParameterName = "@MaKhoa";

            _MonHoc_LoaiMonHoc.SqlValue = hinhthuc;
            _MonHoc_LoaiMonHoc.ParameterName = "@HinhThuc";

            _MonHoc_TinChiLyThuyet.SqlValue = sotietLT;
            _MonHoc_TinChiLyThuyet.ParameterName = "@SoTietLyThuyet";

            _MonHoc_TinChiThucHanh.SqlValue = sotietTH;
            _MonHoc_TinChiThucHanh.ParameterName = "@SoTietThucHanh";

            xuly.ThaoTacDuLieu("qlsv_ThemMonHoc", CommandType.StoredProcedure, _MonHoc_MaMonHoc, _MonHoc_TenMonHoc, _MonHoc_LoaiMonHoc, _MonHoc_TinChiLyThuyet, _MonHoc_TinChiThucHanh,_MonHoc_MaKhoa);
        }


        public void CapNhatMonHoc(string mamh, string tenmh, bool hinhthuc, int sotietLT, int sotietTH, string makhoa)
        {
            _MonHoc_MaMonHoc.SqlValue = mamh;
            _MonHoc_MaMonHoc.ParameterName = "@MaMonHoc";

            _MonHoc_TenMonHoc.SqlValue = tenmh;
            _MonHoc_TenMonHoc.ParameterName = "@TenMonHoc";

            _MonHoc_MaKhoa.SqlValue = makhoa;
            _MonHoc_MaKhoa.ParameterName = "@MaKhoa";

            _MonHoc_LoaiMonHoc.SqlValue = hinhthuc;
            _MonHoc_LoaiMonHoc.ParameterName = "@HinhThuc";

            _MonHoc_TinChiLyThuyet.SqlValue = sotietLT;
            _MonHoc_TinChiLyThuyet.ParameterName = "@SoTietLyThuyet";

            _MonHoc_TinChiThucHanh.SqlValue = sotietTH;
            _MonHoc_TinChiThucHanh.ParameterName = "@SoTietThucHanh";

            xuly.ThaoTacDuLieu("qlsv_CapNhatMonHoc", CommandType.StoredProcedure, _MonHoc_MaMonHoc, _MonHoc_TenMonHoc, _MonHoc_LoaiMonHoc, _MonHoc_TinChiLyThuyet, _MonHoc_TinChiThucHanh, _MonHoc_MaKhoa);
        }

        public void XoaMonHoc(string mamh)
        {
            _MonHoc_MaMonHoc.SqlValue = mamh;
            _MonHoc_MaMonHoc.ParameterName = "@MaMonHoc";

            xuly.ThaoTacDuLieu("qlsv_XoaMonHoc", CommandType.StoredProcedure, _MonHoc_MaMonHoc);
        }

        public DataTable LoadDLMonHoc()
        {
            DataTable dt = new DataTable();
            dt = xuly.LayDanhSach("Select * from MonHoc");
            return dt;
        }

        public string TaoMaMonHoc()
        {
            string ma = "";
            ma = xuly.SinhMaTuDong("MH", "Select * from MonHoc");
            return ma;
        }

        public void LoadDLVaoComboboxMaKhoa_MH(ComboBox cmb)
        {
            xuly.LoadDLVaoCombobox("Select * from Khoa", cmb, "TenKhoa", "MaKhoa");
        }


        //sử dụng cho hàm kiểm tra tên môn học đã tồn tại hay chưa bên class qlsv_xMonhoc.cs
        public string LayTenMonHoc(string Tenmonhoc)
        {
            string ten = "";

            ten = xuly.LayTen("Select TenMonHoc From MonHoc Where TenMonHoc ='" + Tenmonhoc + "'");
            return ten;
        }

        // tìm kiếm môn học
        public DataTable TimKiemMonHoc(string CotTim, string DKTim)
        {
            DataTable dt = new DataTable();
            dt = xuly.LayDanhSach("Select * from MonHoc where " + CotTim + " = N'" + DKTim + "'");
            return dt;
        }

      


    }
}
