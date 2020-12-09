using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class HoaDonNhap
    {
        string maHDN;
        string maNCC;
        string nvGiao;
        string maNvNhan;
        string ngayNhan;
        double tongTien;
        string trangThai;
        double daTT;
        double conNo;
        string ghiChu;
        public HoaDonNhap(string maHDN, string maNCC, string nvGiao, string maNvNhan,string ngayNhan,double tongTien, string trangThai, double daTT, double conNo,string ghiChu)
        {
            this.maHDN = maHDN;
            this.maNCC = maNCC;
            this.nvGiao = nvGiao;
            this.maNvNhan = maNvNhan;
            this.ngayNhan = ngayNhan;
            this.tongTien = tongTien;
            this.trangThai = trangThai;
            this.daTT = daTT;
            this.conNo = conNo;
            this.ghiChu = ghiChu;
        }
        override
            public string ToString()
        {
            return maHDN + ";" + maNCC + ";" + nvGiao + ";" + maNvNhan + ";" + ngayNhan + ";" + tongTien + ";" + trangThai + ";" + daTT + ";" + conNo + ";" + ghiChu;
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
        public string MaNCC
        {
            get
            {
                return MaNCC;
            }
            set
            {
                MaNCC = value;
            }
        }
        public string NvGiao
        {
            get
            {
                return MaNvGiao;
            }
            set
            {
                MaNvGiao = value;
            }
        }
        public string MaNvNhan
        {
            get
            {
                return MaNvNhan;
            }
            set
            {
                MaNvNhan = value;
            }
        }
        public string NgayNhan
        {
            get
            {
                return NgayNhan;
            }
            set
            {
                NgayNhan = value;
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
        public string TrangThai
        {
            get
            {
                return TrangThai;
            }
            set
            {
                TrangThai = value;
            }
        }
        public double DaTT
        {
            get
            {
                return DaTT;
            }
            set
            {
                DaTT = value;
            }
        }
        public double ConNo
        {
            get
            {
                return ConNo;
            }
            set
            {
                ConNo = value;
            }
        }
        public string GhiChu
        {
            get
            {
                return GhiChu;
            }
            set
            {
                GhiChu = value;
            }
        }
    }
}
