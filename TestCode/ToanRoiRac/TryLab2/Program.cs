using System.Text;
using System;
using System.Security.Cryptography;
using TryLab2;

class Program
{
    /*
     Người thực hiện: Đoàn Quang Huy
     Lớp: CTK44B
     */
    enum Menu
    {
        Thoat = 0,
        NhapDuLieu = 1,
        NhapXtrongA = 2,
        Giao = 3,
        Hop = 4,
        Hieu = 5,
        Bu = 6,
        HieuDoiXung = 7
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.ForegroundColor = ConsoleColor.Green;
        //Console.BackgroundColor = ConsoleColor.Yellow;
        //int[] U = new int[0];
        //int[] A = new int[0];
        //int[] B = new int[0];
        Set set = new Set();

        while (true)
        {
            Console.WriteLine("================================ MENU ================================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t  CÁC BÀI TOÁN TRÊN TẬP HỢP");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Nhấn {(int)Menu.Thoat} Thoát");
            Console.WriteLine($"Nhấn {(int)Menu.NhapDuLieu} Nhập vũ trụ U, tập A và tập B");
            Console.WriteLine($"Nhấn {(int)Menu.NhapXtrongA} Nhập vào phần tử x để tìm trong tập A");
            Console.WriteLine($"Nhấn {(int)Menu.Giao} Tìm tập Giao của A và B");
            Console.WriteLine($"Nhấn {(int)Menu.Hop} Tìm tập Hợp của A và B");
            Console.WriteLine($"Nhấn {(int)Menu.Hieu} Tìm Hiệu của tập A cho tập B");
            Console.WriteLine($"Nhấn {(int)Menu.Bu} Tìm Phần bù của tập A trong U");
            Console.WriteLine($"Nhấn {(int)Menu.HieuDoiXung} Tìm Hiệu đối xứng của A và B");
            Console.ResetColor();
            Console.WriteLine("======================================================================");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Mời bạn chọn chức năng: ");
            Console.ResetColor();
            Menu menu = (Menu)int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (menu)
            {
                case Menu.Thoat:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Chương trình đã thoát!");
                    Console.ResetColor();
                    return;
                case Menu.NhapDuLieu:
                    set.HamNhap();
                    set.Xuat();
                    break;
                case Menu.NhapXtrongA:
                    // Nhập phần tử x
                    Console.Write("Nhập vào phần tử x để tìm trong tập A: ");
                    int x = int.Parse(Console.ReadLine());
                    set.Xuat();
                    // Kiểm tra xem x có thuộc tập A hay không
                    bool isInA = KiemTraCoTonTai(x, set._a);
                    if (isInA)
                    {
                        Console.WriteLine($"Phần tử {x} thuộc tập A");
                    }
                    else
                    {
                        Console.WriteLine($"Phần tử {x} không thuộc tập A");
                    }
                    break;
                case Menu.Giao:
                    // Tìm tập giao của A và B
                    int[] TapGiao = Giao(set._a, set._b);
                    set.Xuat();
                    Console.WriteLine("Tập giao của A và B là: " + string.Join(" ", TapGiao));
                    break;
                case Menu.Hop:
                    // Tìm tập hợp của A và B
                    int[] TapHop = Hop(set._a, set._b);
                    set.Xuat();
                    Console.WriteLine("Tập hợp của A và B là: " + string.Join(" ", TapHop));
                    break;
                case Menu.Hieu:
                    // Tìm hiệu của A cho B
                    int[] TapHieu = Hieu(set._a, set._b);
                    set.Xuat();
                    Console.WriteLine("Hiệu của A cho B là: " + string.Join(" ", TapHieu));
                    break;
                case Menu.Bu:
                    // Tìm phần bù của tập A trong tập U
                    int[] TapBu = PhanBu(set._a, set._u);
                    set.Xuat();
                    Console.WriteLine("Phần bù của tập A trong tập U là: " + string.Join(" ", TapBu));
                    break;
                case Menu.HieuDoiXung:
                    // Tìm hiệu đối xứng của A và B
                    int[] TapHieuDoiXung = HieuDoiXung(set._a, set._b, set._u);
                    set.Xuat();
                    Console.WriteLine("Hiệu đối xứng của A và B là: " + string.Join(" ", TapHieuDoiXung));
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nNhấn một phím để tiếp tục!");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }

    }
    // end Main
  
    // kiem tra xem x co nam trong tap A cho truoc khong
    static bool KiemTraCoTonTai(int element, int[] set)
    {
        foreach (int x in set)
        {
            if (x == element)
            {
                return true;
            }
        }
        return false;
    }
    static int[] Giao(int[] A, int[] B)
    {
        HashSet<int> setA = new HashSet<int>(A);
        HashSet<int> setB = new HashSet<int>(B);

        HashSet<int> DanhSachGiao = new HashSet<int>(setA);
        DanhSachGiao.IntersectWith(setB);

        return DanhSachGiao.ToArray();
    }
    // tính hợp của 2 tập A và B
    static int[] Hop(int[] A, int[] B)
    {
        HashSet<int> hop = new HashSet<int>(A);
        foreach (int i in B)
        {
            if (!hop.Contains(i))
            {
                hop.Add(i);
            }
        }
        return hop.ToArray();
    }
    // Tính A hiệu B (A\B)
    static int[] Hieu(int[] A, int[] B)
    {
        List<int> DanhSachHieu = new List<int>();
        foreach (int x in A)
        {
            if (!KiemTraCoTonTai(x, B))
            {
                DanhSachHieu.Add(x);
            }
        }
        return DanhSachHieu.ToArray();
    }
    // tinh phan bu
    static int[] PhanBu(int[] A, int[] U)
    {
        List<int> DanhSachPhanBu = new List<int>();
        foreach (int x in U)
        {
            if (!KiemTraCoTonTai(x, A))
            {
                DanhSachPhanBu.Add(x);
            }
        }
        return DanhSachPhanBu.ToArray();
    }
    // tính hiệu đối xứng
    static int[] HieuDoiXung(int[] A, int[] B, int[] U)
    {
        List<int> DanhSachHieu = new List<int>();

        foreach (int x in U)
        {
            if (KiemTraCoTonTai(x, A) ^ KiemTraCoTonTai(x, B))
            {
                DanhSachHieu.Add(x);
            }
        }

        return DanhSachHieu.ToArray();
    }
}
