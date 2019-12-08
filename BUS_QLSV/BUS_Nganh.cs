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
    public class BUS_Nganh
    {
        DAL_Nganh DAL_Nganh = new DAL_Nganh();
        DTO_Nganh DTO_Nganh = new DTO_Nganh();
        public void ThemNganh(string manganh,string tenlop,string ghichu)
        {
            try
            {
                DAL_Nganh.ThemNganh(manganh,tenlop,ghichu);
            }
            catch
            {

            }
        }

        public void CapNhatNganh(string manganh, string tenlop, string ghichu)
        {
            try
            {
                DAL_Nganh.CapNhatNganh(manganh, tenlop, ghichu);            
            }
            catch
            {

            }
        }

        public void XoaNganh(string manganh)
        {
            try
            {
                DAL_Nganh.XoaNganh(manganh);
            }
            catch
            {

            }
        }

        public DataTable LoadDL()
        {
            DataTable dt = new DataTable();
            try
            {

                dt = DAL_Nganh.LoadDL();
            }
            catch

            {

            }
            return dt;
        }

        public string TaoMaNganh()
        {

            string maNG = "";
            maNG = DAL_Nganh.TaoMaNganh();
            return maNG;

        }
    }
}
