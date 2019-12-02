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
    public class BUS_LOP
    {
        DAL_Lop DalLop = new DAL_Lop();

        public DataTable getLop()
        {
            return DalLop.getLop();
        }
        public void ThemLop(DTO_Lop lop)
        {
           DalLop.ThemLop(lop);
        }
        public void SuaLop(DTO_Lop lop)
        {
           DalLop.SuaLop(lop);
        }
        public void XoaLop(DTO_Lop lop)
        {
            DalLop.XoaLop(lop);
        }
    }
}
