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
    public partial class ThongTinChiTiet_KH : Form
    {
        DataTable tb_ThongTinKH;
        string TenDangNhap;
        string MatKhau;
        public ThongTinChiTiet_KH(string tenDangNhap)
        {
            this.TenDangNhap = tenDangNhap;
          
            InitializeComponent();
        }

        private void loadDataChiTietKH()
        {
            string sql = "SELECT TenDangNhap, HoTenKhachHang, DiaChiKH, SoDienThoaiKH, EmailKH, TAIKHOAN.MaTK " +
               "FROM  TAIKHOAN, KHACHHANG  " +
                "WHERE TenDangNhap = '" + TenDangNhap + "' " +
                "AND TAIKHOAN.MaTK = KHACHHANG.MaTK";



            tb_ThongTinKH = Functions.GetDataTable(sql);

            if (tb_ThongTinKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                txtBox_TDN_KH.Text = tb_ThongTinKH.Rows[0].Field<string>(0).Trim();
                txtBox_HoTen_NV.Text = tb_ThongTinKH.Rows[0].Field<string>(1).Trim();
                txtBox_DC_NV.Text = tb_ThongTinKH.Rows[0].Field<string>(2).Trim();
                txtBox_SDT_NV.Text = tb_ThongTinKH.Rows[0].Field<string>(3).Trim();
                txtBox_Email_NV.Text = tb_ThongTinKH.Rows[0].Field<string>(4).Trim();
                //= tb_ThongTinKH.Rows[0].Field<string>(5).Trim();
            }
        }



        private void loadThongTinCTKH(object sender, EventArgs e)
        {

            loadDataChiTietKH();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
