using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLSV;

namespace DAL_QLSV
{
     public class DAL_Xuly
    {
        DBConnect conn = new DBConnect();

        //hàm thao tác với csdl(them, xoa, sua, cap nhat.)
        public void ThaoTacDuLieu(string strSQL, CommandType cmdT, params SqlParameter[] param)// params SqlParameter[] param)
        {
            
            SqlConnection cn = conn.OpenCN();
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;//truyen vao ten cua storeprocedure
            cmd.CommandType = cmdT;
            cmd.Connection = cn;
            if (param != null)
            {
                foreach (SqlParameter p in param)
                {
                    cmd.Parameters.Add(p);
                }
            }
            try
            {
                cmd.ExecuteNonQuery();
                param = null;
                cmd.Parameters.Clear();
                cmd.Dispose();
                conn.CloseCN(cn);

            }
            catch (SqlException se)
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                throw new Exception(se.ToString());
            }

        }
        //báo cáo
        public DataTable Reports(string strSQL, string table)
        {
            SqlConnection cn = conn.OpenCN();
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, cn);

                da.Fill(ds, table);
                //return ds.Tables[table];
            }
            catch (SqlException se)
            {
                //throw new Exception(se.ToString());
                MessageBox.Show(se.ToString());
            }
            finally
            {
                conn.CloseCN(cn);
            }
            return ds.Tables[table];


        }
        //lấy danh sách
        public DataTable LayDanhSach(string strSQL)
        {
            DataTable dt = new DataTable();

            SqlConnection cn = conn.OpenCN();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, cn);
                da.Fill(dt);
                conn.CloseCN(cn);
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }
            return dt;
        }
        //lấy tên
        public string LayTen(string strSQL)
        {
            SqlConnection cn = conn.OpenCN();
            string ten = "";
            try
            {
                SqlCommand cmd = new SqlCommand(strSQL, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read() == true)
                {
                    // cb.Text = dr[col].ToString();
                    ten = dr[0].ToString();
                }
                dr.Close();
                cmd.Dispose();
                conn.CloseCN(cn);
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi khi truy vấn dữ liệu " + ex.ToString());
            }
            return ten;
        }
        //thêm, xóa sửa.
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
                i.ParameterName = "@ID";

                ThaoTacDuLieu("qlsv_AddNewUser", CommandType.StoredProcedure, u, p, i);
            }
        }
       
        public void DeleteUser(string User)
        {
            SqlParameter u = new SqlParameter();
            u.SqlValue = User;
            u.ParameterName = "@Username";
            ThaoTacDuLieu("qlsv_DeleteUser", CommandType.StoredProcedure, u);
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
            i.ParameterName = "@ID";
           ThaoTacDuLieu("qlsv_UpdateUser", CommandType.StoredProcedure, u, p, i);
        }
        // lấy pass cũ để đổi mật khẩu
        public DataTable GetOldPass(string User)
        {
            DataTable dt = new DataTable();
            dt = LayDanhSach("Select Pass from tb_user where Username = '" + User + "'");
            return dt;
        }
        // load dữ liệu
        public DataTable LoadDL(string tableName)//tableName = tb_User
        {
            DataTable dt = new DataTable();
            dt = LayDanhSach("Select Username,Pass from " + tableName + "");
            return dt;
        }
        
        public DataTable TimKiem(string User)
        {
            DataTable dt = new DataTable();
            dt = LayDanhSach("Select Username,Pass from  tb_User where Username ='" + User + "'");
            return dt;
        }
        //ham tao ma so tu dong
        public string SinhMaTuDong(string KyTuBatDau, string strSQL)
        {
            string maso = "";
            int n = 0;
            SqlConnection cn = conn.OpenCN();
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                maso = dr[0].ToString();
            }
            dr.Close();
            conn.CloseCN(cn);

            if (maso == "")
            {
                return maso = KyTuBatDau + "0000000";
            }
            else
            {
                maso = maso.Substring(2, maso.Length - 2);
                n = int.Parse(maso);
                n = n + 1;//tang len 1 don vi
                maso = n.ToString();
                //them so 0 vao ma
                while (maso.Length < 7)
                {
                    maso = "0" + maso;
                }
                maso = KyTuBatDau + maso;
                return maso;
            }

        }
        public void LoadDLVaoCombobox(string strSQL, ComboBox cmb, string DisplayMember, string ValueMember)
        {
            // SqlConnection cn = conn.OpenCN();
            try
            {
                cmb.DataSource = LayDanhSach(strSQL);
                cmb.DisplayMember = DisplayMember;
                cmb.ValueMember = ValueMember;

                // conn.CloseCN(cn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi Load dữ liệu! \n" + ex.ToString());
            }
        }

    }
}
