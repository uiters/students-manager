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
        public bool ThemLop(DTO_Lop lop)
        {
            return DalLop.ThemLop(lop);
        }
        public bool SuaLop(DTO_Lop lop)
        {
            return DalLop.SuaLop(lop);
        }
        public bool XoaLop(DTO_Lop lop)
        {
            return DalLop.XoaLop(lop);
        }
    }
}
