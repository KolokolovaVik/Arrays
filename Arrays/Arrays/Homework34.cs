using System;

namespace Arrays
{
    internal class Homework34
    {
        static void Main(string[] args)
        {
            const string CommandSum = "Sum";
            const string CommandExit = "Exit";

            int[] numbers = new int[0];

            bool isWork = true;

            while (isWork)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Пользователь ввёл числа: ");

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + "|");
                }

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
                        Console.WriteLine("Программа завершена.");
                        break;

                    default:
                        int[] tempNumbrs = new int[numbers.Length + 1];

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            tempNumbrs[i] = numbers[i];
                        }

                        tempNumbrs[tempNumbrs.Length - 1] = Convert.ToInt32(userInput);
                        numbers = tempNumbrs;
                        break;
                }

                Console.WriteLine("Нажмите любую клавишу.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
