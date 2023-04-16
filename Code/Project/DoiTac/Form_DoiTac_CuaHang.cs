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
    public partial class Form_DoiTac_CuaHang : Form
    {

        private DataTable table_CuaHang = new DataTable();

        string MaSoDoiTac = string.Empty;

        public Form_DoiTac_CuaHang(string masodoitac)
        {
            MaSoDoiTac = masodoitac;
            InitializeComponent();
        }
        private void resetData_ThucDon()
        {
            txtBox_TenQuan.Text = " ";
            txtBox_tgMo.Text = " ";
            txtBox_tgDong.Text = " ";
            txtBox_TinhTrang.Text = " ";
        }

        private void loadData_ThucDon()
        {
            string query = "select ch.MaSoCuaHang, ch.ThoiGianMoCua, ch.ThoiGianDongCua, ch.TinhTrangCuaHang " +
                "from CUAHANG ch where ch.MaSoDoiTac = '" + MaSoDoiTac + "'";

            table_CuaHang = Functions.GetDataTable(query);
            dGV_CuaHang.DataSource= table_CuaHang;

            dGV_CuaHang.Font = new Font("Segoe UI", 11);
            dGV_CuaHang.Columns[0].HeaderText = "Tên cửa hàng";
            dGV_CuaHang.Columns[1].HeaderText = "Thời gian mở cửa";
            dGV_CuaHang.Columns[2].HeaderText = "Thời gian đóng cửa";
            dGV_CuaHang.Columns[3].HeaderText = "Tình trạng cửa hàng";

            dGV_CuaHang.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dGV_CuaHang.Columns[0].Width = 150;
            dGV_CuaHang.Columns[1].Width = 150;
            dGV_CuaHang.Columns[2].Width = 150;
            dGV_CuaHang.Columns[3].Width = 150;

            dGV_CuaHang.AllowUserToAddRows = false;
            dGV_CuaHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void run_ThucDon(object sender, EventArgs e)
        {
            resetData_ThucDon();
            loadData_ThucDon();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dGV_CuaHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            i = dGV_CuaHang.CurrentRow.Index;

            txtBox_TenQuan.Text = dGV_CuaHang.Rows[i].Cells["MaSoCuaHang"].Value.ToString();
            txtBox_tgMo.Text = dGV_CuaHang.Rows[i].Cells["ThoiGianMoCua"].Value.ToString();
            txtBox_tgDong.Text = dGV_CuaHang.Rows[i].Cells["ThoiGianDongCua"].Value.ToString();
            txtBox_TinhTrang.Text = dGV_CuaHang.Rows[i].Cells["TinhTrangCuaHang"].Value.ToString();
        }
    }
}
