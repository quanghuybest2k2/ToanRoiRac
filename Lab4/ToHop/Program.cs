using System;
using System.Text;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập k: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine($"n là {n}");
            Console.WriteLine($"k là {k}");

            // Tính tổng số hoán vị
            int totalPermutations = 1;
            for (int i = n; i > n - k; i--)
            {
                totalPermutations *= i;
            }

            totalPermutations /= Factorial(k);

            // Liệt kê tất cả các hoán vị
            int[] arr = new int[k];
            for (int i = 1; i <= k; i++)
            {
                arr[i - 1] = i;
            }

            int permutationCount = 0;
            while (permutationCount < totalPermutations)
            {
                permutationCount++;
                Console.Write($"Tap con thu {permutationCount} : ");
                for (int j = 0; j < k; j++)
                {
                    Console.Write($"{arr[j]} ");
                }
                Console.WriteLine();

                int i = k - 1;
                while (i >= 0 && arr[i] == n - k + i + 1)
                {
                    i--;
                }

                if (i >= 0)
                {
                    arr[i]++;
                    for (int j = i + 1; j < k; j++)
                    {
                        arr[j] = arr[j - 1] + 1;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"Tổng số hoán vị: {totalPermutations}");
        }

        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
