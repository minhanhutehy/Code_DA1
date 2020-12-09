using Quanlycuahangbangiay.Bussiness.Interface;
using Quanlycuahangbangiay.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.Bussiness
{
    class NhapMauGiay:MauGiayBLL
    {
        public ArrayList maugiays = new ArrayList();
        public void Them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|                   Nhập mẫu giầy                     |");
            Console.WriteLine(" _____________________________________________________");
            Console.Write("|                   Nhập mã giầy: ");
            string magiay = Console.ReadLine();
            Console.Write("|                   Nhập tên giầy: ");
            string tengiay = Console.ReadLine();
            Console.Write("|                    số lượng nhập: ");
            int slNhap = int.Parse(Console.ReadLine());
            Console.Write("|                   Nhập số lượng hiện có: ");
            int slHienco = int.Parse(Console.ReadLine());
            Console.WriteLine(" _____________________________________________________");
            MauGiay mg = new MauGiay(magiay, tengiay, slNhap, slHienco);
            maugiays.Add(mg);
        }
        public void Hien()
        {
            Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,20}","Ma giay","Ten Giay","So luong nhap","So luong hien co");
            foreach(MauGiay mg in maugiays)
            {
                Console.WriteLine("{0,10}|{1,10}|{2,20}|{3,20}", mg.MaGiay, mg.TenGiay, mg.SlNhapve, mg.SlHienco);
            }    
        }
    }
}
