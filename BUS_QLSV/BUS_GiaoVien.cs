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
    public class BUS_GiaoVien 
    {
        DAL_GiaoVien DalGiaoVien = new DAL_GiaoVien();

        public DataTable getGiaoVien()
        {
            return DalGiaoVien.getGiaoVien();
        }
        public void ThemGiaoVien(DTO_GiaoVien gv)
        {
            DalGiaoVien.ThemGiaoVien(gv);
        }
        public void SuaGiaoVien(DTO_GiaoVien gv)
        {
            DalGiaoVien.SuaGiaoVien(gv);
        }
        public void XoaGiaoVien(DTO_GiaoVien gv)
        {
            DalGiaoVien.XoaGiaoVien(gv);
        }
    }
}
