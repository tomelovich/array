using System;

namespace Z_5
{
    class Program
    {
        static double Factorial(double f)
        {
            double factorial = 1;   

            for (double i = 2; i <= f; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        static double F(double n)
        {
            return Factorial(n - 1)/Factorial(n);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            double f = F(x);
            Console.WriteLine(f);
        }
    }
}
