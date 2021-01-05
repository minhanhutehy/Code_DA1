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
            if (File.Exists("data/MauGiay.txt"))
            {
                StreamReader streamReader = new StreamReader("data/MauGiay.txt");
                string line;

                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line == " ") break;

                    ngm.Add(new MauGiay(line.Split(';')[0], line.Split(';')[1], int.Parse(line.Split(';')[2]), int.Parse(line.Split(';')[3])));

                }
                streamReader.Close();
            }
            return ngm;
        }
        public static void Ghifile(ArrayList ngm)
        {
            StreamWriter streamWriter = new StreamWriter("data/MauGiay.txt");
            foreach (MauGiay mg in ngm)
            {
                streamWriter.WriteLine(mg.ToString());
            }
            streamWriter.Close();
        }
    }
}
