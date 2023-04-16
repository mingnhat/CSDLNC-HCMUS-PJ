namespace DoAnCuoiKi
{
    partial class Form_DoiTac_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DoiTac_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_CuaHang = new System.Windows.Forms.Button();
            this.btn_DoiTac_TaiKhoan = new System.Windows.Forms.Button();
            this.btn_DoiTac_DonHang = new System.Windows.Forms.Button();
            this.btn_DoiTac_ThucDon = new System.Windows.Forms.Button();
            this.btn_DoiTac_LapHopDong = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_ChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 146);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đối tác";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_CuaHang);
            this.panel2.Controls.Add(this.btn_DoiTac_TaiKhoan);
            this.panel2.Controls.Add(this.btn_DoiTac_DonHang);
            this.panel2.Controls.Add(this.btn_DoiTac_ThucDon);
            this.panel2.Controls.Add(this.btn_DoiTac_LapHopDong);
            this.panel2.Controls.Add(this.btn_Thoat);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(2, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 582);
            this.panel2.TabIndex = 1;
            // 
            // btn_CuaHang
            // 
            this.btn_CuaHang.Location = new System.Drawing.Point(-1, 183);
            this.btn_CuaHang.Name = "btn_CuaHang";
            this.btn_CuaHang.Size = new System.Drawing.Size(149, 63);
            this.btn_CuaHang.TabIndex = 7;
            this.btn_CuaHang.Text = "Cửa hàng";
            this.btn_CuaHang.UseVisualStyleBackColor = true;
            this.btn_CuaHang.Click += new System.EventHandler(this.btn_CuaHang_Click);
            // 
            // btn_DoiTac_TaiKhoan
            // 
            this.btn_DoiTac_TaiKhoan.Location = new System.Drawing.Point(-1, 241);
            this.btn_DoiTac_TaiKhoan.Name = "btn_DoiTac_TaiKhoan";
            this.btn_DoiTac_TaiKhoan.Size = new System.Drawing.Size(149, 63);
            this.btn_DoiTac_TaiKhoan.TabIndex = 6;
            this.btn_DoiTac_TaiKhoan.Text = "Tài khoản";
            this.btn_DoiTac_TaiKhoan.UseVisualStyleBackColor = true;
            this.btn_DoiTac_TaiKhoan.Click += new System.EventHandler(this.btn_DoiTac_TaiKhoan_Click);
            // 
            // btn_DoiTac_DonHang
            // 
            this.btn_DoiTac_DonHang.Location = new System.Drawing.Point(-1, 126);
            this.btn_DoiTac_DonHang.Name = "btn_DoiTac_DonHang";
            this.btn_DoiTac_DonHang.Size = new System.Drawing.Size(149, 63);
            this.btn_DoiTac_DonHang.TabIndex = 5;
            this.btn_DoiTac_DonHang.Text = "Đơn hàng";
            this.btn_DoiTac_DonHang.UseVisualStyleBackColor = true;
            this.btn_DoiTac_DonHang.Click += new System.EventHandler(this.btn_DoiTac_DonHang_Click);
            // 
            // btn_DoiTac_ThucDon
            // 
            this.btn_DoiTac_ThucDon.Location = new System.Drawing.Point(-1, 67);
            this.btn_DoiTac_ThucDon.Name = "btn_DoiTac_ThucDon";
            this.btn_DoiTac_ThucDon.Size = new System.Drawing.Size(149, 63);
            this.btn_DoiTac_ThucDon.TabIndex = 4;
            this.btn_DoiTac_ThucDon.Text = "Thực đơn";
            this.btn_DoiTac_ThucDon.UseVisualStyleBackColor = true;
            this.btn_DoiTac_ThucDon.Click += new System.EventHandler(this.btn_DoiTac_ThucDon_Click);
            // 
            // btn_DoiTac_LapHopDong
            // 
            this.btn_DoiTac_LapHopDong.Location = new System.Drawing.Point(-1, 8);
            this.btn_DoiTac_LapHopDong.Name = "btn_DoiTac_LapHopDong";
            this.btn_DoiTac_LapHopDong.Size = new System.Drawing.Size(149, 63);
            this.btn_DoiTac_LapHopDong.TabIndex = 3;
            this.btn_DoiTac_LapHopDong.Text = "Lập hợp đồng";
            this.btn_DoiTac_LapHopDong.UseVisualStyleBackColor = true;
            this.btn_DoiTac_LapHopDong.Click += new System.EventHandler(this.btn_DoiTac_LapHopDong_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(-1, 518);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(149, 63);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_ChildForm
            // 
            this.panel_ChildForm.BackColor = System.Drawing.Color.Transparent;
            this.panel_ChildForm.Location = new System.Drawing.Point(150, 2);
            this.panel_ChildForm.Name = "panel_ChildForm";
            this.panel_ChildForm.Size = new System.Drawing.Size(856, 725);
            this.panel_ChildForm.TabIndex = 2;
            this.panel_ChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ChildForm_Paint);
            // 
            // Form_DoiTac_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel_ChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_DoiTac_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DoiTac";
            this.Load += new System.EventHandler(this.Form_DoiTac_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btn_Thoat;
        private Button button1;
        private Panel panel_ChildForm;
        private Button btn_DoiTac_LapHopDong;
        private Button btn_DoiTac_TaiKhoan;
        private Button btn_DoiTac_DonHang;
        private Button btn_DoiTac_ThucDon;
        private Button btn_CuaHang;
    }
}