using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryLab2
{
    public class HamThuatToan
    {
        // kiem tra xem x co nam trong tap A cho truoc khong
        public bool KiemTraCoTonTai(int element, int[] set)
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
        // Giao
        public int[] Giao(int[] A, int[] B)
        {
            HashSet<int> setA = new HashSet<int>(A);
            HashSet<int> setB = new HashSet<int>(B);

            HashSet<int> DanhSachGiao = new HashSet<int>(setA);
            DanhSachGiao.IntersectWith(setB);

            return DanhSachGiao.ToArray();
        }
        // tính hợp của 2 tập A và B
        public int[] Hop(int[] A, int[] B)
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
        public int[] Hieu(int[] A, int[] B)
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
        public int[] PhanBu(int[] A, int[] U)
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
        public int[] HieuDoiXung(int[] A, int[] B, int[] U)
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
}
