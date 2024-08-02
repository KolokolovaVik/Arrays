//using System;

//namespace Arrays
//{
//    internal class Homework33
//    {
//        static void Main(string[] args)
//        {
//            Random random = new Random();
//            int[] array = new int[6];
//            int localMax = int.MinValue;

//            for (int i = 0; i < array.Length; i++)
//            {
//                array[i] = random.Next(100);
//                Console.Write(array[i] + "|");
//            }

//            for (int i = array.Length - 1; i >= 0; i--)
//            {
//                if (array[i] == array[array.Length - 1])
//                {
//                    if (array[i] > array[i - 1])
//                    {
//                        localMax = array[i];
//                        Console.WriteLine("\n\nЛокальный максимум: " + localMax);
//                    }
//                }

//                if (array[i] != array[array.Length - 1] && array[i] != array[0])
//                {
//                    if (array[i] > array[i - 1] && array[i] > array[i +1])
//                    {
//                        localMax = array[i];
//                        Console.WriteLine("\nЛокальный максимум: " + localMax);
//                    }   
//                }

//                if (array[i] == array[0])
//                {
//                    if (array[i] > array[i + 1])
//                    {
//                        localMax = array[i];
//                        Console.WriteLine("\nлокальный максимум: " + localMax);
//                    }
//                }
//            }
//        }
//    }
//}


