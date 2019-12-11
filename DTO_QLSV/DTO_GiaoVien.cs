using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO_QLSV
{
    public class DTO_GiaoVien
    {
        private string _GiaoVien_MaGiaoVien;
        private string _GiaoVien_TenGiaoVien;
        private string _GiaoVien_GhiChu;
        private string _GiaoVien_MaKhoa;

        private ComboBox cmbMaKhoa;
        private string Tentimkiem;
        private TextBox txt;
        private int column;
        private string Cottimkiem;

        public int COLUMN
        {
            get { return column; }
            set { column = value; }
        }

        public TextBox TXT
        {
            get { return txt; }
            set { txt = value; }
        }
        public ComboBox cmbMAKHOA
        {
            get { return cmbMaKhoa; }
            set { cmbMaKhoa = value; }
        }

        public string TENTIMKIEM
        {
            get { return Tentimkiem; }
            set { Tentimkiem = value; }
        }

        public string COTTIMKIEM
        {
            get { return Cottimkiem; }
            set { Cottimkiem = value; }
        }


        public string GiaoVien_MaGiaoVien
        {
            get { return _GiaoVien_MaGiaoVien; }
            set { _GiaoVien_MaGiaoVien = value; }
        }
        public string GiaoVien_TenGiaoVien
        {
            get { return _GiaoVien_TenGiaoVien; }
            set { _GiaoVien_TenGiaoVien = value; }
        }
        public string GiaoVien_GhiChu
        {
            get { return _GiaoVien_GhiChu; }
            set { _GiaoVien_GhiChu = value; }
        }
        public string GiaoVien_MaKhoa
        {
            get { return _GiaoVien_MaKhoa; }
            set { _GiaoVien_MaKhoa = value; }
        }
        public DTO_GiaoVien() { }
        public DTO_GiaoVien(string MaGiaoVien, string TenGiaoVien, string GhiChu, string MaKhoa)
        {
            this._GiaoVien_MaGiaoVien = MaGiaoVien;
            this._GiaoVien_TenGiaoVien = TenGiaoVien;
            this._GiaoVien_GhiChu = GhiChu;
            this._GiaoVien_MaKhoa = MaKhoa;
        }
    }
}
