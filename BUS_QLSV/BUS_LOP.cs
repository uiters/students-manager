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
    public class BUS_LOP
    {
        DAL_Lop Dal_Lop = new DAL_Lop();
        BUS_Xuly BUS_xuly = new BUS_Xuly();
        DTO_Lop DTO_Lop = new DTO_Lop();
        public void ThemLop()
        {
            try
            {
                Dal_Lop.ThemLop(DTO_Lop.Lop_MaLop, DTO_Lop.Lop_TenLop, DTO_Lop.Lop_LoaiLop, DTO_Lop.Lop_NienKhoa, DTO_Lop.Lop_NgayBatDau, DTO_Lop.Lop_NgayKetThuc, DTO_Lop.Lop_MaMonHoc, DTO_Lop.Lop_MaGiaoVien);
            }
            catch

            {
                MessageBox.Show("Có lỗi khi thực hiện! ");
            }

        }
        public void CapNhatLop()
        {
            try
            {
                Dal_Lop.CapNhatLop(DTO_Lop.Lop_MaLop, DTO_Lop.Lop_TenLop, DTO_Lop.Lop_LoaiLop, DTO_Lop.Lop_NienKhoa, DTO_Lop.Lop_NgayBatDau, DTO_Lop.Lop_NgayKetThuc, DTO_Lop.Lop_MaMonHoc, DTO_Lop.Lop_MaGiaoVien);
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện! ");
            }

        }

        public void XoaLop()
        {
            try
            {
                Dal_Lop.XoaLop(DTO_Lop.Lop_MaLop);
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện! ");
            }

        }

        public DataTable LoadDL_dgvLop()
        {
            DataTable dt = new DataTable();
            dt = Dal_Lop.LoadDL();
            return dt;
        }

        public string TaoMaLop()
        {
            string ma = "";
            ma = Dal_Lop.TaoMaLop();
            return ma;
        }



        public void LoadDLVaoCombobox_MaNganh()
        {
            Dal_Lop.LayDLVaoCombobox_MaNganh(DTO_Lop.cmbMANGANH);
        }

        public DataTable TimKiemLop()
        {
            DataTable dt = new DataTable();
            dt = Dal_Lop.TimKiemLop(DTO_Lop.COTIMKIEM, DTO_Lop.DKTIM);
            return dt;
        }

        public void GoiYTimKiem()
        {
            GoiYTimKiem(DTO_Lop.TXTGOIY, DTO_Lop. COTGOIY);
        }
        public void GoiYTimKiem(TextBox txt, int column)
        {
            BUS_xuly.TextBox_AutoComplete(txt, "Lop", column);
        }
    }
}
