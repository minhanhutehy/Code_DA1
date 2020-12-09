using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class HoaDonBan
    {
        string maHDB;
        string maNVBan;
        string ngayBan;
        double tongTien;
        public HoaDonBan(string maHDB, string maNVBan, string ngayBan, double tongTien)
        {
            this.maHDB = maHDB;
            this.maNVBan = maNVBan;
            this.ngayBan = ngayBan;
            this.tongTien = tongTien;
        }
        override
            public string ToString()
        {
            return maHDB + ";" + maNVBan + ";" + ngayBan + ";" + tongTien;
        }
        public string MaHDB
        {
            get
            {
                return MaHDBn;
            }
            set
            {
                MaHDB = value;
            }
        }
        public string MaNVBan
        {
            get
            {
                return MaNVBan;
            }
            set
            {
                MaNVBan = value;
            }
        }
        public string NgayBan
        {
            get
            {
                return NgayBan;
            }
            set
            {
                NgayBan = value;
            }
        }
        public double TongTien
        {
            get
            {
                return TongTien;
            }
            set
            {
                TongTien = value;
            }
        }
    }
}
