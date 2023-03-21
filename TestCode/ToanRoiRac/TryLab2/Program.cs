using System.Text;

class Program
{
    /*
     Người thực hiện: Đoàn Quang Huy
     Lớp: CTK44B
     */
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.ForegroundColor = ConsoleColor.Green;
        //Console.BackgroundColor = ConsoleColor.Yellow;
        // Nhập thông tin tập U
        Console.WriteLine("Nhập thông tin tập U, mỗi phần tử cách nhau bởi dấu phẩy:");
        string[] U_arr = Console.ReadLine().Split(',');
        int[] U = Array.ConvertAll(U_arr, int.Parse);

        // Nhập thông tin tập A
        Console.WriteLine("Nhập tập A, mỗi phần tử cách nhau bởi dấu phẩy:");
        string[] A_arr = Console.ReadLine().Split(',');
        int[] A = Array.ConvertAll(A_arr, int.Parse);

        // Nhập thông tin tập B
        Console.WriteLine("Nhập tập B, mỗi phần tử cách nhau bởi dấu phẩy:");
        string[] B_arr = Console.ReadLine().Split(',');
        int[] B = Array.ConvertAll(B_arr, int.Parse);

        // Tập U,A,B
        Console.WriteLine("Tập U: {" + string.Join(" ", U) + "}");
        Console.WriteLine("Tập A: {" + string.Join(" ", A) + "}");
        Console.WriteLine("Tập B: {" + string.Join(" ", B) + "}");
        // Nhap vao phan tu x
        Console.Write("Nhập vào phần tử x để tìm trong tập A: ");
        // Kiểm tra xem phần tử 3 có thuộc tập A hay không
        int x = int.Parse(Console.ReadLine());
        bool isInA = KiemTraCoTonTai(x, A);
        if (isInA)
        {
            Console.WriteLine($"Phần tử {x} thuộc tập A");
        }
        else
        {
            Console.WriteLine($"Phần tử {x} không thuộc tập A");
        }
        // Tính giao của hai tập A và B
        int[] TapGiao = Giao(A, B);
        Console.WriteLine("Tập giao của A và B là: " + string.Join(" ", TapGiao));
        // Tính hợp của 2 tập A và B
        int[] tapHop = Hop(A, B);
        Console.WriteLine("Tập hợp của A và B: " + string.Join(" ", tapHop));
        // Tính A\B
        int[] hieu = Hieu(A, B);
        Console.WriteLine("Hiệu của tập A cho tập B: " + string.Join(" ", hieu));
        // tinh phan bu
        int[] phanBu = PhanBu(A, U);
        Console.WriteLine("Phần bù của tập A trong U: " + string.Join(" ", phanBu));
        // Hieu doi xung giua A va B
        int[] hieuDoiXung = HieuDoiXung(A, B, U);
        Console.WriteLine("Hiệu đối xứng của A và B: " + string.Join(" ", hieuDoiXung));

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
    // Tinh giao của A và B
    //static int[] Giao(int[] A, int[] B)
    //{
    //    List<int> DanhSachGiao = new List<int>();
    //    foreach (int x in A)
    //    {
    //        if (KiemTraCoTonTai(x, B))
    //        {
    //            DanhSachGiao.Add(x);
    //        }
    //        // cách 2
    //        //if (Array.IndexOf(B, x) >= 0)
    //        //{
    //        //    DanhSachGiao.Add(x);
    //        //}
    //    }
    //    return DanhSachGiao.ToArray();
    //}
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
