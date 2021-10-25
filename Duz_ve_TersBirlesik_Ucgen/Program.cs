using System;

namespace Duz_ve_TersBirlesik_Ucgen
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (int k = 2; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 9; i >= 1; i--)
            {
                for (int j = 1; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (int k = 2; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
