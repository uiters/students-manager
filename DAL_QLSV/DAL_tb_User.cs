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
    public class DAL_tb_User : DBConnect
    {
        public DataTable getUser()
        {
            SqlCommand cmd = new SqlCommand("GiaoVien", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            _conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tb_User", _conn);
            DataTable dtUser = new DataTable();
            da.Fill(dtUser);
            _conn.Close();
            return dtUser;
        }

        public void ThemUser(DTO_tb_User user)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("ThemUser", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Usertype", SqlDbType.Bit);
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Pass", SqlDbType.NVarChar, 50);


                cmd.Parameters["@usertype"].Value = user.tb_User_Usertype;
                cmd.Parameters["@username"].Value = user.tb_User_Username;
                cmd.Parameters["@pass"].Value = user.tb_User_Pass;

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

        public void SuaUser(DTO_tb_User user)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SuaUser", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Usertype", SqlDbType.Bit);
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Pass", SqlDbType.NVarChar, 50);


                cmd.Parameters["@usertype"].Value = user.tb_User_Usertype;
                cmd.Parameters["@username"].Value = user.tb_User_Username;
                cmd.Parameters["@pass"].Value = user.tb_User_Pass;


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
        public void XoaUser(DTO_tb_User user)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("XoaUser", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Username", SqlDbType.NVarChar,50);


                cmd.Parameters["@username"].Value = user.tb_User_Username;

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
