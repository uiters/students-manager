using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_SinhVien
    {
        private string _MaSinhVien;
        private string _HoTen;
        private string _QueQuan;
        private string _NgaySinh;
        private string _NoiSinh;
        private string _GioiTinh;
        private string _Hinh;
        private string _MaNganh;

        public string MaSinhVien { get => _MaSinhVien; set => _MaSinhVien = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string QueQuan { get => _QueQuan; set => _QueQuan = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string NoiSinh { get => _NoiSinh; set => _NoiSinh = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string Hinh { get => _Hinh; set => _Hinh = value; }
        public string MaNganh { get => _MaNganh; set => _MaNganh = value; }
    }
}
