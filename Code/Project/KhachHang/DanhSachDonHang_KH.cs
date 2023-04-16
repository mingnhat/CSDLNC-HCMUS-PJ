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
    public partial class DanhSachDonHang_KH : Form
    {
        DataTable tb_DanhSachDonHang;
        private string MaTK;
        public DanhSachDonHang_KH(string masotaikhoan)
        {
            this.MaTK = masotaikhoan;
            InitializeComponent();
        }


        private void loadData_DanhSachDonHang()
        {
            string query = "select dh.MaSoDonHang, dh.NgayDatHang, dh.DiaChiGiaoHang, dh.HinhThucThanhToan, " +
            "dh.PhiSanPham, dh.PhiVanChuyen, dh.TrangThaiDonHang, ct.SoLuongMon " +
            "from DONHANG dh, CT_DONHANG ct " +
            "where dh.MaSoDonHang = ct.MaSoDonHang and dh.MaSoKhachHang = '" + this.MaTK + "'";
            tb_DanhSachDonHang = Functions.GetDataTable(query);
            dataGridView1.DataSource = tb_DanhSachDonHang;

            dataGridView1.Font = new Font("Time New Roman", 13);
            dataGridView1.Columns[0].HeaderText = "Mã đơn hàng";
            dataGridView1.Columns[1].HeaderText = "Ngày Đặt Hàng";
            dataGridView1.Columns[2].HeaderText = "Địa chỉ giao hàng";
            dataGridView1.Columns[3].HeaderText = "Hình Thức Thanh Toán";
            dataGridView1.Columns[4].HeaderText = "Phí Sản Phẩm";
            dataGridView1.Columns[5].HeaderText = "Phí Vận Chuyển";
            dataGridView1.Columns[6].HeaderText = "Tình Trạng";
            dataGridView1.Columns[7].HeaderText = "Số Lượng Món";

            dataGridView1.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            dataGridView1.Columns[0].Width = 220;
            dataGridView1.Columns[1].Width = 220;
            dataGridView1.Columns[2].Width = 220;
            dataGridView1.Columns[3].Width = 220;
            dataGridView1.Columns[4].Width = 220;
            dataGridView1.Columns[5].Width = 220;
            dataGridView1.Columns[6].Width = 220;
            dataGridView1.Columns[7].Width = 220;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void run_DanhSachDonHang(object sender, EventArgs e)
        {
            loadData_DanhSachDonHang();

        }

        private void convertDataFromGridToTextBox_Click(object sender, EventArgs e)
        {
            if (tb_DanhSachDonHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            txtBox_maDonHang_DSDH.Text = dataGridView1.CurrentRow.Cells["MaSoDonHang"].Value.ToString();
            txtBox_PVC_DSDH.Text = dataGridView1.CurrentRow.Cells["PhiVanChuyen"].Value.ToString();
            txtBox_Sl_DSDH.Text = dataGridView1.CurrentRow.Cells["SoLuongMon"].Value.ToString();
            txtBox_TongPhi_DSDH.Text = dataGridView1.CurrentRow.Cells["PhiSanPham"].Value.ToString();
            txtBox_DCGH_DSDH.Text = dataGridView1.CurrentRow.Cells["DiaChiGiaoHang"].Value.ToString();
            txtBox_HTTT__DSDH.Text = dataGridView1.CurrentRow.Cells["HinhThucThanhToan"].Value.ToString();
            dtp_NgayMua_DSDH.Text = dataGridView1.CurrentRow.Cells["NgayDatHang"].Value.ToString();
            string tinhTrangGiaoHang = "";
            if (dataGridView1.CurrentRow.Cells["TrangThaiDonHang"].Value.ToString() == "0")
            {
                tinhTrangGiaoHang = "Chưa nhận";
            }
            if (dataGridView1.CurrentRow.Cells["TrangThaiDonHang"].Value.ToString() == "1")
            {
                tinhTrangGiaoHang = "Đã nhận";
            }
            if (dataGridView1.CurrentRow.Cells["TrangThaiDonHang"].Value.ToString() == "2")
            {
                tinhTrangGiaoHang = "Đang giao";
            }

            if (dataGridView1.CurrentRow.Cells["TrangThaiDonHang"].Value.ToString() == "3")
            {
                tinhTrangGiaoHang = "Đã giao";
            }
            if (dataGridView1.CurrentRow.Cells["TrangThaiDonHang"].Value.ToString() == "4")
            {
                tinhTrangGiaoHang = "Giao chưa thành công";
            }
            txtBox_TTGH_DSDH.Text = tinhTrangGiaoHang;





        }
    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
