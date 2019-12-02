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

        public void ThemKhoa(DTO_Khoa khoa)
        {
            DalKhoa.ThemKhoa(khoa);
        }
        public void SuaKhoa(DTO_Khoa khoa)
        {
            DalKhoa.SuaKhoa(khoa);
        }
        public void XoaKhoa(DTO_Khoa khoa)
        {
            DalKhoa.XoaKhoa(khoa);
        }
    }
}
