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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Diem", _conn);
            DataTable dtDiem = new DataTable();
            da.Fill(dtDiem);
            return dtDiem;
        }

        public bool ThemDiem(DTO_Diem diem)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("INSERT INTO Diem(MaMonHoc, MaSinhVien, SoDiem, LanThi) VALUE ('','','','')", diem.MaMonHoc,diem.MaSinhVien,diem.SoDiem,diem.LanThi);

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
        public bool SuaDiem(DTO_Diem diem)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("UPDATE Diem SET SoDiem='', LanThi='' WHERE MaMonHoc='', MaSinhVien=''", diem.SoDiem, diem.LanThi, diem.MaMonHoc, diem.MaSinhVien);

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
        public bool XoaDiem(DTO_Diem diem)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("DELETE FROM Diem WHERE MaMonHoc='', MaSinhVien=''", diem.MaMonHoc, diem.MaSinhVien);

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
