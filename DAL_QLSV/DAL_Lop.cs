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
    public class DAL_Lop : DBConnect
    {
        public DataTable getLop()
        {
            SqlCommand cmd = new SqlCommand("Khoa", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            _conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Lop", _conn);
            DataTable dtLop = new DataTable();
            da.Fill(dtLop);
            _conn.Close();
            return dtLop;
        }
        public void ThemLop(DTO_Lop lop)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("ThemLop", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@LoaiLop", SqlDbType.Bit);
                cmd.Parameters.Add("@NienKhoa", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@NgayBatDau", SqlDbType.SmallDateTime);
                cmd.Parameters.Add("@NgayKetThuc", SqlDbType.SmallDateTime);
                cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@MaGiaoVien", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaLop"].Value = lop.Lop_MaLop;
                cmd.Parameters["@TenLop"].Value = lop.Lop_TenLop;;
                cmd.Parameters["@LoaiLop"].Value = lop.Lop_LoaiLop;
                cmd.Parameters["@NienKhoa"].Value = lop.Lop_NienKhoa;
                cmd.Parameters["@NgayBatDau"].Value = lop.Lop_NgayBatDau;
                cmd.Parameters["@NgayKetThuc"].Value = lop.Lop_NgayKetThuc;
                cmd.Parameters["@MaMonHoc"].Value = lop.Lop_MaMonHoc;
                cmd.Parameters["@MaGiaoVien"].Value = lop.Lop_MaGiaoVien;

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

        public void SuaLop(DTO_Lop lop)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SuaLop", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@LoaiLop", SqlDbType.Bit);
                cmd.Parameters.Add("@NienKhoa", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@NgayBatDau", SqlDbType.SmallDateTime);
                cmd.Parameters.Add("@NgayKetThuc", SqlDbType.SmallDateTime);
                cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@MaGiaoVien", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaLop"].Value = lop.Lop_MaLop;
                cmd.Parameters["@TenLop"].Value = lop.Lop_TenLop; ;
                cmd.Parameters["@LoaiLop"].Value = lop.Lop_LoaiLop;
                cmd.Parameters["@NienKhoa"].Value = lop.Lop_NienKhoa;
                cmd.Parameters["@NgayBatDau"].Value = lop.Lop_NgayBatDau;
                cmd.Parameters["@NgayKetThuc"].Value = lop.Lop_NgayKetThuc;
                cmd.Parameters["@MaMonHoc"].Value = lop.Lop_MaMonHoc;
                cmd.Parameters["@MaGiaoVien"].Value = lop.Lop_MaGiaoVien;

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

        public void XoaLop(DTO_Lop lop)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("XoaLop", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 50);

                cmd.Parameters["@MaLop"].Value = lop.Lop_MaLop;

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
