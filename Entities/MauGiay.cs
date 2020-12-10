using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class MauGiay
    {
        string maGiay;
        string tenGiay;
        int slNhapve;
        int slHienco;
        public MauGiay(string maGiay,string tenGiay,int slNhapve,int slHienco)
        {
            this.maGiay = maGiay;
            this.tenGiay = tenGiay;
            this.slNhapve = slNhapve;
            this.slHienco = slHienco;
        }
        override
            public string ToString()
        {
            return maGiay + ";" + tenGiay + ";" + slNhapve + ";" + slHienco;
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
        public string TenGiay
        {
            get
            {
                return TenGiay;
            }
            set
            {
                TenGiay = value;
            }
        }
        public int SlNhapve
        {
            get
            {
                return SlNhapve;
            }
            set
            {
                SlNhapve = value;
            }
        }
        public int SlHienco
        {
            get
            {
                return SlHienco;
            }
            set
            {
                SlHienco = value;
            }
        }
    }
}
