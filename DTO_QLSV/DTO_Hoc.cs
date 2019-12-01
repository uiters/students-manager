using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_Hoc
    {
        private string _MaSinhVien;
        private string _MaLop;

        public string MaSinhVien { get => _MaSinhVien; set => _MaSinhVien = value; }
        public string MaLop { get => _MaLop; set => _MaLop = value; }
    }
}
