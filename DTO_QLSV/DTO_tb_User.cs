using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_tb_User
    {
        private int _Usertype;
        private string _Username;
        private string _Pass;

        public int Usertype { get => _Usertype; set => _Usertype = value; }
        public string Username { get => _Username; set => _Username = value; }
        public string Pass { get => _Pass; set => _Pass = value; }
    }
}
