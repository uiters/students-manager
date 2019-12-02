using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
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
        public void ThemMonHoc(DTO_MonHoc mh)
        {
            DalMonHoc.ThemMonHoc(mh);
        }

        public void SuaMonHoc(DTO_MonHoc mh)
        {
            DalMonHoc.SuaMonHoc(mh);
        }

        public void XoaMonHoc(DTO_MonHoc mh)
        {
            DalMonHoc.XoaMonHoc(mh);
        }
    }
}
