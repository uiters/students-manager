using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using DAL_QLSV;
using DTO_QLSV;
using System.Collections;
using System.Windows.Forms;

namespace BUS_QLSV
{

    public class BUS_tb_User
    {
        BUS_Xuly BUS_xuly = new BUS_Xuly();
        DAL_tb_User DAL_user = new DAL_tb_User();
        DAL_Xuly DAL_xuly = new DAL_Xuly();
        DTO_tb_User DTO_tb_user = new DTO_tb_User();
        DBConnect conn = new DBConnect();

        #region
        //tạo tài khoản 
        public void CreateUser(string User,string Pass,bool id)
        {        
            if (User == "")
            {               
            }
            else
            {
                if (isExist(User) == true)
                {

                    // throw new Exception("User này đã tồn tại");
                    MessageBox.Show("User này đã tồn tại");
                }

                else
                {
                    DAL_user.CreateUser(User, MahoaPass(Pass), id);
                    MessageBox.Show("Tạo tài khoản mới thành công");
                }
            }


        }
        //xoá tài khoản 
        public void DeleteUser(string User)
        {
            if (isAdmin(User) != true)
            {
                if (isExist(User) == true)
                {

                    DAL_user.DeleteUser(User);
                }
                else
                    //throw new Exception("Không tồn tại User này");
                    MessageBox.Show("Không tồn tại User này");
            }
            else
            {
                MessageBox.Show("Bạn không được xóa tài khoản admin");
            }
        }
        //đổi mật khẩu 
        public void UpdateUser(string User,string Pass,string newPass, bool id)
        {
            if (isExist(User) == true)
            {
                string oldpass = DAL_user.GetOldPass(User).Rows[0][0].ToString();
                if (MahoaPass(Pass) != oldpass)
                   
                {                   
                    MessageBox.Show("Mật khẩu nhập vào không trùng khớp");
                }
                else
                {
                    DAL_user.UpdateUser(User, MahoaPass(newPass), id);
                   
                    MessageBox.Show("Cập nhật thành công");
                }
            }
        }
        #endregion

        //mã hóa password ,using System.Security.Cryptography 
        public string MahoaPass(string pass)
        {
            UnicodeEncoding uc = new UnicodeEncoding();
            byte[] hash = uc.GetBytes(pass);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            hash = md5.ComputeHash(hash);
            return Convert.ToBase64String(hash);
        }
        public DataTable LoadDL()
        {
            DataTable dt = new DataTable();
            dt = DAL_user.LoadDL("tb_User");

            return dt;
        }  
        public DataTable TimKiem(string User)
        {
            DataTable dt = new DataTable();
            dt = DAL_user.TimKiem(User);
            return dt;
        }
        //gợi ý tìm kiếm
        public void TextBoxAutoComplete(TextBox txt,string table,int column)
        {
            BUS_xuly.TextBox_AutoComplete(txt, table, column);
        }


        //Kiểm tra xem user đã tồn tại trong csdl hay chưa--           
        public bool isExist(string User)
        {
            bool kq = false;
            string strSQL = "Select Username,Pass from tb_User where Username = @Username";
            SqlConnection cn = conn.OpenCN();
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            cmd.Parameters.Add(new SqlParameter("@Username", User));
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (User == dr[0].ToString())
                    {
                        return kq = true; ;
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra" + ex.ToString());
            }
            return kq;

        }
        //Kiểm tra xem tài khoản xóa có phải là admin hay user.//chưa hoàn thiện
        public bool isAdmin(string User)
        {
            bool kq = false;
            string strSQL = "Select * from tb_User where Username = @Username";
            SqlConnection cn = conn.OpenCN();
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            cmd.Parameters.Add(new SqlParameter("@Username", User));
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (User == dr[1].ToString()&& "1".ToString()==dr[0].ToString())
                    {
                        return kq = true; ;
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra" + ex.ToString());
            }
            return kq;
        }
        //checkuser để đăng nhập       
        public bool CheckUser(string User, string pass)
        {
            bool kq = false;
            DataTable dt = new DataTable();
            dt = DAL_xuly.LayDanhSach("Select * from tb_User Where Username ='" + User + "' and pass ='" + pass + "'");
            try
            {
                int n = dt.Rows.Count;
                if (n > 0)
                {
                    return kq = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return kq;
        }
        public string Login(string user,string pass,bool id)
        {
            string kq = "";

            if (CheckUser(user,MahoaPass(pass) ) == true)
            {

                if (PQ(user, MahoaPass(pass)) == true)
                {
                    kq = "Admin";
                }
                else if (PQ(user, MahoaPass(pass)) == false)
                {
                    kq = "User";
                }
            }
            else
            {
                kq = "False";
            }
            return kq;
        }
        public bool PQ(string User, string pass)
        {
            bool id = false;
            DataTable dt = new DataTable();
            dt = DAL_xuly.LayDanhSach("Select * from tb_User Where Username ='" + User + "' and pass ='" + pass + "'");
            try
            {

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = (bool)dr[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return id; //true là admin, false là thường 
        }
    }
}

