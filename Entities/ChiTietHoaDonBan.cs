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
            this.maCTHDB = maCTHDB;
            this.maHDB = maHDB;
            this.maGiay = maGiay;
            this.soLuong = soLuong;
            this.donGiaBan = donGiaBan;
            this.donViTinh = donViTinh;
        }
        override
            public string ToString()
        {
            return maCTHDB + ";" + ";" + maHDB+ ";"+ maGiay+ ";" + soLuong+ ";" + donGiaBan+ ";" + donViTinh;
        }
        public string MaCTHDB 
        {
            get
            {
                return maCTHDB;
            }
            set
            {
                maCTHDB = value;
            }
        }
        public string MaHDB
        {
            get
            {
                return maHDB;
            }
            set
            {
                maHDB = value;
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
        public double DonGiaBan
        {
            get
            {
                return DonGiaBan;
            }
            set
            {
                DonGiaBan = value;
            }
        }
        public string DonViTinh
        {
            get
            {
                return DonViTinh;
            }
            set
            {
                DonViTinh = value;
            }
        }
        public double ThanhTien(int soLuong,double donGiaBan)
        {
            return soLuong * donGiaBan;
        }
    }
}
