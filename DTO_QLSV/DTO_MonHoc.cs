using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO_QLSV
{
    public class DTO_MonHoc
    {
        private string _MonHoc_MaMonHoc;
        private string _MonHoc_TenMonHoc;
        private bool _MonHoc_LoaiMonHoc;
        private int _MonHoc_TinChiLyThuyet;
        private int _MonHoc_TinChiThucHanh;
        private string _MonHoc_MaKhoa;

        private ComboBox cmb;
        private string CotTimKiem;
        private TextBox txtTimKiem;
        private int Column;
        private string Dktim;

        public string DKTIm
        {
            get { return Dktim; }
            set { Dktim = value; }
        }
        public string COTTIMKIEM
        {
            get { return CotTimKiem; }
            set { CotTimKiem = value; }
        }
        public int COLUMN
        {
            get { return Column; }
            set { Column = value; }
        }
        public TextBox TXTTIMKIEM
        {
            get { return txtTimKiem; }
            set { txtTimKiem = value; }
        }
        public ComboBox CMB
        {
            get { return cmb; }
            set { cmb = value; }
        }


        public string MonHoc_MaMonHoc
        {
            get { return _MonHoc_MaMonHoc; }
            set { _MonHoc_MaMonHoc = value; }
        }

        public string MonHoc_TenMonHoc
        {
            get { return _MonHoc_TenMonHoc; }
            set { _MonHoc_TenMonHoc = value; }
        }

        public bool MonHoc_LoaiMonHoc
        {
            get { return _MonHoc_LoaiMonHoc; }
            set { _MonHoc_LoaiMonHoc = value; }
        }

        public int MonHoc_TinChiLyThuyet
        {
            get { return _MonHoc_TinChiLyThuyet; }
            set { _MonHoc_TinChiLyThuyet = value; }
        }

        public int MonHoc_TinChiThucHanh
        {
            get { return _MonHoc_TinChiThucHanh; }
            set { _MonHoc_TinChiThucHanh = value; }
        }

        public string MonHoc_MaKhoa
        {
            get { return _MonHoc_MaKhoa; }
            set { _MonHoc_MaKhoa = value; }
        }

        public DTO_MonHoc()
        {

        }

        public DTO_MonHoc(string MaMonHoc, string TenMonHoc, bool LoaiMonHoc, int TinChiLyThuyet, int TinChiThucHanh, string MaKhoa)
        {
            this.MonHoc_MaMonHoc = MaMonHoc;
            this.MonHoc_TenMonHoc = TenMonHoc;
            this.MonHoc_LoaiMonHoc = LoaiMonHoc;
            this.MonHoc_TinChiLyThuyet = TinChiLyThuyet;
            this.MonHoc_TinChiThucHanh = TinChiThucHanh;
            this.MonHoc_MaKhoa = MaKhoa;

        }
    }
}
