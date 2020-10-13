using QuanLyBatDongSan.GUI.DANHMUC;
using QuanLyBatDongSan.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBatDongSan.GUI
{
    public partial class Home : Form
    {
        public Home()
        {
			InitializeComponent();
			biencucbo.home = this;
			lbAccount.Text = biencucbo.taikhoan;
			// mở trang bán hàng làm mặc định
			BtnBanHang_Click(new object(), new EventArgs());

		}

		private void BtnBanHang_Click(object sender, EventArgs e)
		{
			// reset lại toàn bộ menu và set lại màu khi click vào menu
			un_btHeader_Click();
			pnContent.Controls.Clear();
			SanPham sanpham = new SanPham();
			sanpham.TopLevel = false;
			pnContent.Controls.Add(sanpham);
			sanpham.Show();
			this.btnBanHang.BackColor = Color.FromArgb(255, 127, 80);
			iconBanHang.BackColor = Color.FromArgb(255, 127, 80);
			btnBanHang.FlatAppearance.BorderColor = Color.White;
		}
		private void un_btHeader_Click()
		{
			this.btnBanHang.BackColor = Color.OrangeRed;
			iconBanHang.BackColor = Color.OrangeRed;
			btnBanHang.FlatAppearance.BorderColor = Color.OrangeRed;

			this.btnNhapHang.BackColor = Color.OrangeRed;
			iconNhapHang.BackColor = Color.OrangeRed;
			btnNhapHang.FlatAppearance.BorderColor = Color.OrangeRed;

			this.btnKhachHang.BackColor = Color.OrangeRed;
			iconKhachHang.BackColor = Color.OrangeRed;
			btnKhachHang.FlatAppearance.BorderColor = Color.OrangeRed;

			

			this.btnTaiKhoan.BackColor = Color.OrangeRed;
			iconTaiKhoan.BackColor = Color.OrangeRed;
			btnTaiKhoan.FlatAppearance.BorderColor = Color.OrangeRed;

			this.btnDangXuat.BackColor = Color.OrangeRed;
			iconDangXuat.BackColor = Color.OrangeRed;
			btnDangXuat.FlatAppearance.BorderColor = Color.OrangeRed;
		}

		private void BtnNhapHang_Click(object sender, EventArgs e)
		{	
			
			// reset lại toàn bộ menu và set lại màu khi click vào menu
			un_btHeader_Click();
			pnContent.Controls.Clear();
			NhomKH nhom = new NhomKH();
			nhom.TopLevel = false;
			pnContent.Controls.Add(nhom);
			nhom.Show();
			this.btnNhapHang.BackColor = Color.FromArgb(255, 127, 80);
			iconNhapHang.BackColor = Color.FromArgb(255, 127, 80);
			btnNhapHang.FlatAppearance.BorderColor = Color.White;
		}

		private void BtnKhachHang_Click(object sender, EventArgs e)
		{

			un_btHeader_Click();
			pnContent.Controls.Clear();
			KhachHang khachHang = new KhachHang();
			khachHang.TopLevel = false;
			pnContent.Controls.Add(khachHang);
			khachHang.Show();
			this.btnKhachHang.BackColor = Color.FromArgb(255, 127, 80);
			iconKhachHang.BackColor = Color.FromArgb(255, 127, 80);
			btnKhachHang.FlatAppearance.BorderColor = Color.White;
		}

		private void BtnTaiKhoan_Click(object sender, EventArgs e)
		{

			un_btHeader_Click();
			pnContent.Controls.Clear();
			NhanVien nhanVien = new NhanVien();
			nhanVien.TopLevel = false;
			pnContent.Controls.Add(nhanVien);
			nhanVien.Show();
			this.btnTaiKhoan.BackColor = Color.FromArgb(255, 127, 80);
			iconTaiKhoan.BackColor = Color.FromArgb(255, 127, 80);
			btnTaiKhoan.FlatAppearance.BorderColor = Color.White;
		}

		private void BtnDangXuat_Click(object sender, EventArgs e)
		{
			DangNhap dangNhap = new DangNhap();
			biencucbo.taikhoan = null;
			biencucbo.loaitaikhoan = null;
			this.Hide();
			dangNhap.ShowDialog();

		}

		// hàm hiển thị với 1 form được truuyền vào lên trang chủ
		public void showForm(Form form)
		{
			pnContent.Controls.Clear();
			form.TopLevel = false;
			pnContent.Controls.Add(form);
			form.Show();
		}




	}
}
