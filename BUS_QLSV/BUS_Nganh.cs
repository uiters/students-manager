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
        public void ThemNganh()
        {
            try
            {
                DAL_Nganh.ThemNganh(DTO_Nganh.Nganh_MaNganh, DTO_Nganh.Nganh_TenNganh, DTO_Nganh.Nganh_GhiChu, DTO_Nganh.Nganh_MaKhoa);
            }
            catch
            {

            }
        }

        public void CapNhatNganh()
        {
            try
            {
                DAL_Nganh.CapNhatNganh(DTO_Nganh.Nganh_MaNganh, DTO_Nganh.Nganh_TenNganh, DTO_Nganh.Nganh_GhiChu, DTO_Nganh.Nganh_MaKhoa);            
            }
            catch
            {

            }
        }

        public void XoaNganh()
        {
            try
            {
                DAL_Nganh.XoaNganh(DTO_Nganh.Nganh_MaNganh);
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
