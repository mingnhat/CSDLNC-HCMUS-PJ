namespace DoAnCuoiKi
{
    partial class Form_DoiTac_ThucDon
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
            this.label5 = new System.Windows.Forms.Label();
            this.dGV_DoiTac_ThucDon = new System.Windows.Forms.DataGridView();
            this.txtBox_TenMon = new System.Windows.Forms.TextBox();
            this.txtBox_TinhTrangMonAn = new System.Windows.Forms.TextBox();
            this.txtBox_MieuTaMonAn = new System.Windows.Forms.TextBox();
            this.txtBox_Gia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DoiTac_ThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dGV_DoiTac_ThucDon);
            this.panel3.Controls.Add(this.txtBox_TenMon);
            this.panel3.Controls.Add(this.txtBox_TinhTrangMonAn);
            this.panel3.Controls.Add(this.txtBox_MieuTaMonAn);
            this.panel3.Controls.Add(this.txtBox_Gia);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(859, 739);
            this.panel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(53, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 26;
            // 
            // dGV_DoiTac_ThucDon
            // 
            this.dGV_DoiTac_ThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DoiTac_ThucDon.Location = new System.Drawing.Point(0, 395);
            this.dGV_DoiTac_ThucDon.Name = "dGV_DoiTac_ThucDon";
            this.dGV_DoiTac_ThucDon.RowTemplate.Height = 25;
            this.dGV_DoiTac_ThucDon.Size = new System.Drawing.Size(859, 344);
            this.dGV_DoiTac_ThucDon.TabIndex = 25;
            this.dGV_DoiTac_ThucDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_DoiTac_ThucDon_CellContentClick);
            // 
            // txtBox_TenMon
            // 
            this.txtBox_TenMon.Location = new System.Drawing.Point(121, 213);
            this.txtBox_TenMon.Name = "txtBox_TenMon";
            this.txtBox_TenMon.Size = new System.Drawing.Size(217, 23);
            this.txtBox_TenMon.TabIndex = 24;
            // 
            // txtBox_TinhTrangMonAn
            // 
            this.txtBox_TinhTrangMonAn.Location = new System.Drawing.Point(481, 313);
            this.txtBox_TinhTrangMonAn.Name = "txtBox_TinhTrangMonAn";
            this.txtBox_TinhTrangMonAn.Size = new System.Drawing.Size(217, 23);
            this.txtBox_TinhTrangMonAn.TabIndex = 22;
            // 
            // txtBox_MieuTaMonAn
            // 
            this.txtBox_MieuTaMonAn.Location = new System.Drawing.Point(481, 213);
            this.txtBox_MieuTaMonAn.Name = "txtBox_MieuTaMonAn";
            this.txtBox_MieuTaMonAn.Size = new System.Drawing.Size(217, 23);
            this.txtBox_MieuTaMonAn.TabIndex = 15;
            // 
            // txtBox_Gia
            // 
            this.txtBox_Gia.Location = new System.Drawing.Point(121, 313);
            this.txtBox_Gia.Name = "txtBox_Gia";
            this.txtBox_Gia.Size = new System.Drawing.Size(217, 23);
            this.txtBox_Gia.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(518, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tình trạng món ăn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(529, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Miêu tả món ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(204, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(189, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên món";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(340, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thực đơn";
            // 
            // Form_DoiTac_ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 739);
            this.Controls.Add(this.panel3);
            this.Name = "Form_DoiTac_ThucDon";
            this.Text = "Form_ThucDon";
            this.Load += new System.EventHandler(this.run_ThucDon);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DoiTac_ThucDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label8;
        private Label label4;
        private TextBox txtBox_MieuTaMonAn;
        private TextBox txtBox_Gia;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtBox_TinhTrangMonAn;
        private Label label5;
        private DataGridView dGV_DoiTac_ThucDon;
        private TextBox txtBox_TenMon;
    }
}