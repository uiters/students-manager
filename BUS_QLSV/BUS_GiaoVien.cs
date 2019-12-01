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
        public bool ThemGiaoVien(DTO_GiaoVien gv)
        {
            return DalGiaoVien.ThemGiaoVien(gv);
        }
        public bool SuaGiaoVien(DTO_GiaoVien gv)
        {
            return DalGiaoVien.SuaGiaoVien(gv);
        }
        public bool XoaGiaoVien(DTO_GiaoVien gv)
        {
            return DalGiaoVien.XoaGiaoVien(gv);
        }
    }
}
