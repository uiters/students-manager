using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLSV;
using DTO_QLSV;
using System.Windows.Forms;

namespace BUS_QLSV
{
    public class BUS_Khoa
    {
        DAL_Khoa DalKhoa = new DAL_Khoa();
        DTO_Khoa DTO_Khoa = new DTO_Khoa();

        public void ThemKhoa(string makhoa,string tenkhoa,string ghichu)
        {
            try
            {
                DalKhoa.ThemKhoa(makhoa,tenkhoa,ghichu,"admin");
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện !");
            }
        }

        public void CapNhatKhoa(string makhoa, string tenkhoa, string ghichu)
        {
            try
            {
                DalKhoa.CapNhatKhoa(makhoa, tenkhoa, ghichu, "admin");
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện !");
            }
        }

        public void XoaKhoa(string makhoa)
        {
            try
            {
                DalKhoa.XoaKhoa(makhoa);
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện !");
            }
        }

        public DataTable LoadDLKhoa()
        {
            DataTable dt = new DataTable();
            dt = DalKhoa.LoadDLKhoa();
            return dt;

        }
        public string TaoMaKhoa()
        {
            string ma;
            ma = DalKhoa.TaoMaKhoa();
            return ma;
        }
    }
}
