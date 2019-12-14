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
            dt = xuly.LayDanhSach("select MonHoc.TenMonHoc,sinhvien.MaSinhVien,SinhVien.HoTen,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh  from (Diem right join SinhVien on Diem.MaSinhVien=SinhVien.MaSinhVien) left join MonHoc on MonHoc.MaMonHoc=Diem.MaMonHoc ");
            return dt;
        }
        public DataTable TimKiemSV(string field, string DKTim)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = xuly.LayDanhSach("select MonHoc.TenMonHoc,sinhvien.MaSinhVien,SinhVien.HoTen,MonHoc.TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh  from (Diem right join SinhVien on Diem.MaSinhVien=SinhVien.MaSinhVien) left join MonHoc on MonHoc.MaMonHoc=Diem.MaMonHoc  where " + field + " = N'" + DKTim + "'");
            return dt;
        }
        //public DataTable TimKiemMHDK(string MaSV)
        //{
        //    DataTable dt = new DataTable();

        //    // dt = xuly.LayDanhSach("Select * from DK_MonHoc where MaSinhVien = '" + MaSV + "'");
        //    dt = xuly.LayDanhSach("select MonHoc.MaMonHoc,sinhvien.MaSinhVien,HoTen,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh from (DKMH right join SinhVien on DKMH.MaSinhVien=SinhVien.MaSinhVien) left join MonHoc on MonHoc.MaMonHoc=DKMH.MaMonHoc where MaSinhVien '" + MaSV +"'");
        //    return dt;
        //}


        //public DataTable LayTenSV(string hoten)
        //{
        //    DataTable dt = new DataTable();

        //    // dt = xuly.LayDanhSach("Select * from DK_MonHoc where MaSinhVien = '" + MaSV + "'");
        //    dt = xuly.LayDanhSach("select MonHoc.MaMonHoc,sinhvien.MaSinhVien,HoTen,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh from (DKMH right join SinhVien on DKMH.MaSinhVien=SinhVien.MaSinhVien) left join MonHoc on MonHoc.MaMonHoc=DKMH.MaMonHoc where HoTen '" + hoten + "'");
        //    return dt;
        //}
    }
}
