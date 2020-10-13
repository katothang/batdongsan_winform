using QuanLyBatDongSan.DAO;
using QuanLyBatDongSan.DTO;
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

namespace QuanLyBatDongSan.GUI.DANHMUC
{
	public partial class NhanVien : Form
	{
		public NhanVien()
		{
			InitializeComponent();
			if(!biencucbo.loaitaikhoan.Equals("admin"))
            {
				
				pcSave.Visible = false;
				pcDelete.Visible = false;
				tbTenTK.Enabled = false;
				cbbChucVu.Visible = false;
				lbcv.Visible = false;

			}
		
			gvdata.DataSource = nhanvienDAO.Instance.showtaikhoan();
			gvdata.Columns[0].HeaderText = "Tên Tài Khoản";
			gvdata.Columns[1].HeaderText = "Quyền Truy Cập";
			gvdata.Columns[2].HeaderText = "Tên NV";
			gvdata.Columns[3].HeaderText = "Ngày Sinh";
			gvdata.Columns[4].HeaderText = "SĐT";
			gvdata.Columns[5].HeaderText = "Địa Chỉ";
			gvdata.Columns[6].HeaderText = "Mật Khẩu";
			gvdata.Columns[7].HeaderText = "Giới Tính";

			nhanvienDTO thongtin = nhanvienDAO.Instance.thongtintaikhoan(biencucbo.taikhoan);
			tbTenNV.Text = thongtin.TenNV.ToString();
			tbTenTK.Text = thongtin.MaNV.ToString();
			tbDiaChi.Text = thongtin.DiaChi.ToString();
			tbSDT.Text = thongtin.Sdt.ToString();
			tbMK1.Text = thongtin.Matkhau;
			if (thongtin.Quyentruycap.ToString() == "admin")
				cbbChucVu.SelectedIndex = 0;
			else
				cbbChucVu.SelectedIndex = 1;

			
			// chỉnh format ngày tháng năm
			dtNgaySinh.CustomFormat = "dd-MM-yyyy";

		}

		private void Gvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

				tbTenNV.Text = gvdata.SelectedRows[0].Cells["tennv"].Value.ToString();
				tbTenTK.Text = gvdata.SelectedRows[0].Cells["manv"].Value.ToString();
				dtNgaySinh.Value = DateTime.Parse(gvdata.SelectedRows[0].Cells["ngaysinh"].Value.ToString());
				tbDiaChi.Text = gvdata.SelectedRows[0].Cells["DiaChi"].Value.ToString();
				tbSDT.Text = gvdata.SelectedRows[0].Cells["SDT"].Value.ToString();
				cbbChucVu.Text = gvdata.SelectedRows[0].Cells["quyentruycap"].Value.ToString();
				cbbGioiTinh.Text = gvdata.SelectedRows[0].Cells["gioitinh"].Value.ToString();
		}

		private void PcSearch_Click(object sender, EventArgs e)
		{
			try
			{
				gvdata.DataSource = nhanvienDAO.Instance.timkiem(tbTimKiem.Text);
			}
			catch (Exception)
			{
				MessageBox.Show("Lỗi..!");
			}
		}

		private void BtLamMoi_Click(object sender, EventArgs e)
		{
			gvdata.DataSource = nhanvienDAO.Instance.showtaikhoan();
		}

		private void PcSave_Click(object sender, EventArgs e)
		{
			//kiểm tra trường trống
			if (tbDiaChi.Text == "" || tbMK1.Text == "" || tbSDT.Text == "" || tbTenNV.Text == "" || tbTenTK.Text == "")
			{
				if (tbDiaChi.Text == "")
					lbdiachi.Text = "Vui lòng nhập địa chỉ.!";
				if (tbMK1.Text == "")
					lbmatkhau.Text = "Vui lòng nhập mật khẩu.!";
				if (tbSDT.Text == "")
					lbSDT.Text = "Vui lòng nhập SĐT.!";
				if (tbTenNV.Text == "")
					lbtennv.Text = "Vui lòng nhập tên nhân viên.!";
				if (tbTenTK.Text == "")
					lbtaikhoan.Text = "Vui lòng nhập tên tài khoản.!";
				return;

			}
			//end kt truong trống 
			//kiểm tra các ngại lệ nhập vào

			if (!rangbuoc.Instance.checkphone(tbSDT.Text))
			{
				lbSDT.Text = "bạn đã nhập sai SĐT";
				return;
			}

			if (tbMK1.Text != tbMK2.Text)
			{
				lbnhaplaimk.Text = "mật khẩu bạn nhập không trùng";
				return;
			}
			// end kt ngoại lệ
			try
			{
				nhanvienDAO.Instance.themDL(tbTenTK.Text, tbMK1.Text, tbTenNV.Text, cbbChucVu.Text, dtNgaySinh.Value, tbSDT.Text, tbDiaChi.Text, cbbGioiTinh.Text);
				MessageBox.Show("thêm thành công nhân viên " + tbTenTK.Text);
				gvdata.DataSource = nhanvienDAO.Instance.showtaikhoan();

			}
			catch (Exception)
			{

				MessageBox.Show("Lỗi...!");
			}
		}

		private void PcEdit_Click(object sender, EventArgs e)
		{
			//kiểm tra trường trống
			if (tbDiaChi.Text == "" || tbMK1.Text == "" || tbSDT.Text == "" || tbTenNV.Text == "" || tbTenTK.Text == "")
			{
				if (tbDiaChi.Text == "")
					lbdiachi.Text = "Vui lòng nhập địa chỉ.!";
				if (tbMK1.Text == "")
					lbmatkhau.Text = "Vui lòng nhập mật khẩu.!";
				if (tbSDT.Text == "")
					lbSDT.Text = "Vui lòng nhập SĐT.!";
				if (tbTenNV.Text == "")
					lbtennv.Text = "Vui lòng nhập tên nhân viên.!";
				if (tbTenTK.Text == "")
					lbtaikhoan.Text = "Vui lòng nhập tên tài khoản.!";
				return;

			}
			//end kt truong trống 
			
			if (!rangbuoc.Instance.checkphone(tbSDT.Text))
			{
				lbSDT.Text = "bạn đã nhập sai SĐT";
				return;
			}

			if (tbMK1.Text != tbMK2.Text && tbMK2.Text != "")
			{
				lbnhaplaimk.Text = "mật khẩu bạn nhập không trùng";
				return;
			}

			if (biencucbo.loaitaikhoan.Equals("admin"))
			{
				if (tbTenTK.Text != gvdata.SelectedRows[0].Cells["manv"].Value.ToString())
				{
					lbtaikhoan.Text = "không được phép sửa tên tài khoản";
					return;
				}
			}
			
			// end kt ngoại lệ
			try
			{
				bool gt = false;
				if (cbbGioiTinh.Text == "Nam")
					gt = true;

				nhanvienDAO.Instance.Sua(tbTenTK.Text, tbMK1.Text, tbTenNV.Text, cbbChucVu.Text, dtNgaySinh.Value, tbSDT.Text, tbDiaChi.Text, cbbGioiTinh.Text);
				MessageBox.Show("sửa thành công nhân viên " + tbTenTK.Text);
				gvdata.DataSource = nhanvienDAO.Instance.showtaikhoan();

			}
			catch (Exception)
			{

				MessageBox.Show("Lỗi...!");
			}

		}

		private void PcDelete_Click(object sender, EventArgs e)
		{
			try
			{
				nhanvienDAO.Instance.Xoa(tbTenTK.Text);
				MessageBox.Show("Xóa thành công tài khoản " + tbTenTK.Text);
				gvdata.DataSource = nhanvienDAO.Instance.showtaikhoan();
			}
			catch (Exception)
			{
				MessageBox.Show("Lỗi...!");

			}
		}
	}
}
