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
    public class DAL_SinhVien : DBConnect
    {
        public DataTable getSinhVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SinhVien", _conn);
            DataTable dtSinhVien = new DataTable();
            da.Fill(dtSinhVien);
            return dtSinhVien;
        }

        public bool ThemSinhVien(DTO_SinhVien sv)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("INSERT INTO SinhVien(MaSinhVien, HoTen, QueQuan, NgaySinh, NoiSinh, GioiTinh, Hinh, MaNganh) VALUE ('','','','','','','','')",sv.MaSinhVien, sv.HoTen,sv.QueQuan,sv.NgaySinh,sv.NoiSinh,sv.GioiTinh,sv.Hinh,sv.MaNganh);

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
        public bool SuaSinhVien(DTO_SinhVien sv)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("UPDATE SinhVien SET HoTen='', QueQuan='', NgaySinh='', NoiSinh='', GioiTinh='', Hinh='', MaNganh='' WHERE  MaSinhVien=''", sv.HoTen, sv.QueQuan, sv.NgaySinh, sv.NoiSinh, sv.GioiTinh, sv.Hinh, sv.MaNganh, sv.MaSinhVien);

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
        public bool XoaSinhVien(DTO_SinhVien sv)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM SinhVien WHERE MaSinhVIen=''", sv.MaSinhVien);
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
