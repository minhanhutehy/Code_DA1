using Quanlycuahangbangiay.Bussiness;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class HoaDonNhapDAL
    {
        public static ArrayList Docfile(ArrayList nhdn)
        {
            if (File.Exists("data/HoaDonNhap.txt"))
            {
                StreamReader streamReader = new StreamReader("data/HoaDonNhap.txt");
                string line;

                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line == " ") break;

                    nhdn.Add(new HoaDonNhap(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], line.Split(';')[3], line.Split(';')[4], double.Parse(line.Split(';')[5]), line.Split(';')[6], double.Parse(line.Split(';')[7]), double.Parse(line.Split(';')[8]), line.Split(';')[9]));
                }
                streamReader.Close();
            }
            return nhdn;
        }
        public static void Ghifile(ArrayList nhdn)
        {
            StreamWriter streamWriter = new StreamWriter("data/HoaDonNhap.txt");
            foreach (HoaDonNhap hdn in nhdn)
            {
                streamWriter.WriteLine(hdn.ToString());
            }
            streamWriter.Close();
        }
    }
}
