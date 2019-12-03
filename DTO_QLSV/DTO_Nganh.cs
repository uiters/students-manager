using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_Nganh
    {
        private string _Nganh_MaNganh;
        private string _Nganh_TenNganh;
        private string _Nganh_GhiChu;
        private string _Nganh_MaKhoa;

        public string Nganh_MaNganh
        {
            get => _Nganh_MaNganh;
            set => _Nganh_MaNganh = value;
        }
        public string Nganh_TenNganh
        {
            get => _Nganh_TenNganh;
            set => _Nganh_TenNganh = value;
        }
        public string Nganh_GhiChu
        {
            get => _Nganh_GhiChu;
            set => _Nganh_GhiChu = value;
        }
        public string Nganh_MaKhoa
        {
            get => _Nganh_MaKhoa;
            set => _Nganh_MaKhoa = value;
        }
        public DTO_Nganh(string MaNganh, string TenNganh, string GhiChu, string MaKhoa)
        {
            this.Nganh_MaNganh = MaNganh;
            this.Nganh_TenNganh = TenNganh;
            this.Nganh_GhiChu = GhiChu;
            this.Nganh_MaKhoa = MaKhoa;
        }
    }
}
