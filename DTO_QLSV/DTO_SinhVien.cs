using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO_QLSV
{
    public class DTO_SinhVien
    {
        private string _SinhVien_MaSinhVien;
        private string _SinhVien_HoTen;
        private string _SinhVien_QueQuan;
        private DateTime _SinhVien_NgaySinh;
        private string _SinhVien_NoiSinh;
        private string _SinhVien_GioiTinh;
        private string _SinhVien_Hinh;
        private string _SinhVien_MaNganh;
        private string _SinhVien_Malop;


        private int column;
        private TextBox txt;
        private string field;//columname
        private string DKTim;//giá trị tìm
        private ComboBox cmb;

        public ComboBox CMB
        {
            get { return cmb; }
            set { cmb = value; }
        }
        public String FIELD//column name
        {
            get { return field; }
            set { field = value; }
        }
        public string DKTIM
        {
            get { return DKTim; }
            set { DKTim = value; }
        }
        public int COLUMN
        {
            get { return column; }
            set { column = value; }
        }
        public TextBox TXT//tìm kiếm
        {
            get { return txt; }
            set { txt = value; }
        }

        public string SinhVien_MaSinhVien
        {
            get { return _SinhVien_MaSinhVien; }
            set
            {
                _SinhVien_MaSinhVien = value;

            }
        }
        public string SinhVien_HoTen
        {
            get { return _SinhVien_HoTen; }
            set
            {
                _SinhVien_HoTen = value;                             
            }
        }
        public string SinhVien_QueQuan
        {
            get { return _SinhVien_QueQuan; }
            set
            {
                _SinhVien_QueQuan = value;
            }
        }
        public DateTime SinhVien_NgaySinh
        {
            get { return _SinhVien_NgaySinh; }
            set { _SinhVien_NgaySinh = value; }
        }
        public string SinhVien_NoiSinh
        {
            get { return _SinhVien_NoiSinh; }
            set
            {
                _SinhVien_NoiSinh = value;

              
            }
        }
        public string SinhVien_GioiTinh
        {
            get { return _SinhVien_GioiTinh; }
            set { _SinhVien_GioiTinh = value; }
        }
        public string SinhVien_Hinh
        {
            get { return _SinhVien_Hinh; }
            set { _SinhVien_Hinh = value; }
        }
        public string SinhVien_MaNganh
        {
            get { return _SinhVien_MaNganh; }
            set

            {
                _SinhVien_MaNganh = value;
            }
        }
        public string SinhVien_MaLop
        {
            get { return _SinhVien_Malop; }
            set

            {
                _SinhVien_Malop = value;
            }

        }
        public DTO_SinhVien()
        {

        }
        public DTO_SinhVien(string MaSinhVien,string HoTen,string QueQuan,DateTime NgaySinh,string NoiSinh,string GioiTinh,string Hinh, string MaNganh,string malop)
        {
            this._SinhVien_MaSinhVien = MaSinhVien;
            this._SinhVien_HoTen = HoTen;
            this._SinhVien_QueQuan = QueQuan;
            this._SinhVien_NgaySinh = NgaySinh;
            this._SinhVien_NoiSinh = NoiSinh;
            this._SinhVien_GioiTinh = GioiTinh;
            this._SinhVien_Hinh = Hinh;
            this._SinhVien_MaNganh = MaNganh;
            this.SinhVien_MaLop = malop;
        }
    }
}
