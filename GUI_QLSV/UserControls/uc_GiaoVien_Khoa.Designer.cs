namespace GUI_QLSV.UserControls
{
    partial class UC_GiaoVien_Khoa
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabGV_Khoa = new System.Windows.Forms.TabControl();
            this.tabGiaoVien = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.cmbDieuKienTim = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThongTinTimKiem_GV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.MaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu_GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupboxGV = new System.Windows.Forms.GroupBox();
            this.btnXoa_GV = new System.Windows.Forms.Button();
            this.btnLuuGV = new System.Windows.Forms.Button();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmbMaKhoa = new System.Windows.Forms.ComboBox();
            this.txtTenGiaoVien = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMaGiaoVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabKhoa = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.Ma_Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu_Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupboxKhoa = new System.Windows.Forms.GroupBox();
            this.btndelete_K = new System.Windows.Forms.Button();
            this.btnLuuKhoa = new System.Windows.Forms.Button();
            this.btnNhaplaiKhoa = new System.Windows.Forms.Button();
            this.btnThemKhoa = new System.Windows.Forms.Button();
            this.txtGhiChu_Khoa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabGV_Khoa.SuspendLayout();
            this.tabGiaoVien.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.groupboxGV.SuspendLayout();
            this.tabKhoa.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.groupboxKhoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGV_Khoa
            // 
            this.tabGV_Khoa.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabGV_Khoa.Controls.Add(this.tabGiaoVien);
            this.tabGV_Khoa.Controls.Add(this.tabKhoa);
            this.tabGV_Khoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGV_Khoa.Location = new System.Drawing.Point(0, 0);
            this.tabGV_Khoa.Name = "tabGV_Khoa";
            this.tabGV_Khoa.SelectedIndex = 0;
            this.tabGV_Khoa.Size = new System.Drawing.Size(690, 520);
            this.tabGV_Khoa.TabIndex = 1;
            this.tabGV_Khoa.Click += new System.EventHandler(this.tabGV_Khoa_Click);
            // 
            // tabGiaoVien
            // 
            this.tabGiaoVien.BackgroundImage = global::GUI_QLSV.Properties.Resources.background_full_hd_dep_110637776;
            this.tabGiaoVien.Controls.Add(this.groupBox3);
            this.tabGiaoVien.Controls.Add(this.groupBox2);
            this.tabGiaoVien.Controls.Add(this.groupboxGV);
            this.tabGiaoVien.Location = new System.Drawing.Point(4, 25);
            this.tabGiaoVien.Name = "tabGiaoVien";
            this.tabGiaoVien.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabGiaoVien.Size = new System.Drawing.Size(682, 491);
            this.tabGiaoVien.TabIndex = 0;
            this.tabGiaoVien.Text = "Giáo Viên";
            this.tabGiaoVien.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Controls.Add(this.cmbDieuKienTim);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtThongTinTimKiem_GV);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(310, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 216);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tra cứu thông tin giáo viên";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Transparent;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTim.Location = new System.Drawing.Point(217, 102);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 54);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click_1);
            // 
            // cmbDieuKienTim
            // 
            this.cmbDieuKienTim.FormattingEnabled = true;
            this.cmbDieuKienTim.Items.AddRange(new object[] {
            "Mã Giáo Viên",
            "Tên Giáo Viên"});
            this.cmbDieuKienTim.Location = new System.Drawing.Point(143, 29);
            this.cmbDieuKienTim.Name = "cmbDieuKienTim";
            this.cmbDieuKienTim.Size = new System.Drawing.Size(188, 21);
            this.cmbDieuKienTim.TabIndex = 3;
            this.cmbDieuKienTim.Text = "-- Chọn điều kiện --";
            this.cmbDieuKienTim.TextChanged += new System.EventHandler(this.cmbDieuKienTim_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tìm Theo:";
            // 
            // txtThongTinTimKiem_GV
            // 
            this.txtThongTinTimKiem_GV.Location = new System.Drawing.Point(144, 65);
            this.txtThongTinTimKiem_GV.Name = "txtThongTinTimKiem_GV";
            this.txtThongTinTimKiem_GV.Size = new System.Drawing.Size(188, 20);
            this.txtThongTinTimKiem_GV.TabIndex = 1;
            this.txtThongTinTimKiem_GV.TextChanged += new System.EventHandler(this.txtThongTinTimKiem_GV_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập thông tin tìm kiếm:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvGiaoVien);
            this.groupBox2.Location = new System.Drawing.Point(6, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Giáo Viên Hiện Tại";
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiaoVien,
            this.TenGiaoVien,
            this.MaKhoa,
            this.GhiChu_GV});
            this.dgvGiaoVien.Location = new System.Drawing.Point(12, 24);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.ReadOnly = true;
            this.dgvGiaoVien.Size = new System.Drawing.Size(650, 161);
            this.dgvGiaoVien.TabIndex = 0;
            this.dgvGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellClick_1);
            // 
            // MaGiaoVien
            // 
            this.MaGiaoVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaGiaoVien.DataPropertyName = "MaGiaoVien";
            this.MaGiaoVien.HeaderText = "Mã GV";
            this.MaGiaoVien.Name = "MaGiaoVien";
            this.MaGiaoVien.ReadOnly = true;
            // 
            // TenGiaoVien
            // 
            this.TenGiaoVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenGiaoVien.DataPropertyName = "TenGiaoVien";
            this.TenGiaoVien.HeaderText = "Tên GV";
            this.TenGiaoVien.Name = "TenGiaoVien";
            this.TenGiaoVien.ReadOnly = true;
            // 
            // MaKhoa
            // 
            this.MaKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã khoa";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            // 
            // GhiChu_GV
            // 
            this.GhiChu_GV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu_GV.DataPropertyName = "GhiChu";
            this.GhiChu_GV.HeaderText = "Ghi chú";
            this.GhiChu_GV.Name = "GhiChu_GV";
            this.GhiChu_GV.ReadOnly = true;
            // 
            // groupboxGV
            // 
            this.groupboxGV.BackColor = System.Drawing.Color.Transparent;
            this.groupboxGV.Controls.Add(this.btnXoa_GV);
            this.groupboxGV.Controls.Add(this.btnLuuGV);
            this.groupboxGV.Controls.Add(this.btnLamlai);
            this.groupboxGV.Controls.Add(this.btnThem);
            this.groupboxGV.Controls.Add(this.cmbMaKhoa);
            this.groupboxGV.Controls.Add(this.txtTenGiaoVien);
            this.groupboxGV.Controls.Add(this.txtGhiChu);
            this.groupboxGV.Controls.Add(this.txtMaGiaoVien);
            this.groupboxGV.Controls.Add(this.label5);
            this.groupboxGV.Controls.Add(this.label3);
            this.groupboxGV.Controls.Add(this.label2);
            this.groupboxGV.Controls.Add(this.label1);
            this.groupboxGV.Location = new System.Drawing.Point(6, 20);
            this.groupboxGV.Name = "groupboxGV";
            this.groupboxGV.Size = new System.Drawing.Size(288, 216);
            this.groupboxGV.TabIndex = 0;
            this.groupboxGV.TabStop = false;
            this.groupboxGV.Text = "Thêm Giáo Viên";
            // 
            // btnXoa_GV
            // 
            this.btnXoa_GV.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa_GV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa_GV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa_GV.Location = new System.Drawing.Point(206, 181);
            this.btnXoa_GV.Name = "btnXoa_GV";
            this.btnXoa_GV.Size = new System.Drawing.Size(75, 24);
            this.btnXoa_GV.TabIndex = 15;
            this.btnXoa_GV.Text = "xóa";
            this.btnXoa_GV.UseVisualStyleBackColor = false;
            this.btnXoa_GV.Click += new System.EventHandler(this.btnXoa_GV_Click_1);
            // 
            // btnLuuGV
            // 
            this.btnLuuGV.BackColor = System.Drawing.Color.Transparent;
            this.btnLuuGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuuGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuuGV.Location = new System.Drawing.Point(16, 181);
            this.btnLuuGV.Name = "btnLuuGV";
            this.btnLuuGV.Size = new System.Drawing.Size(75, 24);
            this.btnLuuGV.TabIndex = 14;
            this.btnLuuGV.Text = "Lưu";
            this.btnLuuGV.UseVisualStyleBackColor = false;
            this.btnLuuGV.Click += new System.EventHandler(this.btnLuuGV_Click_1);
            // 
            // btnLamlai
            // 
            this.btnLamlai.BackColor = System.Drawing.Color.Transparent;
            this.btnLamlai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamlai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLamlai.Location = new System.Drawing.Point(112, 181);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(75, 24);
            this.btnLamlai.TabIndex = 13;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.UseVisualStyleBackColor = false;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Location = new System.Drawing.Point(16, 181);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 24);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // cmbMaKhoa
            // 
            this.cmbMaKhoa.FormattingEnabled = true;
            this.cmbMaKhoa.Location = new System.Drawing.Point(81, 102);
            this.cmbMaKhoa.Name = "cmbMaKhoa";
            this.cmbMaKhoa.Size = new System.Drawing.Size(201, 21);
            this.cmbMaKhoa.TabIndex = 11;
            // 
            // txtTenGiaoVien
            // 
            this.txtTenGiaoVien.Location = new System.Drawing.Point(81, 68);
            this.txtTenGiaoVien.Name = "txtTenGiaoVien";
            this.txtTenGiaoVien.Size = new System.Drawing.Size(201, 20);
            this.txtTenGiaoVien.TabIndex = 10;
            this.txtTenGiaoVien.TextChanged += new System.EventHandler(this.txtTenGiaoVien_TextChanged_1);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(81, 135);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(201, 41);
            this.txtGhiChu.TabIndex = 9;
            // 
            // txtMaGiaoVien
            // 
            this.txtMaGiaoVien.Enabled = false;
            this.txtMaGiaoVien.Location = new System.Drawing.Point(81, 31);
            this.txtMaGiaoVien.Name = "txtMaGiaoVien";
            this.txtMaGiaoVien.Size = new System.Drawing.Size(147, 20);
            this.txtMaGiaoVien.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghi chú:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên giáo viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thuộc khoa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giáo viên:";
            // 
            // tabKhoa
            // 
            this.tabKhoa.BackColor = System.Drawing.Color.Transparent;
            this.tabKhoa.BackgroundImage = global::GUI_QLSV.Properties.Resources.background_full_hd_dep_110637776;
            this.tabKhoa.Controls.Add(this.groupBox5);
            this.tabKhoa.Controls.Add(this.groupboxKhoa);
            this.tabKhoa.Location = new System.Drawing.Point(4, 25);
            this.tabKhoa.Name = "tabKhoa";
            this.tabKhoa.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabKhoa.Size = new System.Drawing.Size(682, 491);
            this.tabKhoa.TabIndex = 1;
            this.tabKhoa.Text = "Khoa";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvKhoa);
            this.groupBox5.Location = new System.Drawing.Point(6, 195);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(670, 305);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh Sách Khoa";
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Khoa,
            this.TenKhoa,
            this.GhiChu_Khoa});
            this.dgvKhoa.Location = new System.Drawing.Point(8, 31);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.ReadOnly = true;
            this.dgvKhoa.Size = new System.Drawing.Size(656, 267);
            this.dgvKhoa.TabIndex = 0;
            this.dgvKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellClick);
            // 
            // Ma_Khoa
            // 
            this.Ma_Khoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ma_Khoa.DataPropertyName = "MaKhoa";
            this.Ma_Khoa.HeaderText = "Mã Khoa";
            this.Ma_Khoa.Name = "Ma_Khoa";
            this.Ma_Khoa.ReadOnly = true;
            // 
            // TenKhoa
            // 
            this.TenKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKhoa.DataPropertyName = "TenKhoa";
            this.TenKhoa.HeaderText = "Tên Khoa";
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.ReadOnly = true;
            // 
            // GhiChu_Khoa
            // 
            this.GhiChu_Khoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu_Khoa.DataPropertyName = "GhiChu";
            this.GhiChu_Khoa.HeaderText = "Ghi Chú";
            this.GhiChu_Khoa.Name = "GhiChu_Khoa";
            this.GhiChu_Khoa.ReadOnly = true;
            // 
            // groupboxKhoa
            // 
            this.groupboxKhoa.Controls.Add(this.btndelete_K);
            this.groupboxKhoa.Controls.Add(this.btnLuuKhoa);
            this.groupboxKhoa.Controls.Add(this.btnNhaplaiKhoa);
            this.groupboxKhoa.Controls.Add(this.btnThemKhoa);
            this.groupboxKhoa.Controls.Add(this.txtGhiChu_Khoa);
            this.groupboxKhoa.Controls.Add(this.txtTenKhoa);
            this.groupboxKhoa.Controls.Add(this.txtMaKhoa);
            this.groupboxKhoa.Controls.Add(this.label10);
            this.groupboxKhoa.Controls.Add(this.label9);
            this.groupboxKhoa.Controls.Add(this.label7);
            this.groupboxKhoa.Location = new System.Drawing.Point(6, 17);
            this.groupboxKhoa.Name = "groupboxKhoa";
            this.groupboxKhoa.Size = new System.Drawing.Size(670, 171);
            this.groupboxKhoa.TabIndex = 0;
            this.groupboxKhoa.TabStop = false;
            this.groupboxKhoa.Text = "Thêm mới một Khoa";
            // 
            // btndelete_K
            // 
            this.btndelete_K.BackColor = System.Drawing.Color.Transparent;
            this.btndelete_K.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndelete_K.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete_K.Location = new System.Drawing.Point(566, 98);
            this.btndelete_K.Name = "btndelete_K";
            this.btndelete_K.Size = new System.Drawing.Size(75, 50);
            this.btndelete_K.TabIndex = 10;
            this.btndelete_K.Text = "xóa";
            this.btndelete_K.UseVisualStyleBackColor = false;
            this.btndelete_K.Click += new System.EventHandler(this.btndelete_K_Click);
            // 
            // btnLuuKhoa
            // 
            this.btnLuuKhoa.BackColor = System.Drawing.Color.Transparent;
            this.btnLuuKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuuKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuuKhoa.Location = new System.Drawing.Point(356, 97);
            this.btnLuuKhoa.Name = "btnLuuKhoa";
            this.btnLuuKhoa.Size = new System.Drawing.Size(75, 50);
            this.btnLuuKhoa.TabIndex = 9;
            this.btnLuuKhoa.Text = "Lưu";
            this.btnLuuKhoa.UseVisualStyleBackColor = false;
            this.btnLuuKhoa.Click += new System.EventHandler(this.btnLuuKhoa_Click);
            // 
            // btnNhaplaiKhoa
            // 
            this.btnNhaplaiKhoa.BackColor = System.Drawing.Color.Transparent;
            this.btnNhaplaiKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNhaplaiKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhaplaiKhoa.Location = new System.Drawing.Point(461, 98);
            this.btnNhaplaiKhoa.Name = "btnNhaplaiKhoa";
            this.btnNhaplaiKhoa.Size = new System.Drawing.Size(75, 50);
            this.btnNhaplaiKhoa.TabIndex = 8;
            this.btnNhaplaiKhoa.Text = "Làm lại";
            this.btnNhaplaiKhoa.UseVisualStyleBackColor = false;
            this.btnNhaplaiKhoa.Click += new System.EventHandler(this.btnNhaplaiKhoa_Click);
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.BackColor = System.Drawing.Color.Transparent;
            this.btnThemKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemKhoa.ForeColor = System.Drawing.Color.Black;
            this.btnThemKhoa.Location = new System.Drawing.Point(356, 97);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Size = new System.Drawing.Size(75, 50);
            this.btnThemKhoa.TabIndex = 7;
            this.btnThemKhoa.Text = "Thêm";
            this.btnThemKhoa.UseVisualStyleBackColor = false;
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click);
            // 
            // txtGhiChu_Khoa
            // 
            this.txtGhiChu_Khoa.Location = new System.Drawing.Point(91, 98);
            this.txtGhiChu_Khoa.Multiline = true;
            this.txtGhiChu_Khoa.Name = "txtGhiChu_Khoa";
            this.txtGhiChu_Khoa.Size = new System.Drawing.Size(222, 49);
            this.txtGhiChu_Khoa.TabIndex = 6;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(91, 65);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(222, 20);
            this.txtTenKhoa.TabIndex = 5;
            this.txtTenKhoa.TextChanged += new System.EventHandler(this.txtTenKhoa_TextChanged_1);
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Enabled = false;
            this.txtMaKhoa.Location = new System.Drawing.Point(91, 33);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(157, 20);
            this.txtMaKhoa.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tên Khoa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ghi chú:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã Khoa:";
            // 
            // UC_GiaoVien_Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_QLSV.Properties.Resources.background_full_hd_dep_110637776;
            this.Controls.Add(this.tabGV_Khoa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_GiaoVien_Khoa";
            this.Size = new System.Drawing.Size(690, 520);
            this.Load += new System.EventHandler(this.UC_GiaoVien_Khoa_Load);
            this.tabGV_Khoa.ResumeLayout(false);
            this.tabGiaoVien.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.groupboxGV.ResumeLayout(false);
            this.groupboxGV.PerformLayout();
            this.tabKhoa.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.groupboxKhoa.ResumeLayout(false);
            this.groupboxKhoa.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        public System.Windows.Forms.TabControl tabGV_Khoa;
        private System.Windows.Forms.TabPage tabGiaoVien;
        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTim;
        public System.Windows.Forms.ComboBox cmbDieuKienTim;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThongTinTimKiem_GV;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu_GV;
        public System.Windows.Forms.GroupBox groupboxGV;
        private System.Windows.Forms.Button btnXoa_GV;
        private System.Windows.Forms.Button btnLuuGV;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmbMaKhoa;
        private System.Windows.Forms.TextBox txtTenGiaoVien;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMaGiaoVien;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabKhoa;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu_Khoa;
        public System.Windows.Forms.GroupBox groupboxKhoa;
        private System.Windows.Forms.Button btndelete_K;
        private System.Windows.Forms.Button btnLuuKhoa;
        private System.Windows.Forms.Button btnNhaplaiKhoa;
        private System.Windows.Forms.Button btnThemKhoa;
        private System.Windows.Forms.TextBox txtGhiChu_Khoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label7;
    }
}
