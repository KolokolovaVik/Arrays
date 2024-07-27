using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sectors = { 1, 6, 16, 28, 119 };

            while (true)
            {
                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i+1}: {sectors[i]} мест");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
