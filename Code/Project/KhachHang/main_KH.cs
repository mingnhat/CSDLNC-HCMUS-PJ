using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace DoAnCuoiKi
{

       
    public partial class main_KH : Form
    {

        private string tenDangNhap;
        private string matKhau;
        public main_KH(string tenDangNhap)
        {
            this.tenDangNhap= tenDangNhap;
            
            InitializeComponent();
        }

        private Button currentButton;
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#4169E1");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(39, 39, 58);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }

        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormKH.Controls.Add(childForm);
            childFormKH.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.Panel();
            this.btn_TaiKhoan_KH = new System.Windows.Forms.Button();
            this.btn_DonHang_KH = new System.Windows.Forms.Button();
            this.btn_DatHang_KH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.childFormKH = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.Controls.Add(this.btn_TaiKhoan_KH);
            this.menu.Controls.Add(this.btn_DonHang_KH);
            this.menu.Controls.Add(this.btn_DatHang_KH);
            this.menu.Controls.Add(this.label1);
            this.menu.Controls.Add(this.pictureBox1);
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(155, 728);
            this.menu.TabIndex = 0;
            // 
            // btn_TaiKhoan_KH
            // 
            this.btn_TaiKhoan_KH.Location = new System.Drawing.Point(0, 132);
            this.btn_TaiKhoan_KH.Name = "btn_TaiKhoan_KH";
            this.btn_TaiKhoan_KH.Size = new System.Drawing.Size(155, 57);
            this.btn_TaiKhoan_KH.TabIndex = 4;
            this.btn_TaiKhoan_KH.Text = "Tài Khoản";
            this.btn_TaiKhoan_KH.UseVisualStyleBackColor = true;
            this.btn_TaiKhoan_KH.Click += new System.EventHandler(this.btn_TaiKhoan_KH_Click);
            // 
            // btn_DonHang_KH
            // 
            this.btn_DonHang_KH.Location = new System.Drawing.Point(0, 195);
            this.btn_DonHang_KH.Name = "btn_DonHang_KH";
            this.btn_DonHang_KH.Size = new System.Drawing.Size(155, 57);
            this.btn_DonHang_KH.TabIndex = 3;
            this.btn_DonHang_KH.Text = "Đơn Hàng Của tôi";
            this.btn_DonHang_KH.UseVisualStyleBackColor = true;
            this.btn_DonHang_KH.Click += new System.EventHandler(this.btn_DonHang_KH_Click);
            // 
            // btn_DatHang_KH
            // 
            this.btn_DatHang_KH.Location = new System.Drawing.Point(0, 258);
            this.btn_DatHang_KH.Name = "btn_DatHang_KH";
            this.btn_DatHang_KH.Size = new System.Drawing.Size(155, 57);
            this.btn_DatHang_KH.TabIndex = 2;
            this.btn_DatHang_KH.Text = "Đặt Hàng";
            this.btn_DatHang_KH.UseVisualStyleBackColor = true;
            this.btn_DatHang_KH.Click += new System.EventHandler(this.btn_DatHang_KH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "KHACH HANG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // childFormKH
            // 
            this.childFormKH.Location = new System.Drawing.Point(151, 0);
            this.childFormKH.Name = "childFormKH";
            this.childFormKH.Size = new System.Drawing.Size(857, 728);
            this.childFormKH.TabIndex = 1;
            // 
            // main_KH
            // 
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.childFormKH);
            this.Controls.Add(this.menu);
            this.Name = "main_KH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void FormMain_KhachHang_Load(object sender, EventArgs e)
        {
            btn_TaiKhoan_KH.PerformClick();
        }

        private void btn_TaiKhoan_KH_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongTinChiTiet_KH(tenDangNhap));
            ActivateButton(sender);
        }


        private void btn_DatHang_KH_Click(object sender, EventArgs e)
        {
            openChildForm(new DanhSachLoaiHang(tenDangNhap));
            ActivateButton(sender);
        }


        private void btn_DonHang_KH_Click(object sender,EventArgs e)
        {
            openChildForm(new DanhSachDonHang_KH(tenDangNhap));
            ActivateButton(sender);
        }
    }
}
