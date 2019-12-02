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
    public class BUS_DKMH
    {
        DAL_DKMH DalDK = new DAL_DKMH();

        public DataTable getDKMH()
        {
            return DalDK.getDKMH();
        }
        public void ThemDKMH(DTO_DKMH dk)
        {
            DalDK.ThemDKMH(dk);
        }
        public void SuaDKMH(DTO_DKMH dk)
        {
           DalDK.SuaDKMH(dk);
        }
        public void XoaDKMH(DTO_DKMH dk)
        {
            DalDK.XoaDKMH(dk);
        }
    }
}
