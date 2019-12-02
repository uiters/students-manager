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
    public class DAL_Khoa : DBConnect
    {
        public DataTable getKhoa()
        {
            SqlCommand cmd = new SqlCommand("Khoa", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            _conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Khoa", _conn);
            DataTable dtKhoa = new DataTable();
            da.Fill(dtKhoa);
            _conn.Close();
            return dtKhoa;
        }

        public void ThemKhoa(DTO_Khoa khoa)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("ThemKhoa", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@TenKhoa", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@GhiChu", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 50);

                cmd.Parameters["@MaKhoa"].Value = khoa.Khoa_MaKhoa;
                cmd.Parameters["@TenKhoa"].Value = khoa.Khoa_TenKhoa;
                cmd.Parameters["@GhiChu"].Value = khoa.Khoa_GhiChu;
                cmd.Parameters["@Username"].Value = khoa.Khoa_Username;

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

        public void SuaKhoa(DTO_Khoa khoa)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SuaKhoa", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@TenKhoa", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@GhiChu", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 50);

                cmd.Parameters["@MaKhoa"].Value = khoa.Khoa_MaKhoa;
                cmd.Parameters["@TenKhoa"].Value = khoa.Khoa_TenKhoa;
                cmd.Parameters["@GhiChu"].Value = khoa.Khoa_GhiChu;
                cmd.Parameters["@Username"].Value = khoa.Khoa_Username;

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
        public void XoaKhoa(DTO_Khoa khoa)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("XoaKhoa", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaKhoa"].Value = khoa.Khoa_MaKhoa;

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
