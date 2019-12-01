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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hoc", _conn);
            DataTable dtHoc = new DataTable();
            da.Fill(dtHoc);
            return dtHoc;
        }
        public bool ThemHoc(DTO_Hoc hoc)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("INSERT INTO HOC(MaSinhVien, MaLop) VALUE('','')",hoc.MaSinhVien,hoc.MaLop) ;

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
        public bool SuaHoc(DTO_Hoc hoc)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("UPDATE HOC SET MaSinhVien='', MaLop=''WHRER MaSinhVien='', MaLop='' ", hoc.MaSinhVien, hoc.MaLop);

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
        public bool XoaHoc(DTO_Hoc hoc)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM HOC WHRER MaSinhVien='', MaLop='' ", hoc.MaSinhVien, hoc.MaLop);

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
