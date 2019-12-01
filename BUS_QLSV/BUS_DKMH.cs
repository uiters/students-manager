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
        public bool ThemDKMH(DTO_DKMH dk)
        {
            return DalDK.ThemDKMH(dk);
        }
        public bool SuaDKMH(DTO_DKMH dk)
        {
            return DalDK.SuaDKMH(dk);
        }
        public bool XoaDKMH(DTO_DKMH dk)
        {
            return DalDK.XoaDKMH(dk);
        }
    }
}
