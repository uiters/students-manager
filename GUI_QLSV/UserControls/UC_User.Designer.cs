namespace GUI_QLSV.UserControls
{
    partial class UC_User
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_Usertype = new System.Windows.Forms.CheckBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblMatkhaumoi = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblTacvu = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdXoa = new System.Windows.Forms.RadioButton();
            this.rdDoiMatkhau = new System.Windows.Forms.RadioButton();
            this.rdTaoUser = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTenTimKiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::GUI_QLSV.Properties.Resources.background_full_hd_dep_110637776;
            this.groupBox1.Controls.Add(this.chk_Usertype);
            this.groupBox1.Controls.Add(this.txtNewPass);
            this.groupBox1.Controls.Add(this.lblMatkhaumoi);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.lblTacvu);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.d);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.dgvUser);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 520);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lí tài khoản";
            // 
            // chk_Usertype
            // 
            this.chk_Usertype.AutoSize = true;
            this.chk_Usertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Usertype.Location = new System.Drawing.Point(111, 475);
            this.chk_Usertype.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_Usertype.Name = "chk_Usertype";
            this.chk_Usertype.Size = new System.Drawing.Size(84, 21);
            this.chk_Usertype.TabIndex = 9;
            this.chk_Usertype.Text = "Usertype";
            this.chk_Usertype.UseVisualStyleBackColor = true;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(242, 441);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(198, 23);
            this.txtNewPass.TabIndex = 12;
            this.txtNewPass.Visible = false;
            // 
            // lblMatkhaumoi
            // 
            this.lblMatkhaumoi.AutoSize = true;
            this.lblMatkhaumoi.BackColor = System.Drawing.Color.Transparent;
            this.lblMatkhaumoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatkhaumoi.Location = new System.Drawing.Point(109, 443);
            this.lblMatkhaumoi.Name = "lblMatkhaumoi";
            this.lblMatkhaumoi.Size = new System.Drawing.Size(134, 17);
            this.lblMatkhaumoi.TabIndex = 14;
            this.lblMatkhaumoi.Text = "Nhập mật khẩu mới:";
            this.lblMatkhaumoi.Visible = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Location = new System.Drawing.Point(477, 420);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 43);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Location = new System.Drawing.Point(572, 370);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 44);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblTacvu
            // 
            this.lblTacvu.AutoSize = true;
            this.lblTacvu.BackColor = System.Drawing.Color.Transparent;
            this.lblTacvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacvu.ForeColor = System.Drawing.Color.Maroon;
            this.lblTacvu.Location = new System.Drawing.Point(250, 333);
            this.lblTacvu.Name = "lblTacvu";
            this.lblTacvu.Size = new System.Drawing.Size(51, 20);
            this.lblTacvu.TabIndex = 11;
            this.lblTacvu.Text = "label4";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.rdXoa);
            this.groupBox3.Controls.Add(this.rdDoiMatkhau);
            this.groupBox3.Controls.Add(this.rdTaoUser);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(81, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(521, 53);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn tác vụ";
            // 
            // rdXoa
            // 
            this.rdXoa.AutoSize = true;
            this.rdXoa.Location = new System.Drawing.Point(399, 22);
            this.rdXoa.Name = "rdXoa";
            this.rdXoa.Size = new System.Drawing.Size(76, 19);
            this.rdXoa.TabIndex = 6;
            this.rdXoa.Text = "Xóa User";
            this.rdXoa.UseVisualStyleBackColor = true;
            this.rdXoa.CheckedChanged += new System.EventHandler(this.rdXoa_CheckedChanged);
            // 
            // rdDoiMatkhau
            // 
            this.rdDoiMatkhau.AutoSize = true;
            this.rdDoiMatkhau.Location = new System.Drawing.Point(217, 22);
            this.rdDoiMatkhau.Name = "rdDoiMatkhau";
            this.rdDoiMatkhau.Size = new System.Drawing.Size(98, 19);
            this.rdDoiMatkhau.TabIndex = 5;
            this.rdDoiMatkhau.Text = "Đổi mật khẩu";
            this.rdDoiMatkhau.UseVisualStyleBackColor = true;
            this.rdDoiMatkhau.CheckedChanged += new System.EventHandler(this.rdDoiMatkhau_CheckedChanged);
            // 
            // rdTaoUser
            // 
            this.rdTaoUser.AutoSize = true;
            this.rdTaoUser.Checked = true;
            this.rdTaoUser.Location = new System.Drawing.Point(42, 22);
            this.rdTaoUser.Name = "rdTaoUser";
            this.rdTaoUser.Size = new System.Drawing.Size(75, 19);
            this.rdTaoUser.TabIndex = 4;
            this.rdTaoUser.TabStop = true;
            this.rdTaoUser.Text = "Tạo User";
            this.rdTaoUser.UseVisualStyleBackColor = true;
            this.rdTaoUser.CheckedChanged += new System.EventHandler(this.rdTaoUser_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Location = new System.Drawing.Point(572, 420);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 43);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Location = new System.Drawing.Point(477, 370);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 44);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.txtTenTimKiem);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 66);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm User";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Location = new System.Drawing.Point(549, 16);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(61, 41);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refesh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTim.Location = new System.Drawing.Point(457, 16);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(69, 41);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTenTimKiem
            // 
            this.txtTenTimKiem.Location = new System.Drawing.Point(135, 28);
            this.txtTenTimKiem.Name = "txtTenTimKiem";
            this.txtTenTimKiem.Size = new System.Drawing.Size(290, 21);
            this.txtTenTimKiem.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên người dùng: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(242, 407);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(198, 23);
            this.txtPass.TabIndex = 8;
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(233, 571);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(75, 23);
            this.d.TabIndex = 4;
            this.d.Text = "Thêm";
            this.d.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(109, 409);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password});
            this.dgvUser.Location = new System.Drawing.Point(23, 112);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(643, 129);
            this.dgvUser.TabIndex = 3;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "Pass";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(242, 374);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(198, 23);
            this.txtUserName.TabIndex = 7;
            // 
            // UC_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_User";
            this.Size = new System.Drawing.Size(690, 520);
            this.Load += new System.EventHandler(this.UC_User_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNewPass;
        public System.Windows.Forms.Label lblMatkhaumoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        public System.Windows.Forms.Label lblTacvu;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton rdXoa;
        public System.Windows.Forms.RadioButton rdDoiMatkhau;
        public System.Windows.Forms.RadioButton rdTaoUser;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTenTimKiem;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button d;
        private System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.CheckBox chk_Usertype;
    }
}
