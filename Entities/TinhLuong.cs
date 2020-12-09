using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class TinhLuong
    {
        string maTL;
        string maNV;
        double soNgayLV;
        double thuong;
        double luongCoBan;
        public TinhLuong(string maTL, string maNV, double soNgayLV, double thuong, double luongCoBan)
        {
            this.maTL = maTL;
            this.MaNV = maNV;
            this.soNgayLV = soNgayLV;
            this.thuong = thuong;
            this.luongCoBan = luongCoBan;
        }
        override
            public string ToString()
        {
            return maTL + ";" + maNV + ";" + soNgayLV + ";" + thuong + ";" + luongCoBan;
        }
        public string MaTL
        {
            get
            {
                return MaTL;
            }
            set
            {
                MaTL = value;
            }
        }
        public string MaNV
        {
            get
            {
                return MaNV;
            }
            set
            {
                MaNV = value;
            }
        }
        public double SoNgayLV
        {
            get
            {
                return SoNgayLV;
            }
            set
            {
                SoNgayLV = value;
            }
        }
        public double Thuong
        {
            get
            {
                return Thuong;
            }
            set
            {
                Thuong = value;
            }
        }
        public double LuongCoBan
        {
            get
            {
                return LuongCoBan;
            }
            set
            {
                LuongCoBan = value;
            }
        }
        public double TinhTien(double soNgayLV,double luongCoBan,double thuong)
        {
            return soNgayLV * luongCoBan + thuong;
        }
    }
}
