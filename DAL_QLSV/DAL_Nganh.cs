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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Nganh", _conn);
            DataTable dtNganh = new DataTable();
            da.Fill(dtNganh);
            return dtNganh;
        }

        public bool ThemNganh(DTO_Nganh nganh)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("INSERT INTO Nganh(MaNganh, TenNganh, GhiChu, MaKhoa) VALUE ('','','','')", nganh.MaNganh, nganh.TenNganh, nganh.GhiChu,nganh.MaKhoa);

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

        public bool SuaNganh(DTO_Nganh nganh)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("UPDATE Nganh SET TenNganh='', GhiChu='', MaKhoa='' WHERE MaNganh=''", nganh.TenNganh, nganh.GhiChu, nganh.MaKhoa, nganh.MaNganh);

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

        public bool XoaNganh(DTO_Nganh nganh)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("DELETE FROM Nganh  WHERE MaNganh=''", nganh.MaNganh);

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
