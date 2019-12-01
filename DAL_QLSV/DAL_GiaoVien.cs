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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM GiaoVien", _conn);
            DataTable dtGiaoVien = new DataTable();
            da.Fill(dtGiaoVien);
            return dtGiaoVien;
        }

        public bool ThemGiaoVien(DTO_GiaoVien gv)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("INSERT INTO GiaoVien(MaGiaoVien, TenGiaoVien, GhiChu, MaKhoa) VALUE ('','','','')", gv.MaGiaoVien,gv.TenGiaoVien,gv.GhiChu,gv.MaKhoa);

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
        public bool SuaGiaoVien(DTO_GiaoVien gv)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("UPDATE GiaoVien SET TenGiaoVien='', GhiChu='', MaKhoa=''WHERE MaGiaoVien=''", gv.TenGiaoVien, gv.GhiChu, gv.MaKhoa, gv.MaGiaoVien);

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
        public bool XoaGiaoVien(DTO_GiaoVien gv)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("DELETE FROM GiaoVien WHERE MaGiaoVien=''", gv.MaGiaoVien);

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
