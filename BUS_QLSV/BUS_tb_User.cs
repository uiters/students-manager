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
    public class BUS_tb_User
    {
        DAL_tb_User User = new DAL_tb_User();

        public DataTable getUser()
        {
            return User.getUser();
        }
        public void ThemUser(DTO_tb_User user)
        {
            User.ThemUser(user);
        }
        public void XoaUser(DTO_tb_User user)
        {
            User.XoaUser(user);
        }

    }
}
