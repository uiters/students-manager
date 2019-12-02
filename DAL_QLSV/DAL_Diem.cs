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
    public class DAL_Diem : DBConnect
    {

        public DataTable getDiem()
        {
            SqlCommand cmd = new SqlCommand("Diem", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            _conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Diem", _conn);
            da.SelectCommand = cmd;
            DataTable dtDiem = new DataTable();
            da.Fill(dtDiem);
            _conn.Close();
            return dtDiem;
        }

        public void ThemDiem(DTO_Diem diem)
        {
            try
            {            
                _conn.Open();
                SqlCommand cmd = new SqlCommand("ThemDiem", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@SoDiem", SqlDbType.Float);
                cmd.Parameters.Add("@LanThi", SqlDbType.Int);
                cmd.Parameters["@MaMonHoc"].Value = diem.Diem_MaMonHoc;
                cmd.Parameters["@MaSinhVien"].Value = diem.Diem_MaSinhVien;
                cmd.Parameters["@SoDiem"].Value = diem.Diem_SoDiem;
                cmd.Parameters["@LanThi"].Value = diem.Diem_LanThi;
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
        public void SuaDiem(DTO_Diem diem)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("Sua", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@SoDiem", SqlDbType.Float);
                cmd.Parameters.Add("@LanThi", SqlDbType.Int);
                cmd.Parameters["@MaMonHoc"].Value = diem.Diem_MaMonHoc;
                cmd.Parameters["@MaSinhVien"].Value = diem.Diem_MaSinhVien;
                cmd.Parameters["@SoDiem"].Value = diem.Diem_SoDiem;
                cmd.Parameters["@LanThi"].Value = diem.Diem_LanThi;
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
        public void XoaDiem(DTO_Diem diem)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("ThemDiem", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaMonHoc"].Value = diem.Diem_MaMonHoc;
                cmd.Parameters["@MaSinhVien"].Value = diem.Diem_MaSinhVien;

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
