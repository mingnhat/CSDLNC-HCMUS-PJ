using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project;


namespace DoAnCuoiKi
{
    public partial class HopDongChuaDuyet : Form
    {
        string MaSoNhanVien;
        DataTable table_HopDongChuaDuyet = new DataTable();

        string return_value_DuyetHD = string.Empty;
        string return_value_LoaiBoHD = string.Empty;

        public HopDongChuaDuyet(string manv)
        {
            InitializeComponent();
            MaSoNhanVien = manv;
        }

        private void resetData_HopDongChuaDuyet()
        {
            dtp_NL_HDCD.CustomFormat = "";
            txtBox_MSHD_HDCD.Text = "";
            txtBox_SLCN_HDCD.Text = "";
            dtp_NL_HDCD.Text = "";
            txtBox_MSDT_HDCD.Text = "";
            txtBox_TDT_HDCD.Text = "";
            txtBox_PHH_HDCD.Text = "";
            txtBox_TH_HDCD.Text = "";
        }

        private void LoadData_HopDongChuaDuyet() //dữ liệu vào DataGridView
        {
            string sql = "select hd.MaSoHopDong, dt.MaSoDoiTac, dt.TenDoiTac, hd.MaSoThueDoiTac, hd.SoChiNhanhDangKi, hd.PhiHoaHong, hd.NgayLapHopDong, hd.ThoiGianHieuLuc " +
            "from HOPDONG hd, DOITAC dt where hd.MaSoDoiTac = dt.MaSoDoiTac and hd.DaDuyet = 0;";

            table_HopDongChuaDuyet = Functions.GetDataTable(sql);
            dGV_NhanVien_HopDongChuaDuyet.DataSource = table_HopDongChuaDuyet;

            // set Font cho tên cột
            dGV_NhanVien_HopDongChuaDuyet.Font = new Font("Time New Roman", 13);
            dGV_NhanVien_HopDongChuaDuyet.Columns[0].HeaderText = "Mã hợp đồng";
            dGV_NhanVien_HopDongChuaDuyet.Columns[1].HeaderText = "Mã đối tác";
            dGV_NhanVien_HopDongChuaDuyet.Columns[2].HeaderText = "Tên đối tác";
            dGV_NhanVien_HopDongChuaDuyet.Columns[3].HeaderText = "Mã Số thuế";
            dGV_NhanVien_HopDongChuaDuyet.Columns[4].HeaderText = "Số lượng chi nhánh";
            dGV_NhanVien_HopDongChuaDuyet.Columns[5].HeaderText = "Phần trăm hoa hồng";
            dGV_NhanVien_HopDongChuaDuyet.Columns[6].HeaderText = "Ngày lập";
            dGV_NhanVien_HopDongChuaDuyet.Columns[7].HeaderText = "Thời hạn hợp đồng";

            // set Font cho dữ liệu hiển thị trong cột
            dGV_NhanVien_HopDongChuaDuyet.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dGV_NhanVien_HopDongChuaDuyet.Columns[0].Width = 200;
            dGV_NhanVien_HopDongChuaDuyet.Columns[1].Width = 200;
            dGV_NhanVien_HopDongChuaDuyet.Columns[2].Width = 200;
            dGV_NhanVien_HopDongChuaDuyet.Columns[3].Width = 200;
            dGV_NhanVien_HopDongChuaDuyet.Columns[4].Width = 200;
            dGV_NhanVien_HopDongChuaDuyet.Columns[5].Width = 200;
            dGV_NhanVien_HopDongChuaDuyet.Columns[6].Width = 200;
            dGV_NhanVien_HopDongChuaDuyet.Columns[7].Width = 200;


            
            dGV_NhanVien_HopDongChuaDuyet.AllowUserToAddRows = false;
            dGV_NhanVien_HopDongChuaDuyet.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void pushData_Click(object sender, EventArgs e) 
        {
            //Nếu không có dữ liệu
            if ( dGV_NhanVien_HopDongChuaDuyet.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // set giá trị cho các mục 
            dtp_NL_HDCD.CustomFormat = "yyyy-MM-dd";
            txtBox_MSHD_HDCD.Text = dGV_NhanVien_HopDongChuaDuyet.CurrentRow.Cells["MaSoHopDong"].Value.ToString();
            txtBox_SLCN_HDCD.Text = dGV_NhanVien_HopDongChuaDuyet.CurrentRow.Cells["SoChiNhanhDangKi"].Value.ToString();
            dtp_NL_HDCD.Text = dGV_NhanVien_HopDongChuaDuyet.CurrentRow.Cells["NgayLapHopDong"].Value.ToString();
            txtBox_MSDT_HDCD.Text = dGV_NhanVien_HopDongChuaDuyet.CurrentRow.Cells["MaSoDoiTac"].Value.ToString();
            txtBox_TDT_HDCD.Text = dGV_NhanVien_HopDongChuaDuyet.CurrentRow.Cells["TenDoiTac"].Value.ToString();
            txtBox_MST_HDCD.Text = dGV_NhanVien_HopDongChuaDuyet.CurrentRow.Cells["MaSoThueDoiTac"].Value.ToString();
           
           txtBox_PHH_HDCD.Text = dGV_NhanVien_HopDongChuaDuyet.CurrentRow.Cells["PhiHoaHong"].Value.ToString();
            txtBox_TH_HDCD.Text = dGV_NhanVien_HopDongChuaDuyet.CurrentRow.Cells["ThoiGianHieuLuc"].Value.ToString();
        }

        private void run_HopDongChuaDuyet(object sender, EventArgs e)
        {
            dtp_NL_HDCD.CustomFormat = " ";
            LoadData_HopDongChuaDuyet();
        }


        private void sp_DuyetHopDong(string ngaybd, string ngaykt, string manv, string mahd)
        {
            SqlCommand cmd = new SqlCommand(" SP_DUYETHOPDONG", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@NgayLapHopDong", SqlDbType.Date);
            cmd.Parameters.Add("@NgayKetThuc", SqlDbType.Date);
            cmd.Parameters.Add("@MaSoNhanVien", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@MaSoHopDong", SqlDbType.NVarChar, 10);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            // set giá trị
            cmd.Parameters["@NgayBatDau"].Value = ngaybd;
            cmd.Parameters["@NgayKetThuc"].Value = ngaykt;
            cmd.Parameters["@MaSoNhanVien"].Value = manv;
            cmd.Parameters["@MaSoHopDong"].Value = mahd;

            cmd.ExecuteNonQuery();

            return_value_DuyetHD = returnParameter.Value.ToString();
        }

        private string Get_ngayketthuc(string ngaybd, string thoihanhd) // set up ngày kết thúc dựa trên ngày bắt đầu và thời hạn hợp đồng
        {
            string kq = "";
            string[] elements = ngaybd.Split('-');
            string[] elements2 = elements[2].Split(' ');
            int year = Int32.Parse(elements[0]);
            int year_end = year + Int32.Parse(thoihanhd);

            kq = elements[1] + "-" + elements2[0] + "-" + year_end.ToString();
            return kq;
        }
        private void btn_duyethd_HHCDNV_Click(object sender, EventArgs e) // xử lí duyệt hợp đồng
        {
            // TH nếu chưa chọn hợp đồng nào 
            if (txtBox_MSHD_HDCD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn hợp đồng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // hỏi người dùng có muốn duyệt không
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn duyệt hợp đồng này không?" +
                "", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // nếu đã thỏa hết các điều kiện 
            try
            {
                DateTime today = DateTime.Today; //yyyy - MM - dd                

                sp_DuyetHopDong(today.ToString("MM/dd/yyyy"), Get_ngayketthuc(today.ToString(), txtBox_TH_HDCD.Text.Trim().ToString())
                    , MaSoNhanVien, txtBox_MSHD_HDCD.Text.Trim().ToString());

                if (return_value_DuyetHD.Equals("0"))
                    MessageBox.Show("Duyệt hợp đồng thất bại!!!");
                else MessageBox.Show("Duyệt hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData_HopDongChuaDuyet();
                resetData_HopDongChuaDuyet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duyệt hợp đồng Thất bại, mã lỗi: " + ex.Message); 
            }
        }
        private void Run_SP_LoaiBoHopDong(string manv, string mahd)
        {
            SqlCommand cmd = new SqlCommand("SP_LOAIHOPDONG", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu        
            cmd.Parameters.Add("@MaSoNhanVien", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@MaSoHopDong", SqlDbType.NVarChar, 10);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            // set giá trị        
            cmd.Parameters["@MaSoNhanVien"].Value = manv;
            cmd.Parameters["@MaSoHopDong"].Value = mahd;

            cmd.ExecuteNonQuery();

            return_value_LoaiBoHD = returnParameter.Value.ToString();
        }

        private void btn_loaibohd_HHCDNV_Click(object sender, EventArgs e) // xử lí loại bỏ hợp đồng
        {
            // TH nếu chưa chọn hợp đồng nào 
            if (txtBox_MSHD_HDCD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn hợp đồng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // hỏi người dùng có muốn loại bỏ hợp đồng này không
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn loại bỏ hợp đồng này không?" +
                "", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // nếu đã thỏa hết các điều kiện 
            try
            {
                Run_SP_LoaiBoHopDong(MaSoNhanVien, txtBox_MSHD_HDCD.Text.Trim().ToString());

                if (return_value_LoaiBoHD.Equals("0"))
                    MessageBox.Show("Loại bỏ hợp đồng thất bại!!!");
                else MessageBox.Show("Loại bỏ hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData_HopDongChuaDuyet();
                resetData_HopDongChuaDuyet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loại bỏ hợp đồng Thất bại, mã lỗi: " + ex.Message); 
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_HDCD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HopDongChuaDuyet_Load(object sender, EventArgs e)
        {

        }

       
    }
}
