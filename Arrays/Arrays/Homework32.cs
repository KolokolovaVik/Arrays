using System;

namespace Arrays
{
    internal class Homework32
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] matrix = new int[10, 10];
            int maxElement = int.MinValue;
            Console.WriteLine("Массив:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(10, 100);

                    if (maxElement <= matrix[i, j])
                    {
                        maxElement = matrix[i, j];
                    }
                    Console.Write(matrix[i, j] + "|");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nНаибольший элемент: {maxElement}\n");
            Console.WriteLine("Полученная матрица: \n");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == maxElement)
                    {
                        matrix[i, j] = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write(matrix[i, j] + "|");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }
    }
}
