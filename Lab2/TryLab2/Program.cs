using System.Text;
using System;
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
        Set set = new Set();
        HamThuatToan htt = new HamThuatToan();
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
                    try
                    {
                        int x = int.Parse(Console.ReadLine());
                        set.Xuat();
                        // Kiểm tra xem x có thuộc tập A hay không
                        bool isInA = htt.KiemTraCoTonTai(x, set._a);
                        if (isInA)
                        {
                            Console.WriteLine($"Phần tử {x} thuộc tập A");
                        }
                        else
                        {
                            Console.WriteLine($"Phần tử {x} không thuộc tập A");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Phải là số! Lỗi >> {ex.Message}");
                    }

                    break;
                case Menu.Giao:
                    // Tìm tập giao của A và B
                    int[] TapGiao = htt.Giao(set._a, set._b);
                    set.Xuat();
                    Console.WriteLine("Tập giao của A và B là: " + string.Join(" ", TapGiao));
                    break;
                case Menu.Hop:
                    // Tìm tập hợp của A và B
                    int[] TapHop = htt.Hop(set._a, set._b);
                    set.Xuat();
                    Console.WriteLine("Tập hợp của A và B là: " + string.Join(" ", TapHop));
                    break;
                case Menu.Hieu:
                    // Tìm hiệu của A cho B
                    int[] TapHieu = htt.Hieu(set._a, set._b);
                    set.Xuat();
                    Console.WriteLine("Hiệu của A cho B là: " + string.Join(" ", TapHieu));
                    break;
                case Menu.Bu:
                    // Tìm phần bù của tập A trong tập U
                    int[] TapBu = htt.PhanBu(set._a, set._u);
                    set.Xuat();
                    Console.WriteLine("Phần bù của tập A trong tập U là: " + string.Join(" ", TapBu));
                    break;
                case Menu.HieuDoiXung:
                    // Tìm hiệu đối xứng của A và B
                    int[] TapHieuDoiXung = htt.HieuDoiXung(set._a, set._b, set._u);
                    set.Xuat();
                    Console.WriteLine("Hiệu đối xứng của A và B là: " + string.Join(" ", TapHieuDoiXung));
                    break;
                default:
                    Console.WriteLine("Không có lựa chọn này! vui lòng thử lại.");
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
}
