using QuanLyBatDongSan.DAO;
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
    public partial class XetDuyet : Form
    {
        string maBDS = "";
        public XetDuyet(String maBDS)
        {
            this.maBDS = maBDS;
            InitializeComponent();
            cbTrangThai.SelectedIndex = 1;
            lbTieuDe.Text = "Xét duyệt cho bài đăng có mã " + maBDS;
        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if("Trả Về".Equals(cbTrangThai.Text))
            {
                lbLyDo.Visible = true;
                tbLyDo.Visible = true;
            }
            else
            {
                lbLyDo.Visible = false;
                tbLyDo.Visible = false;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!"Trả Về".Equals(cbTrangThai.Text))
            {
                tbLyDo.Text = "";
            }
            
            sanphamDAO.Instance.duyetbai(maBDS, cbTrangThai.Text, tbLyDo.Text);
            MessageBox.Show("Sửa trạng thái thành công");
        }
    }
}
