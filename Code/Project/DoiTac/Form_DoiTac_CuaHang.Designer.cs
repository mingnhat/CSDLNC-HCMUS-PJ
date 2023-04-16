namespace DoAnCuoiKi
{
    partial class Form_DoiTac_CuaHang
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dGV_CuaHang = new System.Windows.Forms.DataGridView();
            this.txtBox_tgMo = new System.Windows.Forms.TextBox();
            this.txtBox_TinhTrang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_TenQuan = new System.Windows.Forms.TextBox();
            this.txtBox_tgDong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.dGV_CuaHang);
            this.panel3.Controls.Add(this.txtBox_tgMo);
            this.panel3.Controls.Add(this.txtBox_TinhTrang);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtBox_TenQuan);
            this.panel3.Controls.Add(this.txtBox_tgDong);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(859, 739);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dGV_CuaHang
            // 
            this.dGV_CuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_CuaHang.Location = new System.Drawing.Point(0, 329);
            this.dGV_CuaHang.Name = "dGV_CuaHang";
            this.dGV_CuaHang.RowTemplate.Height = 25;
            this.dGV_CuaHang.Size = new System.Drawing.Size(859, 410);
            this.dGV_CuaHang.TabIndex = 23;
            this.dGV_CuaHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CuaHang_CellContentClick);
            // 
            // txtBox_tgMo
            // 
            this.txtBox_tgMo.Location = new System.Drawing.Point(460, 193);
            this.txtBox_tgMo.Name = "txtBox_tgMo";
            this.txtBox_tgMo.Size = new System.Drawing.Size(217, 23);
            this.txtBox_tgMo.TabIndex = 22;
            // 
            // txtBox_TinhTrang
            // 
            this.txtBox_TinhTrang.Location = new System.Drawing.Point(460, 259);
            this.txtBox_TinhTrang.Name = "txtBox_TinhTrang";
            this.txtBox_TinhTrang.Size = new System.Drawing.Size(217, 23);
            this.txtBox_TinhTrang.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(190, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Thời gian mở cửa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(190, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tên quán";
            // 
            // txtBox_TenQuan
            // 
            this.txtBox_TenQuan.Location = new System.Drawing.Point(460, 160);
            this.txtBox_TenQuan.Name = "txtBox_TenQuan";
            this.txtBox_TenQuan.Size = new System.Drawing.Size(217, 23);
            this.txtBox_TenQuan.TabIndex = 15;
            // 
            // txtBox_tgDong
            // 
            this.txtBox_tgDong.Location = new System.Drawing.Point(460, 227);
            this.txtBox_tgDong.Name = "txtBox_tgDong";
            this.txtBox_tgDong.Size = new System.Drawing.Size(217, 23);
            this.txtBox_tgDong.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(190, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tình trạng cửa hàng";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(190, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Thời gian đóng cửa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(289, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý cửa hàng";
            // 
            // Form_DoiTac_CuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 739);
            this.Controls.Add(this.panel3);
            this.Name = "Form_DoiTac_CuaHang";
            this.Text = "Form_ThongTinCT";
            this.Load += new EventHandler(this.run_ThucDon);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CuaHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private Label label1;
        private Label label8;
        private Label label7;
        private TextBox txtBox_TenQuan;
        private TextBox txtBox_tgDong;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtBox_tgMo;
        private TextBox txtBox_TinhTrang;
        private Label label9;
        private Label label5;
        private DataGridView dGV_CuaHang;
    }
}