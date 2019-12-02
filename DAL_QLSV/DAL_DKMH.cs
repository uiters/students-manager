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
    public class DAL_DKMH : DBConnect
    {
        public DataTable getDKMH()
        {
            SqlCommand cmd = new SqlCommand("Diem", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            _conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DKMH", _conn);
            da.SelectCommand = cmd;
            DataTable dtDK = new DataTable();
            da.Fill(dtDK);
            _conn.Close();
            return dtDK;
        }

        public void ThemDKMH(DTO_DKMH dk)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("ThemDKMH", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaMonHoc"].Value = dk.DKMH_MaMonHoc;
                cmd.Parameters["@MaSinhVien"].Value = dk.DKMH_MaSinhVien;

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
        public void SuaDKMH(DTO_DKMH dk)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SuaDKMH", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaMonHoc"].Value = dk.DKMH_MaMonHoc;
                cmd.Parameters["@MaSinhVien"].Value = dk.DKMH_MaSinhVien;

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
        public void XoaDKMH(DTO_DKMH dk)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("XoaDKMH", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaMonHoc"].Value = dk.DKMH_MaMonHoc;
                cmd.Parameters["@MaSinhVien"].Value = dk.DKMH_MaSinhVien;

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
