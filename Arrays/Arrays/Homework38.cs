using System;

namespace Arrays
{
    internal class Homework38
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Насколько элементов вы хотите сдвинуть массив влево?");
            int shift = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < numbers.Length - shift; j++)
            {
                int tempVariable = numbers[j];
                numbers[j] = numbers[j + shift];
                numbers[j + shift] = tempVariable;
            }

            Console.WriteLine($"Массив со сдвигом влево на: {shift}.");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}