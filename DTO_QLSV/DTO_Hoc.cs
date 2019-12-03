using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_Hoc
    {
        private string _Hoc_MaSinhVien;
        private string _Hoc_MaLop;

        public string Hoc_MaSinhVien
        {
            get => _Hoc_MaSinhVien;
            set => _Hoc_MaSinhVien = value;
        }
        public string Hoc_MaLop
        {
            get => _Hoc_MaLop;
            set => _Hoc_MaLop = value;
        }
        public DTO_Hoc(string MaSinhVien,string MaLop)
        {
            this.Hoc_MaSinhVien = MaSinhVien;
            this.Hoc_MaLop = MaLop;
        }
    }
}
