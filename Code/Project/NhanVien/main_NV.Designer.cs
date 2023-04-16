
namespace DoAnCuoiKi
{
    partial class main_NV
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
            this.menu = new System.Windows.Forms.Panel();
            this.btn_TaiKhoan_NV = new System.Windows.Forms.Button();
            this.btn_HDDD_NV = new System.Windows.Forms.Button();
            this.btn_HDCD_NV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.childFormNV = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.Controls.Add(this.btn_TaiKhoan_NV);
            this.menu.Controls.Add(this.btn_HDDD_NV);
            this.menu.Controls.Add(this.btn_HDCD_NV);
            this.menu.Controls.Add(this.label1);
            this.menu.Controls.Add(this.pictureBox1);
            this.menu.Location = new System.Drawing.Point(1, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(155, 728);
            this.menu.TabIndex = 1;
            // 
            // btn_TaiKhoan_NV
            // 
            this.btn_TaiKhoan_NV.Location = new System.Drawing.Point(0, 132);
            this.btn_TaiKhoan_NV.Name = "btn_TaiKhoan_NV";
            this.btn_TaiKhoan_NV.Size = new System.Drawing.Size(155, 57);
            this.btn_TaiKhoan_NV.TabIndex = 4;
            this.btn_TaiKhoan_NV.Text = "Tài Khoản";
            this.btn_TaiKhoan_NV.UseVisualStyleBackColor = true;
            this.btn_TaiKhoan_NV.Click += new System.EventHandler(this.btn_taikhoan_NV_Click);
            // 
            // btn_HDDD_NV
            // 
            this.btn_HDDD_NV.Location = new System.Drawing.Point(0, 195);
            this.btn_HDDD_NV.Name = "btn_HDDD_NV";
            this.btn_HDDD_NV.Size = new System.Drawing.Size(155, 57);
            this.btn_HDDD_NV.TabIndex = 3;
            this.btn_HDDD_NV.Text = "Hợp đồng đã đuyệt";
            this.btn_HDDD_NV.UseVisualStyleBackColor = true;
            this.btn_HDDD_NV.Click += new System.EventHandler(this.btn_hopdongdaduyet_NV_Click);

            // 
            // btn_HDCD_NV
            // 
            this.btn_HDCD_NV.Location = new System.Drawing.Point(0, 258);
            this.btn_HDCD_NV.Name = "btn_HDCD_NV";
            this.btn_HDCD_NV.Size = new System.Drawing.Size(155, 57);
            this.btn_HDCD_NV.TabIndex = 2;
            this.btn_HDCD_NV.Text = "Hợp đồng chưa duyệt";
            this.btn_HDCD_NV.UseVisualStyleBackColor = true;
            this.btn_HDCD_NV.Click += new System.EventHandler(this.btn_hopdongchuaduyet_NV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = " Nhân Viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // childFormNV
            // 
            this.childFormNV.Location = new System.Drawing.Point(154, 0);
            this.childFormNV.Name = "childFormNV";
            this.childFormNV.Size = new System.Drawing.Size(850, 728);
            this.childFormNV.TabIndex = 2;
            // 
            // main_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.childFormNV);
            this.Controls.Add(this.menu);
            this.Name = "main_NV";
            this.Text = "main_NV";
            this.Load += new System.EventHandler(this.FormMain_NhanVien_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button btn_TaiKhoan_NV;
        private System.Windows.Forms.Button btn_HDDD_NV;
        private System.Windows.Forms.Button btn_HDCD_NV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel childFormNV;
    }
}