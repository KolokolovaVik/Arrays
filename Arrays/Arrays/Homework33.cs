//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arrays
//{
//    internal class Homework33
//    {
//        static void Main(string[] args)
//        {
//            Random random = new Random();
//            int[] array = new int[10];

//            for (int i = 0; i < array.Length; i++)
//            {
//                array[i] = random.Next(100);
//                Console.Write(array[i] + "|");
//            }

//            for (int i = 0; i < array.Length; i++)
//            {
//                if(i < array.Length || i >= 0)
//                {
//                    if (array[i] > array[i+1] || array[i] > array[i-1] ) 
//                    {
//                        Console.WriteLine("Локальный максимум: " + array[i]);
//                    }
//                }
//            }
//        }
//    }
//}
