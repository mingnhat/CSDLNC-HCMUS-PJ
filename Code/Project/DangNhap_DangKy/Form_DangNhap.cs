#nullable disable

using Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class Form_DangNhap : Form
    {
        Thread T;

        public int user_type = -1;
        string MaTK = string.Empty;
        string LoaiTK = string.Empty;
        string TenDangNhap = string.Empty;
        string MatKhau = string.Empty;

        private void resetDataTextBox() {
            txtBox_TenDN.Text = "";
            txtBox_Mk.Text = "";
        }

        public Form_DangNhap()
        {
            InitializeComponent();
        }

        private void LoadingForm(object sender, EventArgs e)
        {
            txtBox_Mk.PasswordChar = '*';
            Functions.Connect(Functions.get_ConnectString(user_type));
            resetDataTextBox();
        }

        private void Run_SP_DangNhap()
        {
            SqlCommand command = new SqlCommand("SP_DANGNHAP", Functions.Con);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@TenDangNhap", SqlDbType.NVarChar, 30);
            command.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 30);
            command.Parameters.Add("@MaTK", SqlDbType.NVarChar, 10).Direction= ParameterDirection.Output;
            command.Parameters.Add("@LoaiTK", SqlDbType.Int).Direction= ParameterDirection.Output;

            command.Parameters["@TenDangNhap"].Value = TenDangNhap;
            command.Parameters["@MatKhau"].Value = MatKhau;

            command.ExecuteNonQuery();

            MaTK = Convert.ToString(command.Parameters["@MaTK"].Value);
            LoaiTK = Convert.ToString(command.Parameters["@LoaiTK"].Value);
        }

        // đăng ký
        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            Form_DangKy form_DangKy = new Form_DangKy();
            form_DangKy.StartPosition = FormStartPosition.CenterParent;
            form_DangKy.ShowDialog();
        }

        public void open_each_form(object obj)
        {
            switch (user_type)
            {
                case 0:
                    Application.Run(new Form_Admin_Main());
                    break;
                case 1:
                    Application.Run(new Form_DoiTac_Main(MaTK));
                    break;
                case 2:
                    Application.Run(new main_KH(MaTK));
                    break;
                case 3:
                    Application.Run(new main_TX());
                    break;
                case 4:
                    Application.Run(new main_NV(TenDangNhap, MatKhau));
                    break;
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            TenDangNhap = txtBox_TenDN.Text.Trim().ToString();
            MatKhau = txtBox_Mk.Text.Trim().ToString();

            // case: không nhập đủ thông tin
            if (TenDangNhap.Length == 0 || MatKhau.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Run_SP_DangNhap();

            if (LoaiTK.Length == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            user_type = Int32.Parse(LoaiTK);

            Functions.Disconnect();
            Functions.Connect(Functions.get_ConnectString(user_type));
            this.Close();
            T = new Thread(open_each_form);
            T.SetApartmentState(ApartmentState.STA);
            T.Start();
        }
    }
}
