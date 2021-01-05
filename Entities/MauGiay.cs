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
            this.MaGiay = maGiay;
            this.TenGiay = tenGiay;
            this.SlNhapve = slNhapve;
            this.SlHienco = slHienco;
        }

        public string MaGiay { get => maGiay; set => maGiay = value; }
        public string TenGiay { get => tenGiay; set => tenGiay = value; }
        public int SlNhapve { get => slNhapve; set => slNhapve = value; }
        public int SlHienco { get => slHienco; set => slHienco = value; }

        override
            public string ToString()
        {
            return MaGiay + ";" + TenGiay + ";" + SlNhapve + ";" + SlHienco;
        }
       
    }
}
