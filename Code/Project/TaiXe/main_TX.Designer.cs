
namespace DoAnCuoiKi
{
    partial class main_TX
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
            this.btn_TK_TX = new System.Windows.Forms.Button();
            this.btn_TaiKhoan_TX = new System.Windows.Forms.Button();
            this.btn_DSDH_TX = new System.Windows.Forms.Button();
            this.btn_DHDN_TX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.childFormTX = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.Controls.Add(this.btn_TK_TX);
            this.menu.Controls.Add(this.btn_TaiKhoan_TX);
            this.menu.Controls.Add(this.btn_DSDH_TX);
            this.menu.Controls.Add(this.btn_DHDN_TX);
            this.menu.Controls.Add(this.label1);
            this.menu.Controls.Add(this.pictureBox1);
            this.menu.Location = new System.Drawing.Point(1, 1);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(155, 728);
            this.menu.TabIndex = 2;
            // 
            // btn_TK_TX
            // 
            this.btn_TK_TX.Location = new System.Drawing.Point(0, 321);
            this.btn_TK_TX.Name = "btn_TK_TX";
            this.btn_TK_TX.Size = new System.Drawing.Size(155, 57);
            this.btn_TK_TX.TabIndex = 5;
            this.btn_TK_TX.Text = "Thống kê";
            this.btn_TK_TX.UseVisualStyleBackColor = true;
            this.btn_TK_TX.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_TaiKhoan_TX
            // 
            this.btn_TaiKhoan_TX.Location = new System.Drawing.Point(0, 132);
            this.btn_TaiKhoan_TX.Name = "btn_TaiKhoan_TX";
            this.btn_TaiKhoan_TX.Size = new System.Drawing.Size(155, 57);
            this.btn_TaiKhoan_TX.TabIndex = 4;
            this.btn_TaiKhoan_TX.Text = "Tài Khoản";
            this.btn_TaiKhoan_TX.UseVisualStyleBackColor = true;
            this.btn_TaiKhoan_TX.Click += new System.EventHandler(this.btn_ThongTinChiTiet_Click);
            // 
            // btn_DSDH_TX
            // 
            this.btn_DSDH_TX.Location = new System.Drawing.Point(0, 195);
            this.btn_DSDH_TX.Name = "btn_DSDH_TX";
            this.btn_DSDH_TX.Size = new System.Drawing.Size(155, 57);
            this.btn_DSDH_TX.TabIndex = 3;
            this.btn_DSDH_TX.Text = "Danh Sách Đơn Hàng";
            this.btn_DSDH_TX.UseVisualStyleBackColor = true;
            this.btn_DSDH_TX.Click += new System.EventHandler(this.btn_DanhSachDonHang_Click);
            // 
            // btn_DHDN_TX
            // 
            this.btn_DHDN_TX.Location = new System.Drawing.Point(0, 258);
            this.btn_DHDN_TX.Name = "btn_DHDN_TX";
            this.btn_DHDN_TX.Size = new System.Drawing.Size(155, 57);
            this.btn_DHDN_TX.TabIndex = 2;
            this.btn_DHDN_TX.Text = "Đơn Hàng đã nhận";
            this.btn_DHDN_TX.UseVisualStyleBackColor = true;
            this.btn_DHDN_TX.Click += new System.EventHandler(this.btn_DanhSachDonHangDaNhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = " Tài Xế";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // childFormTX
            // 
            this.childFormTX.Location = new System.Drawing.Point(156, 1);
            this.childFormTX.Name = "childFormTX";
            this.childFormTX.Size = new System.Drawing.Size(856, 728);
            this.childFormTX.TabIndex = 3;
            // 
            // main_TX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.childFormTX);
            this.Controls.Add(this.menu);
            this.Name = "main_TX";
            this.Text = "main_TX";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button btn_TaiKhoan_TX;
        private System.Windows.Forms.Button btn_DSDH_TX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_TK_TX;
        private System.Windows.Forms.Button btn_DHDN_TX;
        private System.Windows.Forms.Panel childFormTX;
    }
}