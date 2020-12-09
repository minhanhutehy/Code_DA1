using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class GiaBan
    {
        string maGiaBan;
        string maGiay;
        double giaBangiay;
        string donViTinh;
        public GiaBan(string maGiaBan,string maGiay, double giaBangiay,string donViTinh)
        {
            this.maGiaBan = maGiaBan;
            this.maGiay = maGiay;
            this.giaBangiay = giaBangiay;
            this.donViTinh = donViTinh;
           
        }
        override
            public string ToString()
        {
            return maGiaBan + ";" + maGiay + ";" + giaBangiay + ";" + donViTinh;
        }
        public string MaGiaBan
        {
            get
            {
                return MaGiaBan;
            }
            set
            {
                MaGiaBan = value;
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
        public double GiaBangiay
        {
            get
            {
                return GiaBangiay;
            }
            set
            {
                GiaBangiay = value;
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
    }
}
