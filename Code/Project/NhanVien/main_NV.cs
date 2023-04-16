using Project;
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
    public partial class main_NV : Form
    {
        Thread t;
        string tenDangNhap;
        string matKhau;
        string maSoNhanVien;
        public main_NV(string tenDangNhap, string matKhau)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;

           
            getMaNV();
        }




        private void getMaNV()
        {
            
            string sql = "select MaSoNhanVien from NHANVIEN,TAIKHOAN where TenDangNhap ='" + tenDangNhap + "' and MatKhau ='" + matKhau + "' and NHANVIEN.MaTK = TAIKHOAN.MaTK ";
            maSoNhanVien = Functions.GetFieldValues(sql);
          
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
            childFormNV.Controls.Add(childForm);

            childFormNV.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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


        private void FormMain_NhanVien_Load(object sender, EventArgs e)
        {
            btn_TaiKhoan_NV.PerformClick();
        }

        private void btn_hopdongdaduyet_NV_Click(object sender, EventArgs e)
        {
            openChildForm(new HopDongDaDuyet());
            ActivateButton(sender);
        }
        private void btn_hopdongchuaduyet_NV_Click(object sender, EventArgs e)
        {
            openChildForm(new HopDongChuaDuyet(maSoNhanVien));
            ActivateButton(sender);
        }

        private void btn_taikhoan_NV_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongTinChiTiet_NV(tenDangNhap,matKhau));
            ActivateButton(sender);
        }




    }

}
