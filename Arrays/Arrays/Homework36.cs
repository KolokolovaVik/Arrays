//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arrays
//{
//    internal class Homework36
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = new int[30];
//            Random ra = new Random();
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                numbers[i] = ra.Next(100);
//            }

//            for (int i = 0; i < numbers.Length - 1; i++)
//            {
//                for (int j = 0; j< numbers.Length - 1; j++)
//                    if (numbers[j] > numbers[j +1])
//                    {
//                        int temp = numbers[j + 1];
//                        numbers[j  + 1] = numbers[j];
//                        numbers[j] = temp;
//                    }


//            }

//            for (int i = 0; i < numbers.Length; i++)
//            {
//                Console.Write(numbers[i] + " ");
//            }
//        }
//    }
//}
