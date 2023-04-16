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
    public partial class Form_Admin_DSTK : Form
    {

        private DataTable table_dstk = new DataTable();

        public Form_Admin_DSTK()
        {
            InitializeComponent();
        }
        private void resetData_ThucDon()
        {
            txtBox_MaTK.Text = " ";
            txtBox_LoaiTK.Text = " ";
            txtBox_TenDangNhap.Text = " ";
        }

        private string edit_LoaiTK(string MaTK)
        {
            string str = string.Empty;
            switch (MaTK)
            {
                case "0":
                    {
                        str = "Admin";
                        break;
                    }
                case "1":
                    {
                        str = "Đối tác";
                        break;
                    }
                case "2":
                    {
                        str = "Khách hàng";
                        break;
                    }
                case "3":
                    {
                        str = "Tài xế";
                        break;
                    }
                case "4":
                    {
                        str = "Nhân viên";
                        break;
                    }
            }
            return str;
        }

        private void loadData_DSTK()
        {
            string query = "select MaTK, TenDangNhap, LoaiTK from TAIKHOAN";
            table_dstk = Functions.GetDataTable(query);
            dGV_DSTK.DataSource= table_dstk;

            dGV_DSTK.Font = new Font("Segoe UI", 11);
            dGV_DSTK.Columns[0].HeaderText = "Mã tài khoản";
            dGV_DSTK.Columns[1].HeaderText = "Tên đăng nhập";
            dGV_DSTK.Columns[2].HeaderText = "Loại tài khoản";

            dGV_DSTK.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dGV_DSTK.Columns[0].Width = 200;
            dGV_DSTK.Columns[1].Width = 200;
            dGV_DSTK.Columns[2].Width = 200;

            dGV_DSTK.AllowUserToAddRows = false;
            dGV_DSTK.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void run_DSTK(object sender, EventArgs e)
        {
            resetData_ThucDon();
            loadData_DSTK();
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
            i = dGV_DSTK.CurrentRow.Index;

            txtBox_MaTK.Text = dGV_DSTK.Rows[i].Cells["MaTK"].Value.ToString();
            txtBox_TenDangNhap.Text = dGV_DSTK.Rows[i].Cells["TenDangNhap"].Value.ToString();
            txtBox_LoaiTK.Text = edit_LoaiTK(dGV_DSTK.Rows[i].Cells["LoaiTK"].Value.ToString());
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Form_Admin_DangKy form = new Form_Admin_DangKy();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}
