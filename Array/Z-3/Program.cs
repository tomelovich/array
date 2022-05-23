using System;

namespace Z_3
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
                double proizv = 1;
                double sumStr = 0;
                Console.Write("Введите № строки: ");
                int k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Матрица:");
                for (int i = 0; i < matrix.rows; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < matrix.cols; j++)
                    {
                        sum += matrix[i, j];
                        if (matrix[i, j] % 2 != 0)
                        {
                            proizv *= matrix[i, j];
                        }
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                    if (i == k - 1)
                    {
                        sumStr = sum;
                    }
                }
                Console.WriteLine("Произведение всех не четных чисел = {0}",proizv);
                Console.WriteLine("Сумма чисел строки под номером {0} = {1}",k,sumStr);
            }
        }
    }
}
