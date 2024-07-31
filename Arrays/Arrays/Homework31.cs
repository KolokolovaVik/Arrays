using System;

namespace Arrays
{
    internal class Homework31
    {
        static void Main(string[] args)
        {
            int sumSecondLine = 0;
            int multiplicationFirstColumn = 1;
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
                    if (i == line)
                    {
                        sumSecondLine += array[i, j];
                    }

                    if (j == column)
                    {
                        multiplicationFirstColumn *= array[i, j];
                    }

                    Console.Write(array[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Сумма второй строки: " + sumSecondLine);
            Console.WriteLine("Произведение первого столбца: " + multiplicationFirstColumn);
        }
    }
}
