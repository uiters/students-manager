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
    public class BUS_Diem
    {
        DAL_Diem DalDiem = new DAL_Diem();

        public DataTable getDiem()
        {
            return DalDiem.getDiem();
        }
        public bool ThemDiem(DTO_Diem diem)
        {
            return DalDiem.ThemDiem(diem);
        }
        public bool SuaDiem(DTO_Diem diem)
        {
            return DalDiem.SuaDiem(diem);
        }
        public bool XoaDiem(DTO_Diem diem)
        {
            return DalDiem.XoaDiem(diem);
        }
    }
}
