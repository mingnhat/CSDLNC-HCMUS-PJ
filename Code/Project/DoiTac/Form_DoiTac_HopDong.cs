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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DoAnCuoiKi
{
    public partial class Form_DoiTac_HopDong : Form
    {
        string MaSoDoiTac;
        DataTable table_DoiTac_HopDong = new DataTable();

        public Form_DoiTac_HopDong(string maSoDoiTac)
        {
            InitializeComponent();
            MaSoDoiTac = maSoDoiTac;
        }

        private void resetData_HopDong()
        {
            txtBox_MaDT.Text = " ";
            txtBox_MaHD.Text = " ";
            txtBox_MaThue.Text = " ";
            txtBox_NguoiDaiDien.Text = " ";
            txtBox_HieuLuc.Text= " ";
            dTP_NgayKetThuc.CustomFormat = " ";
            dTP_NgayLap.CustomFormat= " ";
        }

        private void loadData_HopDong()
        {
            string query = "SELECT HD.MaSoHopDong, HD.MaSoDoiTac, HD.MaSoThueDoiTac, HD.NguoiDaiDien, HD.NgayLapHopDong, HD.NgayKetThuc, " +
            "DATEDIFF(DAY, HD.NgayLapHopDong, HD.NgayKetThuc) AS ThoiGianHieuLuc FROM HOPDONG HD " +
            "WHERE HD.MaSoDoiTac = '" + MaSoDoiTac + "'";

            table_DoiTac_HopDong = Functions.GetDataTable(query);
            dGV_DoiTac_HopDong.DataSource = table_DoiTac_HopDong;

            dGV_DoiTac_HopDong.Font = new Font("Segoe UI", 11);
            dGV_DoiTac_HopDong.Columns[0].HeaderText = "Mã số hợp đồng";
            dGV_DoiTac_HopDong.Columns[1].HeaderText = "Mã số đối tác";
            dGV_DoiTac_HopDong.Columns[2].HeaderText = "Mã số thuế đối tác";
            dGV_DoiTac_HopDong.Columns[3].HeaderText = "Người đại diện";
            dGV_DoiTac_HopDong.Columns[4].HeaderText = "Ngày lập hợp đồng";
            dGV_DoiTac_HopDong.Columns[5].HeaderText = "Ngày kết thúc hợp đồng";
            dGV_DoiTac_HopDong.Columns[6].HeaderText = "Thời gian hiệu lực";

            dGV_DoiTac_HopDong.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dGV_DoiTac_HopDong.Columns[0].Width = 150;
            dGV_DoiTac_HopDong.Columns[1].Width = 150;
            dGV_DoiTac_HopDong.Columns[2].Width = 150;
            dGV_DoiTac_HopDong.Columns[3].Width = 150;
            dGV_DoiTac_HopDong.Columns[5].Width = 150;
            dGV_DoiTac_HopDong.Columns[6].Width = 150;

            dGV_DoiTac_HopDong.AllowUserToAddRows = false;
            dGV_DoiTac_HopDong.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private string TinhTrangHopDong(string str)
        {
            string result = "Chưa được duyệt";
            if (str.Equals("1")) 
                result = "Đã được duyệt";
            else if (str.Equals("2")) 
                result = "Đã bị hủy";
            else if (str.Equals("3"))
            {
                MessageBox.Show("Hợp đồng của bạn sắp hết hạn !");
                result = "Chờ gia hạn";
            }
            return result;
        }

        private void run_HopDong(object sender, EventArgs e)
        {
            resetData_HopDong();
            loadData_HopDong();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void dGV_DoiTac_HopDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dTP_NgayLap.CustomFormat = "yyyy--MM--dd";
            dTP_NgayKetThuc.CustomFormat = "yyyy--MM--dd";
            int i = 0;
            i = dGV_DoiTac_HopDong.CurrentRow.Index;

            txtBox_MaHD.Text = dGV_DoiTac_HopDong.Rows[i].Cells["MaSoHopDong"].Value.ToString();
            txtBox_MaDT.Text = dGV_DoiTac_HopDong.Rows[i].Cells["MaSoDoiTac"].Value.ToString();
            txtBox_MaThue.Text = dGV_DoiTac_HopDong.Rows[i].Cells["MaSoThueDoiTac"].Value.ToString();
            txtBox_NguoiDaiDien.Text = dGV_DoiTac_HopDong.Rows[i].Cells["NguoiDaiDien"].Value.ToString();
            dTP_NgayLap.Text = dGV_DoiTac_HopDong.Rows[i].Cells["NgayLapHopDong"].Value.ToString();
            dTP_NgayKetThuc.Text = dGV_DoiTac_HopDong.Rows[i].Cells["NgayKetThuc"].Value.ToString();
            txtBox_HieuLuc.Text = dGV_DoiTac_HopDong.Rows[i].Cells["ThoiGianHieuLuc"].Value.ToString();
        }
    }
}
