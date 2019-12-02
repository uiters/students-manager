using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_GiaoVien
    {
        private string _GiaoVien_MaGiaoVien;
        private string _GiaoVien_TenGiaoVien;
        private string _GiaoVien_GhiChu;
        private string _GiaoVien_MaKhoa;

        public string GiaoVien_MaGiaoVien { get => _GiaoVien_MaGiaoVien; set => _GiaoVien_MaGiaoVien = value; }
        public string GiaoVien_TenGiaoVien { get => _GiaoVien_TenGiaoVien; set => _GiaoVien_TenGiaoVien = value; }
        public string GiaoVien_GhiChu { get => _GiaoVien_GhiChu; set => _GiaoVien_GhiChu = value; }
        public string GiaoVien_MaKhoa { get => _GiaoVien_MaKhoa; set => _GiaoVien_MaKhoa = value; }
        public DTO_GiaoVien(string MaGiaoVien, string TenGiaoVien, string GhiChu, string MaKhoa)
        {
            this.GiaoVien_MaGiaoVien = MaGiaoVien;
            this.GiaoVien_TenGiaoVien = TenGiaoVien;
            this.GiaoVien_GhiChu = GhiChu;
            this.GiaoVien_MaKhoa = MaKhoa;
        }
    }
}
