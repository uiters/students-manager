using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO_QLSV
{
    public class DTO_Diem
    {
        private string _Diem_MaMonHoc;
        private string _Diem_MaSinhVien;
        private float _Diem_SoDiem;
        private int _Diem_LanThi;

        private ListBox lb;
        private TextBox txtMSV;
        private TextBox txtTimMsv;
        public TextBox txtTIMMSV
        {
            get { return txtTimMsv; }
            set { txtTimMsv = value; }
        }
        public TextBox TXTMSV
        {
            get { return txtMSV; }
            set { txtMSV = value; }
        }

        public ListBox LISTBOX
        {
            get { return lb; }
            set { lb = value; }
        }

        public string Diem_MaMonHoc
        {
            get { return _Diem_MaMonHoc; }
            set { _Diem_MaMonHoc = value; }
        }
        public string Diem_MaSinhVien
        {
            get { return Diem_MaSinhVien; }
            set { Diem_MaSinhVien = value; }
        }
        public float Diem_SoDiem
        {
            get { return Diem_SoDiem; }
            set { Diem_SoDiem = value; }
        }
        public int Diem_LanThi
        {
            get { return Diem_LanThi; }
            set { Diem_LanThi = value; }
        }
        public DTO_Diem() {  }
        public DTO_Diem(string MaMonHoc, string MaSinhVien, float SoDiem, int LanThi)
        {
            this.Diem_MaMonHoc = MaMonHoc;
            this.Diem_MaSinhVien = MaSinhVien;
            this.Diem_SoDiem = SoDiem;
            this.Diem_LanThi = LanThi;
        }

    }
}
