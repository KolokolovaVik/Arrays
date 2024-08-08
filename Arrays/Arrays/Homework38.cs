using System;

namespace Arrays
{
    internal class Homework38
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Насколько элементов вы хотите сдвинуть массив влево?");
            int shift = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < shift; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    int temp = numbers[j + 1];
                    numbers[j + 1] = numbers[j];
                    numbers[j] = temp;
                }
            }

            Console.WriteLine($"Массив со сдвигом влево на: {shift}.");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}