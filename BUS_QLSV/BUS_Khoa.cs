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
    public class BUS_Khoa
    {
        DAL_Khoa DalKhoa = new DAL_Khoa();

        public DataTable getKhoa()
        {
            return DalKhoa.getKhoa();
        }

        public bool ThemKhoa(DTO_Khoa khoa)
        {
            return DalKhoa.ThemKhoa(khoa);
        }
        public bool SuaKhoa(DTO_Khoa khoa)
        {
            return DalKhoa.SuaKhoa(khoa);
        }
        public bool XoaKhoa(DTO_Khoa khoa)
        {
            return DalKhoa.XoaKhoa(khoa);
        }
    }
}
