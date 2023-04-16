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
    public partial class ChiTietDonHang : Form
    {
        private DataTable table_ChiTietDonHang = new DataTable();
        public ChiTietDonHang()
        {
            InitializeComponent();
        }

        private void resetData_ChiTietDonHang()
        {
            txtBox_TaiXe_MaDonHang.Text = " ";
            txtBox_TaiXe_SoLuong.Text = " ";
            txtBox_TaiXe_TenSanPham.Text = " ";
            txtBox_TaiXe_ThanhTien.Text = " ";
        }

        private void loadData_ChiTietDonHang()
        {
            string query = "select dh.MaSoDonHang, td.TenMon, ctdh.SoLuongMon, ctdh.TongTien " +
            "from TAIXE tx, DONHANG dh, XULY_DONHANG xldh, CT_DONHANG ctdh, THUCDON td " +
            "where dh.MaSoDonHang = ctdh.MaSoDonHang and ctdh.MaSoMonAn = td.MaSoMonAn " +
            "and tx.MaSoTaiXe = xldh.MaSoTaiXe and dh.MaSoTaiXe = xldh.MaSoTaiXe";

            table_ChiTietDonHang = Functions.GetDataTable(query);
            dGV_TaiXe_ChiTietDH.DataSource = table_ChiTietDonHang;

            // set font
            dGV_TaiXe_ChiTietDH.Font = new Font("Segoe UI", 11);
            dGV_TaiXe_ChiTietDH.Columns[0].HeaderText = "Mã số đơn hàng";
            dGV_TaiXe_ChiTietDH.Columns[1].HeaderText = "Tên món";
            dGV_TaiXe_ChiTietDH.Columns[2].HeaderText = "Số lượng món";
            dGV_TaiXe_ChiTietDH.Columns[3].HeaderText = "Tổng tiền";

            // set font cell
            dGV_TaiXe_ChiTietDH.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // set col size
            dGV_TaiXe_ChiTietDH.Columns[0].Width = 150;
            dGV_TaiXe_ChiTietDH.Columns[1].Width = 150;
            dGV_TaiXe_ChiTietDH.Columns[2].Width = 150;
            dGV_TaiXe_ChiTietDH.Columns[3].Width = 150;

            // chặn ng dùng thêm dữ liệu
            dGV_TaiXe_ChiTietDH.AllowUserToAddRows = false;
            dGV_TaiXe_ChiTietDH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void run_ChiTietDonHang(object sender, EventArgs e)
        {
            resetData_ChiTietDonHang();
            loadData_ChiTietDonHang();
        }
    }
}
