using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_DKMH
    {
        private string _MaSinhVien;
        private string _MaMonHoc;

        public string MaSinhVien { get => _MaSinhVien; set => _MaSinhVien = value; }
        public string MaMonHoc { get => _MaMonHoc; set => _MaMonHoc = value; }
    }
}
