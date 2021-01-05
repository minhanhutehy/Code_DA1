using Quanlycuahangbangiay.Bussiness.Interface;
using Quanlycuahangbangiay.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.Bussiness
{
    class NhapGiaBan : GiaBanBLL
    {
        public ArrayList giabans = new ArrayList();
        public void Them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|               Nhập giá giầy                         |");
            Console.WriteLine("|_____________________________________________________|");
            Console.Write("|               Nhập mã giá bán: ");
            string maGiaBan=Console.ReadLine();
            Console.Write("|                mã giầy: ");
            string maGiay=Console.ReadLine();
            Console.Write("|                giá bán giầy: ");
            double giaBangiay=double.Parse(Console.ReadLine());
            Console.Write("|               Nhập đơn vị tính: ");
            string donvitinh = Console.ReadLine();
            Console.WriteLine(" _____________________________________________________");
            GiaBan gb = new GiaBan(maGiaBan, maGiay, giaBangiay, donvitinh);
            giabans.Add(gb);
            GiaBanDAL.Ghifile(giabans);
        }
        public void Hien()
        {
            Console.WriteLine("{0,15}|{1,15}|{2,20}|{3,20}","Ma gia ban","Ma giay","Gia ban giay","Don vi tinh");
            foreach(GiaBan gb in giabans)
            {
                Console.WriteLine("{0,15}|{1,15}|{2,20}|{3,20}", gb.MaGiaBan,gb.MaGiay,gb.GiaBangiay,gb.DonViTinh);
            }
        }
        public void Tim(string ma)
        {
            foreach (GiaBan gb in giabans)
            {
                if(ma.Equals(gb.MaGiay))
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", gb.MaGiaBan, gb.MaGiay, gb.GiaBangiay, gb.DonViTinh);
                }    
            }

        }
    }
}
