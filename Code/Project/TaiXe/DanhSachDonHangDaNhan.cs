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
    public partial class DanhSachDonHangDaNhan : Form
    {
        DataTable tb_DHDN;
        public DanhSachDonHangDaNhan()
        {
            InitializeComponent();
        }

        private void LoadDataDHDN()
        {
            string sql = "SELECT DONHANG.MaSoDonHang, KHACHHANG.HoTenKhachHang,KHACHHANG.SoDienThoaiKH, DONHANG.PhiVanChuyen,DONHANG.HinhThucThanhToan,DONHANG.DiaChiGiaoHang,DONHANG.TrangThaiDonHang, DONHANG.PhiSanPham,CT_DONHANG.SoLuongMon,CT_DONHANG.TongTien FROM DONHANG ,KHACHHANG,CT_DONHANG  WHERE DONHANG.TrangThaiDonHang = 1 and DONHANG.MaSoKhachHang = KHACHHANG.MaSoKhachHang and DONHANG.MaSoDonHang = CT_DONHANG.MaSoDonHang";
                 

            tb_DHDN = Functions.GetDataTable(sql);
            dataGridView_DHDN.DataSource = tb_DHDN;

            // set Font cho tên cột
            dataGridView_DHDN.Font = new Font("Time New Roman", 13);
            dataGridView_DHDN.Columns[0].HeaderText = "Mã đơn hàng";
            dataGridView_DHDN.Columns[1].HeaderText = "Tên Khách hàng";
            dataGridView_DHDN.Columns[2].HeaderText = "Số điện thoại";
            dataGridView_DHDN.Columns[3].HeaderText = "Tình Trạng";
            dataGridView_DHDN.Columns[4].HeaderText = "Phí vận chuyển";
            dataGridView_DHDN.Columns[5].HeaderText = "Số lượng sản phẩm";
            dataGridView_DHDN.Columns[6].HeaderText = "Địa chỉ Giao Hàng";
            dataGridView_DHDN.Columns[7].HeaderText = "Tổng phí";
            // set Font cho dữ liệu hiển thị trong cột
            dataGridView_DHDN.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dataGridView_DHDN.Columns[0].Width = 140;
            dataGridView_DHDN.Columns[1].Width = 140;
            dataGridView_DHDN.Columns[2].Width = 140;
            dataGridView_DHDN.Columns[3].Width = 140;
            dataGridView_DHDN.Columns[4].Width = 160;
            dataGridView_DHDN.Columns[5].Width = 120;
            dataGridView_DHDN.Columns[6].Width = 100;
            dataGridView_DHDN.Columns[7].Width = 110;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_DHDN.AllowUserToAddRows = false;
            dataGridView_DHDN.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadDonHangDaNhan(object sender, EventArgs e)
        {
            LoadDataDHDN();
        }


        private void dGV_TaiXe_DSDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nếu không có dữ liệu
            if (tb_DHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // set giá trị cho các mục            
            /*.Text = dataGridView_DHDN.CurrentRow.Cells["MaSoDonHang"].Value.ToString();
            txtBox_TKH_DSDH.Text = dataGridView_DHDN.CurrentRow.Cells["HoTenKhachHang"].Value.ToString();
            txtBox_SDT_DSDH.Text = dataGridView_DHDN.CurrentRow.Cells["SoDienThoaiKH"].Value.ToString();
            txtbox_ND_DSDH.Text = dataGridView_DHDN.CurrentRow.Cells["NgayDatHang"].Value.ToString();
            ;
            txtBox_PVC_DSDH.Text = dataGridView_DHDN.CurrentRow.Cells["PhiVanChuyen"].Value.ToString();
            txtBox_DCGH_DSDH.Text = dataGridView_DHDN.CurrentRow.Cells["DiaChiGiaoHang"].Value.ToString();
            txtBox_TPSP_DSDH.Text = dataGridView_DHDN.CurrentRow.Cells["PhiSanPham"].Value.ToString();

            string temp = dataGridView_DSDH.CurrentRow.Cells["HinhThucThanhToan"].Value.ToString()*/;
        }

        }
    }
