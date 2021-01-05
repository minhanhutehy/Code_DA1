using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class ChiTietHoaDonBan
    {
        string maCTHDB;
        string maHDB;
        string maGiay;
        int soLuong;
        double donGiaBan;
        string donViTinh;
        public ChiTietHoaDonBan(string maCTHDB,string maHDB,string maGiay,int soLuong,double donGiaBan,string donViTinh)
        {
            this.MaCTHDB = maCTHDB;
            this.MaHDB = maHDB;
            this.MaGiay = maGiay;
            this.SoLuong = soLuong;
            this.DonGiaBan = donGiaBan;
            this.DonViTinh = donViTinh;
        }
        public double ThanhTien()
        {
            return soLuong * donGiaBan;
        }
        public string MaCTHDB { get => maCTHDB; set => maCTHDB = value; }
        public string MaHDB { get => maHDB; set => maHDB = value; }
        public string MaGiay { get => maGiay; set => maGiay = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double DonGiaBan { get => donGiaBan; set => donGiaBan = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }

        override
            public string ToString()
        {
            return MaCTHDB + ";" + ";" + MaHDB+ ";"+ MaGiay+ ";" + SoLuong+ ";" + DonGiaBan+ ";" + DonViTinh;
        }
        
    }
}
