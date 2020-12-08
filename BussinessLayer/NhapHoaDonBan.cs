using Quanlycuahangbangiay.Bussiness.Interface;
using Quanlycuahangbangiay.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.Bussiness
{
    class NhapHoaDonBan:HoaDonBanBLL
    {
        public ArrayList hoadonbans = new ArrayList();
        public void Them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|                   Nhập hóa đơn bán                  |");
            Console.WriteLine(" _____________________________________________________");
            Console.Write("|                   Nhập mã hóa đơn bán: ");
            string maHDB=Console.ReadLine();
            Console.Write("|                   Nhập mã nhân viên bán: ");
            string maNVBan=Console.ReadLine();
            Console.Write("|                   Nhập ngày bán: ");
            string ngayBan=Console.ReadLine();
            Console.Write("|                   Nhập tổng tiền: "); 
            double tongTien=double.Parse(Console.ReadLine());
            Console.WriteLine(" _____________________________________________________");
            HoaDonBan hdb = new HoaDonBan(maHDB, maNVBan, ngayBan, tongTien);
            hoadonbans.Add(hdb);
        }
        public void Hien()
        {
            Console.WriteLine("{0,15}|{1,15}|{2,15}|{3,15}","Ma HDB","Ma NV ban","Ngay Ban","Tong Tien");
            foreach(HoaDonBan hdb in hoadonbans)
            {
                Console.WriteLine("{0,15}|{1,15}|{2,15}|{3,15}", hdb.MaHDB,hdb.MaNVBan,hdb.NgayBan,hdb.TongTien);
            }    
        }

    }
}
