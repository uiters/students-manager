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

        //    dt = qlsv_dDiem.LayDSMonHoc();
        //    return dt;
        //}

        public void NhapDiem()
        {
            try
            {
                if (DTO_Diem.Diem_MaSinhVien == "")
                {

                    MessageBox.Show("Vui lòng nhập mã số sinh viên ! ");
                    return;
                }
                DalDiem.NhapDiem(DTO_Diem.Diem_MaMonHoc, DTO_Diem.Diem_MaSinhVien, DTO_Diem.Diem_SoDiem, DTO_Diem.Diem_LanThi);
            }
            catch
            {

                MessageBox.Show("Không tồn tại sinh viên có mã số: " + DTO_Diem.Diem_MaSinhVien + ".\n Hoặc Sinh viên này đã có trong danh sách cho điểm. Vui lòng thử lại! ");
                return;
            }

        }

        public DataTable LayDLDiem()
        {
            DataTable dt = new DataTable();
            dt = DalDiem.LayDLDiem();
            return dt;
        }

        public void XoaDiem()
        {
            try
            {
                DalDiem.XoaDiem(DTO_Diem.Diem_MaMonHoc, DTO_Diem. Diem_MaSinhVien);
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi xóa \n " + ex.ToString());
            }
        }

        public void CapNhatDiem()
        {
            try
            {
                DalDiem.CapNhatDiem(DTO_Diem.Diem_MaMonHoc, DTO_Diem.Diem_MaSinhVien, DTO_Diem.Diem_SoDiem, DTO_Diem.Diem_LanThi);
                MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Có lỗi khi cập nhật");
            }
        }

        public DataTable TracuuDiem()
        {
            DataTable dt = new DataTable();
            dt = DalDiem.TimKiemDiem(DTO_Diem.Diem_MaSinhVien);
            return dt;
        }

        public void LayDanhSachMonHocVaoListBox()
        {
            // DalDiem.LoadDLVaoListBox(DTO_Diem.LISTBOX, DTO_Diem.MAKHOA);
            DalDiem.LoadDLVaoListBox(DTO_Diem.LISTBOX, DTO_Diem.Diem_MaMonHoc);
        }

        public void GoiYMaSinhVien()
        {
            GoiYMaSinhVien(DTO_Diem.TXTMSV);
        }

        //gợi ý tìm kiếm msv
        public void GoiYTimMSV()
        {
            GoiYMaSinhVien(DTO_Diem.txtTIMMSV);
        }
        //Tạo từ gợi ý khi tìm kiếm
        public void GoiYMaSinhVien(TextBox txt)
        {
            BUS_xuly.TextBox_AutoComplete(txt, "SinhVien", 0);
        }
    }
}
