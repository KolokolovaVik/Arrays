using System;

namespace Arrays
{
    internal class Homework34
    {
        static void Main(string[] args)
        {
            const string CommandSum = "Sum";
            const string CommandExit = "Exit";

            int[] numbers = new int[1];

            bool isWork = true;

            while (isWork)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Пользователь ввёл числа: ");

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    Console.Write(numbers[i] + "|");
                }

                int[] tempNumbrs = new int[numbers.Length + 1];

                for (int i = 0; i < numbers.Length; i++)
                {
                    tempNumbrs[i] = numbers[i];
                }

                Console.WriteLine("\nВведите число: ");
                tempNumbrs[numbers.Length - 1] = Convert.ToInt32(Console.ReadLine());
                numbers = tempNumbrs;

                Console.SetCursorPosition(0, 5);
                Console.WriteLine($"Введите команду:\n{CommandSum} - для вывода суммы введённых чисел. " +
                    $"\n{CommandExit} - для выхода из программы.");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandSum:
                        int sum = 0;
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine($"\nСумма всех чисел: {sum}");
                        break;

                    case CommandExit:
                        isWork = false;
                        Console.WriteLine("Команда завершена.");
                        break;

                    default:
                        Console.WriteLine("Такой команды нет");
                        break;

                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
