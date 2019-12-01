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
        
        public bool ThemKhoa(DTO_Nganh nganh)
        {
            return DalNganh.ThemNganh(nganh);
        }
        public bool SuaNganh(DTO_Nganh nganh)
        {
            return DalNganh.SuaNganh(nganh);
        }
        public bool XoaNganh(DTO_Nganh nganh)
        {
            return DalNganh.XoaNganh(nganh);
        }
    }
}
