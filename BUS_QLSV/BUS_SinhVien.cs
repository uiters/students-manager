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
    public class BUS_SinhVien
    {
        DAL_SinhVien DalSinhVien = new DAL_SinhVien();

        public DataTable getSinhVien()
        {
            return DalSinhVien.getSinhVien();
        }
        public bool ThemSinhVien(DTO_SinhVien sv)
        {
            return DalSinhVien.ThemSinhVien(sv);
        }

        public bool SuaSinhVien(DTO_SinhVien sv)
        {
            return DalSinhVien.SuaSinhVien(sv);
        }

        public bool XoaSinhVien(DTO_SinhVien sv)
        {
            return DalSinhVien.XoaSinhVien(sv);
        }
    }
}
