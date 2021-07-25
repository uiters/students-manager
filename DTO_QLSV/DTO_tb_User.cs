using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Data;
using System.Windows.Forms;

namespace DTO_QLSV
{
    public class DTO_tb_User 
    {

        // TÀI KHOẢN
        private string User;
        private string Pass;
        private string newPass;
        private bool Id;

        //sử dụng để gọi ý tìm kiếm
        private TextBox txt = new TextBox();
        private string table = "tb_User";
        private int column = 1;


        public TextBox TXT
        {
            get { return txt; }
            set { txt = value; }
        }
        public string Table { get { return table; }  }
        public int Column { get {return column; } }
        public string NEWPASS
        {
            get { return newPass; }
            set
            {
                newPass = value;

            }
        }
        public string PASS
        {
            get { return Pass; }
            set
            {
                Pass = value;

            }
        }
        public string USER
        {
            get
            {
                return User ;
            }
            set
            {
                User = value;

            }
        }
        public bool ID
        {
            get { return Id; }
            set { Id = value; }

        }
        public DTO_tb_User()
        {

        } 
        public DTO_tb_User(string username,string pass,bool id)
        {
            User = username;
            Pass = pass;
            Id = id;
        }
        public DTO_tb_User(string username, string pass)
        {
            User = username;
            Pass = pass;
            Id = false;
        }

    }
}
