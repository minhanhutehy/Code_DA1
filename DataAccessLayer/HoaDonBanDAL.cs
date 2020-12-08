using Quanlycuahangbangiay.Bussiness;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class HoaDonBanDAL
    {
        public static ArrayList Docfile(ArrayList nhdb)
        {
            StreamReader streamReader = new StreamReader("HoaDonBan.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                nhdb.Add(new HoaDonBan(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], double.Parse(line.Split(';')[3])));

            }
            streamReader.Close();
            return nhdb;
        }
        public static void Ghifile(ArrayList nhdb)
        {
            StreamWriter streamWriter = new StreamWriter("HoaDonBan.txt");
            foreach (HoaDonBan hdb in nhdb)
            {
                streamWriter.WriteLine(hdb.ToString());
            }
            streamWriter.Close();
        }
    }
}
