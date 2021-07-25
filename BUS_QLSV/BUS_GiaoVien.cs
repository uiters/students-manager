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
    public class BUS_GiaoVien 
    {
        DAL_GiaoVien DalGiaoVien = new DAL_GiaoVien();
        BUS_Xuly BUS_xuly = new BUS_Xuly();
        DTO_GiaoVien DTO_GiaoVien = new DTO_GiaoVien();
        public void ThemGiaoVien(string magv,string tengv,string ghichu,string makhoa)
        {
            try
            {
                DalGiaoVien.ThemGiaoVien(magv,tengv,ghichu,makhoa);
            }
            catch

            {
                MessageBox.Show("Có lỗi khi thực hiện! ");
            }

        }

        public void CapNhatGiaoVien(string magv, string tengv, string ghichu,string makhoa)
        {
            try
            {
                DalGiaoVien.CapNhatGiaoVien(magv, tengv, ghichu,makhoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi thực hiện! \n" + ex.ToString());
            }

        }

        public void XoaGiaoVien(string magv)
        {
            try
            {
                DalGiaoVien.XoaGiaoVien(magv);
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện! ");
            }

        }

        public DataTable LoadDLGiaoVien()
        {
            DataTable dt = new DataTable();
            dt = DalGiaoVien.LoadDL_GiaoVien();
            return dt;
        }

        public string TaoMaGV()
        {
            string ma;
            ma = DalGiaoVien.TaoMaGiaoVien();
            return ma;
        }

        public void LoadDLVao_cmbMaKhoa(ComboBox makhoa)
        {
            DalGiaoVien.LayDLVaoCombobox_MaKhoa(makhoa);
        }

        public DataTable TimKiemGV(string columnName, string TenTimKiem)   // tìm kiếm giáo viên
        {
            DataTable dt = new DataTable();
            dt = DalGiaoVien.TimKiemGiaoVien(columnName, TenTimKiem);
            return dt;
        }

        public void GoiYTimKiem(TextBox txt,string table, int column) // gợi ý tìm kiếm
        {
            table = "GiaoVien";
            BUS_xuly.TextBox_AutoComplete(txt, table, column);
        }
    }
}
