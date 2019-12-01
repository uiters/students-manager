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
    public class BUS_MonHoc
    {
        DAL_MonHoc DalMonHoc = new DAL_MonHoc();
        public DataTable getMonhoc()
        {
            return DalMonHoc.getMonHoc();
        }
        public bool ThemMonHoc(DTO_MonHoc mh)
        {
            return DalMonHoc.ThemMonHoc(mh);
        }

        public bool SuaMonHoc(DTO_MonHoc mh)
        {
            return DalMonHoc.SuaMonHoc(mh);
        }

        public bool XoaMonHoc(DTO_MonHoc mh)
        {
            return DalMonHoc.XoaMonHoc(mh);
        }
    }
}
