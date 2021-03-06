using QuanLyBatDongSan.DTO;
using QuanLyBatDongSan.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyBatDongSan.DAO
{
    class sanphamDAO
    {
        private static sanphamDAO instance;

        public static sanphamDAO Instance
        {
            get { if (instance == null) instance = new sanphamDAO(); return sanphamDAO.instance; }
            private set { sanphamDAO.instance = value; }
        }

        public DataTable showsanpham()
        {
            DataTable dataTable = new DataTable();
            string query = "select MaBDS, TrangThai,DiaChi,tinh, QuanHuyen, PhuongXa,LoaiBDS,ThoiGianXayDung,TinhTrangHienTai,PhapLy,DienTichTrenSo,DienTichSuDung,MatTien,DuongRong,Huong,SoTang,ThongTin,Gia,NguoiDang,TrangThaiBaiDang, LyDoTraVe  from BATDONGSAN";
            if(!biencucbo.loaitaikhoan.Equals("admin"))
            {
                query = String.Format("select MaBDS, TrangThai,DiaChi,tinh, QuanHuyen, PhuongXa,LoaiBDS,ThoiGianXayDung,TinhTrangHienTai,PhapLy,DienTichTrenSo,DienTichSuDung,MatTien,DuongRong,Huong,SoTang,ThongTin,Gia,NguoiDang,TrangThaiBaiDang, LyDoTraVe  from BATDONGSAN where TrangThaiBaiDang = N'Duyệt' OR NguoiDang = '{0}'", biencucbo.taikhoan);
            } 
            dataTable = SQLconnect.Instance.ExecuteQuery(query);
            return dataTable;
        }

        public DataTable showsanphambyID(String maBDS)
        {
            string query = String.Format("select * from BATDONGSAN where MaBDS='{0}'", maBDS);
            
            return SQLconnect.Instance.ExecuteQuery(query);
        }

        public DataTable showFilebyID(string id)
        {
            string query = "select id, MaBDS,FileName,GiayTo from FileUpload where MaBDS='" + id+"'";
            return SQLconnect.Instance.ExecuteQuery(query);
        }

        public DataTable getdownFilebyID(string id)
        {
            string query = "select * from FileUpload where id='" + id + "'";
            return SQLconnect.Instance.ExecuteQuery(query);
        }

        public void deleteFile(string id)
        {
            string query = "delete FROM  FileUpload where id='" + id + "'";
            SQLconnect.Instance.ExecuteNonQuery(query);
        }

        public DataTable getFile(string id)
        {
            string query = "select * FROM  FileUpload where id='" + id + "'";
            return SQLconnect.Instance.ExecuteQuery(query);
        }
        public int themDL(string MaBDS, string TrangThai, string DiaChi, string PhuongXa, string QuanHuyen, string tinh, string LoaiBDS, string ThoiGianXayDung, string TinhTrangHienTai, string PhapLy,string DienTichTrenSo, string DienTichSuDung, string MatTien, string DuongRong, string Huong, string SoTang, string ThongTin, string Gia, string NguoiDang)
        {
            Gia = string.Format("{0:0,0} VNĐ", Decimal.Parse(Gia), System.Globalization.NumberStyles.Any);
            string query = string.Format("INSERT INTO BATDONGSAN(MaBDS, TrangThai,DiaChi,PhuongXa,QuanHuyen,LoaiBDS,ThoiGianXayDung,TinhTrangHienTai,PhapLy,DienTichTrenSo,DienTichSuDung,MatTien,DuongRong,Huong,SoTang,ThongTin,Gia,NguoiDang, tinh, TrangThaiBaiDang) values('{18}',N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}','{8}','{9}', '{10}', '{11}', '{12}', '{13}', N'{14}', '{15}', '{16}', N'{17}', N'Chưa Duyệt')", TrangThai, DiaChi, PhuongXa, QuanHuyen, LoaiBDS, ThoiGianXayDung, TinhTrangHienTai, PhapLy, DienTichTrenSo, DienTichSuDung, MatTien, DuongRong, Huong, SoTang, ThongTin, Gia, NguoiDang, tinh, MaBDS);
            return SQLconnect.Instance.ExecuteNonQuery(query);

        }

        public int suaDL(string TrangThai, string DiaChi, string PhuongXa, string QuanHuyen, string tinh, string LoaiBDS, string ThoiGianXayDung, string TinhTrangHienTai, string PhapLy, string DienTichTrenSo, string DienTichSuDung, string MatTien, string DuongRong, string Huong, string SoTang, string ThongTin, string Gia, string NguoiDang, string maBDS)
        {
            Gia = string.Format("{0:0,0} VNĐ", Decimal.Parse(Gia), System.Globalization.NumberStyles.Any);
            string query = string.Format("update BATDONGSAN SET TrangThai = N'{0}', DiaChi = N'{1}', PhuongXa = N'{2}', QuanHuyen = N'{3}', LoaiBDS = N'{4}', ThoiGianXayDung = '{5}', TinhTrangHienTai = N'{6}', PhapLy = N'{7}', DienTichTrenSo = '{8}', DienTichSuDung = '{9}', MatTien = '{10}', DuongRong = '{11}', Huong = N'{12}', SoTang = '{13}', ThongTin = N'{14}', Gia = '{15}', tinh = N'{16}' where MaBDS = '{17}'", TrangThai, DiaChi, PhuongXa, QuanHuyen, LoaiBDS, ThoiGianXayDung, TinhTrangHienTai, PhapLy, DienTichTrenSo, DienTichSuDung, MatTien, DuongRong, Huong, SoTang, ThongTin, Gia, tinh, maBDS);
            return SQLconnect.Instance.ExecuteNonQuery(query);

        }
        public void Xoa(string MaBDS)
        {
            string query = string.Format("delete BATDONGSAN where MaBDS='{0}'", MaBDS);
            SQLconnect.Instance.ExecuteNonQuery(query);
        }

        public int duyetbai(string maBDS, string tinhtrang, string lydo)
        {
            string query = string.Format("update BATDONGSAN SET TrangThaiBaiDang = N'{1}', LyDoTraVe = N'{2}' where MaBDS = '{0}'", maBDS, tinhtrang, lydo);
            return SQLconnect.Instance.ExecuteNonQuery(query);

        }

        public DataTable timkiem(string noidung, String loaidat)
        {
            string query = string.Format("select MaBDS, TrangThai,DiaChi,tinh, QuanHuyen, PhuongXa,LoaiBDS,ThoiGianXayDung,TinhTrangHienTai,PhapLy,DienTichTrenSo,DienTichSuDung,MatTien,DuongRong,Huong,SoTang,ThongTin,Gia,NguoiDang,TrangThaiBaiDang, LyDoTraVe from BATDONGSAN where (MaBDS like '{0}' OR  TrangThai like '{0}' OR DiaChi like '{0}' OR PhuongXa like '{0}' OR QuanHuyen like '{0}' OR LoaiBDS like '{0}' OR ThoiGianXayDung like '{0}' OR TinhTrangHienTai like '{0}' OR PhapLy like '{0}' OR DienTichTrenSo like '{0}' OR DienTichSuDung like '{0}' OR MatTien like '{0}' OR DuongRong like '{0}' OR Huong like '{0}' OR SoTang like '{0}' OR ThongTin like '{0}' OR Gia like '{0}') and LoaiBDS = N'{1}'", noidung, loaidat);

            if (!biencucbo.loaitaikhoan.Equals("admin"))
            {
                query = string.Format("select MaBDS, TrangThai,DiaChi,tinh, QuanHuyen, PhuongXa,LoaiBDS,ThoiGianXayDung,TinhTrangHienTai,PhapLy,DienTichTrenSo,DienTichSuDung,MatTien,DuongRong,Huong,SoTang,ThongTin,Gia,NguoiDang,TrangThaiBaiDang, LyDoTraVe from BATDONGSAN where (TrangThaiBaiDang = N'Duyệt' OR NguoiDang = '{1}') AND LoaiBDS = N'{2}'  AND (MaBDS like '{0}' OR  TrangThai like '{0}' OR DiaChi like '{0}' OR PhuongXa like '{0}' OR QuanHuyen like '{0}' OR LoaiBDS like '{0}' OR ThoiGianXayDung like '{0}' OR TinhTrangHienTai like '{0}' OR PhapLy like '{0}' OR DienTichTrenSo like '{0}' OR DienTichSuDung like '{0}' OR MatTien like '{0}' OR DuongRong like '{0}' OR Huong like '{0}' OR SoTang like '{0}' OR ThongTin like '{0}' OR Gia like '{0}')", noidung, biencucbo.taikhoan, loaidat);
            }
            return SQLconnect.Instance.ExecuteQuery(query);
        }

        public DataTable getTinh()
        {
            string query = "SELECT * FROM province";
            return SQLconnect.Instance.ExecuteQuery(query);
        }

        public DataTable getHuyen(string id)
        {
            string query = String.Format("SELECT * FROM district where _province_id = '{0}'", id);
            return SQLconnect.Instance.ExecuteQuery(query);
        }


        public DataTable getXa(string idTinh, string idHuyen)
        {
            string query = String.Format("SELECT * FROM ward where _province_id = '{0}' and _district_id = '{1}'", idTinh, idHuyen);
            return SQLconnect.Instance.ExecuteQuery(query);
        }

        public void uploadFile(string maBDS, string fileName, byte[] data)
        {
            string query = String.Format("insert into FileUpload(MaBDS, FileName, GiayTo) values(N'{0}', N'{1}', @File)", maBDS, fileName);
            SQLconnect.Instance.ExecuteSaveFileBDS(query, data);
        }


    }
}
