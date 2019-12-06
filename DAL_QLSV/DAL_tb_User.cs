using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QLSV;
using System.Windows.Forms;


namespace DAL_QLSV
{
    public class DAL_tb_User 
    {
       
        DAL_Xuly xuly = new DAL_Xuly();

        public void CreateUser(string User, string pass, bool ID)
        {
            SqlParameter u = new SqlParameter();//user
            SqlParameter p = new SqlParameter();//pass
            SqlParameter i = new SqlParameter();//ID check
            if (User == "" || pass == "")
            {
                MessageBox.Show("Mời nhập user và pass ");
            }
            else
            {
                u.SqlValue = User;
                p.SqlValue = pass;
                i.SqlValue = ID;
                u.ParameterName = "@Username";
                p.ParameterName = "@Pass";
                i.ParameterName = "@Usertype";

                xuly.ThaoTacDuLieu("qlsv_AddNewUser", CommandType.StoredProcedure, i,u,p);
            }
        }

        public void DeleteUser(string User)
        {
            SqlParameter u = new SqlParameter();
            u.SqlValue = User;
            u.ParameterName = "@Username";
            xuly.ThaoTacDuLieu("qlsv_DeleteUser", CommandType.StoredProcedure, u);
        }

        public void UpdateUser(String User, string Pass, bool ID)
        {
            SqlParameter u = new SqlParameter();
            SqlParameter p = new SqlParameter();
            SqlParameter i = new SqlParameter();//ID check
            u.SqlValue = User;
            p.SqlValue = Pass;
            i.SqlValue = ID;
            u.ParameterName = "@Username";
            p.ParameterName = "@Pass";
            i.ParameterName = "@Usertype";
            xuly.ThaoTacDuLieu("qlsv_UpdateUser", CommandType.StoredProcedure, i, u, p);
        }

        public DataTable GetOldPass(string User)
        {
            DataTable dt = new DataTable();
            dt = xuly.LayDanhSach("Select Pass from tb_user where Username = '" + User + "'");
            return dt;
        }

        public DataTable LoadDL(string tableName)//tableName = tb_User
        {
            DataTable dt = new DataTable();
            dt = xuly.LayDanhSach("Select Username,Pass from " + tableName + "");

            return dt;
        }
     
        public DataTable TimKiem(string User)
        {
            DataTable dt = new DataTable();
            dt = xuly.LayDanhSach("Select Username,Pass from  tb_User where Username ='" + User + "'");
            return dt;
        }

    }
}
