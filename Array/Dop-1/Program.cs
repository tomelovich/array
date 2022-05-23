using System;

namespace Dop_1
{
    class Program
    {
        static void CalcIndexesOfArray(out int a, out int b, out int m)
        {
            int y, diff = -1; a = -1; b = -1;
            m = 49;
            int[] A = { };
            for (int i = 1; i <= m; i++)
            {
                y = Math.Abs((m / i) - i);
                if (diff == -1 || y < diff)
                {
                    diff = y;
                    a = i;
                    b = (m % i == 0) ? m / i : m / i + 1;
                }
            }
        }
        static void Main(string[] args)
        {
            int a, b, z;
            CalcIndexesOfArray(out a, out b, out z);
            int m = a;
            int n = b;
            int[,] mat = new int[m, n];
            int k = 1;
            int t = 0;
            int i, j = 0;
            while (k <= z)
            {
                for (i = t; i < n; i++)
                    if (k == z)
                    {
                        mat[j, i] = k++;
                    }
                    else
                    {
                        if (k <= z)
                        {
                            mat[j, i] = k++;
                        }
                    }
                j = n - 1;
                for (i = t + 1; i < m; i++)
                    if (k == z)
                    {
                        mat[i, j] = k++;
                    }
                    else
                    {
                        if (k <= z)
                        {
                            mat[i, j] = k++;
                        }
                    }
                j = m - 1;
                for (i = n - 2; i >= t; i--)
                    if (k == z)
                    {
                        mat[j, i] = k++;
                    }
                    else
                    {
                        if (k <= z)
                        {
                            mat[j, i] = k++;
                        }
                    }
                j = t;
                for (i = m - 2; i > t; i--)
                    if (k == z)
                    {
                        mat[i, j] = k++;
                    }
                    else
                    {
                        if (k <= z)
                        {
                            mat[i, j] = k++;
                        }
                    }
                n--;
                m--;
                t++;
                j = t;
            }
            for (i = 0; i < mat.GetLength(0); i++)
            {
                for (j = 0; j < mat.GetLength(1); j++)
                    Console.Write("{0,2}", mat[i, j] + "\t");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
