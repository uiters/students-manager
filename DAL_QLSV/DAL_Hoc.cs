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
    public class DAL_Hoc : DBConnect
    {
        public DataTable getHoc()
        {
            SqlCommand cmd = new SqlCommand("Hoc", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            _conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hoc", _conn);
            DataTable dtHoc = new DataTable();
            da.Fill(dtHoc);
            _conn.Close();
            return dtHoc;
        }
        public void ThemHoc(DTO_Hoc hoc)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("ThemHoc", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaSinhVien"].Value =hoc.Hoc_MaSinhVien;
                cmd.Parameters["@MaLop"].Value = hoc.Hoc_MaLop;

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
        }
        public void SuaHoc(DTO_Hoc hoc)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SuaHoc", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaSinhVien"].Value = hoc.Hoc_MaSinhVien;
                cmd.Parameters["@MaLop"].Value = hoc.Hoc_MaLop;

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
        }
        public void XoaHoc(DTO_Hoc hoc)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("XoaHoc", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaSinhVien"].Value = hoc.Hoc_MaSinhVien;
                cmd.Parameters["@MaLop"].Value = hoc.Hoc_MaLop;

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
        }
    }
}
