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
    public class DAL_SinhVien 
    {
       
        DAL_Xuly xuly = new DAL_Xuly();

        SqlParameter _SinhVien_MaSinhVien = new SqlParameter();
        SqlParameter _SinhVien_HoTen = new SqlParameter();
        SqlParameter _SinhVien_QueQuan = new SqlParameter();
        SqlParameter _SinhVien_NgaySinh = new SqlParameter();
        SqlParameter _SinhVien_NoiSinh = new SqlParameter();
        SqlParameter _SinhVien_GioiTinh = new SqlParameter();
        SqlParameter _SinhVien_MaNganh = new SqlParameter();
        SqlParameter _SinhVien_Hinh = new SqlParameter();
        SqlParameter _SinhVien_Lop = new SqlParameter();
        

      

        public void ThemSinhVien(string MaSv, string Hoten, string Quequan, DateTime Ngaysinh, string noisinh, string gioitinh, string hinh, string malop,string manganh)
        {


            _SinhVien_MaSinhVien.SqlValue = MaSv;
            _SinhVien_MaSinhVien.ParameterName = "@MaSinhVien";

            _SinhVien_HoTen.SqlValue = Hoten;
            _SinhVien_HoTen.ParameterName = "@Hoten";

            _SinhVien_QueQuan.SqlValue = Quequan;
            _SinhVien_QueQuan.ParameterName = "@QueQuan";

            _SinhVien_NgaySinh.SqlValue = Ngaysinh;
            _SinhVien_NgaySinh.ParameterName = "@Ngaysinh";

            _SinhVien_NoiSinh.SqlValue = noisinh;
            _SinhVien_NoiSinh.ParameterName = "@Noisinh";

            _SinhVien_GioiTinh.SqlValue = gioitinh;
            _SinhVien_GioiTinh.ParameterName = "@Gioitinh";

            _SinhVien_MaNganh.SqlValue = manganh;
            _SinhVien_MaNganh.ParameterName = "@MaNganh";

            _SinhVien_Hinh.SqlValue = hinh;
            _SinhVien_Hinh.ParameterName = "@Hinh";

            _SinhVien_Lop.SqlValue = malop;
            _SinhVien_Lop.ParameterName = "@MaLop";

            xuly.ThaoTacDuLieu("qlsv_ThemSinhVien", CommandType.StoredProcedure, _SinhVien_MaSinhVien, _SinhVien_HoTen, _SinhVien_QueQuan, _SinhVien_NgaySinh, _SinhVien_NoiSinh, _SinhVien_GioiTinh, _SinhVien_Hinh,_SinhVien_Lop, _SinhVien_MaNganh);
        }

        public void CapNhatSinhVien(string MaSv, string Hoten, string Quequan, DateTime Ngaysinh, string noisinh, string gioitinh, string hinh, string malop,string manganh)
        {

            _SinhVien_MaSinhVien.SqlValue = MaSv;
            _SinhVien_MaSinhVien.ParameterName = "@MaSinhVien";

            _SinhVien_HoTen.SqlValue = Hoten;
            _SinhVien_HoTen.ParameterName = "@Hoten";

            _SinhVien_QueQuan.SqlValue = Quequan;
            _SinhVien_QueQuan.ParameterName = "@QueQuan";

            _SinhVien_NgaySinh.SqlValue = Ngaysinh;
            _SinhVien_NgaySinh.ParameterName = "@Ngaysinh";

            _SinhVien_NoiSinh.SqlValue = noisinh;
            _SinhVien_NoiSinh.ParameterName = "@Noisinh";

            _SinhVien_GioiTinh.SqlValue = gioitinh;
            _SinhVien_GioiTinh.ParameterName = "@Gioitinh";

            _SinhVien_MaNganh.SqlValue = manganh;
            _SinhVien_MaNganh.ParameterName = "@MaNganh";

            _SinhVien_Hinh.SqlValue = hinh;
            _SinhVien_Hinh.ParameterName = "@Hinh";

            _SinhVien_Lop.SqlValue = malop;
            _SinhVien_Lop.ParameterName = "@MaLop";

            xuly.ThaoTacDuLieu("qlsv_CapNhatSinhVien", CommandType.StoredProcedure, _SinhVien_MaSinhVien, _SinhVien_HoTen, _SinhVien_QueQuan, _SinhVien_NgaySinh, _SinhVien_NoiSinh, _SinhVien_GioiTinh, _SinhVien_Hinh,_SinhVien_Lop, _SinhVien_MaNganh);
        }
        public void XoaSinhVien(string MaSv)
        {

             _SinhVien_MaSinhVien.SqlValue = MaSv;
            _SinhVien_MaSinhVien.ParameterName = "@MaSinhVien";

            xuly.ThaoTacDuLieu("qlsv_XoaSinhVien", CommandType.StoredProcedure, _SinhVien_MaSinhVien);
        }

        public string TaoMaSinhVien()
        {
            string msv;
            msv = xuly.SinhMaTuDong("SV", "Select * from SinhVien");
            return msv;
        }

        public DataTable LoadDL()
        {
            DataTable dt = new DataTable();
            dt = xuly.LayDanhSach("Select * from SinhVien");
            return dt;
        }

        public DataTable TimKiemSV(string field, string DKTim)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = xuly.LayDanhSach("Select * from  SinhVien where " + field + " = N'" + DKTim + "'");
            return dt;
        }

        public void LayMaNganhVaoComBoboxMaNganh(ComboBox cmb)
        {
            xuly.LoadDLVaoCombobox("Select * from Nganh", cmb, "TenNganh", "MaNganh");
        }
        public void LayMaNganhVaoComBoboxMaLop(ComboBox cmb)
        {
            xuly.LoadDLVaoCombobox("Select * from Lop", cmb, "TenLop", "MaLop");
        }

    }
}
