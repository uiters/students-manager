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

        public DataTable TimKiemSVDK()
        {
            DataTable dt = new DataTable();
            dt = DalDK.TimKiemMHDK(DTO_DKMH.DKMH_MaSinhVien);
            return dt;
        }

        public void LoadDLVao_cmbMaMonHoc_DK()
        {
            DalDK.LoadDLVaoCombobox(DTO_DKMH.CMB);
        }


        public void GoiYTimKiem()
        {
            GoiYTimKiem(DTO_DKMH.TXTTIM);
        }

        public void GoiYMSSV()
        {
            GoiYTimMSSV(DTO_DKMH.TXTMSV);
        }

        public string LayTenSV()
        {
            string ten = "";
            ten = DalDK.LayTenSV(DTO_DKMH.DKMH_MaSinhVien);
            return ten;
        }
        public void GoiYTimKiem(TextBox txt)
        {
            BUS_xuly.TextBox_AutoComplete(txt, "DK_MonHoc", 1);
        }

        public void GoiYTimMSSV(TextBox txt)
        {
            BUS_xuly.TextBox_AutoComplete(txt, "SinhVien", 0);
        }
    }
}
