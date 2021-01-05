using Quanlycuahangbangiay.Bussiness;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class CTHDNDAL
    {
        public static ArrayList Docfile(ArrayList cthdn)
        {
            if (File.Exists("data/CTHDN.txt")){
                StreamReader streamReader = new StreamReader("data/CTHDN.txt");
                string line;

                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line == " ") break;

                    cthdn.Add(new ChiTietHoaDonNhap(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], int.Parse(line.Split(';')[3]), double.Parse(line.Split(';')[4]), line.Split(';')[5]));

                } streamReader.Close();
            }
           
            return cthdn;

        }
        public static void Ghifile(ArrayList cthdn)
        {
            StreamWriter streamWriter = new StreamWriter("data/CTHDN.txt");
            foreach (ChiTietHoaDonNhap hdn in cthdn)
            {
                streamWriter.WriteLine(hdn.ToString());
            }
            streamWriter.Close();
        }
    }
}
