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
    public class DAL_Nganh : DBConnect
    {
        public DataTable getNganh()
        {
            SqlCommand cmd = new SqlCommand("GiaoVien", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            _conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Nganh", _conn);
            DataTable dtNganh = new DataTable();
            da.Fill(dtNganh);
            _conn.Close();
            return dtNganh;
        }

        public void ThemNganh(DTO_Nganh nganh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("ThemNganh", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaNganh", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@TenNganh", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaNganh"].Value = nganh.Nganh_MaKhoa;
                cmd.Parameters["@TenNganh"].Value = nganh.Nganh_TenNganh;
                cmd.Parameters["@GhiChu"].Value = nganh.Nganh_GhiChu;
                cmd.Parameters["@MaKhoa"].Value = nganh.Nganh_MaKhoa;

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

        public void SuaNganh(DTO_Nganh nganh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SuaNganh", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaNganh", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@TenNganh", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaNganh"].Value = nganh.Nganh_MaKhoa;
                cmd.Parameters["@TenNganh"].Value = nganh.Nganh_TenNganh;
                cmd.Parameters["@GhiChu"].Value = nganh.Nganh_GhiChu;
                cmd.Parameters["@MaKhoa"].Value = nganh.Nganh_MaKhoa;

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

        public void XoaNganh(DTO_Nganh nganh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("XoaNganh", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaNganh", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@TenNganh", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaNganh"].Value = nganh.Nganh_MaKhoa;
                cmd.Parameters["@TenNganh"].Value = nganh.Nganh_TenNganh;
                cmd.Parameters["@GhiChu"].Value = nganh.Nganh_GhiChu;
                cmd.Parameters["@MaKhoa"].Value = nganh.Nganh_MaKhoa;

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
