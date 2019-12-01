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
    public class BUS_Hoc
    {
        DAL_Hoc DalHoc = new DAL_Hoc();

        public DataTable getHoc()
        {
            return DalHoc.getHoc();
        }
        public bool ThemHoc(DTO_Hoc hoc)
        {
            return DalHoc.ThemHoc(hoc);
        }
        public bool SuaHoc(DTO_Hoc hoc)
        {
            return DalHoc.SuaHoc(hoc);
        }
        public bool XoaHoc(DTO_Hoc hoc)
        {
            return DalHoc.XoaHoc(hoc);
        }
    }
}
