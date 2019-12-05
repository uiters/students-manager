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
        DAL_Xuly DAL_xuly = new DAL_Xuly();
        DTO_tb_User DTO_user = new DTO_tb_User();
        DBConnect conn = new DBConnect();

        private string table = "tb_User";
        private int column = 0;

        //mã hóa password ,using System.Security.Cryptography -- BUS
        public string MahoaPass(string pass)
        {
            UnicodeEncoding uc = new UnicodeEncoding();
            byte[] hash = uc.GetBytes(pass);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            hash = md5.ComputeHash(hash);
            return Convert.ToBase64String(hash);
        }
        //tạo tài khoản 
        public void CreateUser()
        {
            if (this.DTO_user.USER == "")
            {

            }
            else
            {
                if (isExist(DTO_user.USER) == true)
                {

                    // throw new Exception("User này đã tồn tại");
                    MessageBox.Show("User này đã tồn tại");
                }

                else
                {
                    DAL_xuly.CreateUser(DTO_user.USER, MahoaPass(DTO_user.PASS), DTO_user.ID);
                    MessageBox.Show("Tạo tài khoản mới thành công");
                }
            }


        }
        //xoá tài khoản 
        public void DeleteUser()
        {
            if (isExist(DTO_user.USER) == true)
            {

                DAL_xuly.DeleteUser(DTO_user.USER);
            }
            else
                //throw new Exception("Không tồn tại User này");
                MessageBox.Show("Không tồn tại User này");
        }
        //đổi mật khẩu 
        public void UpdateUser()
        {
            if (isExist(DTO_user.USER) == true)
            {
                string oldpass = DAL_xuly.GetOldPass(DTO_user.USER).Rows[0][0].ToString();
                if (MahoaPass(DTO_user.PASS) != oldpass)
                {
                    //throw new Exception("Mật khẩu nhập vào không trùng khớp");
                    MessageBox.Show("Mật khẩu nhập vào không trùng khớp");

                }
                else
                {
                    DAL_xuly.UpdateUser(DTO_user.USER, MahoaPass(DTO_user.NEWPASS), DTO_user.ID);
                    MessageBox.Show("Cập nhật thành công");
                }
            }
        }
       
        public DataTable LoadDL()
        {
            DataTable dt = new DataTable();
            dt = DAL_xuly.LoadDL("tb_User");

            return dt;
        }
    
        public DataTable TimKiem()
        {
            DataTable dt = new DataTable();
            dt = DAL_xuly.TimKiem(DTO_user.USER);
            return dt;
        }
        //gợi ý tìm kiếm
        public void TextBoxAutoComplete()
        {
            BUS_xuly.TextBox_AutoComplete(DTO_user.TXT,table,column);
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
        public string Login()
        {
            string kq = "";

            if (CheckUser(DTO_user.USER, MahoaPass(DTO_user.PASS)) == true)
            {

                if (PQ(DTO_user.USER, MahoaPass(DTO_user.PASS)) == true)
                {
                    kq = "Admin";
                }
                else if (PQ(DTO_user.USER, MahoaPass(DTO_user.PASS)) == false)
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

