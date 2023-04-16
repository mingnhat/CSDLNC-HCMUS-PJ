#nullable disable

using Project;

namespace DoAnCuoiKi
{
    public partial class Form_Admin_Main : Form
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
        public Form_Admin_Main()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_ChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_DoiTac_Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_DanhSachTK_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Admin_DSTK());
        }

        private void btn_ThongTinCT_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Admin_ThongTinCT());
        }
    }
}
