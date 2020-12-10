using Quanlycuahangbangiay.Bussiness.Interface;
using Quanlycuahangbangiay.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.Bussiness
{
    class NhapTinhLuong:TinhLuongBLL
    {
        public ArrayList tinhluongs = new ArrayList();
        public void Them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|                   Nhập nhân viên                    |");
            Console.WriteLine("|_____________________________________________________|");
            Console.Write("|                   Nhập mã tính lương: ");
            string matl = Console.ReadLine();
            Console.Write("|                   Nhập mã nhân viên: ");
            string manv = Console.ReadLine();
            Console.Write("|                   Nhập số ngày làm việc: ");
            double songaylv = double.Parse(Console.ReadLine());
            Console.Write("|                   Nhập số tiền thưởng: ");
            double thuong = double.Parse(Console.ReadLine());
            Console.Write("|                   Nhập lương cơ bản: ");
            double luongcb = double.Parse(Console.ReadLine());
            Console.WriteLine(" _____________________________________________________");
            TinhLuong tl = new TinhLuong(matl, manv, songaylv, thuong, luongcb);
            tinhluongs.Add(tl);
        }
        public void Hien()
        {
            Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}","Ma TL","Ma NV","So ngay LV","Thuong","Luong co ban","Thanh tien");
            foreach(TinhLuong tl in tinhluongs)
            {
                Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}", tl.MaTL,tl.MaNV,tl.SoNgayLV,tl.Thuong,tl.LuongCoBan,tl.TinhTien(tl.SoNgayLV, tl.Thuong, tl.LuongCoBan));
            }    
        }
        public void Tim(string ma)
        {
            foreach (TinhLuong tl in tinhluongs)
            {
                if(ma.Equals(tl.MaTL))
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", tl.MaTL, tl.MaNV, tl.SoNgayLV, tl.Thuong, tl.LuongCoBan, tl.TinhTien(tl.SoNgayLV, tl.Thuong, tl.LuongCoBan));
                }
            }
        }
    }
}
