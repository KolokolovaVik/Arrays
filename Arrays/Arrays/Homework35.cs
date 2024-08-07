using System;

namespace Arrays
{
    internal class Homework35
    {
        static void Main(string[] args)
        {
            int sizeArray = 30;
            int counter = 1;
            int maxCountRepetitions = 0;
            int number = 0;
            int repeatableNumber = 0;
            int maxNumberRandom = 10;

            int[] numbers = new int[sizeArray];

            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(maxNumberRandom);
                Console.Write(numbers[i] + " ");
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    number = numbers[i];
                }
                else
                {
                    counter = 1;
                }

                if (maxCountRepetitions < counter)
                {
                    maxCountRepetitions = counter;
                    repeatableNumber = number;
                }
            }

            Console.WriteLine($"\nЧисло: {repeatableNumber} повторяется {maxCountRepetitions} раз");
        }
    }
}
