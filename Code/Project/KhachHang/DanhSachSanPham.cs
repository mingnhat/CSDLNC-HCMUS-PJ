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
    public partial class DanhSachSanPham : Form
    {
        DataTable tb_DanhSachSanPham;
        private string MaTK;
        private string MaSoDoiTac;
        string soLuongMua;
        string maSoMonAn;
        string tenMon;
        string giaBan;
        public DanhSachSanPham(string MaTk, string MaSoDoiTac)
        {
            this.MaTK = MaTk;
            this.MaSoDoiTac = MaSoDoiTac;
            InitializeComponent();
        }


        private void btn_XnDatHang_click(Object sender, EventArgs e)
        {
            if(txtBox_SLM_DSSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập số lượng mua!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            soLuongMua = txtBox_SLM_DSSP.Text.Trim();
            if (Int32.Parse(txtBox_SLM_DSSP.Text) >Int32.Parse(txtBox_SLC_DSSP.Text.Trim().ToString()))
            {
                MessageBox.Show("Số lượng sản phẩm không đủ! Vui lòng nhập lại số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DatHang dathang_kh = new DatHang(MaTK, MaSoDoiTac, maSoMonAn, tenMon, giaBan, soLuongMua);
            dathang_kh.Show();
        }

        private void loadDataDanhSachSanPham()
        {
            string sql = "select TenMon, MieuTaMonAn, SoLuong, Gia, MaSoMonAn from THUCDON where MaSoDoiTac ='" + MaSoDoiTac + "'";
            tb_DanhSachSanPham = Functions.GetDataTable(sql);
            dataGridView_TD.DataSource = tb_DanhSachSanPham;


            dataGridView_TD.Font = new Font("Time New Roman", 13);
            dataGridView_TD.Columns[0].HeaderText = "Tên Món";
            dataGridView_TD.Columns[1].HeaderText = "Miêu Tả Món Ăn";
            dataGridView_TD.Columns[2].HeaderText = "Số Lượng";
            dataGridView_TD.Columns[3].HeaderText = "Giá bán";

            dataGridView_TD.DefaultCellStyle.Font = new Font("Time New Roman", 12);


            dataGridView_TD.Columns[0].Width = 220;
            dataGridView_TD.Columns[1].Width = 220;
            dataGridView_TD.Columns[2].Width = 220;
            dataGridView_TD.Columns[3].Width = 220;
            dataGridView_TD.Columns[4].Width = 0;

            dataGridView_TD.AllowUserToAddRows = false;
            dataGridView_TD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        private void loadDanhSachSanPham(object sender, EventArgs e)
        {
            loadDataDanhSachSanPham();

        }

        private void pushData_DSSP(object sender, EventArgs e)
        {
            if (tb_DanhSachSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            // set giá trị cho các mục 
            txtBox_TenMon_DSSP.Text = dataGridView_TD.CurrentRow.Cells["TenMon"].Value.ToString();
            txtBox_MieuTa_DSSP.Text = dataGridView_TD.CurrentRow.Cells["MieuTaMonAn"].Value.ToString();
            txtBox_SLC_DSSP.Text = dataGridView_TD.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtBox_Gia_DSSP.Text = dataGridView_TD.CurrentRow.Cells["Gia"].Value.ToString();
            maSoMonAn = dataGridView_TD.CurrentRow.Cells["MaSoMonAn"].Value.ToString();
            tenMon = dataGridView_TD.CurrentRow.Cells["TenMon"].Value.ToString();
            giaBan = dataGridView_TD.CurrentRow.Cells["Gia"].Value.ToString();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
