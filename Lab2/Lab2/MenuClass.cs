using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class MenuClass
    {
        int n, final;
        string FileName = "Data.txt";
        int[] a = new int[100];
        set A, B, U;

        public MenuClass()
        {

        }
        public int ChonMenu()
        {
            n = 0;
            try
            {
                Console.Write("\n\n Chon tren menu thuc hien cac thuat toan khac : ");
                n = int.Parse(Console.ReadLine());

            }
            catch (Exception loi)
            {
                Console.Write("\n Nhap sai !!!");
                Console.WriteLine(loi.Message);
            }
            if ((n > 0 || n < 9) || n != 99)
                return n;
            else return ChonMenu();

        }
        public void Menu()
        {
            Console.Write("=============================MENU===========================\n");
            Console.Write("1. NHAP TAP VU TRU U VA TAP HOP A VA TOP HOP B (TRUOC KHI THUC HIEN CAC MUC 2 DEN 8)\n");
            Console.Write("2. Kiem tra phan tu co thuoc Tap hop A hay khong? \n");
            Console.Write("3. Kiem tra Tap hop A la con tap hop Tap hop B? \n");
            Console.Write("4. Giao cua Tap hop A va Tap hop B \n");
            Console.Write("5. Hop cua Tap hop A và Tap hop B \n");
            Console.Write("6. Hieu cua Tap hop A và Tap hop B \n");
            Console.Write("7. Bu cua Tap hop A trong U\n");
            Console.Write("8. Hieu doi xung cua Tap hop A và Tap hop B \n");
            Console.Write("99. Thoat!!!\n");
            Console.Write("============================================================\n");
        }
        public int XuLyMenu()
        {
            int chon = ChonMenu();
            //int n;// a = 5; int b = 6;
            switch (chon)
            {
                case 1:
                    Console.Clear();
                    Menu();
                    Console.Write("1. Nhap Tap vu tru U, Tap hop A và Tap hop B \n ");
                    NhapTapU();
                    NhapTapA();
                    NhapTapB();
                    break;
                case 2:
                    Console.Clear();
                    Menu();
                    if (chon == 2 && U != null)
                    {
                        Console.Write("2. Kiem tra phan tu co thuoc Tap hop A? \n");
                        Console.Write("A : "); A.display();
                        int pt = 0;
                        try
                        {
                            Console.Write("\n Nhap ky tu can kiem tra co thuoc A: ");
                            pt = int.Parse(Console.ReadLine());
                        }
                        catch (Exception loi)
                        {
                            Console.Write("\n Nhap sai !!!");
                            Console.WriteLine(loi.Message);
                        }
                        if (A.PtInSet(pt, A)) Console.WriteLine("\n Phan tu " + pt + " thuoc Tap hop A.");
                        else
                        {
                            Console.WriteLine("\n Phan tu " + pt + " khong thuoc Tap hop A");
                            A.display();
                        }
                    }
                    else Console.Write("NHAP TAP VU TRU U VA TAP HOP A VA TOP HOP B (TRUOC KHI THUC HIEN CAC MUC 2 DEN 8)\n");
                    break;
                case 3:
                    Console.Clear();
                    Menu();
                    if (chon == 3 && U != null)
                    {
                        Console.Write("A : "); A.display(); Console.WriteLine();
                        Console.Write("B : "); B.display(); Console.WriteLine();
                        Console.Write("\n 3. Kiem tra Tap hop A là con Tap hop B \n");
                        if (A.setAInB(A, B)) Console.WriteLine("\n Tap hop A thuoc Tap hop B.");
                        else Console.WriteLine("\n Tap hop A KHONG thuoc Tap hop B..");
                    }
                    else Console.Write("NHAP TAP VU TRU U VA TAP HOP A VA TOP HOP B (TRUOC KHI THUC HIEN CAC MUC 2 DEN 8)\n");
                    break;
                case 4:
                    Console.Clear();
                    Menu();
                    if (chon == 4 && U != null)
                    {
                        Console.Write("A : "); A.display(); Console.WriteLine();
                        Console.Write("B : "); B.display(); Console.WriteLine();
                        Console.Write("4. Giao cua Tap hop A và Tap hop B \n");
                        A.Intersect(A, B).display();
                    }
                    else Console.Write("NHAP TAP VU TRU U VA TAP HOP A VA TOP HOP B (TRUOC KHI THUC HIEN CAC MUC 2 DEN 8)\n");
                    break;
                case 5:
                    Console.Clear();
                    Menu();
                    if (chon == 5 && U != null)
                    {
                        Console.Write("A : "); A.display(); Console.WriteLine();
                        Console.Write("B : "); B.display(); Console.WriteLine();
                        Console.Write("5. Hop cua Tap hop A và Tap hop B \n");
                        A.Union(A, B).display();
                    }
                    else Console.Write("NHAP TAP VU TRU U VA TAP HOP A VA TOP HOP B (TRUOC KHI THUC HIEN CAC MUC 2 DEN 8)\n");
                    break;
                case 6:
                    Console.Clear();
                    Menu();
                    if (chon == 6 && U != null)
                    {
                        Console.Write("A : "); A.display(); Console.WriteLine();
                        Console.Write("B : "); B.display(); Console.WriteLine();
                        Console.Write("6. Hieu cua Tap hop A và Tap hop B \n");
                        A.Subtraction(A, B).display();
                    }
                    else Console.Write("NHAP TAP VU TRU U VA TAP HOP A VA TOP HOP B (TRUOC KHI THUC HIEN CAC MUC 2 DEN 8)\n");
                    break;
                case 7:
                    Console.Clear();
                    Menu();
                    if (chon == 7 && U != null)
                    {
                        Console.Write("U : "); U.display(); Console.WriteLine();
                        Console.Write("A : "); A.display(); Console.WriteLine();
                        Console.Write("7. Bu cua Tap hop A trong U (U - A): \n");
                        A.NotsetA(U, A).display();
                    }
                    else Console.Write("NHAP TAP VU TRU U VA TAP HOP A VA TOP HOP B (TRUOC KHI THUC HIEN CAC MUC 2 DEN 8)\n");
                    break;
                case 8:
                    Console.Clear();
                    Menu();
                    if (chon == 8 && U != null)
                    {
                        Console.Write("A : "); A.display(); Console.WriteLine();
                        Console.Write("B : "); B.display(); Console.WriteLine();
                        Console.Write("8. Hieu doi xung cua Tap hop A va Tap hop B \n");
                        A.SubtractionAB_BA(A, B).display();
                    }
                    else Console.Write("NHAP TAP VU TRU U VA TAP HOP A VA TOP HOP B (TRUOC KHI THUC HIEN CAC MUC 2 DEN 8)\n");
                    break;
                case 99:
                    Console.Clear();
                    Menu();
                    Console.Write("Thoat!!!\n");
                    return 0;
            }
            return 1;
        }
        public void NhapTapU()
        {
            int kt;
            Console.Write("\n 1. Nhap Tap Vu tru U \n");
            int ktU = 0;
            try
            {
                Console.Write("\n Nhap kich thuoc U la mot so nguyen co kich thuoc nho hơn " + ToanCuc.nrobjs.ToString() + ": ");
                ktU = int.Parse(Console.ReadLine());
            }
            catch (Exception loi)
            {
                Console.Write("\n Nhap sai !!!");
                Console.WriteLine(loi.Message);
            }
            List<int> no = new List<int>();
            for (int i = 0; i < ktU; i++)
            {
                kt = 0;
                try
                {
                    Console.Write("\n Nhap tung phan tu cua U la cac so nguyen duong tu 1 đến " + ToanCuc.nrobjs.ToString() + ": ");
                    kt = int.Parse(Console.ReadLine());
                }
                catch (Exception loi)
                {
                    Console.Write("\n Nhap sai !!!");
                    Console.WriteLine(loi.Message);
                }
                no.Add(kt);
            }
            U = new set(ktU, no);
            U.display();
        }
        public void NhapTapA()
        {
            int kt;
            Console.Write("\n 1. Nhap Tap hop A \n");
            int ktA = 0;
            try
            {
                Console.Write("\n Nhap kich thuoc A la mot so nguyen co kich thuoc nho hơn " + ToanCuc.nrobjs.ToString() + " : ");
                ktA = int.Parse(Console.ReadLine());
            }
            catch (Exception loi)
            {
                Console.Write("\n Nhap sai !!!");
                Console.WriteLine(loi.Message);
            }
            List<int> na = new List<int>();
            for (int i = 0; i < ktA; i++)
            {
                kt = 0;
                try
                {
                    Console.Write("\n Nhap tung phan tu cua A la cac so nguyen duong tu 1 đến " + ToanCuc.nrobjs.ToString() + " : ");
                    kt = int.Parse(Console.ReadLine());
                }
                catch (Exception loi)
                {
                    Console.Write("\n Nhap sai !!!");
                    Console.WriteLine(loi.Message);
                }
                na.Add(kt);
            }
            A = new set(ktA, na);

            A.display();
        }
        public void NhapTapB()
        {
            int kt;
            Console.Write("\n 1. Nhap Tap hop B \n");
            int ktB = 0;
            try
            {
                Console.Write("\n Nhap kich thuoc B la mot so nguyen co kich thuoc nho hơn " + ToanCuc.nrobjs.ToString() + " : ");
                ktB = int.Parse(Console.ReadLine());
            }
            catch (Exception loi)
            {
                Console.Write("\n Nhap sai !!!");
                Console.WriteLine(loi.Message);
            }
            List<int> nb = new List<int>();
            for (int i = 0; i < ktB; i++)
            {
                kt = 0;
                try
                {
                    Console.Write("\n Nhap tung phan tu cua B la cac so nguyen duong tu 1 đến " + ToanCuc.nrobjs.ToString() + " : ");
                    kt = int.Parse(Console.ReadLine());
                }
                catch (Exception loi)
                {
                    Console.Write("\n Nhap sai !!!");
                    Console.WriteLine(loi.Message);
                }
                nb.Add(kt);
            }
            B = new set(ktB, nb);
            B.display();
        }
        public void XuatTatcaTapConChar()
        {
            File.Delete(FileName);// Xoa nội dung trên file cũ
            while (final == 1)
            {
                // Khởi tạo một tập hợp
                set C = new set(ToanCuc.nrobjs);
                // Khởi tạo chuỗi kết quả k
                int k = 0;
                for (int i = 1; i < n; i++)
                {
                    if (a[i] != 0)
                    {
                        C.o.Insert(k, ToanCuc.Kytu[i]);
                        k++;
                    }
                }
                if (a[n] != 0)
                {
                    C.o.Insert(k, ToanCuc.Kytu[n]);
                    k++;
                }
                C.nmember = k;
                C.display();
                // Chèn tập hợp vào File thông qua hàm Ctostring()
                File.AppendAllText(FileName, C.Ctostring() + "\r\n");
                Console.WriteLine();
                // Sinh mảng nhị phân tiếp theo
                Sinh();
            }
        }
        public void khoitao()
        {
            for (int i = 1; i <= n; i++)
                a[i] = 0;

        }
        public void Sinh()
        {
            int i = n;

            while (i >= 1 && a[i] == 1) // Duyệt các phần tử từ n tới 1. Neu gap bit 1 chuyên thanh 0 va dich sach trai. Neu gap bit 0 chuyen thanh 1 và copy phan con lai
            {
                a[i] = 0;
                --i;

            }
            if (i == 0) final = 0; // Cau hinh cuoi cung --> Xuất 111
            else
            {
                a[i] = 1;

            }
        }
    }
}
