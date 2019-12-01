using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_GiaoVien
    {
        private string _MaGiaoVien;
        private string _TenGiaoVien;
        private string _GhiChu;
        private string _MaKhoa;

        public string MaGiaoVien { get => _MaGiaoVien; set => _MaGiaoVien = value; }
        public string TenGiaoVien { get => _TenGiaoVien; set => _TenGiaoVien = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
        public string MaKhoa { get => _MaKhoa; set => _MaKhoa = value; }
    }
}
