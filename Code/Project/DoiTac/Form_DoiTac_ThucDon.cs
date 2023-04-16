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
    public partial class Form_DoiTac_ThucDon : Form
    {
        DataTable table_DoiTac_ThucDon = new DataTable();

        string MaSoMonAn = string.Empty;
        string MaSoDoiTac = string.Empty;

        public Form_DoiTac_ThucDon(string masodt)
        {
            MaSoDoiTac = masodt;
            InitializeComponent();
        }

        private void resetData_ThucDon()
        {
            txtBox_Gia.Text = " ";
            txtBox_MieuTaMonAn.Text = "";
            txtBox_TenMon.Text= " ";
            txtBox_TinhTrangMonAn.Text= " ";
        }

        private void loadData_ThucDon()
        {
            string query = "select td.TenMon, td.MieuTaMonAn, td.Gia, td.TinhTrangMonAn " +
                "from THUCDON td where td.MaSoDoiTac = '" + MaSoDoiTac + "'";

            table_DoiTac_ThucDon = Functions.GetDataTable(query);
            dGV_DoiTac_ThucDon.DataSource = table_DoiTac_ThucDon;

            dGV_DoiTac_ThucDon.Font = new Font("Segoe UI", 11);
            dGV_DoiTac_ThucDon.Columns[0].HeaderText = "Tên món ăn";
            dGV_DoiTac_ThucDon.Columns[1].HeaderText = "Miêu tả món ăn";
            dGV_DoiTac_ThucDon.Columns[2].HeaderText = "Giá";
            dGV_DoiTac_ThucDon.Columns[3].HeaderText = "Tình trạng món ăn";

            dGV_DoiTac_ThucDon.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dGV_DoiTac_ThucDon.Columns[0].Width = 150;
            dGV_DoiTac_ThucDon.Columns[1].Width = 150;
            dGV_DoiTac_ThucDon.Columns[2].Width = 150;
            dGV_DoiTac_ThucDon.Columns[3].Width = 150;

            dGV_DoiTac_ThucDon.AllowUserToAddRows = false;
            dGV_DoiTac_ThucDon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void run_ThucDon(object sender, EventArgs e)
        {
            resetData_ThucDon();
            loadData_ThucDon();
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dGV_DoiTac_ThucDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // hiện thông tin lên text box
            int i = 0;
            i = dGV_DoiTac_ThucDon.CurrentRow.Index;

            txtBox_TenMon.Text = dGV_DoiTac_ThucDon.Rows[i].Cells[0].Value.ToString();
            txtBox_MieuTaMonAn.Text = dGV_DoiTac_ThucDon.Rows[i].Cells[1].Value.ToString();
            txtBox_Gia.Text = dGV_DoiTac_ThucDon.Rows[i].Cells[2].Value.ToString();
            txtBox_TinhTrangMonAn.Text = dGV_DoiTac_ThucDon.Rows[i].Cells[3].Value.ToString();
        }
    }
}
