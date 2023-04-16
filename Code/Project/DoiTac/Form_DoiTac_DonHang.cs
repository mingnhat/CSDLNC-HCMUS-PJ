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
    public partial class Form_DoiTac_DonHang : Form
    {
        DataTable table_DoiTac_DonHang = new DataTable();

        public Form_DoiTac_DonHang()
        {
            InitializeComponent();
        }

        private void loadData_DonHang()
        {

            dGV_DoiTac_DonHang.AutoSize = false;
            dGV_DoiTac_DonHang.ScrollBars = ScrollBars.Both;

            string query = "select dh.MaSoDonHang, dh.NgayDatHang, dh.DiaChiGiaoHang, dh.SoDienThoaiKH, tx.HoTenTaiXe, tx.SoDienThoaiTX, tx.BienSoXe, dh.TrangThaiDonHang " +
            "from DONHANG dh, TAIXE tx, XULY_DONHANG xldh " +
            "where dh.MaSoDonHang = xldh.MaSoDonHang and xldh.MaSoTaiXe = tx.MaSoTaiXe";

            table_DoiTac_DonHang = Functions.GetDataTable(query);
            dGV_DoiTac_DonHang.DataSource = table_DoiTac_DonHang;

            dGV_DoiTac_DonHang.Font = new Font("Segoe UI", 11);
            dGV_DoiTac_DonHang.Columns[0].HeaderText = "Mã số đơn hàng";
            dGV_DoiTac_DonHang.Columns[1].HeaderText = "Ngày đặt hàng";
            dGV_DoiTac_DonHang.Columns[2].HeaderText = "Địa chỉ giao hàng";
            dGV_DoiTac_DonHang.Columns[3].HeaderText = "Số điện thoại khách hàng";
            dGV_DoiTac_DonHang.Columns[4].HeaderText = "Họ tên tài xế";
            dGV_DoiTac_DonHang.Columns[5].HeaderText = "Số điện thoại tài xế";
            dGV_DoiTac_DonHang.Columns[6].HeaderText = "Biển số xe";
            dGV_DoiTac_DonHang.Columns[7].HeaderText = "Trạng thái đơn hàng";


            dGV_DoiTac_DonHang.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dGV_DoiTac_DonHang.Columns[0].Width = 150;
            dGV_DoiTac_DonHang.Columns[1].Width = 150;
            dGV_DoiTac_DonHang.Columns[2].Width = 150;
            dGV_DoiTac_DonHang.Columns[3].Width = 150;
            dGV_DoiTac_DonHang.Columns[4].Width = 150;
            dGV_DoiTac_DonHang.Columns[5].Width = 150;
            dGV_DoiTac_DonHang.Columns[6].Width = 150;
            dGV_DoiTac_DonHang.Columns[7].Width = 150;

            dGV_DoiTac_DonHang.AllowUserToAddRows = false;
            dGV_DoiTac_DonHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void run_DoiTac_DonHang(object sender, EventArgs e)
        {
            loadData_DonHang();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dGV_DoiTac_DonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            i = dGV_DoiTac_DonHang.CurrentRow.Index;

            txtBox_MaDonHang.Text = dGV_DoiTac_DonHang.Rows[i].Cells["MaSoDonHang"].Value.ToString();
            txtBox_NgayDatHang.Text = dGV_DoiTac_DonHang.Rows[i].Cells["NgayDatHang"].Value.ToString();
            txtBox_DiaChiGiaoHang.Text = dGV_DoiTac_DonHang.Rows[i].Cells["DiaChiGiaoHang"].Value.ToString();
            txtBox_sdtkh.Text = dGV_DoiTac_DonHang.Rows[i].Cells["SoDienThoaiKH"].Value.ToString();
            txtBox_TenTaiXe.Text = dGV_DoiTac_DonHang.Rows[i].Cells["HoTenTaiXe"].Value.ToString();
            txtBox_sdttx.Text = dGV_DoiTac_DonHang.Rows[i].Cells["SoDienThoaiTX"].Value.ToString();
            txtBox_BienSo.Text = dGV_DoiTac_DonHang.Rows[i].Cells["BienSoXe"].Value.ToString();
            txtBox_TrangThaiDonHang.Text = dGV_DoiTac_DonHang.Rows[i].Cells["TrangThaiDonHang"].Value.ToString();
        }
    }
}
