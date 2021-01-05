using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class ChiTietHoaDonNhap
    {
        string maCTHDN;
        string maHDN;
        string maGiay;
        int soLuong;
        double donGiaNhap;
        string vAT;

        public string MaCTHDN { get => maCTHDN; set => maCTHDN = value; }
        public string MaHDN { get => maHDN; set => maHDN = value; }
        public string MaGiay { get => maGiay; set => maGiay = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public string VAT { get => vAT; set => vAT = value; }

        public ChiTietHoaDonNhap(string maCTHDN, string maHDN, string maGiay, int soLuong, double donGiaNhap, string vAT)
        {
            MaCTHDN = maCTHDN;
            MaHDN = maHDN;
            MaGiay = maGiay;
            SoLuong = soLuong;
            DonGiaNhap = donGiaNhap;
            VAT = vAT;
        }
        override
            public string ToString()
        {
            return MaCTHDN+ ";" + MaHDN+ ";" + MaGiay+ ";" + SoLuong+ ";" + DonGiaNhap+ ";" + VAT;
        }
      
        public double ThanhTien(int SoLuong,double DongiaNhap)
        {
            return SoLuong * DongiaNhap;
        }
    }
}
