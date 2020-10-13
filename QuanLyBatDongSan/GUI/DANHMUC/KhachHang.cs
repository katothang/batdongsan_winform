using QuanLyBatDongSan.DAO;
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
	public partial class KhachHang : Form
	{
		int MaKH = 0;
		public KhachHang()
		{
			InitializeComponent();
			gvdata.DataSource = khachhangDAO.Instance.showkhachhang();
			cbbNhomKH.DataSource = khachhangDAO.Instance.showNhom();
			cbbNhomKH.DisplayMember = "TenNhom";
			cbbNhanVienQL.DataSource = khachhangDAO.Instance.showNhanVien();
			cbbNhanVienQL.DisplayMember = "MaNV";

			gvdata.Columns[0].HeaderText = "MaKH";
			gvdata.Columns[1].HeaderText = "Tên KH";
			gvdata.Columns[2].HeaderText = "Ngày Sinh";
			gvdata.Columns[3].HeaderText = "Địa Chỉ";
			gvdata.Columns[4].HeaderText = "SĐT";
			gvdata.Columns[5].HeaderText = "Giới Tính";
			gvdata.Columns[6].HeaderText = "Nhóm";
			gvdata.Columns[7].HeaderText = "Nhân Viên QL";
			// chỉnh format ngày tháng năm
			dtNgaySinh.CustomFormat = "dd-MM-yyyy";
		}

		private void Gvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			tbMaKH.Text = gvdata.SelectedRows[0].Cells["MaKH"].Value.ToString();
			tbTenKH.Text = gvdata.SelectedRows[0].Cells["tenKh"].Value.ToString();
			dtNgaySinh.Value = DateTime.Parse(gvdata.SelectedRows[0].Cells["NgaySinh"].Value.ToString());
			tbDiaChi.Text = gvdata.SelectedRows[0].Cells["DiaChi"].Value.ToString();
			tbSoDienThoai.Text = gvdata.SelectedRows[0].Cells["SDT"].Value.ToString();
			if (gvdata.SelectedRows[0].Cells["GioiTinh"].Value.ToString() == "Nam")
				cbbGioiTinh.SelectedIndex = 0;
			else
				cbbGioiTinh.SelectedIndex = 1;
		}

		private void PcSave_Click(object sender, EventArgs e)
		{
			if (!rangbuoc.Instance.checkphone(tbSoDienThoai.Text))
			{
				lbSDT.Text = "bạn đã nhập sai số điện thoại.!";
				return;
			}

			if (tbDiaChi.Text == "")
			{
				lbdiachi.Text = "vui lòng nhập địa chỉ.!";
				return;
			}

			if (tbTenKH.Text == "")
			{
				lbtenkh.Text = "vui lòng nhập tên khách hàng.!";
				return;
			}
			// end kiểm tra
			try
			{
				khachhangDAO.Instance.themDL(tbMaKH.Text, tbTenKH.Text, cbbGioiTinh.Text, tbDiaChi.Text, tbSoDienThoai.Text, dtNgaySinh.Value, cbbNhomKH.Text,cbbNhanVienQL.Text);
				MessageBox.Show("thêm thành công");
				gvdata.DataSource = khachhangDAO.Instance.showkhachhang();

			}
			catch (Exception)
			{

				MessageBox.Show("lỗi vui lòng kiểm tra lại");
			}
		}

		private void PcEdit_Click(object sender, EventArgs e)
		{

			if (!rangbuoc.Instance.checkphone(tbSoDienThoai.Text))
			{
				lbSDT.Text = "bạn đã nhập sai số điện thoại.!";
				return;
			}


			if (tbDiaChi.Text == "")
			{
				lbdiachi.Text = "vui lòng nhập địa chỉ.!";
				return;
			}

			if (tbTenKH.Text == "")
			{
				lbtenkh.Text = "vui lòng nhập tên khách hàng.!";
				return;
			}
            // end kiểm tra
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
			try
			{
				khachhangDAO.Instance.Sua(tbMaKH.Text, tbTenKH.Text, cbbGioiTinh.Text, tbDiaChi.Text, tbSoDienThoai.Text, dtNgaySinh.Value, cbbNhomKH.Text, cbbNhanVienQL.Text);
				MessageBox.Show("Sửa thành công");
				gvdata.DataSource = khachhangDAO.Instance.showkhachhang();

			}
			catch (Exception)
			{

				MessageBox.Show("lỗi vui lòng kiểm tra lại");
			}
		}

		private void PcDelete_Click(object sender, EventArgs e)
		{
			try
			{
				khachhangDAO.Instance.Xoa(tbMaKH.Text);
				MessageBox.Show("xóa thành công mã khách hàng " + MaKH);
				gvdata.DataSource = khachhangDAO.Instance.showkhachhang();
			}
			catch (Exception)
			{

				MessageBox.Show("lỗi vui lòng kiểm tra lại");
			}
		}

		private void PcSearch_Click(object sender, EventArgs e)
		{
			try
			{
				gvdata.DataSource = khachhangDAO.Instance.timkiem(tbTimKiem.Text);
			}
			catch (Exception)
			{

				MessageBox.Show("lỗi..!");
			}
		}

		private void BtLamMoi_Click(object sender, EventArgs e)
		{
			gvdata.DataSource = khachhangDAO.Instance.showkhachhang();
		}

        private void tbTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
