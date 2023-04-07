using System;
using System.Text;

namespace DeQuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nhập vào giá trị cho n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Kết quả hàm: {HamXN(n)}");
            Console.ReadLine();
        }
        static int HamXN(int n)
        {
            if (n == 0) return 1;
            else if (n == 1) return 3;
            else return (5 * HamXN(n - 1) - 6 * HamXN(n - 2) + n - 3);
        }
    }
}