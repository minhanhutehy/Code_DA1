using Quanlycuahangbangiay.Bussiness;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class GiaBanDAL
    {
        public static ArrayList Docfile(ArrayList ngb)
        {
            StreamReader streamReader = new StreamReader("GiaBan.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                ngb.Add(new GiaBan(line.Split(';')[0], line.Split(';')[1], double.Parse(line.Split(';')[2]), line.Split(';')[3]));

            }
            streamReader.Close();
            return ngb;
        }
        public static void Ghifile(ArrayList ngb)
        {
            StreamWriter streamWriter = new StreamWriter("GiaBan.txt");
            foreach (GiaBan gb in ngb)
            {
                streamWriter.WriteLine(gb.ToString());
            }
            streamWriter.Close();
        }
    }
}
