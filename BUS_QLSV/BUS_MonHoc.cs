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

        public void ThemMonHoc(string mamh,string tenmh,bool loaimonhoc,int lythuyet,int thuchanh,string makhoa)
        {
            try
            {
                if (KiemTraTenMonHoc(tenmh) == false)
                {
                    DAL_MonHoc.ThemMonHoc(mamh, tenmh, loaimonhoc, lythuyet, thuchanh, makhoa);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi thực hiện! \n" + ex.ToString());
            }
        }

        public void CapNhatMonHoc(string mamh, string tenmh, bool loaimonhoc, int lythuyet, int thuchanh, string makhoa)
        {
            try
            {
                if (KiemTraTenMonHoc(tenmh) == false )
                {

                    DAL_MonHoc.CapNhatMonHoc(mamh, tenmh, loaimonhoc, lythuyet, thuchanh, makhoa);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi thực hiện!\n " + ex.ToString());
            }
        }

        public void XoaMonHoc(string mamh)
        {
            try
            {
                DAL_MonHoc.XoaMonHoc(mamh);
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

        public void LoadDLVaoCombobox_cmbMaKhoa_MH(ComboBox CMB)
        {
            DAL_MonHoc.LoadDLVaoComboboxMaKhoa_MH(CMB);
        }

        //hàm kiểm tra tên mon hoc đã tồn tai trong csdl hay chua
        private bool KiemTraTenMonHoc(string tenmonhoc)
        {
            bool kq = false;
            try
            {
                if (tenmonhoc == DAL_MonHoc.LayTenMonHoc(tenmonhoc))
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
