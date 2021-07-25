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
    public class DAL_Lop : DBConnect
    {
        DAL_Xuly xuly = new DAL_Xuly();

        SqlParameter _Lop_MaLop = new SqlParameter();
        SqlParameter _Lop_TenLop = new SqlParameter();
        SqlParameter _Lop_LoaiLop = new SqlParameter();
        SqlParameter _Lop_NienKhoa = new SqlParameter();
        SqlParameter _Lop_NgayBatDau = new SqlParameter();
        SqlParameter _Lop_NgayKetThuc = new SqlParameter();
        SqlParameter _Lop_MaMonHoc = new SqlParameter();
        SqlParameter _Lop_MaGiaoVien = new SqlParameter();

        public void ThemLop(string malop, string tenlop, bool loailop, string nienkhoa, DateTime BD,DateTime KT,string mamh,string magv)
        {
            _Lop_MaLop.SqlValue = malop;
            _Lop_MaLop.ParameterName = "@MaLop";

            _Lop_TenLop.SqlValue = tenlop;
            _Lop_TenLop.ParameterName = "@TenLop";

            _Lop_LoaiLop.SqlValue = loailop;
            _Lop_LoaiLop.ParameterName = "@LoaiLop";

            _Lop_NienKhoa.SqlValue = nienkhoa;
            _Lop_NienKhoa.ParameterName = "@NienKhoa";

            _Lop_NgayBatDau.SqlValue = BD;
            _Lop_NgayBatDau.ParameterName = "@NgayBatDau";

            _Lop_NgayKetThuc.SqlValue = KT;
            _Lop_NgayKetThuc.ParameterName = "@NgayKetThuc";

            _Lop_MaMonHoc.SqlValue = mamh;
            _Lop_MaMonHoc.ParameterName = "@MaMonHoc";

            _Lop_MaGiaoVien.SqlValue = magv;
            _Lop_MaGiaoVien.ParameterName = "@MaGiaoVien";



            xuly.ThaoTacDuLieu("qlsv_ThemLop", CommandType.StoredProcedure, _Lop_MaLop, _Lop_TenLop, _Lop_LoaiLop, _Lop_NienKhoa, _Lop_NgayBatDau, _Lop_NgayKetThuc,_Lop_MaMonHoc,_Lop_MaGiaoVien);


        }

        public void CapNhatLop(string malop, string tenlop, bool loailop, string nienkhoa, DateTime BD, DateTime KT, string mamh, string magv)
        {
            _Lop_MaLop.SqlValue = malop;
            _Lop_MaLop.ParameterName = "@MaLop";

            _Lop_TenLop.SqlValue = tenlop;
            _Lop_TenLop.ParameterName = "@TenLop";

            _Lop_LoaiLop.SqlValue = loailop;
            _Lop_LoaiLop.ParameterName = "@LoaiLop";

            _Lop_NienKhoa.SqlValue = nienkhoa;
            _Lop_NienKhoa.ParameterName = "@NienKhoa";

            _Lop_NgayBatDau.SqlValue = BD;
            _Lop_NgayBatDau.ParameterName = "@NgayBatDau";

            _Lop_NgayKetThuc.SqlValue = KT;
            _Lop_NgayKetThuc.ParameterName = "@NgayKetThuc";

            _Lop_MaMonHoc.SqlValue = mamh;
            _Lop_MaMonHoc.ParameterName = "@MaMonHoc";

            _Lop_MaGiaoVien.SqlValue = magv;
            _Lop_MaGiaoVien.ParameterName = "@MaGiaoVien";


            xuly.ThaoTacDuLieu("qlsv_CapNhatLop", CommandType.StoredProcedure, _Lop_MaLop, _Lop_TenLop, _Lop_LoaiLop, _Lop_NienKhoa, _Lop_NgayBatDau, _Lop_NgayKetThuc, _Lop_MaMonHoc, _Lop_MaGiaoVien);


        }

        public void XoaLop(string malop)
        {
            _Lop_MaLop.SqlValue = malop;
            _Lop_MaLop.ParameterName = "@MaLop";
            xuly.ThaoTacDuLieu("qlsv_XoaLop", CommandType.StoredProcedure, _Lop_MaLop);

        }

        public DataTable LoadDL()
        {
            DataTable dt = new DataTable();
            dt = xuly.LayDanhSach("Select * from Lop");
            return dt;
        }

        public string TaoMaLop()
        {
            string ma;
            ma = xuly.SinhMaTuDong("LP", "Select * from Lop");
            return ma;
        }

        public void LayDLVaoCombobox_MaGiaoVien(ComboBox cmb)
        {
            xuly.LoadDLVaoCombobox("Select * from GiaoVien", cmb, "TenGiaoVien", "MaGiaoVien");
        }

        public void LayDLVaoCombobox_MaMonHoc(ComboBox cmb)
        {
            xuly.LoadDLVaoCombobox("Select * from MonHoc", cmb, "TenMonHoc", "MaMonHoc");
        }

        public DataTable TimKiemLop(string cotTim, string DKTim,string table)
        {
            DataTable dt = new DataTable();
            dt = xuly.LayDanhSach("Select * from "+table+" Where " + cotTim + " = '" + DKTim + "'");
            return dt;
        }

     
    }
}



