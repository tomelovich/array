using System;

namespace Z_1
{
    class Program
    {
        static int[] Input()
        {
            Console.WriteLine("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i <a.Length; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            return a;
        }
        static void Print(int[] a)
        {
            for(int i = 0; i < a.Length; ++i)
            {
                Console.Write("{0} ", a[i]);
                Console.WriteLine();
            }
        }
        private static int ComputeSumByDivisors(int[] array, params int[] divisors)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                int current = array[i];

                for (int divIndex = 0; divIndex < divisors.Length; ++divIndex)
                {
                    if ((current % 3) == 0)
                    {
                        sum += current;
                    }
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] myArray = Input();
            Console.WriteLine("Исходный массив:");
            Print(myArray);
            int sum = ComputeSumByDivisors(myArray, 3);
            Console.WriteLine("Сумма чисел, кратных 3= {0}", sum);
        }
    }
}
