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

        public void ThemKhoa()
        {
            try
            {
                DalKhoa.ThemKhoa(DTO_Khoa.Khoa_MaKhoa, DTO_Khoa.Khoa_TenKhoa, DTO_Khoa.Khoa_GhiChu,DTO_Khoa.Khoa_Username);
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện !");
            }
        }

        public void CapNhatKhoa()
        {
            try
            {
                DalKhoa.CapNhatKhoa(DTO_Khoa.Khoa_MaKhoa, DTO_Khoa.Khoa_TenKhoa, DTO_Khoa.Khoa_GhiChu, DTO_Khoa.Khoa_Username);
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện !");
            }
        }

        public void XoaKhoa()
        {
            try
            {
                DalKhoa.XoaKhoa(DTO_Khoa.Khoa_MaKhoa);
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
