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
        public ChiTietHoaDonNhap(string maCTHDN, string maHDN, string maGiay, int soLuong, double donGiaNhap, string vAT)
        {
            this.maCTHDN = maCTHDN;
            this.maHDN = maHDN;
            this.maGiay = maGiay;
            this.soLuong = soLuong;
            this.donGiaNhap = donGiaNhap;
            this.vAT = vAT;
        }
        override
            public string ToString()
        {
            return maCTHDN+ ";" + maHDN+ ";" + maGiay+ ";" + soLuong+ ";" + donGiaNhap+ ";" + vAT;
        }
        public string MaCTHDN
        {
            get
            {
                return MaCTHDN;
            }
            set
            {
                MaCTHDN = value;
            }
        }
        public string MaHDN
        {
            get
            {
                return MaHDN;
            }
            set
            {
                MaHDN = value;
            }
        }
        public string MaGiay
        {
            get
            {
                return MaGiay;
            }
            set
            {
                MaGiay = value;
            }
        }
        public int SoLuong
        {
            get
            {
                return SoLuong;
            }
            set
            {
                SoLuong = value;
            }
        }
        public double DonGiaNhap
        {
            get
            {
                return DonGiaNhap;
            }
            set
            {
                DonGiaNhap = value;
            }
        }
        public string VAT
        {
            get
            {
                return VAT;
            }
            set
            {
                VAT = value;
            }
        }

        public double ThanhTien(int SoLuong,double DongiaNhap)
        {
            return SoLuong * DongiaNhap;
        }
    }
}
