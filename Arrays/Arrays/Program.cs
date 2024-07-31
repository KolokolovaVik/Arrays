//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arrays
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = { 1, 2, 3, 4 };
//            foreach (int i in numbers)
//            {
//                Console.WriteLine(i);
//            }
//            //string greeting = "Привет!";
//            //Console.WriteLine(greeting[6]);

//            //    char[] bag = new char[1];
//            //    int userX = 10, userY = 11;
//            //    Console.CursorVisible = false;

//            //    char[,] map =
//            //    {
//            //        {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
//            //        {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
//            //        {'#',' ',' ','X',' ',' ',' ',' ',' ','X',' ',' ',' ',' ','#'},
//            //        {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
//            //        {'#',' ','#',' ',' ',' ',' ','#',' ',' ','#',' ',' ',' ','#'},
//            //        {'#',' ','#',' ',' ',' ',' ','#',' ',' ','#',' ',' ',' ','#'},
//            //        {'#',' ','#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#'},
//            //        {'#',' ','#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#'},
//            //        {'#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#'},
//            //        {'#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','X',' ','#'},
//            //        {'#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#'},
//            //        {'#',' ',' ','#',' ',' ',' ',' ',' ',' ','X',' ',' ',' ','#'},
//            //        {'#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
//            //        {'#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
//            //        {'#','X',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
//            //        {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
//            //        {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
//            //        {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
//            //    };

//            //    while (true)
//            //    {
//            //        Console.SetCursorPosition(0, 20);
//            //        Console.Write("Сумка: ");
//            //        for (int i = 0; i < bag.Length; i++)
//            //        {
//            //            Console.Write(bag[i] + " ");
//            //        }

//            //        Console.SetCursorPosition(0, 0);

//            //        for (int i = 0; i < map.GetLength(0); i++)
//            //        {
//            //            for (int j = 0; j < map.GetLength(1); j++)
//            //            {
//            //                Console.Write(map[i, j]);
//            //            }
//            //            Console.WriteLine();
//            //        }

//            //        Console.SetCursorPosition(userX, userY);
//            //        Console.Write('@');

//            //        ConsoleKeyInfo keyInfo = Console.ReadKey();

//            //        switch (keyInfo.Key)
//            //        {
//            //            case ConsoleKey.UpArrow:
//            //                if (map[userY - 1, userX] != '#')
//            //                {
//            //                    userY--;
//            //                }
//            //                break;

//            //            case ConsoleKey.DownArrow:
//            //                if (map[userY + 1, userX] != '#')
//            //                {
//            //                    userY++;
//            //                }
//            //                break;

//            //            case ConsoleKey.LeftArrow:
//            //                if (map[userY, userX - 1] != '#')
//            //                {
//            //                    userX--;
//            //                }
//            //                break;

//            //            case ConsoleKey.RightArrow:
//            //                if (map[userY, userX + 1] != '#')
//            //                {
//            //                    userX++;
//            //                }
//            //                break;
//            //        }

//            //        if (map[userY, userX] == 'X')
//            //        {
//            //            map[userY, userX] = 'o';
//            //            char[] tempBag = new char[bag.Length + 1];
//            //            for (int i = 0; i < bag.Length; i++)
//            //            {
//            //                tempBag[i] = bag[i];
//            //            }
//            //            tempBag[tempBag.Length - 1] = 'X';
//            //            bag = tempBag;
//            //        }
//            //        Console.Clear();





//            //    }
//        }

//    }
//}
