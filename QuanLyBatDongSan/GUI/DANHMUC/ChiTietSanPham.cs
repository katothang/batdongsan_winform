﻿using QuanLyBatDongSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Net.Http.Headers;

namespace QuanLyBatDongSan.GUI.DANHMUC
{
    public partial class ChiTietSanPham : Form
    {
        List<string> lstImage = new List<string>();
        int positionImg = 0;
        public ChiTietSanPham(DataTable dataTable)
        {
            InitializeComponent();
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            positionImg = 0;
            this.AutoScroll = true;
            lbMaDBS.Text = dataTable.Rows[0]["MaBDS"].ToString();
            lbTrangThai.Text = dataTable.Rows[0]["TrangThai"].ToString();
            lbDiaChi.Text = dataTable.Rows[0]["DiaChi"].ToString();
            lbTinh.Text = dataTable.Rows[0]["Tinh"].ToString();
            lbHuyen.Text = dataTable.Rows[0]["QuanHuyen"].ToString();
            lbPhuongXa.Text = dataTable.Rows[0]["PhuongXa"].ToString();
            lbLoaiBDS.Text = dataTable.Rows[0]["LoaiBDS"].ToString();
            lbThoiGian.Text = DateTime.Parse(dataTable.Rows[0]["ThoiGianXayDung"].ToString()).Year.ToString();
            lbTinhTrang.Text = dataTable.Rows[0]["TinhTrangHienTai"].ToString();
            lbPhapLy.Text = dataTable.Rows[0]["PhapLy"].ToString();
            lbDienTichTrenSO.Text = dataTable.Rows[0]["DienTichTrenSo"].ToString() + " m2";
            lbDienTichSuDung.Text = dataTable.Rows[0]["DienTichSuDung"].ToString() + " m2";
            lbMatTien.Text = dataTable.Rows[0]["MatTien"].ToString() + " m";
            lbDuong.Text = dataTable.Rows[0]["DuongRong"].ToString() + " m";
            lbHuong.Text = dataTable.Rows[0]["Huong"].ToString();
            lbSoTang.Text = dataTable.Rows[0]["SoTang"].ToString() + " Tầng";
            lbThongTin.Text = dataTable.Rows[0]["ThongTin"].ToString();

            lbGiaBDS.Text = dataTable.Rows[0]["Gia"].ToString();
            cbDSfile.DataSource = sanphamDAO.Instance.showFilebyID(lbMaDBS.Text);
            cbDSfile.DisplayMember = "FileName";
            cbDSfile.ValueMember = "id";
            lstImage = sanphamDAO.Instance.showListFilebyID(lbMaDBS.Text);


        }

        private void ChiTietSanPham_Load(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            String fileName = "";
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    fileName = System.IO.Path.GetFileName(openFile.FileName);
                    var confirmResult = MessageBox.Show(String.Format("Bạn có muốn upload file {0} ??", fileName),
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        byte[] file = null;

                            try
                            {
                                FileStream stream = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);
                                BinaryReader reader = new BinaryReader(stream);
                                file = reader.ReadBytes((int)stream.Length);
                                reader.Close();
                                stream.Close();
                            sanphamDAO.Instance.uploadFile(lbMaDBS.Text, fileName, file);
                            MessageBox.Show("upload thành công");
                            cbDSfile.DataSource = sanphamDAO.Instance.showFilebyID(lbMaDBS.Text);
                            cbDSfile.DisplayMember = "FileName";
                            cbDSfile.ValueMember = "id";

                        }
                            catch
                            {
                                MessageBox.Show("upload lỗi..!");
                            }
                        }
                    else
                    {
                        // If 'No', do something here.
                    }
                }

            }
            catch (Exception)
            {

            }
        }

        private void btnTaiVe_Click(object sender, EventArgs e)
        {
            if (cbDSfile.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn file cần download..!");
                return;
            }
            string keyFile = "";
            try
            {
                DataRowView dataRowView = (DataRowView)cbDSfile.SelectedValue;
                keyFile= dataRowView.Row.ItemArray[0].ToString();

            }
            catch
            {
                keyFile = cbDSfile.SelectedValue.ToString();
            }
            String path = "";
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    DataTable dataTable = sanphamDAO.Instance.getdownFilebyID(keyFile);

                    byte[] bytes = (byte[])dataTable.Rows[0]["GiayTo"];
                    path = fbd.SelectedPath + "\\" + dataTable.Rows[0]["FileName"].ToString();
                    File.WriteAllBytes(path, bytes.ToArray());
                    MessageBox.Show("Đã lưu thành công file..!");

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbDSfile.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn file cần xoá..!");
                return;
            }
            string keyFile = "";
            try
            {
                DataRowView dataRowView = (DataRowView)cbDSfile.SelectedValue;
                keyFile = dataRowView.Row.ItemArray[0].ToString();

            }
            catch
            {
                keyFile = cbDSfile.SelectedValue.ToString();
            }
            try
            {
                sanphamDAO.Instance.deleteFile(keyFile);
                MessageBox.Show("Xoá thành công.!");
                cbDSfile.DataSource = sanphamDAO.Instance.showFilebyID(lbMaDBS.Text);
                cbDSfile.DisplayMember = "FileName";
                cbDSfile.ValueMember = "id";
            }
            catch
            {
                MessageBox.Show("Lỗi Xoá file.!");
            }
            
        }

        private void cbDSfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string keyFile = "";
                try
                {
                    DataRowView dataRowView = (DataRowView)cbDSfile.SelectedValue;
                    keyFile = dataRowView.Row.ItemArray[0].ToString();

                }
                catch
                {
                    keyFile = cbDSfile.SelectedValue.ToString();
                }

                DataTable dataTable = sanphamDAO.Instance.getFile(keyFile);

                pcAnh.Image = byteArrayToImage((byte[])dataTable.Rows[0]["GiayTo"]);
            }
            catch
            {
                pcAnh.Image = null;
            }
            
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                returnImage = Image.FromStream(ms);
            }
            return returnImage;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lbTinhTrang_Click(object sender, EventArgs e)
        {

        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            try
            {
                if(lstImage.Count > 0)
                {
                    if (positionImg<= 0)
                    {
                        positionImg = lstImage.Count -1;
                    }
                    else
                    {
                        positionImg--;
                    }
                    DataTable dataTable = sanphamDAO.Instance.getFile(lstImage[positionImg]);

                    pcAnh.Image = byteArrayToImage((byte[])dataTable.Rows[0]["GiayTo"]);
                }
                
            }
            catch
            {

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstImage.Count > 0)
                {
                    if (positionImg >= lstImage.Count - 1)
                    {
                        positionImg = 0;
                    }
                    else
                    {
                        positionImg++;
                    }
                    DataTable dataTable = sanphamDAO.Instance.getFile(lstImage[positionImg]);

                    pcAnh.Image = byteArrayToImage((byte[])dataTable.Rows[0]["GiayTo"]);
                }

            }
            catch
            {

            }
        }
    }
}
