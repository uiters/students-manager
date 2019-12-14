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
        public void ThemLop(string malop,string tenlop,bool loailop,string nienkhoa,DateTime BD,DateTime KT,string mamh,string magv)
        {
            try
            {
                if ((KT.Day - BD.Day > 0) || (KT.Month - BD.Month > 0) || (KT.Year - BD.Year > 0))
                {

                    Dal_Lop.ThemLop(malop, tenlop, loailop, nienkhoa, BD, KT, mamh, magv);
                }


            }
            catch(Exception e)

            {
                MessageBox.Show("Có lỗi khi thực hiện! ",e.ToString());
            }

        }
        public void CapNhatLop(string malop, string tenlop, bool loailop, string nienkhoa, DateTime BD, DateTime KT,string mamh,string magv)
        {
            try
            {
                if ((KT.Day - BD.Day > 0) || (KT.Month - BD.Month > 0) || (KT.Year - BD.Year > 0))
                {

                    Dal_Lop.CapNhatLop(malop, tenlop, loailop, nienkhoa, BD, KT, mamh, magv);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện! ");
            }

        }

        public void XoaLop(string malop)
        {
            try
            {
                Dal_Lop.XoaLop(malop);
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


        public void LoadDLVaoCombobox_GiaoVien(ComboBox giaovien)
        {
            Dal_Lop.LayDLVaoCombobox_MaGiaoVien(giaovien);
        }
        public void LoadDLVaoCombobox_MonHoc(ComboBox monhoc)
        {
            Dal_Lop.LayDLVaoCombobox_MaMonHoc(monhoc);
        }

        public DataTable TimKiemLop(string columnName,string timkiem,string table)
        {
            DataTable dt = new DataTable();
            dt = Dal_Lop.TimKiemLop(columnName,timkiem,table);
            return dt;
        }

        public void GoiYTimKiem(TextBox txt,string table, int column)
        {
            
            BUS_xuly.TextBox_AutoComplete(txt, table, column);
        }
    }
}
