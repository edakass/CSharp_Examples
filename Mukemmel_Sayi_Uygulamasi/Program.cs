using System;

namespace ConsoleApp1
{
    class Program
    {
         //1 ile 10000 arasındaki Mükemmel Sayıları ekrana yazdıran programın kodu
        static void Main(string[] args)
        {
            int sum = 0;
            int counter = 0;
            for(int number = 1; number < 10000; number++)
            {
                for(int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                        sum += i;
                }
                if (sum == number)
                {
                    Console.WriteLine(number);
                    counter++;
                }
                sum = 0;
            }
            Console.WriteLine("1 ile 10000" + counter + " tane Mükemmel Sayı vardır.");
            Console.ReadKey();
        }
    }
}
