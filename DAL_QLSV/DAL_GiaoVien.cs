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
    public class DAL_GiaoVien : DBConnect
    {
        public DataTable getGiaoVien()
        {
            SqlCommand cmd = new SqlCommand("GiaoVien", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            _conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM GiaoVien", _conn);
            DataTable dtGiaoVien = new DataTable();
            da.Fill(dtGiaoVien);
            _conn.Close();
            return dtGiaoVien;
        }

        public void ThemGiaoVien(DTO_GiaoVien gv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("ThemGiaoVien", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaGiaoVien", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@TenGiaoVien", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 50);

                cmd.Parameters["@MaGiaoVien"].Value = gv.GiaoVien_MaGiaoVien;
                cmd.Parameters["@TenGiaoVien"].Value = gv.GiaoVien_TenGiaoVien;
                cmd.Parameters["@GhiChu"].Value = gv.GiaoVien_GhiChu;
                cmd.Parameters["@MaKhoa"].Value = gv.GiaoVien_MaKhoa;

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
        public void SuaGiaoVien(DTO_GiaoVien gv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SuaGiaoVien", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaGiaoVien", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@TenGiaoVien", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 50);

                cmd.Parameters["@MaGiaoVien"].Value = gv.GiaoVien_MaGiaoVien;
                cmd.Parameters["@TenGiaoVien"].Value = gv.GiaoVien_TenGiaoVien;
                cmd.Parameters["@GhiChu"].Value = gv.GiaoVien_GhiChu;
                cmd.Parameters["@MaKhoa"].Value = gv.GiaoVien_MaKhoa;


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
        public void XoaGiaoVien(DTO_GiaoVien gv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("XoaGiaoVien", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaGiaoVien", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaGiaoVien"].Value = gv.GiaoVien_MaGiaoVien;

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
