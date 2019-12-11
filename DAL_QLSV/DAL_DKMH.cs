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
            dt = xuly.LayDanhSach("select MonHoc.MaMonHoc,sinhvien.MaSinhVien,HoTen,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh from (DKMH full join SinhVien on DKMH.MaSinhVien=SinhVien.MaSinhVien) full join MonHoc on MonHoc.MaMonHoc=DKMH.MaMonHoc");
            return dt;
        }

        public DataTable TimKiemMHDK(string MaSV)
        {
            DataTable dt = new DataTable();
           // dt = xuly.LayDanhSach("Select * from DK_MonHoc where MaSinhVien = '" + MaSV + "'");
            dt = xuly.LayDanhSach("select MonHoc.MaMonHoc,sinhvien.MaSinhVien,HoTen,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh from (DKMH full join SinhVien on DKMH.MaSinhVien=SinhVien.MaSinhVien) full join MonHoc on MonHoc.MaMonHoc=DKMH.MaMonHoc having MaSinhVien '"+ MaSV +"'");
            return dt;
        }


        public string LayTenSV(string Masv)
        {
            string ten = "";
            ten = xuly.LayTen("Select Hoten from SinhVien Where HoTen = '" + Masv + "'");
            return ten;
        }
    }
}
