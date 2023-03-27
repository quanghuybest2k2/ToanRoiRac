using Lab2;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
          Console.WriteLine("Nhap vào gia tri cho n < 13.");
          n = int.Parse(Console.ReadLine());
          final = 1;
          khoitao();
          //XuatTatcaTapCon();
          XuatTatcaTapConChar();
          Console.ReadLine();
          */
            MenuClass menuClass = new MenuClass();
            Console.Clear();
            menuClass.Menu();
            while (true)
            {
                int t = menuClass.XuLyMenu();
                if (t == 0) break;
            }
            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}