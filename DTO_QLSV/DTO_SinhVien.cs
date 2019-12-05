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

        private int column;
        private TextBox txt;
        private string field;
        private string DKTim;
        private ComboBox cmb;

        public ComboBox CMB
        {
            get { return cmb; }
            set { cmb = value; }
        }
        public String FIELD
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
            get { return SinhVien_MaSinhVien; }
            set
            {

                SinhVien_MaSinhVien = value;
                if (this.SinhVien_MaSinhVien == "")
                {
                    MessageBox.Show("Chưa nhập mã số sinh viên! ");
                    return;
                }
            }
        }
        public string SinhVien_HoTen
        {
            get { return _SinhVien_HoTen; }
            set
            {
                _SinhVien_HoTen = value;

                if (this._SinhVien_HoTen == "")
                {
                    MessageBox.Show("Chưa nhập họ tên sinh viên! ");
                    return;
                }
                
            }
        }
        public string SinhVien_QueQuan
        {
            get { return SinhVien_QueQuan; }
            set
            {
                SinhVien_QueQuan = value;

                if (this.SinhVien_QueQuan == "")
                {
                    MessageBox.Show("Chưa nhập quê quán! ");
                    return;
                }
              

            }
        }
        public DateTime SinhVien_NgaySinh
        {
            get { return SinhVien_NgaySinh; }
            set { SinhVien_NgaySinh = value; }
        }
        public string SinhVien_NoiSinh
        {
            get { return SinhVien_NoiSinh; }
            set
            {
                SinhVien_NoiSinh = value;

                if (this.SinhVien_NoiSinh == "")
                {
                    MessageBox.Show("Chưa nhập nơi sinh! ");
                    return;
                }
              
            }
        }
        public string SinhVien_GioiTinh
        {
            get { return SinhVien_GioiTinh; }
            set { SinhVien_GioiTinh = value; }
        }
        public string SinhVien_Hinh
        {
            get { return SinhVien_Hinh; }
            set { SinhVien_Hinh = value; }
        }
        public string SinhVien_MaNganh
        {
            get { return SinhVien_MaNganh; }
            set

            {

                SinhVien_MaNganh = value;
                if (SinhVien_MaNganh == "")
                {
                    MessageBox.Show("Vui lòng Chọn Mã ngành!");
                    return;
                }
            }
        }
        public DTO_SinhVien()
        {

        }
        public DTO_SinhVien(string MaSinhVien,string HoTen,string QueQuan,DateTime NgaySinh,string NoiSinh,string GioiTinh,string Hinh, string MaNganh)
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
