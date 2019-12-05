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
    public class DAL_Diem 
    {
        DAL_Xuly xuly = new DAL_Xuly();

        SqlParameter _MaMH = new SqlParameter();
        SqlParameter _Masv = new SqlParameter();
        SqlParameter _SoDiem= new SqlParameter();
        SqlParameter _Lanthi = new SqlParameter();


        public DataTable LayDuLieuKhoa()
        {
            DataTable dt = new DataTable();

            dt = xuly.LayDanhSach("Select * from Khoa");
            return dt;
        }



        public void NhapDiem(string mamh, string masv, float sodiem, int lanthi)
           
        {
            _MaMH.SqlValue = mamh;
            _MaMH.ParameterName = "@MaMonHoc";

            _Masv.SqlValue = masv;
            _Masv.ParameterName = "@MaSV";

            _SoDiem.SqlValue = sodiem;
            _SoDiem.ParameterName = "@SoDiem";

            _Lanthi.SqlValue = lanthi;
            _Lanthi.ParameterName = "@LanThi";



            xuly.ThaoTacDuLieu("qlsv_NhapDiem", CommandType.StoredProcedure, _MaMH, _Masv, _SoDiem, _Lanthi);

        }

        public DataTable LayDLDiem()
        {
            DataTable dt = new DataTable();
            dt = xuly.LayDanhSach("Select * from Diem");
            return dt;
        }
        public void XoaDiem(string MaMH, String MaSV)
        {
            _MaMH.SqlValue = MaMH;
            _MaMH.ParameterName = "@MaMonHoc";

            _Masv.SqlValue = MaSV;
            _Masv.ParameterName = "@MaSV";

            xuly.ThaoTacDuLieu("qlsv_XoaDiem", CommandType.StoredProcedure, _MaMH, _Masv);
        }

        public void CapNhatDiem(string mamh, string masv, float sodiem, int lanthi)
        { 
           _MaMH.SqlValue = mamh;
            _MaMH.ParameterName = "@MaMonHoc";

            _Masv.SqlValue = masv;
            _Masv.ParameterName = "@MaSV";

            _SoDiem.SqlValue = sodiem;
            _SoDiem.ParameterName = "@SoDiem";

            _Lanthi.SqlValue = lanthi;
            _Lanthi.ParameterName = "@LanThi";

            xuly.ThaoTacDuLieu("qlsv_CapNhatDiem", CommandType.StoredProcedure, _MaMH, _Masv, _SoDiem, _Lanthi);
        }

        public DataTable TimKiemDiem(string masv)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = xuly.LayDanhSach("Select * from Diem where MaSv = '" + masv + "'");
            return dt;
        }

        //lấy danh sách môn học vào listbox
        public void LoadDLVaoListBox(ListBox lb, string makhoa)
        {

            try
            {
                lb.DataSource = xuly.LayDanhSach("Select * from MonHoc where MaKhoa = '" + makhoa + "'");
                lb.DisplayMember = "TenMonHoc";
                lb.ValueMember = "MaMonHoc";
            }
            catch
            {
                MessageBox.Show("Có lỗi khi lấy danh sách môn học");
            }
        }

    
    }
}
