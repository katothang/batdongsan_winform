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
	public partial class NhomKH : Form
	{
		string maNhom = "";
		public NhomKH()
		{
			InitializeComponent();
			gvdata.DataSource = nhomKHDAO.Instance.showNhom();
			//tieu đề
			gvdata.Columns["MaNhom"].HeaderText = "Mã Nhóm";
			gvdata.Columns["TenNhom"].HeaderText = "Tên Nhóm";
			
		}

		private void Gvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			tbTenNhom.Text = gvdata.SelectedRows[0].Cells["TenNhom"].Value.ToString();
			maNhom = gvdata.SelectedRows[0].Cells["MaNhom"].Value.ToString();
			tbMaNhom.Text = gvdata.SelectedRows[0].Cells["MaNhom"].Value.ToString();
		}

		private void PcSearch_Click(object sender, EventArgs e)
		{
			try
			{
				gvdata.DataSource = nhomKHDAO.Instance.timkiem(tbTimKiem.Text);
			}
			catch (Exception)
			{

				MessageBox.Show("Lỗi..!");
			}
		}

		private void BtLamMoi_Click(object sender, EventArgs e)
		{
			gvdata.DataSource = nhomKHDAO.Instance.showNhom();
		}

		private void PcSave_Click(object sender, EventArgs e)
		{
			try
			{
				nhomKHDAO.Instance.ThemDL(tbMaNhom.Text,tbTenNhom.Text);
				MessageBox.Show("thêm thành công nhóm " + tbTenNhom.Text);
				gvdata.DataSource = nhomKHDAO.Instance.showNhom();
			}
			catch (Exception)
			{

				MessageBox.Show("lỗi vui lòng kiểm tra lại dữ liệu");
			}
		}

		private void PcEdit_Click(object sender, EventArgs e)
		{
			try
			{
				nhomKHDAO.Instance.SuaDL(maNhom, tbTenNhom.Text);
				MessageBox.Show("sửa thành công mã nhà cung cấp " + tbTenNhom.Text);
				gvdata.DataSource = nhomKHDAO.Instance.showNhom();
			}
			catch (Exception)
			{

				MessageBox.Show("lỗi vui lòng kiểm tra lại dữ liệu");
			}
		}

		private void PcDelete_Click(object sender, EventArgs e)
		{
			try
			{
				nhomKHDAO.Instance.xoaDL(maNhom);
				MessageBox.Show("xóa thành công");
				gvdata.DataSource = nhomKHDAO.Instance.showNhom();
			}
			catch (Exception)
			{

				MessageBox.Show("lỗi vui lòng kiểm tra lại");
			}
		}
	}
}
