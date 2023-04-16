
namespace DoAnCuoiKi
{
    partial class DanhSachLoaiHang
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
            this.dataGridView_LoaiHang = new System.Windows.Forms.DataGridView();
            this.txtBox_LH_DSLH = new System.Windows.Forms.TextBox();
            this.txtBox_DC_DSLH = new System.Windows.Forms.TextBox();
            this.txtBox_TDT_DSLH = new System.Windows.Forms.TextBox();
            this.btn_DanhSachSp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_LoaiHang
            // 
            this.dataGridView_LoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LoaiHang.Location = new System.Drawing.Point(-3, 264);
            this.dataGridView_LoaiHang.Name = "dataGridView_LoaiHang";
            this.dataGridView_LoaiHang.Size = new System.Drawing.Size(843, 429);
            this.dataGridView_LoaiHang.TabIndex = 19;
            this.dataGridView_LoaiHang.Click += new System.EventHandler(this.PushData_DSLH_Click);
           
            // 
            // txtBox_LH_DSLH
            // 
            this.txtBox_LH_DSLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_LH_DSLH.Location = new System.Drawing.Point(446, 157);
            this.txtBox_LH_DSLH.Name = "txtBox_LH_DSLH";
            this.txtBox_LH_DSLH.Size = new System.Drawing.Size(100, 27);
            this.txtBox_LH_DSLH.TabIndex = 18;
            // 
            // txtBox_DC_DSLH
            // 
            this.txtBox_DC_DSLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_DC_DSLH.Location = new System.Drawing.Point(260, 157);
            this.txtBox_DC_DSLH.Name = "txtBox_DC_DSLH";
            this.txtBox_DC_DSLH.Size = new System.Drawing.Size(100, 27);
            this.txtBox_DC_DSLH.TabIndex = 17;
            // 
            // txtBox_TDT_DSLH
            // 
            this.txtBox_TDT_DSLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_TDT_DSLH.Location = new System.Drawing.Point(75, 157);
            this.txtBox_TDT_DSLH.Name = "txtBox_TDT_DSLH";
            this.txtBox_TDT_DSLH.Size = new System.Drawing.Size(100, 27);
            this.txtBox_TDT_DSLH.TabIndex = 16;
            // 
            // btn_DanhSachSp
            // 
            this.btn_DanhSachSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DanhSachSp.Location = new System.Drawing.Point(587, 132);
            this.btn_DanhSachSp.Name = "btn_DanhSachSp";
            this.btn_DanhSachSp.Size = new System.Drawing.Size(160, 52);
            this.btn_DanhSachSp.TabIndex = 15;
            this.btn_DanhSachSp.Text = "Xem danh sách sản phẩm";
            this.btn_DanhSachSp.UseVisualStyleBackColor = true;
            this.btn_DanhSachSp.Click += new System.EventHandler(this.btn_DanhSachSp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Loại Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên Đối Tác";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Danh Sách Loại Hàng";
            // 
            // DanhSachLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 689);
            this.Controls.Add(this.dataGridView_LoaiHang);
            this.Controls.Add(this.txtBox_LH_DSLH);
            this.Controls.Add(this.txtBox_DC_DSLH);
            this.Controls.Add(this.txtBox_TDT_DSLH);
            this.Controls.Add(this.btn_DanhSachSp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DanhSachLoaiHang";
            this.Text = "DanhSachLoaiHang";
            this.Load += new System.EventHandler(this.loadDanhSachLoaiHang);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_LoaiHang;
        private System.Windows.Forms.TextBox txtBox_LH_DSLH;
        private System.Windows.Forms.TextBox txtBox_DC_DSLH;
        private System.Windows.Forms.TextBox txtBox_TDT_DSLH;
        private System.Windows.Forms.Button btn_DanhSachSp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}