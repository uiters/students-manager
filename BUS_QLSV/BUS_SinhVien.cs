using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLSV;
using DTO_QLSV;
using System.Windows.Forms;

namespace BUS_QLSV
{
    public class BUS_SinhVien
    {
        DAL_SinhVien DalSinhVien = new DAL_SinhVien();
        DTO_SinhVien DtoSinhVien = new DTO_SinhVien();
        BUS_Xuly BUS_xuly = new BUS_Xuly();

        private string table = "SinhVien";
        
        public void ThemSinhVien(string masv,string hoten,string quequan,DateTime ngaysinh,string noisinh,string hinh,string gioitinh,string manganh)
        {
            // DtoSinhVien.SinhVien_MaSinhVien, DtoSinhVien.SinhVien_HoTen, DtoSinhVien.SinhVien_QueQuan, DtoSinhVien.SinhVien_NgaySinh, DtoSinhVien.SinhVien_NoiSinh, DtoSinhVien.SinhVien_GioiTinh, DtoSinhVien.SinhVien_MaNganh, DtoSinhVien.SinhVien_Hinh
            DalSinhVien.ThemSinhVien(masv,hoten,quequan,ngaysinh,noisinh,hinh,gioitinh,manganh);
        }

        public void CapNhatSinhVien(string masv, string hoten, string quequan, DateTime ngaysinh, string noisinh, string hinh, string gioitinh, string manganh)
        {
            DalSinhVien.CapNhatSinhVien(masv, hoten, quequan, ngaysinh, noisinh, hinh, gioitinh, manganh);
        }

        public void XoaSinhVien(string masv)
        {
            DalSinhVien.XoaSinhVien(masv);
        }

        public string TaoMaSinhVien()
        {
            string msv = DalSinhVien.TaoMaSinhVien();
            return msv;
        }

        public DataTable LoadDL()
        {
            DataTable dt = new DataTable();
            dt = DalSinhVien.LoadDL();
            return dt;
        }

        public void TextBoxAutoComplete(TextBox TXT,string table,int column)
        {
            this.table = table;
            BUS_xuly.TextBox_AutoComplete(TXT, table, column);
        }

        public DataTable TimKiemSV()
        {
            DataTable dt = new DataTable();
            dt = DalSinhVien.TimKiemSV(DtoSinhVien.FIELD, DtoSinhVien.DKTIM);
            return dt;
        }

        public void LayDLVaoComboboxMaNganh(ComboBox CMB)
        {
            DalSinhVien.LayMaNganhVaoComBoboxMaNganh(CMB);
        }
    }
}
