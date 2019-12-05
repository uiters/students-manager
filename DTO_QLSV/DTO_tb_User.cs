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
        //DTO
        //sử dụng để gọi ý tìm kiếm
        private TextBox txt = new TextBox();
        


        public TextBox TXT
        {
            get { return txt; }
            set { txt = value; }
        }

        public string NEWPASS
        {
            get { return newPass; }
            set
            {
                newPass = value;
                if (this.newPass == "")
                {

                    MessageBox.Show("Vui lòng nhập mật khẩu mới");
                }
            }
        }
        public string PASS
        {
            get { return Pass; }
            set
            {
                Pass = value;
                if (this.PASS == "")
                {

                    MessageBox.Show("Vui lòng nhập mật khẩu");
                }
            }
        }
        public string USER
        {
            get { return User; }
            set
            {
                User = value;
                if (this.USER == "")
                {

                    MessageBox.Show("Chưa nhập Username");
                }
            }
        }
        public bool ID
        {
            get { return Id; }
            set { Id = value; }

        }

    }
}
