using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_Diem
    {
        private string _MaMonHoc;
        private string _MaSinhVien;
        private int _SoDiem;
        private int _LanThi;

        public string MaMonHoc { get => _MaMonHoc; set => _MaMonHoc = value; }
        public string MaSinhVien { get => _MaSinhVien; set => _MaSinhVien = value; }
        public int SoDiem { get => _SoDiem; set => _SoDiem = value; }
        public int LanThi { get => _LanThi; set => _LanThi = value; }
    }
}
