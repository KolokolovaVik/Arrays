using System;

namespace Arrays
{
    internal class Homework33
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int sizeArray = 30;
            int randomNumber = 100;

            int[] numbers = new int[sizeArray];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(randomNumber);
                Console.Write(numbers[i] + "|");
            }

            Console.WriteLine();

            if (numbers[0] > numbers[1])
            {
                Console.WriteLine("\nЛокальный максимум: " + numbers[0]);
            }

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    Console.WriteLine("\nЛокальный максимум: " + numbers[i]);
                }
            }

            if (numbers[numbers.Length - 1] > numbers[numbers.Length - 2])
            {
                Console.WriteLine("\nлокальный максимум: " + numbers[numbers.Length - 1]);
            }
        }
    }
}


