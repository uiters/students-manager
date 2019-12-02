using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_Diem
    {
        private string _Diem_MaMonHoc;
        private string _Diem_MaSinhVien;
        private int _Diem_SoDiem;
        private int _Diem_LanThi;

        public string Diem_MaMonHoc { get => _Diem_MaMonHoc; set => _Diem_MaMonHoc = value; }
        public string Diem_MaSinhVien { get => _Diem_MaSinhVien; set => _Diem_MaSinhVien = value; }
        public int Diem_SoDiem { get => _Diem_SoDiem; set => _Diem_SoDiem = value; }
        public int Diem_LanThi { get => _Diem_LanThi; set => _Diem_LanThi = value; }
        public DTO_Diem(string MaMonHoc, string MaSinhVien, int SoDien, int LanThi)
        {
            this.Diem_MaMonHoc = MaMonHoc;
            this.Diem_MaSinhVien = MaSinhVien;
            this.Diem_SoDiem = SoDien;
            this.Diem_LanThi = LanThi;
        }

    }
}
