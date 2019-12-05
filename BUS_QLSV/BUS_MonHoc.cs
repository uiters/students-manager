using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DAL_QLSV;
using DTO_QLSV;

namespace BUS_QLSV
{
    public class BUS_MonHoc
    {

        DAL_MonHoc DAL_MonHoc = new DAL_MonHoc();
        DTO_MonHoc DTO_MonHoc = new DTO_MonHoc();
        BUS_Xuly BUS_xuly = new BUS_Xuly();

        public void ThemMonHoc()
        {
            try
            {
                if (KiemTraTenMonHoc(DTO_MonHoc.MonHoc_TenMonHoc) == false)
                {
                    DAL_MonHoc.ThemMonHoc(DTO_MonHoc.MonHoc_MaMonHoc, DTO_MonHoc.MonHoc_TenMonHoc, DTO_MonHoc.MonHoc_LoaiMonHoc, DTO_MonHoc.MonHoc_TinChiLyThuyet, DTO_MonHoc.MonHoc_TinChiThucHanh, DTO_MonHoc.MonHoc_MaKhoa);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi thực hiện! \n" + ex.ToString());
            }
        }

        public void CapNhatMonHoc()
        {
            try
            {
                if (KiemTraTenMonHoc(DTO_MonHoc.MonHoc_TenMonHoc) == false )
                {

                    DAL_MonHoc.CapNhatMonHoc(DTO_MonHoc.MonHoc_MaMonHoc,DTO_MonHoc.MonHoc_TenMonHoc, DTO_MonHoc.MonHoc_LoaiMonHoc, DTO_MonHoc.MonHoc_TinChiLyThuyet, DTO_MonHoc.MonHoc_TinChiThucHanh, DTO_MonHoc.MonHoc_MaKhoa);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi thực hiện!\n " + ex.ToString());
            }
        }

        public void XoaMonHoc()
        {
            try
            {
                DAL_MonHoc.XoaMonHoc(DTO_MonHoc.MonHoc_MaMonHoc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi thực hiện! \n" + ex.ToString());
            }
        }

        public DataTable LoadDLMonHoc()
        {
            DataTable dt = new DataTable();
            dt = DAL_MonHoc.LoadDLMonHoc();
            return dt;
        }

        public string TaoMaMonHoc()
        {
            string ma = "";
            ma = DAL_MonHoc.TaoMaMonHoc();
            return ma;
        }

        public void LoadDLVaoCombobox_cmbMaKhoa_MH()
        {
            DAL_MonHoc.LoadDLVaoComboboxMaKhoa_MH(DTO_MonHoc.CMB);
        }

        //hàm kiểm tra tên mon hoc đã tồn tai trong csdl hay chua
        private bool KiemTraTenMonHoc(string tenmonhoc)
        {
            bool kq = false;
            try
            {
                if (tenmonhoc == DAL_MonHoc.LayTenMonHoc(DTO_MonHoc.MonHoc_TenMonHoc))
                {
                    kq = true;
                    MessageBox.Show("Môn học này đã có trong danh sách");
                }
                else
                    kq = false;
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện");
            }
            return kq;
        }


        public void GoiYTimMH()
        {
            GoiYTimKiemMH(DTO_MonHoc.TXTTIMKIEM, DTO_MonHoc.COLUMN);
        }

        public DataTable TimKiemMH()
        {
            DataTable dt = new DataTable();
            dt = DAL_MonHoc.TimKiemMonHoc(DTO_MonHoc.COTTIMKIEM, DTO_MonHoc. DKTIm);
            return dt;
        }

        public void GoiYTimKiemMH(TextBox txt, int column)
        {
            BUS_xuly.TextBox_AutoComplete(txt, "MonHoc", column);
        }
    }
}
