using Quanlycuahangbangiay.Bussiness;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class NhanVienDAL
    {
        public static ArrayList Docfile(ArrayList nv)
        {
            StreamReader streamReader = new StreamReader("NhanVien.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                nv.Add(new NhanVien(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], line.Split(';')[3], line.Split(';')[4], line.Split(';')[5]));

            }
            streamReader.Close();
            return nv;
        }
        public static void Ghifile(ArrayList nvt)
        {
            StreamWriter streamWriter = new StreamWriter("NhanVien.txt");
            foreach (NhanVien nv in nvt)
            {
                streamWriter.WriteLine(nv.ToString());
            }
            streamWriter.Close();
        }
    }
}
