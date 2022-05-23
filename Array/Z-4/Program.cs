using System;

namespace Z_4
{
    class Matrix
    {
        private int[,] matrix;
        public int rows, cols;
        private int Length;
        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            matrix = new int[this.rows, this.cols];
            Length = rows * cols;
        }
        public double this[int index1, int index2]
        {
            get { return matrix[index1, index2]; }
            set { matrix[index1, index2] = (int)value; }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Random rnd = new Random();
                Console.WriteLine("Введите N:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите диапазон [a,b]");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Matrix matrix = new Matrix(n, n);
                for (int i = 0; i < matrix.rows; i++)
                {
                    for (int j = 0; j < matrix.cols; j++)
                    {
                        matrix[i, j] = rnd.Next(a, b);
                    }
                }
                Console.Write("Введите № строки: ");
                int k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Матрица:");
                for (int i = 0; i < matrix.rows; i++)
                {
                    for (int j = 0; j < matrix.cols; j++)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }
                double sum = 0;
                for (int i = 0; i < n; i++) sum += matrix[i, k-1];
                Console.WriteLine("\nСумма столбца = {0}", sum);
                Console.WriteLine("Задайте число: ");
                int ch = Convert.ToInt32(Console.ReadLine());
                if (sum % ch == 0)
                {
                    Console.WriteLine("Кратно");
                }
                else { Console.WriteLine("Не кратно"); }
            }
        }
    }
}
