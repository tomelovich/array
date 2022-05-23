using System;

namespace Z_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int [] b = new int[10];
            int[] a = new int[10];
            int n;
            Console.WriteLine("Введите размерность массива:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n+1; i++)
            {
                a[i] = rnd.Next(-10, 10);
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            for (int i = 1; i < n+1; i++)
            {
                b[i] = rnd.Next(-10, 10);
                Console.Write(b[i]+ " ");
            }
            
            for (int i = 1; i < n+1; i++)
            {
                if (a[i] < 0)
                    b[i] = b[i] * 10;
                else
                {
                    b[i] = 0;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Полученный массив B: ");
            for (int i = 1; i < n+1; i++)
            {
                Console.Write(b[i]+" ");
            }
        }
    }
}
