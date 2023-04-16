#nullable disable

using Project;

namespace DoAnCuoiKi
{
    public partial class Form_DoiTac_Main : Form
    {
        Thread T;
        string MaTK = string.Empty;
        string MaSoDoiTac = string.Empty;

        private Form activeForm = null;

        // khởi tạo form trong panel chính
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.ShowInTaskbar = false;
            childForm.Dock = DockStyle.Fill;
            panel_ChildForm.Controls.Add(childForm);
            panel_ChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public Form_DoiTac_Main(string MaTK)
        {
            InitializeComponent();

            // lấy mã số đối tác
            string query = "SELECT DT.MaSoDoiTac FROM DOITAC DT WHERE DT.MaTK = '" + MaTK + "'";
            MaSoDoiTac = Functions.GetFieldValues(query).Trim();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btn_DoiTac_LapHopDong_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_DoiTac_HopDong(MaSoDoiTac));
        }

        private void panel_ChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_DoiTac_TaiKhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_DoiTac_ThongTinCT());
        }

        // Quản lí thực đơn
        private void btn_DoiTac_ThucDon_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_DoiTac_ThucDon(MaSoDoiTac));
        }

        private void btn_DoiTac_DonHang_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_DoiTac_DonHang());
        }

        private void Form_DoiTac_Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_CuaHang_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_DoiTac_CuaHang(MaSoDoiTac));
        }

        public void open_FormDangNhap(object obj)
        {
            Application.Run(new Form_DangNhap());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            T = new Thread(open_FormDangNhap);
            T.SetApartmentState(ApartmentState.STA);
            T.Start();
        }
    }
}
