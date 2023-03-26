﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryLab2
{
    public class Set
    {
        public int[] _u;
        public int[] _a;
        public int[] _b;
        public Set(int[] u, int[] a, int[] b)
        {
            this._u = u;
            this._a = a;
            this._b = b;
        }
        public Set()
        {

        }
       public void HamNhap()
        {
            try
            {
                // Nhập thông tin tập U
                Console.WriteLine("Nhập thông tin tập U, mỗi phần tử cách nhau bởi dấu phẩy:");
                string[] U_arr = Console.ReadLine().Split(',');
                this._u = Array.ConvertAll(U_arr, int.Parse);
                SapXep(this._u);
                // Nhập thông tin tập A
                Console.WriteLine("Nhập tập A, mỗi phần tử cách nhau bởi dấu phẩy:");
                string[] A_arr = Console.ReadLine().Split(',');
                this._a = Array.ConvertAll(A_arr, int.Parse);
                SapXep(this._a);
                // Nhập thông tin tập B
                Console.WriteLine("Nhập tập B, mỗi phần tử cách nhau bởi dấu phẩy:");
                string[] B_arr = Console.ReadLine().Split(',');
                this._b = Array.ConvertAll(B_arr, int.Parse);
                SapXep(this._b);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi nhập {ex.Message}");
            }
        }
        // Xuất mảng
        public void Xuat()
        {
            try
            {
                Console.WriteLine($"Tập U: {{{string.Join(", ", this._u)}}}");
                Console.WriteLine($"Tập A: {{{string.Join(", ", this._a)}}}");
                Console.WriteLine($"Tập B: {{{string.Join(", ", this._b)}}}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xuất");
            }
        }
        //Sắp xếp mảng
        private void SapXep(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}
