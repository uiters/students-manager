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
        public void ThemDiem(DTO_Diem diem)
        {
            DalDiem.ThemDiem(diem);
        }
        public void SuaDiem(DTO_Diem diem)
        {
            DalDiem.SuaDiem(diem);
        }
        public void XoaDiem(DTO_Diem diem)
        {
            DalDiem.XoaDiem(diem);
        }
    }
}
