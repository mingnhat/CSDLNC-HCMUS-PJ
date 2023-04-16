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
    public partial class DanhSachLoaiHang : Form
    {
        DataTable tb_DanhSachLoaiHang;
        private string tenDangNhap;
        string MaSoDoiTac;
        public DanhSachLoaiHang(string tenDangNhap)
        {
            this.tenDangNhap = tenDangNhap;
            InitializeComponent();
        }

        

        private void btn_DanhSachSp_Click(object sender, EventArgs e)
        {
            DanhSachSanPham ds_sanpham = new DanhSachSanPham(tenDangNhap,MaSoDoiTac);
            ds_sanpham.Show();
        }
        private void loadDataDanhSachLoaiHang()
        {
           
            
            string sql = "select TenDoiTac, DiaChiKinhDoanh, LoaiAmThuc, MaSoDoiTac from DOITAC ";
         
            tb_DanhSachLoaiHang = Functions.GetDataTable(sql);
            dataGridView_LoaiHang.DataSource = tb_DanhSachLoaiHang;


            dataGridView_LoaiHang.Font = new Font("Time New Roman", 13);
            dataGridView_LoaiHang.Columns[0].HeaderText = "Tên Đối Tác";
            dataGridView_LoaiHang.Columns[1].HeaderText = "Địa chỉ đối tác";
            dataGridView_LoaiHang.Columns[2].HeaderText = "Loại hàng cung cấp";


            dataGridView_LoaiHang.DefaultCellStyle.Font = new Font("Time New Roman", 12);


           dataGridView_LoaiHang.Columns[0].Width = 220;
            dataGridView_LoaiHang.Columns[1].Width = 220;
            dataGridView_LoaiHang.Columns[2].Width = 220;
           


            dataGridView_LoaiHang.AllowUserToAddRows = false;
            dataGridView_LoaiHang.EditMode = DataGridViewEditMode.EditProgrammatically;


            

        }

        private void loadDanhSachLoaiHang(object sender, EventArgs e)
        {
            loadDataDanhSachLoaiHang();
        }


        private void PushData_DSLH_Click(object sender, EventArgs e)
        {
            if (tb_DanhSachLoaiHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                txtBox_TDT_DSLH.Text = dataGridView_LoaiHang.CurrentRow.Cells["TenDoiTac"].Value.ToString();
                txtBox_DC_DSLH.Text = dataGridView_LoaiHang.CurrentRow.Cells["DiaChiKinhDoanh"].Value.ToString();
                txtBox_LH_DSLH.Text = dataGridView_LoaiHang.CurrentRow.Cells["LoaiAmThuc"].Value.ToString();
                MaSoDoiTac = dataGridView_LoaiHang.CurrentRow.Cells["MaSoDoiTac"].Value.ToString();
            }    
        }
    }



   





}
