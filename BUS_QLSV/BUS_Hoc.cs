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
        public void ThemHoc(DTO_Hoc hoc)
        {
            DalHoc.ThemHoc(hoc);
        }
        public void SuaHoc(DTO_Hoc hoc)
        {
            DalHoc.SuaHoc(hoc);
        }
        public void XoaHoc(DTO_Hoc hoc)
        {
            DalHoc.XoaHoc(hoc);
        }
    }
}
