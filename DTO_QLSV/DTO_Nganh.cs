using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO_QLSV
{
    public class DTO_Nganh
    {
        private string _Nganh_MaNganh;
        private string _Nganh_TenNganh;
        private string _Nganh_GhiChu;
        private string _Nganh_MaKhoa;
        private ComboBox _Nganh_cmbMaKhoa;

        public ComboBox Nganh_cmbMaKhoa
        {
            get { return _Nganh_cmbMaKhoa; }
            set { _Nganh_cmbMaKhoa = value; }

        }



        public string Nganh_MaNganh
        {
            get { return _Nganh_MaNganh; }
            set { _Nganh_MaNganh = value; }
        }
        public string Nganh_TenNganh
        {
            get { return _Nganh_TenNganh; }
            set { _Nganh_TenNganh = value; }
        }
        public string Nganh_GhiChu
        {
            get { return _Nganh_GhiChu; }
            set { _Nganh_GhiChu = value; }
        }
        public string Nganh_MaKhoa
        {
            get { return _Nganh_MaKhoa; }
            set { _Nganh_MaKhoa = value; }
        }
        public DTO_Nganh()
        {
        }
        public DTO_Nganh(string MaNganh, string TenNganh, string GhiChu, string MaKhoa)
        {
            this._Nganh_MaNganh = MaNganh;
            this._Nganh_TenNganh = TenNganh;
            this._Nganh_GhiChu = GhiChu;
            this._Nganh_MaKhoa = MaKhoa;
        }
    }
}
