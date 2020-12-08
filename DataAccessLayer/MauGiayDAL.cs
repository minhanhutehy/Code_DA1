using Quanlycuahangbangiay.Bussiness;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class MauGiayDAL
    {
        public static ArrayList Docfile(ArrayList ngm)
        {
            StreamReader streamReader = new StreamReader("MauGiay.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                ngm.Add(new MauGiay(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], int.Parse(line.Split(';')[3]), int.Parse(line.Split(';')[4])));

            }
            streamReader.Close();
            return ngm;
        }
        public static void Ghifile(ArrayList ngm)
        {
            StreamWriter streamWriter = new StreamWriter("MauGiay.txt");
            foreach (MauGiay mg in ngm)
            {
                streamWriter.WriteLine(mg.ToString());
            }
            streamWriter.Close();
        }
    }
}
