namespace DoAnCuoiKi
{
    partial class Form_Admin_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ThongTinCT = new System.Windows.Forms.Button();
            this.btn_DanhSachTK = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
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
            this.panel2.Controls.Add(this.btn_ThongTinCT);
            this.panel2.Controls.Add(this.btn_DanhSachTK);
            this.panel2.Controls.Add(this.btn_Thoat);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(2, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 582);
            this.panel2.TabIndex = 1;
            // 
            // btn_ThongTinCT
            // 
            this.btn_ThongTinCT.Location = new System.Drawing.Point(-1, 59);
            this.btn_ThongTinCT.Name = "btn_ThongTinCT";
            this.btn_ThongTinCT.Size = new System.Drawing.Size(149, 63);
            this.btn_ThongTinCT.TabIndex = 7;
            this.btn_ThongTinCT.Text = "Thông tin CT";
            this.btn_ThongTinCT.UseVisualStyleBackColor = true;
            this.btn_ThongTinCT.Click += new System.EventHandler(this.btn_ThongTinCT_Click);
            // 
            // btn_DanhSachTK
            // 
            this.btn_DanhSachTK.Location = new System.Drawing.Point(-1, -1);
            this.btn_DanhSachTK.Name = "btn_DanhSachTK";
            this.btn_DanhSachTK.Size = new System.Drawing.Size(149, 63);
            this.btn_DanhSachTK.TabIndex = 6;
            this.btn_DanhSachTK.Text = "Danh sách TK";
            this.btn_DanhSachTK.UseVisualStyleBackColor = true;
            this.btn_DanhSachTK.Click += new System.EventHandler(this.btn_DanhSachTK_Click);
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
            // Form_Admin_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel_ChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Admin_Main";
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
        private Button btn_DanhSachTK;
        private Button btn_ThongTinCT;
    }
}