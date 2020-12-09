using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class NhanVien
    {
        string maNV;
        string tenNV;
        string ngaySinh;
        string gioiTinh;
        string ngayVaoLV;
        string loaiNV;
        public NhanVien(string maNV,string tenNV,string ngaySinh,string gioiTinh,string ngayVaoLV,string loaiNV)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.ngayVaoLV = ngayVaoLV;
            this.loaiNV = loaiNV;
        }
        override
            public string ToString()
        {
            return maNV + ";" + tenNV + ";" + ngaySinh + ";" + gioiTinh + ";" + ngayVaoLV + ";" + loaiNV;
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
        public string TenNV
        {
            get
            {
                return TenNV;
            }
            set
            {
                TenNV = value;
            }
        }
        public string NgaySinh
        {
            get
            {
                return NgaySinh;
            }
            set
            {
                NgaySinh = value;
            }
        }
        public string GioiTinh
        {
            get
            {
                return GioiTinh;
            }
            set
            {
                GioiTinh = value;
            }
        }
        public string NgayVaoLV
        {
            get
            {
                return NgayVaoLV;
            }
            set
            {
                NgayVaoLV = value;
            }
        }
        public string LoaiNV
        {
            get
            {
                return LoaiNV;
            }
            set
            {
                LoaiNV = value;
            }
        }
    }
}
