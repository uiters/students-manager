namespace GUI_QLSV
{
    partial class frmQLMH
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLMH));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvMonhoc = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdMonbatbuoc = new System.Windows.Forms.RadioButton();
            this.rdMontuchon = new System.Windows.Forms.RadioButton();
            this.txtTenMh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGhichu_MH = new System.Windows.Forms.TextBox();
            this.numSoTietLT = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numSoTietTH = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbMaKhoa_MH = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.txtTimMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTimMH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonhoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTietLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTietTH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(954, 587);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập Môn Học";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvMonhoc);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 85);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(948, 224);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tác vụ";
            // 
            // dgvMonhoc
            // 
            this.dgvMonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonhoc.Location = new System.Drawing.Point(2, 15);
            this.dgvMonhoc.Name = "dgvMonhoc";
            this.dgvMonhoc.ReadOnly = true;
            this.dgvMonhoc.Size = new System.Drawing.Size(944, 207);
            this.dgvMonhoc.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtMaMH);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.txtTenMh);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtGhichu_MH);
            this.groupBox2.Controls.Add(this.numSoTietLT);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.numSoTietTH);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmbMaKhoa_MH);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 309);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(948, 275);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Location = new System.Drawing.Point(628, 116);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 33);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(38, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Mã môn học:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(38, 126);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Số tiết lý thuyết:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Location = new System.Drawing.Point(670, 191);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 32);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhat.Location = new System.Drawing.Point(670, 116);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 33);
            this.btnCapNhat.TabIndex = 27;
            this.btnCapNhat.Text = "Cập nhập";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Tên môn học:";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Enabled = false;
            this.txtMaMH.Location = new System.Drawing.Point(128, 12);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(225, 20);
            this.txtMaMH.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdMonbatbuoc);
            this.groupBox5.Controls.Add(this.rdMontuchon);
            this.groupBox5.Location = new System.Drawing.Point(128, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(225, 36);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            // 
            // rdMonbatbuoc
            // 
            this.rdMonbatbuoc.AutoSize = true;
            this.rdMonbatbuoc.Checked = true;
            this.rdMonbatbuoc.Location = new System.Drawing.Point(13, 13);
            this.rdMonbatbuoc.Name = "rdMonbatbuoc";
            this.rdMonbatbuoc.Size = new System.Drawing.Size(91, 17);
            this.rdMonbatbuoc.TabIndex = 18;
            this.rdMonbatbuoc.TabStop = true;
            this.rdMonbatbuoc.Text = "Môn bắt buộc";
            this.rdMonbatbuoc.UseVisualStyleBackColor = true;
            // 
            // rdMontuchon
            // 
            this.rdMontuchon.AutoSize = true;
            this.rdMontuchon.Location = new System.Drawing.Point(121, 13);
            this.rdMontuchon.Name = "rdMontuchon";
            this.rdMontuchon.Size = new System.Drawing.Size(85, 17);
            this.rdMontuchon.TabIndex = 19;
            this.rdMontuchon.TabStop = true;
            this.rdMontuchon.Text = "Môn tự chọn";
            this.rdMontuchon.UseVisualStyleBackColor = true;
            // 
            // txtTenMh
            // 
            this.txtTenMh.Location = new System.Drawing.Point(128, 49);
            this.txtTenMh.Name = "txtTenMh";
            this.txtTenMh.Size = new System.Drawing.Size(225, 20);
            this.txtTenMh.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Hình thức:";
            // 
            // txtGhichu_MH
            // 
            this.txtGhichu_MH.Location = new System.Drawing.Point(128, 163);
            this.txtGhichu_MH.Multiline = true;
            this.txtGhichu_MH.Name = "txtGhichu_MH";
            this.txtGhichu_MH.Size = new System.Drawing.Size(392, 69);
            this.txtGhichu_MH.TabIndex = 10;
            // 
            // numSoTietLT
            // 
            this.numSoTietLT.Location = new System.Drawing.Point(135, 124);
            this.numSoTietLT.Name = "numSoTietLT";
            this.numSoTietLT.Size = new System.Drawing.Size(42, 20);
            this.numSoTietLT.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(368, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Thuộc khoa:";
            // 
            // numSoTietTH
            // 
            this.numSoTietTH.Location = new System.Drawing.Point(312, 124);
            this.numSoTietTH.Name = "numSoTietTH";
            this.numSoTietTH.Size = new System.Drawing.Size(43, 20);
            this.numSoTietTH.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(203, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Số tiết thực hành:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ghi chú";
            // 
            // cmbMaKhoa_MH
            // 
            this.cmbMaKhoa_MH.FormattingEnabled = true;
            this.cmbMaKhoa_MH.Location = new System.Drawing.Point(442, 12);
            this.cmbMaKhoa_MH.Name = "cmbMaKhoa_MH";
            this.cmbMaKhoa_MH.Size = new System.Drawing.Size(173, 21);
            this.cmbMaKhoa_MH.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.btnback);
            this.groupBox1.Controls.Add(this.txtTimMH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbTimMH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 69);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Môn Học";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Transparent;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTim.Location = new System.Drawing.Point(591, 19);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 36);
            this.btnTim.TabIndex = 4;
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Location = new System.Drawing.Point(853, 13);
            this.btnback.Margin = new System.Windows.Forms.Padding(2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 47);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            // 
            // txtTimMH
            // 
            this.txtTimMH.Location = new System.Drawing.Point(393, 34);
            this.txtTimMH.Name = "txtTimMH";
            this.txtTimMH.Size = new System.Drawing.Size(181, 20);
            this.txtTimMH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập từ khóa:";
            // 
            // cmbTimMH
            // 
            this.cmbTimMH.FormattingEnabled = true;
            this.cmbTimMH.Items.AddRange(new object[] {
            "Mã môn học",
            "Tên môn học"});
            this.cmbTimMH.Location = new System.Drawing.Point(157, 34);
            this.cmbTimMH.Name = "cmbTimMH";
            this.cmbTimMH.Size = new System.Drawing.Size(135, 21);
            this.cmbTimMH.TabIndex = 1;
            this.cmbTimMH.Text = "-- Chọn điều kiện --";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Theo:";
            // 
            // frmQLMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_QLSV.Properties.Resources.background_full_hd_dep_110637776;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 587);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQLMH";
            this.Text = "Quản lý môn học";
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonhoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTietLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTietTH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLuu;
        public System.Windows.Forms.Button btnback;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimMH;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbTimMH;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView dgvMonhoc;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdMonbatbuoc;
        private System.Windows.Forms.RadioButton rdMontuchon;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numSoTietLT;
        private System.Windows.Forms.NumericUpDown numSoTietTH;
        private System.Windows.Forms.ComboBox cmbMaKhoa_MH;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGhichu_MH;
        private System.Windows.Forms.TextBox txtTenMh;
        private System.Windows.Forms.TextBox txtMaMH;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}