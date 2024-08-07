using System;

namespace Arrays
{
    internal class Homework37
    {
        static void Main(string[] args)
        {
            string text = "Split это город в Хорватии.";

            string[] substring = text.Split();

            foreach (string sub in substring)
            {
                Console.WriteLine(sub);
            }
        }
    }
}
