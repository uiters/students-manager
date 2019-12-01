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
    public class DAL_MonHoc : DBConnect
    {
        public DataTable getMonHoc()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MonHoc", _conn);
            DataTable dtMonHoc = new DataTable();
            da.Fill(dtMonHoc);
            return dtMonHoc;
        }

        public bool ThemMonHoc(DTO_MonHoc mh)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("INSERT INTO MonHoc(MaMonHoc, TenMonHoc, LoaiMonHoc, TinChiLyThuyet, TinChiThucHanh, MaKhoa) VALUE ('','','','','','')", mh.MonHoc_MaMonHoc, mh.MonHoc_TenMonHoc, mh.MonHoc_LoaiMonHoc, mh.MonHoc_TinChiLyThuyet, mh.MonHoc_TinChiThucHanh, mh.MonHoc_MaKhoa);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool SuaMonHoc(DTO_MonHoc mh)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("UPDATE MonHoc SET TenMonHoc='', LoaiMonHoc='', TinChiLyThuyet='', TinChiThucHanh='',MaKhoa='' WHERE MaMonHoc=''", mh.MonHoc_TenMonHoc, mh.MonHoc_LoaiMonHoc, mh.MonHoc_TinChiLyThuyet, mh.MonHoc_TinChiThucHanh, mh.MonHoc_MaKhoa, mh.MonHoc_MaMonHoc);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool XoaMonHoc(DTO_MonHoc mh)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("DELETE FROM MonHoc WHERE MaMonHoc=''",mh.MonHoc_MaMonHoc);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }


    }
}
