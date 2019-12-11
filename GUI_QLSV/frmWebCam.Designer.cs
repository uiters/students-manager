namespace GUI_QLSV
{
    partial class frmWebCam
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnTakePhoto = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptxWebCam = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ptxWebCam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(521, 394);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 48);
            this.btnStart.TabIndex = 13;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Location = new System.Drawing.Point(348, 396);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 46);
            this.btnStop.TabIndex = 12;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // btnTakePhoto
            // 
            this.btnTakePhoto.BackColor = System.Drawing.Color.Transparent;
            this.btnTakePhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTakePhoto.Enabled = false;
            this.btnTakePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakePhoto.Location = new System.Drawing.Point(197, 397);
            this.btnTakePhoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnTakePhoto.Name = "btnTakePhoto";
            this.btnTakePhoto.Size = new System.Drawing.Size(100, 45);
            this.btnTakePhoto.TabIndex = 11;
            this.btnTakePhoto.UseVisualStyleBackColor = false;
            this.btnTakePhoto.Click += new System.EventHandler(this.btnTakePhoto_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(521, 346);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(247, 352);
            this.txtSave.Margin = new System.Windows.Forms.Padding(4);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(265, 22);
            this.txtSave.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(181, 356);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "OutPut:";
            // 
            // ptxWebCam
            // 
            this.ptxWebCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptxWebCam.Location = new System.Drawing.Point(180, 8);
            this.ptxWebCam.Margin = new System.Windows.Forms.Padding(4);
            this.ptxWebCam.Name = "ptxWebCam";
            this.ptxWebCam.Size = new System.Drawing.Size(440, 326);
            this.ptxWebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptxWebCam.TabIndex = 7;
            this.ptxWebCam.TabStop = false;
            // 
            // frmWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnTakePhoto);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptxWebCam);
            this.Name = "frmWebCam";
            this.Text = "frmWebCam";
            ((System.ComponentModel.ISupportInitialize)(this.ptxWebCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnTakePhoto;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptxWebCam;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}