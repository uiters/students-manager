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
    
    public class BUS_DKMH
    {
        DAL_DKMH DalDK = new DAL_DKMH();
        BUS_Xuly BUS_xuly = new BUS_Xuly();
        DTO_DKMH DTO_DKMH = new DTO_DKMH();

        public DataTable LoadDL_DKMonHoc()
        {
            DataTable dt = new DataTable();
            dt = DalDK.LoadDL_DKMonHoc();
            return dt;
        }

        public DataTable TimKiemSVDK(string masv)
        {
            DataTable dt = new DataTable();
            dt = DalDK.TimKiemMHDK(masv);
            return dt;
        }
        public void TuDongHoanThanh(TextBox TXT, string table, int column)
        {
            table = "SinhVien";
            BUS_xuly.TextBox_AutoComplete(TXT, table, column);
        }

        public string LayTenSV(string hoten)
        {
            string ten = "";
            ten = DalDK.LayTenSV(hoten);
            return ten;
        }

    }
}
