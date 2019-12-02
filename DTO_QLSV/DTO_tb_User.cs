using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_tb_User
    {
        private int _tb_User_Usertype;
        private string _tb_User_Username;
        private string _tb_User_Pass;

        public int tb_User_Usertype { get => _tb_User_Usertype; set => _tb_User_Usertype = value; }
        public string tb_User_Username { get => _tb_User_Username; set => _tb_User_Username = value; }
        public string tb_User_Pass { get => _tb_User_Pass; set => _tb_User_Pass = value; }
        public DTO_tb_User(int Usertype,string Username, string Pass)
        {
            this.tb_User_Usertype = Usertype;
            this.tb_User_Username = Username;
            this.tb_User_Pass = Pass;
        }
    }
}
