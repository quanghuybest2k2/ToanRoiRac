using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class set
    {

        //ArrayList tam = new ArrayList();
        /// <summary>
        /// Số phần tử của tập hợp
        /// </summary>
        public int nmember = 0;
        /// <summary>
        /// Mảng các phần tử của tập hợp
        /// </summary>
        /// 
        //public List<int> o = new List<int>();
        public List<int> o = new List<int>();
        //= new List<int>();
        //int[ToanCuc.nobjs];
        /// <summary>
        /// Hàm khởi tạo không tham số
        /// </summary>
        public set()
        {
            this.nmember = 0;
            o = new List<int>();
            //int[ToanCuc.nobjs];
            //this.o = null;
        }
        /// <summary>
        /// Hàm khởi tạo tập hợp có n là tham số
        /// </summary>
        /// <param name="n"></param>
        public set(int n)
        {
            this.nmember = n;
            this.o = new List<int>(this.nmember);
            //for (int i = 0; i < n; i++)
            //    this.o[i] = 0;

        }
        //public set(int n, List<int> a)
        //{
        //    this.nmember = n;
        //    //this.o = new List<int>(this.nmember);
        //    for (int i = 0; i < n; i++)
        //        this.o.Add(a[i]);

        //}
        // A = {a,a,a,a,b,d} = {a,b,d}
        public set(int n, List<int> a)
        {
            int[] A1 = new int[ToanCuc.nrobjs];
            int i;
            for (i = 0; i < ToanCuc.nrobjs; i++)
                A1[i] = 0;
            // Luy dang trong tap hop
            for (i = 0; i < a.Count; i++)
                A1[a[i]] = 1;
            int k = 0;
            for (i = 0; i < ToanCuc.nrobjs; i++)
            {
                if (A1[i] == 1)
                {
                    this.o.Insert(k, i);
                    k++;
                }
            }
            this.nmember = k;
        }
        public void sort()
        {
            this.o.Sort();
        }
        /// <summary>
        /// Hàm hủy một tập hợp
        /// </summary>
        ~set()
        {
            this.nmember = 0;
            this.o = null;
        }
        /// <summary>
        /// Hàm khởi tạo một tập hợp
        /// </summary>
        /// <param name="s"></param>
        public set(set s)
        {
            this.nmember = s.nmember;
            this.o = new List<int>(nmember);
            for (int i = 0; i < s.nmember; i++)
                this.o.Add(s.o[i]);
        }
        /// <summary>
        /// Hàm quá tải toán tử gán của hai tập hợp
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        //public static set operator + (set s)
        //{
        //    this.

        //}
        /// <summary>
        /// Hàm giao của 2 tập hợp có kích thước
        /// </summary>
        /// <param name="?"></param>
        /// <returns></returns>
        /// <summary>
        /// Hàm xuất các phần tử của tập hợp
        /// </summary>
        public void display()
        {
            if (nmember > 0)
            {
                Console.Write("{");
                for (int i = 0; i < nmember - 1; i++)
                    Console.Write("{0},", o[i]);
                Console.Write("{0}", o[nmember - 1]);
                Console.Write("}");
            }
            else
                Console.WriteLine("{}");

        }
        public string Ctostring()
        {
            string str = "";
            if (nmember > 0)
            {
                str = str + "{";
                for (int i = 0; i < nmember - 1; i++)
                    str = str + o[i].ToString() + ",";
                str = str + o[nmember - 1];
                str = str + "}";
            }
            else
                str = str + "{}";
            return str;
        }
        ///
        /// 
        /// <summary>
        /// Hàm hiển thị bằng tên 
        /// </summary>
        public void display_name()
        {
            if (nmember > 0)
            {
                Console.Write("{");
                for (int i = 0; i < nmember - 1; i++)
                    Console.Write("{0},", ToanCuc.animals[o[i]]);
                Console.Write("{0}", ToanCuc.animals[o[nmember - 1]]);
                Console.Write("}");
            }
            else
                Console.WriteLine("{}");
        }
        ///
        /// ///
        ///         /// <summary>
        /// Kiểm tra phần tử có thuộc tập hợp không
        /// </summary>
        /// Input: 1 char kt, 1 set a
        /// Output:         true : Thuộc; false: Không thuộc
        ///
        public bool PtInSet(int pt, set a)
        {
            int[] A1 = new int[ToanCuc.nrobjs];
            int i;
            for (i = 0; i < ToanCuc.nrobjs; i++)
                A1[i] = 0;

            for (i = 0; i < a.nmember; i++)
                A1[a.o[i]] = 1;
            if (A1[pt] == 1) return true;
            else return false;
        }
        /// <summary>
        /// Kiểm tra Tập hợp A là con Tập hợp B?
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool setAInB(set a, set b)
        {
            int[] A1 = new int[ToanCuc.nrobjs];
            int[] B1 = new int[ToanCuc.nrobjs];
            int i;
            for (i = 0; i < ToanCuc.nrobjs; i++)
            {
                A1[i] = 0;
                B1[i] = 0;
            }
            for (i = 0; i < a.nmember; i++)
                A1[a.o[i]] = 1;
            for (i = 0; i < b.nmember; i++)
                B1[b.o[i]] = 1;
            bool kq = false;
            for (i = 0; i < ToanCuc.nrobjs; i++)
                if (A1[i] == 1)
                {
                    if (B1[i] == 1) kq = true;
                    else { kq = false; break; }
                }
            if (kq == true && a.nmember <= b.nmember) return true;
            return false;
        }
        /// <summary>
        /// Hàm giao của 2 tập hợp
        /// </summary>
        /// <param name="?"></param>
        /// <returns></returns>
        public set Intersect(set a, set b)
        {
            int[] A1 = new int[ToanCuc.nrobjs];
            int[] B1 = new int[ToanCuc.nrobjs];
            set C = new set(ToanCuc.nrobjs);
            int i, k = 0;
            for (i = 0; i < ToanCuc.nrobjs; i++)
            {
                A1[i] = 0;
                B1[i] = 0;
            }
            for (i = 0; i < a.nmember; i++)
                A1[a.o[i]] = 1;
            for (i = 0; i < b.nmember; i++)
                B1[b.o[i]] = 1;
            for (i = 0; i < ToanCuc.nrobjs; i++)
                if (A1[i] * B1[i] == 1)
                {
                    C.o.Insert(k, i);
                    k++;
                }
            C.nmember = k;
            return C;
        }
        /// <summary>
        /// Hợp của hai tập hợp
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public set Union(set a, set b)
        {
            int[] A1 = new int[ToanCuc.nrobjs];
            int[] B1 = new int[ToanCuc.nrobjs];
            set C = new set(ToanCuc.nrobjs);
            int i, k = 0;
            for (i = 0; i < ToanCuc.nrobjs; i++)
            {
                A1[i] = 0;
                B1[i] = 0;
            }
            for (i = 0; i < a.nmember; i++)
                A1[a.o[i]] = 1;
            for (i = 0; i < b.nmember; i++)
                B1[b.o[i]] = 1;
            for (i = 0; i < ToanCuc.nrobjs; i++)
                if (A1[i] == 1 || B1[i] == 1)
                {
                    C.o.Insert(k, i);
                    k++;
                }
            C.nmember = k;
            return C;
        }
        /// <summary>
        /// Hàm hiệu của 2 tập hợp
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public set Subtraction(set a, set b)
        {
            int[] A1 = new int[ToanCuc.nrobjs];
            int[] B1 = new int[ToanCuc.nrobjs];
            set C = new set(ToanCuc.nrobjs);
            int i, k = 0;
            for (i = 0; i < ToanCuc.nrobjs; i++)
            {
                A1[i] = 0;
                B1[i] = 0;
            }
            for (i = 0; i < a.nmember; i++)
                A1[a.o[i]] = 1;
            for (i = 0; i < b.nmember; i++)
                B1[b.o[i]] = 1;
            for (i = 0; i < ToanCuc.nrobjs; i++)
                if (A1[i] == 1 && B1[i] == 0)
                {
                    C.o.Insert(k, i);
                    k++;
                }
            C.nmember = k;
            return C;
        }
        ///
        /// Bù A trong U // Giốn hàm hiệu nhưng thay đối số truyền vào thay vì truyền A, B thì truyền U, A
        ///
        public set NotsetA(set u, set a)
        {
            int[] A1 = new int[ToanCuc.nrobjs];
            int[] U1 = new int[ToanCuc.nrobjs];
            set C = new set(ToanCuc.nrobjs);
            int i, k = 0;
            for (i = 0; i < ToanCuc.nrobjs; i++)
            {
                U1[i] = 0;
                A1[i] = 0;
            }
            for (i = 0; i < u.nmember; i++)
                U1[u.o[i]] = 1;
            for (i = 0; i < a.nmember; i++)
                A1[a.o[i]] = 1;
            for (i = 0; i < ToanCuc.nrobjs; i++)
                if (U1[i] == 1 && A1[i] == 0)
                {
                    C.o.Insert(k, i);
                    k++;
                }

            C.nmember = k;
            return C;
        }
        public set SubtractionAB_BA(set a, set b)
        {
            set C = new set(ToanCuc.nrobjs);
            return (C.Union(C.Subtraction(a, b), C.Subtraction(b, a)));
        }
    }
}
