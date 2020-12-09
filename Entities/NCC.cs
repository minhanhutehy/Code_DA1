using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class NCC
    {
        string maNCC;
        string tenNCC;
        string diaChi;
        string sdt;
        public NCC(string maNCC,string tenNCC,string diaChi,string sdt)
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.diaChi = diaChi;
            this.sdt = sdt;
        }
        override
            public string ToString()
        {
            return maNCC + ";" + tenNCC + ";" + diaChi + ";" + sdt;
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
        public string TenNCC
        {
            get
            {
                return TenNCC;
            }
            set
            {
                TenNCC = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return DiaChi;
            }
            set
            {
                DiaChi = value;
            }
        }
        public string Sdt
        {
            get
            {
                return Sdt;
            }
            set
            {
                Sdt = value;
            }
        }
    }
}
