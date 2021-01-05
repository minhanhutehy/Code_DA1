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

        public string MaTL { get => maTL; set => maTL = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public double SoNgayLV { get => soNgayLV; set => soNgayLV = value; }
        public double Thuong { get => thuong; set => thuong = value; }
        public double LuongCoBan { get => luongCoBan; set => luongCoBan = value; }

        public TinhLuong(string maTL, string maNV, double soNgayLV, double thuong, double luongCoBan)
        {
            this.MaTL = maTL;
            this.MaNV = maNV;
            this.SoNgayLV = soNgayLV;
            this.Thuong = thuong;
            this.LuongCoBan = luongCoBan;
        }
        override
            public string ToString()
        {
            return MaTL + ";" + MaNV + ";" + SoNgayLV + ";" + Thuong + ";" + LuongCoBan;
        }
      
        public double TinhTien(double soNgayLV,double luongCoBan,double thuong)
        {
            return soNgayLV * luongCoBan + thuong;
        }
    }
}
