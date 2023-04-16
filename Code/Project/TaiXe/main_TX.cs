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
    public partial class main_TX : Form
    {
        public main_TX()
        {
            InitializeComponent();
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
            childFormTX.Controls.Add(childForm);
            childFormTX.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // xử lí chuyển màu khi click vào button
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

       
     

      

        // xử lí khi load form thì hiện tab tài khoản
        private void FormMain_TaiXe_Load(object sender, EventArgs e)
        {
            btn_TaiKhoan_TX.PerformClick();
        }

        // xử lí thoát
        private void btn_thoat_TX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // chức năng xem DS đơn hàng
        private void btn_DanhSachDonHang_Click(object sender, EventArgs e)
        {
            openChildForm(new DanhSachDonHang());
            ActivateButton(sender);
        }

        // chức năng xem đơn hàng đã nhận
        private void btn_DanhSachDonHangDaNhan_Click(object sender, EventArgs e)
        {
            openChildForm(new DanhSachDonHangDaNhan());
            ActivateButton(sender);
        }

        // chức năng thống kê
        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKe());
            ActivateButton(sender);
        }

        // chức năng tài khoản
        private void btn_ThongTinChiTiet_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongTinChiTiet_TX());
            ActivateButton(sender);
        }
    

    private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
