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
    public class BUS_Diem
    {
        DAL_Diem DalDiem = new DAL_Diem();
        BUS_Xuly BUS_xuly = new BUS_Xuly();
        DTO_Diem DTO_Diem = new DTO_Diem();

        public DataTable LayDuLieuKhoa()
        {
            DataTable dt = new DataTable();

            dt = DalDiem.LayDuLieuKhoa();

            return dt;
        }

        //public DataTable LayDSMonHoc()
        //{
        //    DataTable dt = new DataTable();

        //    dt = DalDiem.LayDSMonHoc();
        //    return dt;
        //}

        public void NhapDiem(string mmh,string mssv,float diem,int lanthi)
        {
            try
            {
                if (mssv == "")
                {

                    MessageBox.Show("Vui lòng nhập mã số sinh viên ! ");
                    return;
                }
                DalDiem.NhapDiem(mmh,mssv,diem,lanthi);
            }
            catch
            {

                MessageBox.Show("Không tồn tại sinh viên có mã số: " + DTO_Diem.Diem_MaSinhVien + ".\n Hoặc Sinh viên này đã có trong danh sách cho điểm. Vui lòng thử lại! ");
                return;
            }

        }
     
        public void XoaDiem(string mmh,string mssv)
        {
            try
            {
                DalDiem.XoaDiem(mmh,mssv);
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi xóa \n " + ex.ToString());
            }
        }

        public void CapNhatDiem(string mmh, string mssv, float diem, int lanthi)
        {
            try
            {
                DalDiem.CapNhatDiem(mmh, mssv, diem, lanthi);
                MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Có lỗi khi cập nhật");
            }
        }

        public DataTable TracuuDiem(string mssv)
        {
            DataTable dt = new DataTable();
            dt = DalDiem.TimKiemDiem(mssv);
            return dt;
        }

        public DataTable LayDLDiem()
        {
            DataTable dt = new DataTable();
            dt = DalDiem.LayDLDiem();
            return dt;
        }

        public void LayDanhSachMonHocVaoListBox(ListBox lb,string makhoa)
        {
             DalDiem.LoadDLVaoListBox(lb, makhoa);
           // DalDiem.LoadDLVaoListBox(DTO_Diem.LISTBOX, DTO_Diem.Diem_MaMonHoc);
        }

        //Tạo từ gợi ý khi tìm kiếm
        public void GoiYMaSinhVien(TextBox txt,string table,int column)
        {
            BUS_xuly.TextBox_AutoComplete(txt, table,column);
        }
    }
}
