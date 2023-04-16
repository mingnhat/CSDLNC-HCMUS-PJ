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
    public partial class HopDongDaDuyet : Form
    {
        DataTable tb_HDDD;
        public HopDongDaDuyet()
        {
            InitializeComponent();
        }


        private void loadDataHDDD()
        {
            string sql = "select HOPDONG.MaSoHopDong, HOPDONG.MaSoDoiTac, DOITAC.TenDoiTac, HOPDONG.SoChiNhanhDangKi,HOPDONG.MaSoThueDoiTac,HOPDONG.NgayLapHopDong,HOPDONG.ThoiGianHieuLuc,HOPDONG.PhiHoaHong from HOPDONG, DOITAC where HOPDONG.DaDuyet = 1 and HOPDONG.MaSoDoiTac = DOITAC.MaSoDoiTac";
            tb_HDDD = Functions.GetDataTable(sql);
            dataGridView_HDDD.DataSource = tb_HDDD;

            // set Font cho tên cột
            dataGridView_HDDD.Font = new Font("Time New Roman", 13);
            dataGridView_HDDD.Columns[0].HeaderText = "Mã hợp đồng";
            dataGridView_HDDD.Columns[1].HeaderText = "Mã đối tác";
            dataGridView_HDDD.Columns[2].HeaderText = "Số lượng chi nhánh";
            dataGridView_HDDD.Columns[3].HeaderText = "Mã Số Thuế";
            dataGridView_HDDD.Columns[4].HeaderText = "Ngày lập";
            dataGridView_HDDD.Columns[5].HeaderText = "Thời Hạn Hợp Đồng";
            dataGridView_HDDD.Columns[6].HeaderText = "Phí Hoa Hồng";
            // set Font cho dữ liệu hiển thị trong cột
            dataGridView_HDDD.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dataGridView_HDDD.Columns[0].Width = 150;
            dataGridView_HDDD.Columns[1].Width = 150;
            dataGridView_HDDD.Columns[2].Width = 200;
            dataGridView_HDDD.Columns[3].Width = 200;
            dataGridView_HDDD.Columns[4].Width = 150;
            dataGridView_HDDD.Columns[5].Width = 150;
            dataGridView_HDDD.Columns[6].Width = 150;
 
            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_HDDD.AllowUserToAddRows = false;
            dataGridView_HDDD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        private void LoadHDDD(object sender, EventArgs e)

        {

            loadDataHDDD();

        }

        private void pushData_HDDDClick(object sender, EventArgs e) // xử lí khi click vào datagridview
        {
            //Nếu không có dữ liệu
            if (tb_HDDD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // set giá trị cho các mục 
            dtp_NL_HDDD.CustomFormat = "yyyy-MM-dd";
           

            txtBox_MSHD_HDDD.Text = dataGridView_HDDD.CurrentRow.Cells["MaSoHopDong"].Value.ToString();
            txtBox_SLCN_HDDD.Text = dataGridView_HDDD.CurrentRow.Cells["SoChiNhanhDangKi"].Value.ToString();
            txtbox_MSDT_HDDD.Text = dataGridView_HDDD.CurrentRow.Cells["MaSoDoiTac"].Value.ToString();
            txtBox_TDT_HDDD.Text = dataGridView_HDDD.CurrentRow.Cells["TenDoiTac"].Value.ToString();
            txtBox_MST_HDDD.Text = dataGridView_HDDD.CurrentRow.Cells["MaSoThueDoiTac"].Value.ToString();
            txtBox_PHH_HDDD.Text = dataGridView_HDDD.CurrentRow.Cells["PhiHoaHong"].Value.ToString();
            txtBox_THHD_HDDD.Text = dataGridView_HDDD.CurrentRow.Cells["ThoiGianHieuLuc"].Value.ToString();
            dtp_NL_HDDD.Text = dataGridView_HDDD.CurrentRow.Cells["NgayLapHopDong"].Value.ToString();


          
            
        }
    }
}
