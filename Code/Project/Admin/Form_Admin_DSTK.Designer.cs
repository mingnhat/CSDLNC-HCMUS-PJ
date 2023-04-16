namespace DoAnCuoiKi
{
    partial class Form_Admin_DSTK
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.txtBox_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dGV_DSTK = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_MaTK = new System.Windows.Forms.TextBox();
            this.txtBox_LoaiTK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSTK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_Them);
            this.panel3.Controls.Add(this.txtBox_TenDangNhap);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dGV_DSTK);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtBox_MaTK);
            this.panel3.Controls.Add(this.txtBox_LoaiTK);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(859, 739);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(90, 291);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 26;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txtBox_TenDangNhap
            // 
            this.txtBox_TenDangNhap.Location = new System.Drawing.Point(460, 188);
            this.txtBox_TenDangNhap.Name = "txtBox_TenDangNhap";
            this.txtBox_TenDangNhap.Size = new System.Drawing.Size(217, 23);
            this.txtBox_TenDangNhap.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(207, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã tài khoản";
            // 
            // dGV_DSTK
            // 
            this.dGV_DSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DSTK.Location = new System.Drawing.Point(0, 329);
            this.dGV_DSTK.Name = "dGV_DSTK";
            this.dGV_DSTK.RowTemplate.Height = 25;
            this.dGV_DSTK.Size = new System.Drawing.Size(859, 410);
            this.dGV_DSTK.TabIndex = 23;
            this.dGV_DSTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CuaHang_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(207, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tên đăng nhập";
            // 
            // txtBox_MaTK
            // 
            this.txtBox_MaTK.Location = new System.Drawing.Point(460, 139);
            this.txtBox_MaTK.Name = "txtBox_MaTK";
            this.txtBox_MaTK.Size = new System.Drawing.Size(217, 23);
            this.txtBox_MaTK.TabIndex = 15;
            // 
            // txtBox_LoaiTK
            // 
            this.txtBox_LoaiTK.Location = new System.Drawing.Point(460, 236);
            this.txtBox_LoaiTK.Name = "txtBox_LoaiTK";
            this.txtBox_LoaiTK.Size = new System.Drawing.Size(217, 23);
            this.txtBox_LoaiTK.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(207, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Loại tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(289, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách tài khoản";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_Admin_DSTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 739);
            this.Controls.Add(this.panel3);
            this.Name = "Form_Admin_DSTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_ThongTinCT";
            this.Load += new System.EventHandler(this.run_DSTK);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private Label label1;
        private Label label7;
        private TextBox txtBox_MaTK;
        private TextBox txtBox_LoaiTK;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label5;
        private DataGridView dGV_DSTK;
        private TextBox txtBox_TenDangNhap;
        private Label label2;
        private Button btn_Them;
        private Button button1;
    }
}