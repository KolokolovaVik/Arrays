using System;

namespace Arrays
{
    internal class Homework31
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int multiplication = 1;
            int lineIndex = 1;
            int columnIndex = 0;

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

            for (int i = columnIndex; i < array.GetLength(1); i++)
            {
                sum += array[lineIndex, i];
            }

            for (int j = columnIndex; j < array.GetLength(0); j++)
            {
                multiplication *= array[j, columnIndex];
            }

            Console.WriteLine($"\nСумма {lineIndex + 1} строки: " + sum);
            Console.WriteLine($"Произведение {columnIndex + 1}  столбца: " + multiplication);
        }
    }
}
