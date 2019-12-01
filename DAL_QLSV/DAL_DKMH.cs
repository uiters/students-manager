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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DKMH", _conn);
            DataTable dtDK = new DataTable();
            da.Fill(dtDK);
            return dtDK;
        }
        public bool ThemDKMH(DTO_DKMH dk)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("INSERT INTO DKMH(MaSinhVien, MaMonHoc) VALUE('','')",dk.MaSinhVien,dk.MaMonHoc);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
        public bool SuaDKMH(DTO_DKMH dk)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("UPDATE DKMH SET MaSinhVien='', MaMonHoc='' WHERE MaSinhVien='',MaMonHoc='')", dk.MaSinhVien, dk.MaMonHoc);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
        public bool XoaDKMH(DTO_DKMH dk)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM DKMH WHERE MaSinhVien='',MaMonHoc='')", dk.MaSinhVien, dk.MaMonHoc);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
    }
}
