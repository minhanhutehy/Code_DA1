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
            this.MaGiaBan = maGiaBan;
            this.MaGiay = maGiay;
            this.GiaBangiay = giaBangiay;
            this.DonViTinh = donViTinh;
           
        }

        public string MaGiaBan { get => maGiaBan; set => maGiaBan = value; }
        public string MaGiay { get => maGiay; set => maGiay = value; }
        public double GiaBangiay { get => giaBangiay; set => giaBangiay = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }

        override
            public string ToString()
        {
            return MaGiaBan + ";" + MaGiay + ";" + GiaBangiay + ";" + DonViTinh;
        }
      
    }
}
