using Quanlycuahangbangiay.Bussiness;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class NCCDAL
    {
        public static ArrayList Docfile(ArrayList ncc)
        {
            StreamReader streamReader = new StreamReader("NhaCungCap.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                ncc.Add(new NCC(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], line.Split(';')[3]));

            }
            streamReader.Close();
            return ncc;
        }
        public static void Ghifile(ArrayList ncc)
        {
            StreamWriter streamWriter = new StreamWriter("NhaCungCap.txt");
            foreach (NCC nc in ncc)
            {
                streamWriter.WriteLine(nc.ToString());
            }
            streamWriter.Close();
        }
    }
}
