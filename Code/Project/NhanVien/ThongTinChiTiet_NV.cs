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
    public partial class ThongTinChiTiet_NV : Form
    {
        DataTable tbl_TTCT_NV ;
        bool updatePass = false;
       
        string TenDangNhap;
        string MatKhau;
        string MaTK;
        string MaSoNhanVien;
        public ThongTinChiTiet_NV(string tenDangNhap, string MatKhau)
        {
            InitializeComponent();
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = MatKhau;
           

            string sql = "select MaSoNhanVien from NHANVIEN,TAIKHOAN where TenDangNhap ='" + TenDangNhap + "' and MatKhau ='" + MatKhau + "' and NHANVIEN.MaTK = TAIKHOAN.MaTK ";
            MaSoNhanVien = Functions.GetFieldValues(sql);

        }
        

        private void Init_valueFalse()
        {
           
            txtBox_MKM_NV.Enabled = false;
            txtBox_XNMK_NV.Enabled = false;
          
        }

        private void Init_valueTrue()
        {
            
            txtBox_MKM_NV.Enabled = true;
            txtBox_XNMK_NV.Enabled = true;
           
        }
        private void loadDataChiTietNhanVien()
        {
            string sql = "SELECT TenDangNhap, HoTen, DiaChiNhanVien, SoDienThoaiNV, EmailNV, TAIKHOAN.MaTK " +
               "FROM  TAIKHOAN, NHANVIEN  " +
                "WHERE TenDangNhap = '" + TenDangNhap + "' " +
               "AND MatKhau =  '" + MatKhau + "' " +
                "AND TAIKHOAN.MaTK = NhanVien.MaTK";
           


            tbl_TTCT_NV = Functions.GetDataTable(sql);   

            if(tbl_TTCT_NV.Rows.Count == 0) {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                txtBox_TDN_NV.Text = tbl_TTCT_NV.Rows[0].Field<string>(0).Trim();
                txtBox_HoTen_NV.Text = tbl_TTCT_NV.Rows[0].Field<string>(1).Trim();
                txtBox_DC_NV.Text = tbl_TTCT_NV.Rows[0].Field<string>(2).Trim();
                txtBox_SDT_NV.Text = tbl_TTCT_NV.Rows[0].Field<string>(3).Trim();
                txtBox_Email_NV.Text = tbl_TTCT_NV.Rows[0].Field<string>(4).Trim();
                MaTK = tbl_TTCT_NV.Rows[0].Field<string>(5).Trim();
            }
        }



        private void loadThongTinCTNV(object sender, EventArgs e)
        {
            Init_valueFalse();
            loadDataChiTietNhanVien();
        }


        private void btn_CapNhat_NV_click(object sender, EventArgs e)
        {
            Init_valueTrue();
            updatePass = true;
        }

       
        private void sp_DoiMK_NV(string MaTKNV, string matkhaumoi)
        {
            SqlCommand cmd = new SqlCommand("SP_DOIMK", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@MaTK", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar, 50);

            // set giá trị
            cmd.Parameters["@MaTK"].Value = MaTKNV;
            cmd.Parameters["@MatKhau"].Value = matkhaumoi;

            cmd.ExecuteNonQuery();
        }

        private void sp_DoiThongTinTK_NV(string MaSoNhanVien, string HoTen, string SoDienThoai, string DiaChi, string EmailNV)
        {
            SqlCommand cmd = new SqlCommand("SP_DOITHONGTIN_NV", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@MaSoNhanVien", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@SoDienThoaiNV", SqlDbType.Char,10);
            cmd.Parameters.Add("@DiaChiNhanVien", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@EmailNV", SqlDbType.NVarChar, 30);

            // set giá trị
            cmd.Parameters["@MaSoNhanVien"].Value = MaSoNhanVien;
            cmd.Parameters["@HoTen"].Value = HoTen;
            cmd.Parameters["@SoDienThoaiNV"].Value = SoDienThoai;
            cmd.Parameters["@DiaChiNhanVien"].Value = DiaChi;
            cmd.Parameters["@EmailNV"].Value = EmailNV;

            cmd.ExecuteNonQuery();
        }

        private void btn_Luu_NV_Click(object sender, EventArgs e)
        {
            // TH người dùng chưa nhập đầy đủ dữ liệu chưa
            if (txtBox_HoTen_NV.Text.Trim().Length == 0 | txtBox_DC_NV.Text.Trim().Length == 0 |
                txtBox_SDT_NV.Text.Trim().Length == 0 | txtBox_Email_NV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (updatePass)
            {
                if (txtBox_MKM_NV.Text.Trim().Length == 0 | txtBox_XNMK_NV.Text.Trim().Length == 0 )
                {
                    MessageBox.Show("Bạn cần phải nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

              

                if (!txtBox_MKM_NV.Text.Trim().Equals(txtBox_XNMK_NV.Text.Trim()))
                {
                    MessageBox.Show("Xác nhận mật khẩu chưa đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // nếu đã thỏa hết các điều kiện ở trên
            try
            {
                string sql = "";
                if (updatePass)
                    sp_DoiMK_NV(MaTK, txtBox_MKM_NV.Text.Trim());

                sp_DoiThongTinTK_NV(MaSoNhanVien, txtBox_HoTen_NV.Text.Trim(),
                   txtBox_DC_NV.Text.Trim(), txtBox_SDT_NV.Text.Trim(),
                    txtBox_Email_NV.Text.Trim());

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBox_MKM_NV.Text = "";
                
                txtBox_XNMK_NV.Text = "";
                Init_valueFalse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thông tin thất bại, mã lỗi: " + ex.Message); // This will display all the error in your statement.
            }
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
