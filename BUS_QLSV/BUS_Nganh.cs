using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLSV;
using DTO_QLSV;

namespace BUS_QLSV
{
    public class BUS_Nganh
    {
        DAL_Nganh DalNganh = new DAL_Nganh();
        public DataTable getNganh()
        {
            return DalNganh.getNganh();
        }
        
        public void ThemKhoa(DTO_Nganh nganh)
        {
            DalNganh.ThemNganh(nganh);
        }
        public void SuaNganh(DTO_Nganh nganh)
        {
            DalNganh.SuaNganh(nganh);
        }
        public void XoaNganh(DTO_Nganh nganh)
        {
           DalNganh.XoaNganh(nganh);
        }
    }
}
