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
    public partial class DanhSachDonHang : Form
    {
        DataTable tb_DSDH;
        public DanhSachDonHang()
        {
            InitializeComponent();
        }
        private void LoadDataDSDH()//dữ liệu vào DataGridView
        {
            string sql = "SELECT MaSoDonHang, HoTenKhachHang, KHACHHANG.SoDienThoaiKH, NgayDatHang, PhiVanChuyen, " +
                "DiaChiGiaoHang, PhiSanPham, HinhThucThanhToan " +
                "FROM DONHANG ,KHACHHANG  WHERE TrangThaiDonHang =0  and DONHANG.MaSoKhachHang = KHACHHANG.MaSoKhachHang";


            tb_DSDH = Functions.GetDataTable(sql);
            dataGridView_DSDH.DataSource = tb_DSDH;



            // set Font cho tên cột
            dataGridView_DSDH.Font = new Font("Time New Roman", 13);
            dataGridView_DSDH.Columns[0].HeaderText = "Mã đơn hàng";
            dataGridView_DSDH.Columns[1].HeaderText = "Khách hàng";
            dataGridView_DSDH.Columns[2].HeaderText = "Số điện thoại";
            dataGridView_DSDH.Columns[3].HeaderText = "Ngày đặt";
            dataGridView_DSDH.Columns[4].HeaderText = "Phí vận chuyển";
       
            dataGridView_DSDH.Columns[5].HeaderText = "Địa chỉ giao hàng";
            dataGridView_DSDH.Columns[6].HeaderText = "Tổng phí SP";
     
            dataGridView_DSDH.Columns[7].HeaderText = "Hình thức thanh toán";
            // set Font cho dữ liệu hiển thị trong cột
            dataGridView_DSDH.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dataGridView_DSDH.Columns[0].Width = 140;
            dataGridView_DSDH.Columns[1].Width = 140;
            dataGridView_DSDH.Columns[2].Width = 140;
            dataGridView_DSDH.Columns[3].Width = 140;
            dataGridView_DSDH.Columns[4].Width = 180;
            dataGridView_DSDH.Columns[5].Width = 120;
            dataGridView_DSDH.Columns[6].Width = 200;
            dataGridView_DSDH.Columns[7].Width = 170;
 
           
            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_DSDH.AllowUserToAddRows = false;
            dataGridView_DSDH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DS_DonHang_TX_Load(object sender, System.EventArgs e)
        {
            LoadDataDSDH();
        }

        private void dGV_TaiXe_DSDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nếu không có dữ liệu
            if (tb_DSDH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // set giá trị cho các mục            
            txtBox_MDH_DSDH.Text = dataGridView_DSDH.CurrentRow.Cells["MaSoDonHang"].Value.ToString();
            txtBox_TKH_DSDH.Text = dataGridView_DSDH.CurrentRow.Cells["HoTenKhachHang"].Value.ToString();
            txtBox_SDT_DSDH.Text = dataGridView_DSDH.CurrentRow.Cells["SoDienThoaiKH"].Value.ToString();
            txtbox_ND_DSDH.Text = dataGridView_DSDH.CurrentRow.Cells["NgayDatHang"].Value.ToString();
           ;
            txtBox_PVC_DSDH.Text = dataGridView_DSDH.CurrentRow.Cells["PhiVanChuyen"].Value.ToString();
            txtBox_DCGH_DSDH.Text = dataGridView_DSDH.CurrentRow.Cells["DiaChiGiaoHang"].Value.ToString();
            txtBox_TPSP_DSDH.Text = dataGridView_DSDH.CurrentRow.Cells["PhiSanPham"].Value.ToString();
      
            string temp = dataGridView_DSDH.CurrentRow.Cells["HinhThucThanhToan"].Value.ToString();



            switch (temp)
            {
                case "0":
                    txtBox_HTTT_DSDH.Text = "Tiền mặt";
                    break;
                case "1":
                    txtBox_HTTT_DSDH.Text = "Ví điện tử";
                    break;
                case "2":
                    txtBox_HTTT_DSDH.Text = "Ngân hàng";
                    break;
                default:
                    break;
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
