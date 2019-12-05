using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using DTO_QLSV;
using DAL_QLSV;

namespace BUS_QLSV
{
    public class BUS_Xuly
    {
        DBConnect conn = new DBConnect();
        //Hàm xóa rỗng tất cả các textbox trên form
        public void ClearAllTextBox(Control ctr)//ctr truyền vào 1 form, hoặc 1 usercontrol, hoặc 1 groupbox chứa các textbox......
        {
            if (ctr.GetType() == typeof(TextBox))
            {
                ctr.Text = "";

            }
            else if (ctr.GetType() == typeof(NumericUpDown))
            {
                ctr.Text = "0";
            }
            else if (ctr.GetType() == typeof(DateTimePicker))
            {
                ctr.Text = DateTime.Now.ToString();
            }
            //Duyệt tất cả các textbox trên form
            foreach (Control iCtr in ctr.Controls)
            {
                ClearAllTextBox(iCtr);
            }
        }
        public void AddControl(Panel pn, UserControl uc)
        {
            pn.BackgroundImage = null;
            pn.Controls.Clear();
            pn.Controls.Add(uc);
        }
        public string ChuanHoaString(string str)
        {
            string FullName = str;
            string result = "";
            if (str != "")
            {
                FullName = FullName.Trim();//cắt khoảng trắng dư ở 2 đầu
                while (FullName.IndexOf("  ") != -1)// tìm không thấy return -1
                {
                    FullName = FullName.Replace("  ", " ");
                }
                string[] SubName = FullName.Split(' ');//chuỗi cắt khi gặp khoẳng trắng, thành mảng chuỗi
                for (int i = 0; i < SubName.Length; i++)
                {
                    string FirstChar = SubName[i].Substring(0, 1);
                    string OtherChar = SubName[i].Substring(1);
                    SubName[i] = FirstChar.ToUpper() + OtherChar.ToLower();
                    result += SubName[i] + " ";
                }
            }
            return result;
        }
        public void TextBox_AutoComplete(TextBox txt, string table, int column)//giá trị nhập, table, cột
        {

            txt.AutoCompleteCustomSource.Clear();
            txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //gán nguồn cấp dữ liệu cho text box autocomplete
            txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            string strSql = "Select * from " + table + "";
            SqlConnection cn = conn.OpenCN();
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt.AutoCompleteCustomSource.Add(dr[column].ToString()).ToString();
                    //load du lieu len CustomSource cua textbox autocomplete
                    //txt.Text = txt.AutoCompleteCustomSource.Add(dr.GetValue(column).ToString()).ToString();

                }
                dr.Close();
            }
            catch
            {
                throw;
            }

            conn.CloseCN(cn);
        }
      
    }
}

