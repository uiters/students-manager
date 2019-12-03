using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_SinhVien
    {
        private string _SinhVien_MaSinhVien;
        private string _SinhVien_HoTen;
        private string _SinhVien_QueQuan;
        private string _SinhVien_NgaySinh;
        private string _SinhVien_NoiSinh;
        private string _SinhVien_GioiTinh;
        private string _SinhVien_Hinh;
        private string _SinhVien_MaNganh;

        public string SinhVien_MaSinhVien
        {
            get => _SinhVien_MaSinhVien;
            set => _SinhVien_MaSinhVien = value;
        }
        public string SinhVien_HoTen
        {
            get => _SinhVien_HoTen;
            set => _SinhVien_HoTen = value;
        }
        public string SinhVien_QueQuan
        {
            get => _SinhVien_QueQuan;
            set => _SinhVien_QueQuan = value;
        }
        public string SinhVien_NgaySinh
        {
            get => _SinhVien_NgaySinh;
            set => _SinhVien_NgaySinh = value;
        }
        public string SinhVien_NoiSinh
        {
            get => _SinhVien_NoiSinh;
            set => _SinhVien_NoiSinh = value;
        }
        public string SinhVien_GioiTinh
        { get => _SinhVien_GioiTinh;
            set => _SinhVien_GioiTinh = value;
        }
        public string SinhVien_Hinh
        { get => _SinhVien_Hinh;
            set => _SinhVien_Hinh = value;
        }
        public string SinhVien_MaNganh
        { get => _SinhVien_MaNganh;
            set => _SinhVien_MaNganh = value;
        }
        public DTO_SinhVien(string MaSinhVien,string HoTen,string QueQuan,string NgaySinh,string NoiSinh,string GioiTinh,string Hinh, string MaNganh)
        {
            this.SinhVien_MaSinhVien = MaSinhVien;
            this.SinhVien_HoTen = HoTen;
            this.SinhVien_QueQuan = QueQuan;
            this.SinhVien_NgaySinh = NgaySinh;
            this.SinhVien_NoiSinh = NoiSinh;
            this._SinhVien_GioiTinh = GioiTinh;
            this._SinhVien_Hinh = Hinh;
            this.SinhVien_MaNganh = MaNganh;
        }
    }
}
