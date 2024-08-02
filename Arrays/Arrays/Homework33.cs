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

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] == numbers[numbers.Length - 1])
                {
                    if (numbers[i] > numbers[i - 1])
                    {
                        Console.WriteLine("\nЛокальный максимум: " + numbers[i]);
                    }
                }

                if (numbers[i] != numbers[numbers.Length - 1] && numbers[i] != numbers[0])
                {
                    if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                    {
                        Console.WriteLine("\nЛокальный максимум: " + numbers[i]);
                    }
                }

                if (numbers[i] == numbers[0])
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        Console.WriteLine("\nлокальный максимум: " + numbers[i]);
                    }
                }
            }
        }
    }
}


