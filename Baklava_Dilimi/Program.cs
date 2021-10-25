using System;

namespace Baklava_Dilimi
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 10; i++)
            {
                for(int j = 1; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("/");

                for(int k = 1; k <= i; k++)
                {
                    Console.Write("**");
                }
                Console.Write("\\");
                Console.WriteLine();
            }
            for(int i = 11; i >= 1; i--)
            {
                for(int j = 0; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\\");
                for(int k = 1; k < i; k++)
                {
                    Console.Write("**");
                }
                Console.Write("/");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
