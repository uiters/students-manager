using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_Lop
    {
        private string _MaLop;
        private string _TenLop;
        private int _LoaiLop;
        private string _NienKhoa;
        private string _NgayBatDau;
        private string _NgayKetThuc;
        private string _MaMonHoc;
        private string _MaGiaoVien;

        public string MaLop { get { return _MaLop; } set { _MaLop = value; } }
        public string TenLop { get {return _TenLop; } set { _TenLop = value; } }
        public int LoaiLop { get {return _LoaiLop; } set { _LoaiLop = value; } }
        public string NienKhoa { get { return _NienKhoa; } set { _NienKhoa = value; } }
        public string NgayBatDau { get { return _NgayBatDau; } set { _NgayBatDau = value; } }
        public string NgayKetThuc { get { return _NgayKetThuc; } set { _NgayKetThuc = value; } }
        public string MaMonHoc { get { return _MaMonHoc; } set { _MaMonHoc = value; } }
        public string MaGiaoVien { get { return _MaGiaoVien; } set { _MaGiaoVien = value; } }
    }
}
