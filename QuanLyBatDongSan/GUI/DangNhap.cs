using QuanLyBatDongSan.DAO;
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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

		private void Btnlogin_Click(object sender, EventArgs e)
		{
			if (dangnhapDAO.Dn.ktDangNhap(tbtaikhoan.Text, tbpass.Text))
			{
				biencucbo.taikhoan = tbtaikhoan.Text;
				biencucbo.loaitaikhoan = dangnhapDAO.Dn.quyenADMIN(tbtaikhoan.Text, tbpass.Text);
				Home gD = new Home();
				this.Hide();
				gD.ShowDialog();
				this.Show();
			}
			else
			{
				MessageBox.Show("Tên Tài khoản và mật khẩu không chính xác");
			}
		}
	}
}
