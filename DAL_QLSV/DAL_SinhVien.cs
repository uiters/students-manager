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
            SqlCommand cmd = new SqlCommand("GiaoVien", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            _conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SinhVien", _conn);
            DataTable dtSinhVien = new DataTable();
            da.Fill(dtSinhVien);
            _conn.Close();
            return dtSinhVien;
        }

        public void ThemSinhVien(DTO_SinhVien sv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("ThemSinhVien", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 150);
                cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 350);
                cmd.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime);
                cmd.Parameters.Add("@NoiSinh", SqlDbType.NVarChar, 400);
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 5);
                cmd.Parameters.Add("@Hinh", SqlDbType.NVarChar, 150);
                cmd.Parameters.Add("@MaNganh", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaSinhVien"].Value = sv.SinhVien_MaSinhVien;
                cmd.Parameters["@HoTen"].Value = sv.SinhVien_HoTen;
                cmd.Parameters["@QueQuan"].Value = sv.SinhVien_QueQuan;
                cmd.Parameters["@NgaySinh"].Value = sv.SinhVien_NgaySinh;
                cmd.Parameters["@NoiSinh"].Value = sv.SinhVien_NoiSinh;
                cmd.Parameters["@GioiTinh"].Value = sv.SinhVien_GioiTinh;
                cmd.Parameters["@Hinh"].Value = sv.SinhVien_Hinh;
                cmd.Parameters["@MaNganh"].Value = sv.SinhVien_MaNganh;

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
        public void SuaSinhVien(DTO_SinhVien sv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SuaSinhVien", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 150);
                cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 350);
                cmd.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime);
                cmd.Parameters.Add("@NoiSinh", SqlDbType.NVarChar, 400);
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 5);
                cmd.Parameters.Add("@Hinh", SqlDbType.NVarChar, 150);
                cmd.Parameters.Add("@MaNganh", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaSinhVien"].Value = sv.SinhVien_MaSinhVien;
                cmd.Parameters["@HoTen"].Value = sv.SinhVien_HoTen;
                cmd.Parameters["@QueQuan"].Value = sv.SinhVien_QueQuan;
                cmd.Parameters["@NgaySinh"].Value = sv.SinhVien_NgaySinh;
                cmd.Parameters["@NoiSinh"].Value = sv.SinhVien_NoiSinh;
                cmd.Parameters["@GioiTinh"].Value = sv.SinhVien_GioiTinh;
                cmd.Parameters["@Hinh"].Value = sv.SinhVien_Hinh;
                cmd.Parameters["@MaNganh"].Value = sv.SinhVien_MaNganh;

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
        public void XoaSinhVien(DTO_SinhVien sv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("ThemSinhVien", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaSinhVien"].Value = sv.SinhVien_MaSinhVien;

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
