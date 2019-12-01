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
    public class DAL_Lop : DBConnect
    {
        public DataTable getLop()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOP", _conn);
            DataTable dtLop = new DataTable();
            da.Fill(dtLop);
            return dtLop;
        }
        public bool ThemLop(DTO_Lop lop)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("INSERT INTO lOP(MaLop, TenLop, LoaiLop, NienKhoa, NgayBatDau, NgayKetThuc, MaMonHoc, MaGiaoVien) VALUE('','','','','','','','')",lop.MaLop,lop.TenLop,lop.LoaiLop,lop.NienKhoa,lop.NgayBatDau,lop.NgayKetThuc,lop.MaMonHoc,lop.MaGiaoVien);

                SqlCommand cmd = new SqlCommand(SQL,_conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        public bool SuaLop(DTO_Lop lop)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("UPDATE lOP SET TenLop='', LoaiLop='', NienKhoa='', NgayBatDau='', NgayKetThuc='', MaMonHoc='', MaGiaoVien=''WHERE  MaLop=''", lop.TenLop, lop.LoaiLop, lop.NienKhoa, lop.NgayBatDau, lop.NgayKetThuc, lop.MaMonHoc, lop.MaGiaoVien, lop.MaLop);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        public bool XoaLop(DTO_Lop lop)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM lOP WHERE MaLop=''", lop.MaLop);
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
    }


}
