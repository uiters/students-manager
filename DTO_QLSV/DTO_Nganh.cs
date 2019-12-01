using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_Nganh
    {
        private string _MaNganh;
        private string _TenNganh;
        private string _GhiChu;
        private string _MaKhoa;

        public string MaNganh { get => _MaNganh; set => _MaNganh = value; }
        public string TenNganh { get => _TenNganh; set => _TenNganh = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
        public string MaKhoa { get => _MaKhoa; set => _MaKhoa = value; }
    }
}
