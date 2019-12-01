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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Khoa", _conn);
            DataTable dtKhoa = new DataTable();
            da.Fill(dtKhoa);
            return dtKhoa;
        }

        public bool ThemKhoa(DTO_Khoa khoa)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("INSERT INTO Khoa(MaKhoa, TenKhoa, GhiChu, Username) VALUE ('','','','')", khoa.MaKhoa, khoa.TenKhoa, khoa.GhiChu, khoa.Username);

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

        public bool SuaKhoa(DTO_Khoa khoa)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("UPDATE Khoa SET TenKhoa='', GhiChu='', Username='' WHERE MaKhoa",  khoa.TenKhoa, khoa.GhiChu, khoa.Username, khoa.MaKhoa);

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
        public bool XoaKhoa(DTO_Khoa khoa)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("DELETE FROM Khoa WHERE MaKhoa", khoa.MaKhoa);

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
