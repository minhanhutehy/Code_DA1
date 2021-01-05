using Quanlycuahangbangiay.Bussiness;
using Quanlycuahangbangiay.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.View
{
    class frmQuanLyCuaHangGiay
    {
        public static int Menu()
        {
            Console.WriteLine("                      __________________________________________");
            Console.WriteLine("                     |         QUẢN LÝ CỬA HÀNG GIÀY           |");
            Console.WriteLine("                     |_________________________________________|");
            Console.WriteLine("                     |        1. Quản lý mẫu giày              |");
            Console.WriteLine("                     |        2. Quản lý nhà cung cấp          |");
            Console.WriteLine("                     |        3. Quản lý nhân viên             |");
            Console.WriteLine("                     |        4. Quản lý tính lương            |");
            Console.WriteLine("                     |        5. Quản lý giá bán               |");
            Console.WriteLine("                     |        6. Quản lý hóa đơn nhập          |");
            Console.WriteLine("                     |        7. Chi tiết hóa đơn nhập         |");
            Console.WriteLine("                     |        8. Quản lý hóa đơn bán           |");
            Console.WriteLine("                     |        9. Chi tiết hóa đơn bán          |");
            Console.WriteLine("                     |       10. Thoát                         |");
            Console.WriteLine("                     |_________________________________________|");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 11));
            return n;
        }
        public static int MenuMG()
        {
            Console.WriteLine("                      _______________________________");
            Console.WriteLine("                     |      1. Thêm mẫu giày         |");
            Console.WriteLine("                     |      2. Hiện các mẫu giày     |");
            Console.WriteLine("                     |      3. Quay lại              |");
            Console.WriteLine("                     |_______________________________|");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 2));
            return n;
        }
        public static int MenuNCC()
        {
            Console.WriteLine("                      ___________________________________");
            Console.WriteLine("                     |      1. Thêm nhà cung cấp         |");
            Console.WriteLine("                     |      2. Hiện tất cả nhà cung cấp  |");
            Console.WriteLine("                     |      3. Quay lại                  |");
            Console.WriteLine("                     |___________________________________|");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 2));
            return n;
        }
        public static int MenuNhanVien()
        {
            Console.WriteLine("                      ___________________________________");
            Console.WriteLine("                     |       1. Thêm nhân viên           |");
            Console.WriteLine("                     |       2. Hiện nhân viên           |");
            Console.WriteLine("                     |       3. Xóa nhân viên            |");
            Console.WriteLine("                     |       4. Tìm nhân viên            |");
            Console.WriteLine("                     |       5. Sửa nhân viên            |");
            Console.WriteLine("                     |       6. Quay lại                 |");
            Console.WriteLine("                     |___________________________________|");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 5));
            return n;
        }
        public static int MenuTinhLuong()
        {
            Console.WriteLine("                      ______________________________________");
            Console.WriteLine("                     |     1. Thêm hóa đơn tính lương       |");
            Console.WriteLine("                     |     2. Hiện hóa đơn tính lương       |");
            Console.WriteLine("                     |     3. Tìm hóa đơn                   |");
            Console.WriteLine("                     |     4. Quay lại                      |");
            Console.WriteLine("                     |______________________________________|");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 3));
            return n;
        }
        public static int MenuGiaBan()
        {
            Console.WriteLine("                      ______________________________________");
            Console.WriteLine("                     |           1. Thêm giá giầy           |");
            Console.WriteLine("                     |           2. Hiện giá giầy           |");
            Console.WriteLine("                     |           3. Tìm giá giầy            |");
            Console.WriteLine("                     |           4. Quay lại                |");
            Console.WriteLine("                     |______________________________________|");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 3));
            return n;
        }
        public static int MenuHDN()
        {
            Console.WriteLine("                      ______________________________________");
            Console.WriteLine("                     |        1. Thêm hóa đơn nhập          |");
            Console.WriteLine("                     |        2. Hiện hóa đơn nhập          |");
            Console.WriteLine("                     |        3. Quay lại                   |");
            Console.WriteLine("                     |______________________________________|");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 2));
            return n;
        }
        public static int MenuCTHDN()
        {
            Console.WriteLine("                      ______________________________________");
            Console.WriteLine("                     |    1. Thêm chi tiết hóa đơn nhập     |");
            Console.WriteLine("                     |    2. Hiện chi tiết hóa đơn nhập     |");
            Console.WriteLine("                     |    3. Quay lại                       |");
            Console.WriteLine("                     |______________________________________|");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 2));
            return n;
        }
        public static int MenuHDB()
        {
            Console.WriteLine("                      _______________________________________");
            Console.WriteLine("                     |         1. Thêm hóa đơn bán          |");
            Console.WriteLine("                     |         2. Hiện hóa đơn bán          |");
            Console.WriteLine("                     |         3. Quay lại                  |");
            Console.WriteLine("                     |______________________________________|");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 2));
            return n;
        }
        public static int MenuCTHDB()
        {
            Console.WriteLine("                      _______________________________________");
            Console.WriteLine("                     |    1. Thêm chi tiết hóa đơn ban      |");
            Console.WriteLine("                     |    2. Hiện chi tiết hóa đơn ban      |");
            Console.WriteLine("                     |    3. Quay lại                       |");
            Console.WriteLine("                     |______________________________________|");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 2));
            return n;
        }

        public static void View()
        {
            int chon;
            do
            {
                switch (Menu())
                {
                    
                    case 1:
                        Console.Clear();
                        do
                        {

                            chon = MenuMG();
                            switch (chon)
                            {
                                case 1:
                                    Console.Clear();
                                    nmg.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    nmg.Hien();
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 2);
                        break;
                    case 2:
                        Console.Clear();
                        do
                        {

                            chon = MenuNCC();
                            switch (chon)
                            {
                                case 1:
                                    Console.Clear();
                                    ncc.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    ncc.Hien();
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 2);
                        break;
                    case 3:
                        Console.Clear();
                        do
                        {
                            chon = MenuNhanVien();

                            switch (chon)
                            {
                                case 1:
                                    Console.Clear();
                                    nnv.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    nnv.Hien();
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.Write("Nhập mã nhân viên cần tìm: ");
                                    string name = Console.ReadLine();
                                    nnv.Tim(name);
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.Write("Nhập mã nhân viên cần xóa: ");
                                    string ma = Console.ReadLine();
                                    nnv.Xoa(ma);

                                    Console.ReadKey();
                                    break;
                                case 5:
                                    Console.Clear();
                                    Console.Write("Nhập mã nhân viên cần sửa: ");
                                    string ma2 = Console.ReadLine();
                                    nnv.Sua(ma2);
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 5);
                        break;
                    case 4:
                        Console.Clear();
                        do
                        {
                            chon = MenuTinhLuong();
                            switch (chon)
                            {
                                case 1:
                                    Console.Clear();
                                    tl.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    tl.Hien();
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.Write("Nhập mã tính lương cần tìm: ");
                                    string ma = Console.ReadLine();
                                    tl.Tim(ma);
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 3);
                        break;
                    case 5:
                        Console.Clear();
                        do
                        {

                            chon = MenuGiaBan();
                            switch (chon)
                            {
                                case 1:
                                    Console.Clear();
                                    ngb.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    ngb.Hien();
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.Write("Nhập mã giầy cần tìm giá: ");
                                    string ma = Console.ReadLine();
                                    ngb.Tim(ma);
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 3);
                        break;
                    case 6:
                        Console.Clear();
                        do
                        {

                            chon = MenuHDN();
                            switch (chon)
                            {
                                case 1:
                                    Console.Clear();
                                    nhdn.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    nhdn.Hien();
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 2);
                        break;
                    case 7:
                        Console.Clear();
                        do
                        {
                            chon = MenuCTHDN();

                            switch (chon)
                            {
                                case 1:
                                    Console.Clear();
                                    cthdn.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    cthdn.Hien();
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 2);
                        break;
                    case 8:
                        Console.Clear();
                        do
                        {
                            chon = MenuHDB();
                            switch (chon)
                            {
                                case 1:
                                    Console.Clear();
                                    nhdb.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    nhdb.Hien();
                                    Console.ReadKey();
                                    break;

                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 2);
                        break;
                    case 9:
                        Console.Clear();
                        do
                        {
                            chon = MenuCTHDB();
                            switch (chon)
                            {
                                case 1:
                                    Console.Clear();
                                    cthdb.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    cthdb.Hien();
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 2);
                        break;
                    case 10:
                        System.Environment.Exit(0);
                        break;
                }
                Console.Clear();
            } while (true);
        }
       
        public static NhapMauGiay nmg = new NhapMauGiay();
        public static NhapNCC ncc = new NhapNCC();
        public static NhapNhanVien nnv = new NhapNhanVien();
        public static NhapGiaBan ngb = new NhapGiaBan();
        public static NhapHoaDonNhap nhdn = new NhapHoaDonNhap();
        public static NhapCTHDN cthdn = new NhapCTHDN();
        public static NhapHoaDonBan nhdb = new NhapHoaDonBan();
        public static NhapCTHDB cthdb = new NhapCTHDB();
        public static NhapTinhLuong tl = new NhapTinhLuong();
        public static void DocAllFile()
        {
            CTHDBDAL.Docfile(cthdb.cthdbs);
            CTHDNDAL.Docfile(cthdn.cthdns);
            GiaBanDAL.Docfile(ngb.giabans);
            HoaDonBanDAL.Docfile(nhdb.hoadonbans);
            HoaDonNhapDAL.Docfile(nhdn.hoadonnhaps);
           
            MauGiayDAL.Docfile(nmg.maugiays);
            NCCDAL.Docfile(ncc.nccs);
            NhanVienDAL.Docfile(nnv.nhanviens);
            TinhLuongDAL.Docfile(tl.tinhluongs);
        }
        public static void Pass()
        {
            do
            {
                Console.WriteLine("                                 -----------------------------------------");
                Console.WriteLine("                                |                Đăng nhập                |");
                Console.WriteLine("                                 -----------------------------------------");
                Console.Write("                                |         Tài khoản:");
                String tk = Console.ReadLine();
                Console.Write("                                |         Mật khẩu: ");
                String mk = Console.ReadLine();
                if (tk == "minhanh2000" && mk == "12345678")
                {
                    Console.Clear();
                    DocAllFile();
                    View();
                }
                else
                {

                    Console.WriteLine("                                Tài khoản hoặc mật khẩu sai");
                    Console.WriteLine("                                Chọn 1 để tiếp tục đăng nhập | Chọn 2 để thoát");
                    String chon = Console.ReadLine();
                    if (chon == "1")
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (chon == "2")
                    {
                        break;
                    }
                }
            } while (true);
        }
        public static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode; Console.InputEncoding = Encoding.Unicode;
            Pass();
            Console.ReadKey();
        }

    }
}
