using System;

namespace Arrays
{
    internal class Homework36
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int sizeArray = 10;
            int randomNumber = 100;

            int[] numbers = new int[sizeArray];

            Console.WriteLine("Массив:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(randomNumber);
                Console.Write(numbers[i] + " ");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int tempNumber = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = tempNumber;
                    }
                }
            }

            Console.WriteLine("\nОтсортированный массив от меньшего к большему:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
