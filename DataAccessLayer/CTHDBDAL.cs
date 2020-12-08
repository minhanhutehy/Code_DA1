using Quanlycuahangbangiay.Bussiness;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class CTHDBDAL
    {
        public static ArrayList Docfile(ArrayList cthdb)
        {
            StreamReader streamReader = new StreamReader("CTHDB.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                cthdb.Add(new ChiTietHoaDonBan(line.Split(";")[0], line.Split(";")[1], line.Split(";")[2], int.Parse(line.Split(";")[3]), double.Parse(line.Split(";")[4]), line.Split(";")[5]));

            }
            streamReader.Close();
            return cthdb;
            
        }
        public static void Ghifile(ArrayList cthdb)
        {
            StreamWriter streamWriter = new StreamWriter("CTHDB.txt");
            foreach (ChiTietHoaDonBan hdb in cthdb)
            {
                streamWriter.WriteLine(hdb.ToString());
            }
            streamWriter.Close();
        }
    }
}
