using QuanLyBatDongSan.DAO;
using QuanLyBatDongSan.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBatDongSan.GUI.DANHMUC
{
	public partial class SanPham : Form
	{
		String maBDS = "";
		public SanPham()
		{

			InitializeComponent();
			if (biencucbo.loaitaikhoan.Equals("admin"))
            {
				btnDuyetBai.Visible = true;
            }
			else
            {
				btnDuyetBai.Visible = false;
			}
			gvdata.DataSource = sanphamDAO.Instance.showsanpham();
			gvdata.Columns[0].HeaderText = "Mã BĐS";
			gvdata.Columns[1].HeaderText = "Trạng thái";
			gvdata.Columns[2].HeaderText = "Địa chỉ";
			gvdata.Columns[3].HeaderText = "Tỉnh";
			gvdata.Columns[4].HeaderText = "Quận, Huyện";
			gvdata.Columns[5].HeaderText = "Phường, Xã";
			
			gvdata.Columns[6].HeaderText = "Loại";
			gvdata.Columns[7].HeaderText = "Thời gian XD";
			gvdata.Columns[8].HeaderText = "Tình trạng";
			gvdata.Columns[9].HeaderText = "Pháp lý";
			gvdata.Columns[10].HeaderText = "Diện tích (trên sổ)";
			gvdata.Columns[11].HeaderText = "Diện tích (sử dụng)";
			gvdata.Columns[12].HeaderText = "mặt tiền(m)";
			gvdata.Columns[13].HeaderText = "Đường rộng (m)";
			gvdata.Columns[14].HeaderText = "Hướng";
			gvdata.Columns[15].HeaderText = "Số tầng";
			gvdata.Columns[16].HeaderText = "Thông tin";
			gvdata.Columns[17].HeaderText = "Giá";
			gvdata.Columns[18].HeaderText = "Người Đăng";
			gvdata.Columns[19].HeaderText = "Trạng Thái Bài";
			gvdata.Columns[20].HeaderText = "Lý Do Trả Về";

			cbTinh.DataSource = sanphamDAO.Instance.getTinh();
			cbTinh.DisplayMember = "_name";
			cbTinh.ValueMember = "id";
		}

		private void Gvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			maBDS = gvdata.SelectedRows[0].Cells["MaBDS"].Value.ToString();
			tbMaBDS.Text = gvdata.SelectedRows[0].Cells["MaBDS"].Value.ToString();
			tbTrangThai.Text = gvdata.SelectedRows[0].Cells["TrangThai"].Value.ToString();
			tbDiaChi.Text = gvdata.SelectedRows[0].Cells["DiaChi"].Value.ToString();
			cbXa.Text = gvdata.SelectedRows[0].Cells["PhuongXa"].Value.ToString();
			cbHuyen.Text = gvdata.SelectedRows[0].Cells["QuanHuyen"].Value.ToString();
			tbLoaiBDS.Text = gvdata.SelectedRows[0].Cells["LoaiBDS"].Value.ToString();
			cbTinh.Text = gvdata.SelectedRows[0].Cells["tinh"].Value.ToString();
			dtThoiGianXD.Text = gvdata.SelectedRows[0].Cells["ThoiGianXayDung"].Value.ToString();

			tbTinhTrang.Text = gvdata.SelectedRows[0].Cells["TinhTrangHienTai"].Value.ToString();
			tbPhapLy.Text = gvdata.SelectedRows[0].Cells["PhapLy"].Value.ToString();
			tbDienTichTrenSo.Text = gvdata.SelectedRows[0].Cells["DienTichTrenSo"].Value.ToString();
			tbDienTichSuDung.Text = gvdata.SelectedRows[0].Cells["DienTichSuDung"].Value.ToString();
			tbMatTien.Text = gvdata.SelectedRows[0].Cells["MatTien"].Value.ToString();
			tbDuongRong.Text = gvdata.SelectedRows[0].Cells["DuongRong"].Value.ToString();
			tbHuong.Text = gvdata.SelectedRows[0].Cells["Huong"].Value.ToString();
			tbSoTang.Text = gvdata.SelectedRows[0].Cells["SoTang"].Value.ToString();
			tbThongTin.Text = gvdata.SelectedRows[0].Cells["ThongTin"].Value.ToString();

			tbGiaBDS.Text = new String(gvdata.SelectedRows[0].Cells["Gia"].Value.ToString().Where(Char.IsDigit).ToArray());
	
			
		}

		private void PcSave_Click(object sender, EventArgs e)
		{
			byte[] file = null;
			try
			{
				
				sanphamDAO.Instance.themDL(tbMaBDS.Text, tbTrangThai.Text, tbDiaChi.Text, cbXa.Text, cbHuyen.Text, cbTinh.Text, tbLoaiBDS.Text, dtThoiGianXD.Text, tbTinhTrang.Text, tbPhapLy.Text, tbDienTichTrenSo.Text, tbDienTichSuDung.Text, tbMatTien.Text, tbDuongRong.Text, tbHuong.Text, tbSoTang.Text, tbThongTin.Text, tbGiaBDS.Text, biencucbo.taikhoan);
				MessageBox.Show("thêm thành công");
				//insert vao bang nhap hàng
				


			}
			catch (Exception)
			{

				MessageBox.Show("dữ liệu nhập không chính xác hoặc thiếu!");
			}
			gvdata.DataSource = sanphamDAO.Instance.showsanpham();
		}

		private void PcEdit_Click(object sender, EventArgs e)
		{
			byte[] file = null;
			//String fileName = System.IO.Path.GetFileName(btnUpload.Text);
			try
			{
				
				/*try
				{
					FileStream stream = new FileStream(btnUpload.Text, FileMode.Open, FileAccess.Read);
					BinaryReader reader = new BinaryReader(stream);
					file = reader.ReadBytes((int)stream.Length);
					reader.Close();
					stream.Close();
				}
				catch
				{
					file = (byte[])sanphamDAO.Instance.showFilebyID(tbMaBDS.Text).Rows[0]["GiayTo"];
					fileName = sanphamDAO.Instance.showFilebyID(tbMaBDS.Text).Rows[0]["FileName"].ToString();
				}
				*/
				sanphamDAO.Instance.suaDL(tbTrangThai.Text, tbDiaChi.Text, cbXa.Text, cbHuyen.Text, cbTinh.Text, tbLoaiBDS.Text, dtThoiGianXD.Text, tbTinhTrang.Text, tbPhapLy.Text, tbDienTichTrenSo.Text, tbDienTichSuDung.Text, tbMatTien.Text, tbDuongRong.Text, tbHuong.Text, tbSoTang.Text, tbThongTin.Text, tbGiaBDS.Text, "admin", tbMaBDS.Text);
				MessageBox.Show("Sửa Thành Công");
				//insert vao bang nhap hàng



			}
			catch (Exception)
			{

				MessageBox.Show("dữ liệu nhập thiếu hoặc không chính xác.!");
			}
			
			gvdata.DataSource = sanphamDAO.Instance.showsanpham();
		}

		private void PcDelete_Click(object sender, EventArgs e)
		{
			try
			{
				sanphamDAO.Instance.Xoa(tbMaBDS.Text);
				MessageBox.Show("xóa thành công");
				gvdata.DataSource = sanphamDAO.Instance.showsanpham();
			}
			catch (Exception)
			{

				MessageBox.Show("thất bại");
			}
		}

		private void PcSearch_Click(object sender, EventArgs e)
		{
			try
			{
				gvdata.DataSource = sanphamDAO.Instance.timkiem(tbTimKiem.Text, cbTimLoaiDat.Text);
			}
			catch (Exception)
			{

				MessageBox.Show("Lỗi..!");
			}
		}

		private void BtLamMoi_Click(object sender, EventArgs e)
		{
			gvdata.DataSource = sanphamDAO.Instance.showsanpham();
		}

        private void btnUpload_Click(object sender, EventArgs e)
        {
			String fileName = "";
			try
			{
				OpenFileDialog openFile = new OpenFileDialog();
				if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					fileName = openFile.FileName;
					//pbAnhThe.ImageLocation = fileName;
					//anhThe = openFile.FileName;
					//btnUpload.Text = fileName;
				}

			}
			catch (Exception)
			{

			}
		}

        private void btnTaiFile_Click(object sender, EventArgs e)
        {
			if(maBDS.Equals(""))
            {
				MessageBox.Show("Vui lòng click chọn sản phẩm trên danh sách..!");
				return;
			}
			String path = "";
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					DataTable dataTable = sanphamDAO.Instance.showFilebyID(maBDS);

					byte[] bytes = (byte[])dataTable.Rows[0]["GiayTo"];
					path = fbd.SelectedPath + "\\" + dataTable.Rows[0]["FileName"].ToString();
					File.WriteAllBytes(path, bytes.ToArray());
					MessageBox.Show("Đã lưu thành công file..!");

				}
			}
		}

        private void btnDuyetBai_Click(object sender, EventArgs e)
        {
			var windowHeight = btnDuyetBai.Top;
			var windowWidth = btnDuyetBai.Left;
			XetDuyet gD = new XetDuyet(tbMaBDS.Text);
			gD.StartPosition = FormStartPosition.Manual;
			gD.Location = new Point(windowWidth, windowHeight);
			gD.ShowDialog();
			this.Show();
		}

        private void cbTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
			try
            {
				DataRowView dataRowView = (DataRowView)cbTinh.SelectedValue;
				string key = dataRowView.Row.ItemArray[0].ToString();
				cbHuyen.DataSource = sanphamDAO.Instance.getHuyen(key);
				cbHuyen.DisplayMember = "_name";
				cbHuyen.ValueMember = "id";
			} catch
            {

				cbHuyen.DataSource = sanphamDAO.Instance.getHuyen(cbTinh.SelectedValue.ToString());
				cbHuyen.DisplayMember = "_name";
				cbHuyen.ValueMember = "id";
			}
			
		}

        private void cbHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
			try
			{
				DataRowView dataRowView = (DataRowView)cbTinh.SelectedValue;
				string keytinh = dataRowView.Row.ItemArray[0].ToString();

				DataRowView dataRowView1 = (DataRowView)cbTinh.SelectedValue;
				string keyHuyen = dataRowView1.Row.ItemArray[0].ToString();
				cbXa.DataSource = sanphamDAO.Instance.getXa(keytinh, keyHuyen);
				cbXa.DisplayMember = "_name";
				cbXa.ValueMember = "id";
			}
			catch
			{

				cbXa.DataSource = sanphamDAO.Instance.getXa(cbTinh.SelectedValue.ToString(), cbHuyen.SelectedValue.ToString());
				cbXa.DisplayMember = "_name";
				cbXa.ValueMember = "id";
			}
		}

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
			DataTable dataTable = sanphamDAO.Instance.showsanphambyID(tbMaBDS.Text);
			if(dataTable == null || dataTable.Rows.Count != 1)
            {
				MessageBox.Show("Vui lòng chọn sản phẩm cần xem.!");
				return;
            }
			ChiTietSanPham gD = new ChiTietSanPham(dataTable);
			gD.StartPosition = FormStartPosition.CenterParent;
			//gD.Location = new Point(windowWidth, windowHeight);
			gD.ShowDialog();
			this.Show();
		}

        private void tbThongTin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
