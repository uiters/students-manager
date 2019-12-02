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

        public DataTable getMonHoc()
        {
            SqlCommand cmd = new SqlCommand("MonHoc", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            _conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MonHoc", _conn);
            da.SelectCommand = cmd;
            DataTable dtMonHoc = new DataTable();
            da.Fill(dtMonHoc);
            _conn.Close();
            return dtMonHoc;
        }

        public void ThemMonHoc(DTO_MonHoc mh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("ThemMonHoc", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@TenMonHoc", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@LoaiMonHoc", SqlDbType.Bit);
                cmd.Parameters.Add("@TinChiLyThuyet", SqlDbType.Int);
                cmd.Parameters.Add("@TinChiThuchanh", SqlDbType.Int);
                cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 50);
                cmd.Parameters["@MaMonHoc"].Value = mh.MonHoc_MaMonHoc;
                cmd.Parameters["@TenMonHoc"].Value = mh.MonHoc_TenMonHoc;
                cmd.Parameters["@LoaiMonHoc"].Value = mh.MonHoc_LoaiMonHoc;
                cmd.Parameters["@TinChiLyThuyet"].Value = mh.MonHoc_TinChiLyThuyet;
                cmd.Parameters["@TinChiThucHanh"].Value = mh.MonHoc_TinChiThucHanh;
                cmd.Parameters["@MaKhoa"].Value = mh.MonHoc_MaKhoa;
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
        }

        public void SuaMonHoc(DTO_MonHoc mh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SuaMonHoc", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@TenMonHoc", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@LoaiMonHoc", SqlDbType.Bit);
                cmd.Parameters.Add("@TinChiLyThuyet", SqlDbType.Int);
                cmd.Parameters.Add("@TinChiThuchanh", SqlDbType.Int);
                cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 50);
                cmd.Parameters["@MaMonHoc"].Value = mh.MonHoc_MaMonHoc;
                cmd.Parameters["@TenMonHoc"].Value = mh.MonHoc_TenMonHoc;
                cmd.Parameters["@LoaiMonHoc"].Value = mh.MonHoc_LoaiMonHoc;
                cmd.Parameters["@TinChiLyThuyet"].Value = mh.MonHoc_TinChiLyThuyet;
                cmd.Parameters["@TinChiThucHanh"].Value = mh.MonHoc_TinChiThucHanh;
                cmd.Parameters["@MaKhoa"].Value = mh.MonHoc_MaKhoa;
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
        }

        public void XoaMonHoc(DTO_MonHoc mh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("XoaMonHoc", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaMonHoc"].Value = mh.MonHoc_MaMonHoc;

                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
        }



    }
}
