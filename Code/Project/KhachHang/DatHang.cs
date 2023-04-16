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
    public partial class DatHang : Form
    {
        private string maTK;
        private string maSoDoiTac;
        private string maSoMonAn;
        private string tenMon;
        private string giaBan;
        private string soluongmua;
        public DatHang(string maTK, string maSoDoiTac, string maSoMonAn, string tenMon, string giaBan, string soluongmua)
        {
            this.maTK =maTK;
            this.maSoDoiTac = maSoDoiTac;
            this.maSoMonAn = maSoMonAn;
            this.tenMon = tenMon;
            this.giaBan = giaBan;
            this.soluongmua = soluongmua;
            InitializeComponent();
        }

        private void btn_Back_DH_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        private void LoadDatHang(object sender, EventArgs e)
        {
            txtBox_TenMon_DH.Text = tenMon;
            txtBox_GB_DH.Text = giaBan;
            txtBox_Sl_DH.Text = soluongmua;
            int temp = Int32.Parse(soluongmua) * Int32.Parse(giaBan);
            txt_TT_DH.Text = temp.ToString();

            string sql = "SELECT DiaChiKH FROM KHACHHANG  WHERE MaTK = '" + maTK + "'";
            string diachi = Functions.GetFieldValues(sql);
            cbox_HTTT_DH.Items.Add("Tiền mặt");
            cbox_HTTT_DH.Items.Add("Ví điện tử");
            cbox_HTTT_DH.Items.Add("Thẻ ngân hàng");
            txtBox_DCGH_DH.Text = diachi;
            txtBox_PVC_DH.Text = "20000";

        }

        private void btn_DH_Click(object sender, EventArgs e)
        {
            int count = 0;
            string sql1 = "SELECT COUNT(*) FROM DONHANG";
            string temp = Functions.GetFieldValues(sql1);
            count = Int32.Parse(temp) + 1;
            string maSoDonHang;
            if (count < 10)
            {
                maSoDonHang = "DH00" + count;
            }
            else if (count < 100)
            {
                maSoDonHang = "DH0" + count;
            }
            else
            {
                maSoDonHang = "DH" + count;
            }


            if (cbox_HTTT_DH.Text.Trim().Length == 0 || txtBox_DCGH_DH.Text.Trim().Length == 0
                || txtBox_Sl_DH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DateTime now = DateTime.Now;
            string httt = "";
            if (cbox_HTTT_DH.Text.Trim().ToString() == "Tiền mặt")
            {
                httt = "0";
            }
            if (cbox_HTTT_DH.Text.Trim().ToString() == "Ví điện tử")
            {
                httt = "1";
            }
            if (cbox_HTTT_DH.Text.Trim().ToString() == "Thẻ ngân hàng")
            {
                httt = "2";
            }
            float tongtien = float.Parse(txt_TT_DH.Text.ToString()) + float.Parse(txtBox_PVC_DH.Text.ToString());
            string sql2 = "INSERT INTO DONHANG(MaSoDonHang,MaSoDoiTac,MaSoKhachHang,HinhThucThanhToan, DiaChiGiaoHang, NgayDatHang,SoDienThoaiKH, PhiSanPham, PhiVanChuyen,  TrangThaiDonHang) " +
                "VALUES('" + maSoDonHang + "','" + maSoDoiTac + "','" + maTK + "'," + httt.ToString() + "," + "N'" + txtBox_DCGH_DH.Text.Trim().ToString() + "',"
                  + "'" + "2002-12-24" + "'," + "123456789" + "," + txt_TT_DH.Text.ToString() + "," + txtBox_PVC_DH.Text.ToString() + "," + "0" + ")";

            Functions.RunSQL(sql2);










            string slq3 = "INSERT INTO CT_DONHANG( MaSoDonHang, MaSoMonAn, SoLuongMon, TongTien) "
                + "VALUES('" + maSoDonHang + "','" + maSoMonAn + "'," + txtBox_Sl_DH.Text.Trim().ToString() + "," + txt_TT_DH.Text.ToString() + ")";



            Functions.RunSQL(slq3);

            MessageBox.Show("Đặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string sql4 = "SP_KHMUASP '" + maSoMonAn + "'," + txtBox_Sl_DH.Text.Trim().ToString();
            Functions.RunSQL(sql4);
            this.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_click (object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_DatMua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
