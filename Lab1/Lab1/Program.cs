using System;
using System.IO;
using System.Text;

namespace Lab1
{

    /*
     Người thực hiện: 
     Họ và tên: Đoàn Quang Huy
     MSSV: 2015597
     Lớp: CTK44B
     Link mã nguồn: https://github.com/quanghuybest2k2/ToanRoiRac
     */
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Yellow;

            int[] S = { 1, 2, 3 };
            int n = S.Length;

            while (true)
            {
                // Hiển thị menu
                Console.WriteLine("Chọn chức năng:");
                Console.WriteLine("1. Xuất kết quả trực tiếp");
                Console.WriteLine("2. Xuất kết quả vào file .txt");
                Console.WriteLine("0. Thoát");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Lựa chọn của bạn: ");
                Console.ResetColor();
                // Nhập lựa chọn từ người dùng
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Xuất kết quả trực tiếp lên màn hình
                        for (int i = 0; i < (1 << n); i++)
                        {
                            Console.Write("{ ");
                            for (int j = 0; j < n; j++)
                            {
                                if ((i & (1 << j)) > 0)
                                {
                                    Console.Write(S[j] + " ");
                                }
                            }
                            Console.Write("}\n");
                        }
                        break;

                    case 2:
                        // Xuất kết quả vào file .txt
                        StreamWriter writer = new StreamWriter("result.txt");
                        for (int i = 0; i < (1 << n); i++)
                        {
                            writer.Write("{ ");
                            for (int j = 0; j < n; j++)
                            {
                                if ((i & (1 << j)) > 0)
                                {
                                    writer.Write(S[j] + " ");
                                }
                            }
                            writer.Write("}\n");
                        }
                        writer.Close();
                        Console.WriteLine("Kết quả đã được xuất vào bin\\Debug\\result.txt");
                        break;

                    case 0:
                        // Thoát khỏi chương trình
                        Console.WriteLine("Chương trình đã thoát!");
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nNhấn một phím để tiếp tục!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}