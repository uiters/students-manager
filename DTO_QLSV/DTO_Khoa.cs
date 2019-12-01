using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_Khoa
    {
        private string _MaKhoa;
        private string _TenKhoa;
        private string _GhiChu;
        private string _Username;

        public string MaKhoa { get => _MaKhoa; set => _MaKhoa = value; }
        public string TenKhoa { get => _TenKhoa; set => _TenKhoa = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
        public string Username { get => _Username; set => _Username = value; }
    }
}
