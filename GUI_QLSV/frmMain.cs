using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_QLSV.UserControls;
using BUS_QLSV;
namespace GUI_QLSV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Khai báo đối tượng
        BUS_Xuly Bus_xuly = new BUS_Xuly();
        static frmLogin frmLogin = new frmLogin();
        //static frmBaocaoDiem frmDiem = new frmBaocaoDiem();
        //static frmReportSinhVien frm = new frmReportSinhVien();
        //static frmBaocaoMH frmMH = new frmBaocaoMH();
        static UC_User user = new UC_User();
        static UC_SinhVien_MonHoc_DKHP sinhvien_monhoc_dkhp = new UC_SinhVien_MonHoc_DKHP();
        static UC_GiaoVien_Khoa giaovien_khoa = new UC_GiaoVien_Khoa();
        static UC_Nganh_Lop nganh_lop = new UC_Nganh_Lop();
        static UC_Nhapdiem nhapdiem = new UC_Nhapdiem();
       
        bool Flag;// cờ đổi ngôn ngữ, true= english, false= VN
        #endregion

        #region Add user control
        private void quanlyTK_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Flag == false)
            {
                lblTitle.Text = "Quản lý tài khoản";
            }
            else if (Flag == true)
            {
                lblTitle.Text = "Accout Management";
            }
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);

            Bus_xuly.AddControl(pan_Main, user);
        }

        private void lnkTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Flag == false)
            {
                lblTitle.Text = "Quản lý tài khoản";
            }
            else if (Flag == true)
            {
                lblTitle.Text = "Accout Management";
            }
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);



            Bus_xuly.AddControl(pan_Main, user);
        }

        private void lnkDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grB_leftMenu.Enabled = false;
            quanlyTK_ToolStripMenuItem.Enabled = false;
            lnkTaiKhoan.Enabled = false;
            DangXuatToolStripMenuItem.Enabled = false;
            DangNhapToolStripMenuItem.Enabled = true;
            TacVuToolStripMenuItem.Enabled = false;
            báoCáoToolStripMenuItem.Enabled = false;
            pan_Main.Controls.Clear();
            // pan_Main.BackgroundImage = Properties.Resources.school;

            lblTitle.Text = "Chương trình quản lý sinh viên";
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);
        }

        private void lnk_QuanlySv__Mon_DKMH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Flag == false)
            {
                lblTitle.Text = "Quản lí Sinh Viên - Môn Học - DKMH";
            }
            else if (Flag == true)
            {
                lblTitle.Text = "Student-Subject-Course Register";
            }
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);


            Bus_xuly.AddControl(pan_Main, sinhvien_monhoc_dkhp);
        }

        private void lnkKH_Nganh_Lop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Flag == false)
            {
                lblTitle.Text = "Quản lý Ngành - Lớp";
            }
            else if (Flag == true)
            {
                lblTitle.Text = "Course-Field-Class";
            }
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);


            Bus_xuly.AddControl(pan_Main, nganh_lop);
        }

        private void lnkGV_Khoa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Flag == false)
            {
                lblTitle.Text = "Quản lí Giáo viên - Khoa";
            }
            else if (Flag == true)
            {
                lblTitle.Text = "Lecturer-Faculty";
            }
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);


            Bus_xuly.AddControl(pan_Main, giaovien_khoa);
        }

        private void lnkNhapDiem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Flag == false)
            {
                lblTitle.Text = "Nhập điểm";
            }
            else if (Flag == true)
            {
                lblTitle.Text = "Insert scores";
            }
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);


            Bus_xuly.AddControl(pan_Main, nhapdiem);
        }

       

        private void quanliSV_MH_DKMHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Flag == false)
            {
                lblTitle.Text = "Quản lí Sinh Viên - Môn Học - DKMH";
            }
            else if (Flag == true)
            {
                lblTitle.Text = "Student-Subject-Course Register";
            }
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);


            Bus_xuly.AddControl(pan_Main, sinhvien_monhoc_dkhp);
        }

        private void quảnLíKhoáHọcNgànhLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Flag == false)
            {
                lblTitle.Text = "Quản lý Ngành - Lớp";
            }
            else if (Flag == true)
            {
                lblTitle.Text = "Course-Field-Class";
            }
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);


            Bus_xuly.AddControl(pan_Main, nganh_lop);
        }

        private void quanliGV_KhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Flag == false)
            {
                lblTitle.Text = "Quản lí Giáo viên - Khoa";
            }
            else if (Flag == true)
            {
                lblTitle.Text = "Lecturer-Faculty";
            }
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);


            Bus_xuly.AddControl(pan_Main, giaovien_khoa);
        }

        private void nhapDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Flag == false)
            {
                lblTitle.Text = "Nhập điểm";
            }
            else if (Flag == true)
            {
                lblTitle.Text = "Insert scores";
            }
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);


            Bus_xuly.AddControl(pan_Main, nhapdiem);
        }

      

        private void tiếngViệtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region grBox left
        bool is_panQLSVExpand = true;//khoi tao 1 bien co de xet xem panel dang o che do expand hay collapse
        bool is_panQLMHExpand = true;
        int x_pnQlSV, y_pnQLSV, x_pnQLD, y_pnQLD, x_pnQLMH, y_pnQLMH;//ví trí
        private void btnQLDIEM_ex_Click(object sender, EventArgs e)
        {
            do
            {
                pan_MenuQLDIEM.Height = pan_MenuQLDIEM.Height + 147;
                Application.DoEvents();
            } while (pan_MenuQLDIEM.Height <= 120);
            btnQLDIEM_ex.Visible = false;
            btnQLDIEM_Collapse.Visible = true;
        }
        private void btnQLDIEM_Collapse_Click(object sender, EventArgs e)
        {
            btnQLDIEM_ex.Visible = true;
            btnQLDIEM_Collapse.Visible = false;
            do
            {
                pan_MenuQLDIEM.Height = pan_MenuQLDIEM.Height - 147;
                Application.DoEvents();
            } while (pan_MenuQLDIEM.Height > 0);
        }

        private void btnQLMH_Collapse_Click(object sender, EventArgs e)
        {
            btnQLMH_ex.Visible = true;
            btnQLMH_Collapse.Visible = false;
            do
            {
                pan_MenuMH.Height = pan_MenuMH.Height - 279;
                Application.DoEvents();
            } while (pan_MenuMH.Height > 0);
            is_panQLMHExpand = false;

            if (is_panQLSVExpand == false && is_panQLMHExpand == false)
            {
                pan_QLDIEM.Location = new Point(x_pnQLMH, pan_MenuMH.Location.Y + 50);
            }
            else
            {
                int new_y_QLDiem = pan_MenuMH.Location.Y + pan_QLMH.Location.Y;
                pan_QLDIEM.Location = new Point(x_pnQLD, new_y_QLDiem);
            }
        }
        private void btnQLMH_ex_Click(object sender, EventArgs e)
        {
            do
            {
                pan_MenuMH.Height = pan_MenuMH.Height + 147;
                Application.DoEvents();
            } while (pan_MenuMH.Height <= 120);
            btnQLMH_ex.Visible = false;
            btnQLMH_Collapse.Visible = true;


            if (is_panQLSVExpand == false)
            {
                pan_QLDIEM.Location = new Point(x_pnQLMH, y_pnQLMH + 40);
            }

            else
            {
                pan_QLDIEM.Location = new Point(x_pnQLD, y_pnQLD);
            }
            is_panQLMHExpand = true;
        }

        private void btnQLSV_collapse_Click(object sender, EventArgs e)
        {
            btnQLSV_ex.Visible = true;
            btnQLSV_collapse.Visible = false;
            do
            {
                pan_MenuQLSV.Height = pan_MenuQLSV.Height - 279;
                Application.DoEvents();
            } while (pan_MenuQLSV.Height > 0);

            pan_QLMH.BringToFront();
            pan_QLDIEM.BringToFront();
            int new_y_QLMH = pan_MenuQLSV.Location.Y + 10;
            int new_y_QLDiem = pan_MenuMH.Location.Y * 6;//pan_MenuMH.Location.Y*5 + 30;
            pan_QLMH.Location = new Point(x_pnQLMH, new_y_QLMH);

            is_panQLSVExpand = false;
            if (is_panQLMHExpand == false && is_panQLSVExpand == false)
            {
                pan_QLDIEM.Location = new Point(x_pnQLMH, y_pnQLMH / 2);
            }
            else
            {
                pan_QLDIEM.Location = new Point(x_pnQLD, new_y_QLDiem);
            }

        }

      
        private void btnQLSV_ex_Click(object sender, EventArgs e)
        {
            do
            {
                pan_MenuQLSV.Height = pan_MenuQLSV.Height + 1;
                Application.DoEvents();
            } while (pan_MenuQLSV.Height <= 120);
            btnQLSV_ex.Visible = false;
            btnQLSV_collapse.Visible = true;

            pan_QLDIEM.Location = new Point(x_pnQLD, y_pnQLD);
            pan_QLMH.Location = new Point(x_pnQLMH, y_pnQLMH);
            is_panQLSVExpand = true;
            if (is_panQLMHExpand == false && is_panQLSVExpand == true)
            {
                int new_y_QLDiem = pan_MenuMH.Location.Y * 6;
                pan_QLDIEM.Location = new Point(x_pnQLD, new_y_QLDiem);
            }


        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            btnQLSV_collapse.Visible = true;
            btnQLSV_ex.Visible = false;

            btnQLMH_Collapse.Visible = true;
            btnQLMH_ex.Visible = false;

            btnQLDIEM_Collapse.Visible = true;
            btnQLDIEM_ex.Visible = false;

            //pan_MenuMH.Height = 0;
            //pan_MenuQLDIEM.Height = 0;

            x_pnQlSV = pan_QLSV.Location.X;
            y_pnQLSV = pan_QLSV.Location.Y;

            x_pnQLMH = pan_QLMH.Location.X;
            y_pnQLMH = pan_QLMH.Location.Y;

            x_pnQLD = pan_QLDIEM.Location.X;
            y_pnQLD = pan_QLDIEM.Location.Y;

            //  grB_leftMenu.Visible = false;
            grB_leftMenu.Enabled = false;
            menuStrip.Visible = true;

            TacVuToolStripMenuItem.Enabled = false;
            báoCáoToolStripMenuItem.Enabled = false;

            lblTitle.Text = "CHƯƠNG TRÌNH QUẢN LÍ SINH VIÊN";
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);
        }


        #endregion

        #region hàm nhận tham số truyền về từ delegate Login
        public void enable_groupbox(bool kq)
        {
            grB_leftMenu.Enabled = kq;
        }
        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            this.ShowInTaskbar = false;
            this.Hide();
            // WindowState = FormWindowState.Minimized;
        }
        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grB_leftMenu.Enabled = false;
            quanlyTK_ToolStripMenuItem.Enabled = false;
            lnkTaiKhoan.Enabled = false;
            DangXuatToolStripMenuItem.Enabled = false;
            DangNhapToolStripMenuItem.Enabled = true;
            TacVuToolStripMenuItem.Enabled = false;
            báoCáoToolStripMenuItem.Enabled = false;
            pan_Main.Controls.Clear();
           // pan_Main.BackgroundImage = Properties.Resources.school;

            lblTitle.Text = "Chương trình quản lý sinh viên";
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            this.ShowInTaskbar = false;
            this.Hide();
            // WindowState = FormWindowState.Minimized;
        }
        private void DangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin.setGroupbox = new frmLogin.EnableGroupbox(enable_groupbox);
            //nhận tham so truyen ve tu ham delegate EnableGroupbox
            frmLogin.ShowDialog();
            if (frmLogin.PQ == "Admin")
            {
                if (grB_leftMenu.Enabled == true)
                {
                    quanlyTK_ToolStripMenuItem.Enabled = true;
                    lnkTaiKhoan.Enabled = true;

                    DangNhapToolStripMenuItem.Enabled = false;
                    DangXuatToolStripMenuItem.Enabled = true;
                    pan_Main.Enabled = true;
                    TacVuToolStripMenuItem.Enabled = true;
                    báoCáoToolStripMenuItem.Enabled = true;
                }
            }
            else if (frmLogin.PQ == "User")
            {
                if (grB_leftMenu.Enabled == true)
                {
                    quanlyTK_ToolStripMenuItem.Enabled = false;
                    lnkTaiKhoan.Enabled = false;

                    DangNhapToolStripMenuItem.Enabled = false;
                    DangXuatToolStripMenuItem.Enabled = true;
                    pan_Main.Enabled = true;
                    TacVuToolStripMenuItem.Enabled = true;
                    báoCáoToolStripMenuItem.Enabled = true;
                }
            }
        }
        #endregion

        #region Báo cáo
        private void lnkXuatDSMH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkXuatSV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkXemDiem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void xuatDSMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xuatDSSVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region mouse color

        private void lnkTaiKhoan_MouseHover(object sender, EventArgs e)
        {
            lnkTaiKhoan.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void lnkTaiKhoan_MouseLeave(object sender, EventArgs e)
        {
            lnkTaiKhoan.BackColor = System.Drawing.Color.Empty;
        }

        private void lnk_QuanlySv__Mon_DKMH_MouseHover(object sender, EventArgs e)
        {
            lnk_QuanlySv__Mon_DKMH.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void lnk_QuanlySv__Mon_DKMH_MouseLeave(object sender, EventArgs e)
        {
            lnk_QuanlySv__Mon_DKMH.BackColor = System.Drawing.Color.Empty;
        }

        private void lnkKH_Nganh_Lop_MouseHover(object sender, EventArgs e)
        {
            lnkKH_Nganh_Lop.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void lnkKH_Nganh_Lop_MouseLeave(object sender, EventArgs e)
        {
            lnkKH_Nganh_Lop.BackColor = System.Drawing.Color.Empty;
        }

        private void lnkGV_Khoa_MouseHover(object sender, EventArgs e)
        {
            lnkGV_Khoa.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void lnkGV_Khoa_MouseLeave(object sender, EventArgs e)
        {
            lnkGV_Khoa.BackColor = System.Drawing.Color.Empty;
        }

        private void lnkNhapDiem_MouseHover(object sender, EventArgs e)
        {
            lnkNhapDiem.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void lnkNhapDiem_MouseLeave(object sender, EventArgs e)
        {
            lnkNhapDiem.BackColor = System.Drawing.Color.Empty;
        }

        private void lnkXuatDSMH_MouseHover(object sender, EventArgs e)
        {
            lnkXuatDSMH.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void lnkXuatDSMH_MouseLeave(object sender, EventArgs e)
        {
            lnkXuatDSMH.BackColor = System.Drawing.Color.Empty;
        }

        private void lnkXuatSV_MouseHover(object sender, EventArgs e)
        {
            lnkXuatSV.BackColor = System.Drawing.Color.AliceBlue;
        }
      
        private void lnkXuatSV_MouseLeave(object sender, EventArgs e)
        {
            lnkXuatSV.BackColor = System.Drawing.Color.Empty;
        }

        private void lnkXemDiem_MouseHover(object sender, EventArgs e)
        {
            lnkXemDiem.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void lnkXemDiem_MouseLeave(object sender, EventArgs e)
        {
            lnkXemDiem.BackColor = System.Drawing.Color.Empty;
        }

        #endregion

        #region flicker double-buffer
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion


        private void aboutMeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            frmAbout ab = new frmAbout();
            ab.ShowDialog();
        }

    }
}
