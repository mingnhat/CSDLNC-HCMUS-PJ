namespace DoAnCuoiKi
{
    partial class Form_DoiTac_HopDong
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
            this.dTP_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dTP_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtBox_NguoiDaiDien = new System.Windows.Forms.TextBox();
            this.txtBox_MaThue = new System.Windows.Forms.TextBox();
            this.txtBox_MaDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dGV_DoiTac_HopDong = new System.Windows.Forms.DataGridView();
            this.txtBox_MaHD = new System.Windows.Forms.TextBox();
            this.txtBox_HieuLuc = new System.Windows.Forms.TextBox();
            this.label_DoiTac_MaSoThue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DoiTac_HopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.dTP_NgayKetThuc);
            this.panel3.Controls.Add(this.dTP_NgayLap);
            this.panel3.Controls.Add(this.txtBox_NguoiDaiDien);
            this.panel3.Controls.Add(this.txtBox_MaThue);
            this.panel3.Controls.Add(this.txtBox_MaDT);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dGV_DoiTac_HopDong);
            this.panel3.Controls.Add(this.txtBox_MaHD);
            this.panel3.Controls.Add(this.txtBox_HieuLuc);
            this.panel3.Controls.Add(this.label_DoiTac_MaSoThue);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(859, 739);
            this.panel3.TabIndex = 3;
            // 
            // dTP_NgayKetThuc
            // 
            this.dTP_NgayKetThuc.Location = new System.Drawing.Point(563, 250);
            this.dTP_NgayKetThuc.Name = "dTP_NgayKetThuc";
            this.dTP_NgayKetThuc.Size = new System.Drawing.Size(200, 23);
            this.dTP_NgayKetThuc.TabIndex = 40;
            // 
            // dTP_NgayLap
            // 
            this.dTP_NgayLap.Location = new System.Drawing.Point(563, 189);
            this.dTP_NgayLap.Name = "dTP_NgayLap";
            this.dTP_NgayLap.Size = new System.Drawing.Size(200, 23);
            this.dTP_NgayLap.TabIndex = 39;
            // 
            // txtBox_NguoiDaiDien
            // 
            this.txtBox_NguoiDaiDien.Location = new System.Drawing.Point(210, 250);
            this.txtBox_NguoiDaiDien.Name = "txtBox_NguoiDaiDien";
            this.txtBox_NguoiDaiDien.Size = new System.Drawing.Size(217, 23);
            this.txtBox_NguoiDaiDien.TabIndex = 38;
            // 
            // txtBox_MaThue
            // 
            this.txtBox_MaThue.Location = new System.Drawing.Point(210, 219);
            this.txtBox_MaThue.Name = "txtBox_MaThue";
            this.txtBox_MaThue.Size = new System.Drawing.Size(217, 23);
            this.txtBox_MaThue.TabIndex = 37;
            // 
            // txtBox_MaDT
            // 
            this.txtBox_MaDT.Location = new System.Drawing.Point(210, 189);
            this.txtBox_MaDT.Name = "txtBox_MaDT";
            this.txtBox_MaDT.Size = new System.Drawing.Size(217, 23);
            this.txtBox_MaDT.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(249, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "Thời gian hiệu lực";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(609, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(52, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "Mã số đối tác";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(52, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Mã số hợp đồng";
            // 
            // dGV_DoiTac_HopDong
            // 
            this.dGV_DoiTac_HopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DoiTac_HopDong.Location = new System.Drawing.Point(0, 429);
            this.dGV_DoiTac_HopDong.Name = "dGV_DoiTac_HopDong";
            this.dGV_DoiTac_HopDong.RowTemplate.Height = 25;
            this.dGV_DoiTac_HopDong.Size = new System.Drawing.Size(859, 310);
            this.dGV_DoiTac_HopDong.TabIndex = 30;
            this.dGV_DoiTac_HopDong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_DoiTac_HopDong_CellContentClick);
            // 
            // txtBox_MaHD
            // 
            this.txtBox_MaHD.Location = new System.Drawing.Point(210, 159);
            this.txtBox_MaHD.Name = "txtBox_MaHD";
            this.txtBox_MaHD.Size = new System.Drawing.Size(217, 23);
            this.txtBox_MaHD.TabIndex = 24;
            // 
            // txtBox_HieuLuc
            // 
            this.txtBox_HieuLuc.Location = new System.Drawing.Point(416, 330);
            this.txtBox_HieuLuc.Name = "txtBox_HieuLuc";
            this.txtBox_HieuLuc.Size = new System.Drawing.Size(131, 23);
            this.txtBox_HieuLuc.TabIndex = 15;
            // 
            // label_DoiTac_MaSoThue
            // 
            this.label_DoiTac_MaSoThue.AutoSize = true;
            this.label_DoiTac_MaSoThue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_DoiTac_MaSoThue.Location = new System.Drawing.Point(52, 217);
            this.label_DoiTac_MaSoThue.Name = "label_DoiTac_MaSoThue";
            this.label_DoiTac_MaSoThue.Size = new System.Drawing.Size(86, 21);
            this.label_DoiTac_MaSoThue.TabIndex = 6;
            this.label_DoiTac_MaSoThue.Text = "Mã số thuế";
            this.label_DoiTac_MaSoThue.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(591, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày lập hợp đồng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(52, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Người đại diện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(306, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hợp đồng đã lập";
            // 
            // Form_DoiTac_HopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 739);
            this.Controls.Add(this.panel3);
            this.Name = "Form_DoiTac_HopDong";
            this.Text = "Form_ThucDon";
            this.Load += new System.EventHandler(this.run_HopDong);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DoiTac_HopDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label_DoiTac_MaSoThue;
        private TextBox txtBox_HieuLuc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtBox_MaHD;
        private DataGridView dGV_DoiTac_HopDong;
        private TextBox txtBox_NguoiDaiDien;
        private TextBox txtBox_MaThue;
        private TextBox txtBox_MaDT;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker dTP_NgayKetThuc;
        private DateTimePicker dTP_NgayLap;
    }
}