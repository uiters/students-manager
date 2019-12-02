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
        public void ThemSinhVien(DTO_SinhVien sv)
        {
            DalSinhVien.ThemSinhVien(sv);
        }

        public void SuaSinhVien(DTO_SinhVien sv)
        {
           DalSinhVien.SuaSinhVien(sv);
        }

        public void XoaSinhVien(DTO_SinhVien sv)
        {
            DalSinhVien.XoaSinhVien(sv);
        }
    }
}
