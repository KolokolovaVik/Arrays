using System;

namespace Arrays
{
    internal class Homework31
    {
        static void Main(string[] args)
        {
            int sumLine = 0;
            int multiplicationColumn = 1;
            int line = 1;
            int column = 0;

            int[,] array =
            {
                {3,9,5,9,2},
                {4,6,7,1,2},
                {5,7,9,2,3},
            };

            Console.WriteLine("Двумерный массив:\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = column; i < array.GetLength(1); i++)
            {
                sumLine += array[line, i];
            }

            for (int j = column; j < array.GetLength(0); j++)
            {
                multiplicationColumn *= array[j, column];
            }

            Console.WriteLine($"\nСумма {line + 1} строки: " + sumLine);
            Console.WriteLine($"Произведение {column + 1}  столбца: " + multiplicationColumn);
        }
    }
}
