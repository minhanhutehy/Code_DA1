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
        public string MaGiay { get => maGiay; set => maGiay = value; }
        public string TenGiay { get => tenGiay; set => tenGiay = value; }
        public int SlNhapve { get => slNhapve; set => slNhapve = value; }
        public int SlHienco { get => slHienco; set => slHienco = value; }
    }
}
