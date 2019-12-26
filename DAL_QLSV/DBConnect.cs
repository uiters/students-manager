using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL_QLSV
{
   public class DBConnect
    {
        string strCn = @"Data Source=Thien;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        public SqlConnection OpenCN()
        {
            SqlConnection cn = new SqlConnection(strCn);
            try
            {
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối  " + ex.ToString(), "Thông báo! ");
            }
            return cn;
        }
        public void CloseCN(SqlConnection cn)
        {

            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không đóng được kết nối " + ex.ToString());
            }

        }

    }
}

