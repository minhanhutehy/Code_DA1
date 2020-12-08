using Quanlycuahangbangiay.Bussiness.Interface;
using Quanlycuahangbangiay.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.Bussiness
{
    class NhapNCC:NCCBLL
    {
        public ArrayList nccs = new ArrayList();
        public void Them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|                   Nhập nhà cung cấp                 |");
            Console.WriteLine(" _____________________________________________________");
            Console.Write("|                   Nhập mã nhà cung cấp: ");
            string mancc = Console.ReadLine();
            Console.Write("|                   Nhập tên nhà cung cấp: ");
            string tenncc = Console.ReadLine();
            Console.Write("|                   Nhập địa chỉ: ");
            string diachi = Console.ReadLine();
            Console.Write("|                   Nhập số điện thoại: ");
            string sdt = Console.ReadLine();
            Console.WriteLine(" _____________________________________________________");
            NCC nc = new NCC(mancc, tenncc, diachi, sdt);
            nccs.Add(nc);
        }
        public void Hien()
        {
            Console.WriteLine("{0,10}|{1,25}|{2,30}|{3,15}", "Ma NCC","TenNCC","Dia chi", "So dien thoai");
            foreach(NCC nc in nccs)
            {
                Console.WriteLine("{0,10}|{1,25}|{2,30}|{3,15}", nc.MaNCC, nc.TenNCC, nc.DiaChi, nc.Sdt);
            }    
        }
    }
}
