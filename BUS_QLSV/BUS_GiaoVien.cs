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
        public void ThemGiaoVien()
        {
            try
            {
                DalGiaoVien.ThemGiaoVien(DTO_GiaoVien.GiaoVien_MaGiaoVien, DTO_GiaoVien.TENTIMKIEM, DTO_GiaoVien.GiaoVien_MaKhoa, DTO_GiaoVien.GiaoVien_GhiChu);
            }
            catch

            {
                MessageBox.Show("Có lỗi khi thực hiện! ");
            }

        }

        public void CapNhatGiaoVien()
        {
            try
            {
                DalGiaoVien.CapNhatGiaoVien(DTO_GiaoVien.GiaoVien_MaGiaoVien, DTO_GiaoVien.TENTIMKIEM, DTO_GiaoVien.GiaoVien_MaKhoa, DTO_GiaoVien.GiaoVien_GhiChu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi thực hiện! \n" + ex.ToString());
            }

        }

        public void XoaGiaoVien()
        {
            try
            {
                DalGiaoVien.XoaGiaoVien(DTO_GiaoVien.GiaoVien_MaGiaoVien);
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

        public DataTable TimKiemGV()
        {
            DataTable dt = new DataTable();
            dt = DalGiaoVien.TimKiemGiaoVien(DTO_GiaoVien.COTTIMKIEM, DTO_GiaoVien.TENTIMKIEM);
            return dt;
        }

        public string TaoMaGV()
        {
            string ma;
            ma = DalGiaoVien.TaoMaGiaoVien();
            return ma;
        }

        public void LoadDLVao_cmbMaKhoa()
        {
            DalGiaoVien.LayDLVaoCombobox_MaKhoa(DTO_GiaoVien.cmbMAKHOA);
        }

        public void GoiYGiaoVien()
        {
            GoiYTimKiem(DTO_GiaoVien.TXT, DTO_GiaoVien.COLUMN);
        }
        public void GoiYTimKiem(TextBox txt, int column)
        {
            BUS_xuly.TextBox_AutoComplete(txt, "GiaoVien", column);
        }
    }
}
