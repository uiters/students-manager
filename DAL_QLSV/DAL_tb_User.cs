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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tb_User", _conn);
            DataTable dtUser = new DataTable();
            da.Fill(dtUser);
            return dtUser;
        }

        public bool ThemUser(DTO_tb_User user)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("INSERT INTO tb_User(Usertype, Username, Pas) VALUE ('','','')", user.Usertype, user.Username,user.Pass);

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
        public bool XoaUser(DTO_tb_User user)
        {
            try
            {
                //ket noi
                _conn.Open();
                string SQL = string.Format("DELETE FROM tb_User WHERE Username=''", user.Username);

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
