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
    public partial class ThongKe : Form
    {
        DataTable tb_TK;
        public ThongKe()
        {
           
            InitializeComponent();
        }
        private void LoadData_ThongKe()//dữ liệu vào DataGridView
        {
            string sql = "SELECT MaSoDonHang,PhiVanChuyen from  DONHANG  WHERE TinhTrang = 1";


            tb_TK = Functions.GetDataTable(sql);
            dataGridView_TKTN.DataSource = tb_TK;

            // set Font cho tên cột
            dataGridView_TKTN.Font = new Font("Time New Roman", 13);
            dataGridView_TKTN.Columns[0].HeaderText = "Mã đơn hàng";
            dataGridView_TKTN.Columns[1].HeaderText = "Phí vận chuyển";

            // set Font cho dữ liệu hiển thị trong cột
            dataGridView_TKTN.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dataGridView_TKTN.Columns[0].Width = 450;
            dataGridView_TKTN.Columns[1].Width = 450;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_TKTN.AllowUserToAddRows = false;
            dataGridView_TKTN.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

    }
}
