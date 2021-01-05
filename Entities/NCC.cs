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
            this.MaNCC = maNCC;
            this.TenNCC = tenNCC;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
        }

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }

        override
            public string ToString()
        {
            return MaNCC + ";" + TenNCC + ";" + DiaChi + ";" + Sdt;
        }
      
    }
}
