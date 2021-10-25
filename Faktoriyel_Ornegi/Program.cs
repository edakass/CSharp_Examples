using System;

namespace Faktoriyel_Ornegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz : ");
            int entered_num = Convert.ToInt32(Console.ReadLine());

            int fakt = 1;

            for(int i = 1; i <= entered_num; i++)
            {
                fakt *= i;
            }
            Console.WriteLine("İteratif Yöntem Faktoriyel : " + fakt);


        }
    }
}
