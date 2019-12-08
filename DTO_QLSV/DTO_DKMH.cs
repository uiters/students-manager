using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO_QLSV
{
    public class DTO_DKMH
    {
        private string _DKMH_MaSinhVien;
        private string _DKMH_MaMonHoc;       
        private TextBox txtTim;
        private TextBox txtMsv;


        public TextBox TXTMSV
        {
            get { return txtMsv; }
            set { txtMsv = value; }
        }
        public TextBox TXTTIM
        {
            get { return txtTim; }
            set { txtTim = value; }
        }
        public string DKMH_MaSinhVien
        {
            get { return _DKMH_MaSinhVien; }
            set { _DKMH_MaSinhVien = value; }
        }
        public string DKMH_MaMonHoc
        {
            get { return _DKMH_MaMonHoc; }
            set { _DKMH_MaMonHoc = value; }
        }
        public DTO_DKMH()
        { }
        public DTO_DKMH(string MaSinhVien, string MaMonHoc )
        {
            this.DKMH_MaSinhVien = MaSinhVien;
            this.DKMH_MaMonHoc = MaMonHoc;
        }
    }
}
