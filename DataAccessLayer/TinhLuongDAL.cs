using Quanlycuahangbangiay.Bussiness;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class TinhLuongDAL
    {
        public static ArrayList Docfile(ArrayList arr)
        {
            StreamReader streamReader = new StreamReader("TinhLuong.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                arr.Add(new TinhLuong(line.Split(';')[0], line.Split(';')[1], double.Parse(line.Split(';')[2]), double.Parse(line.Split(';')[3]), double.Parse(line.Split(';')[4])));

            }
            streamReader.Close();
            return arr;
        }
        public static void Ghifile(ArrayList arr)
        {
            StreamWriter streamWriter = new StreamWriter("TinhLuong.txt");
            foreach (TinhLuong tl in arr)
            {
                streamWriter.WriteLine(tl.ToString());
            }
            streamWriter.Close();
        }
    }
}
