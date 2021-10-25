using System;

namespace Armstrong_Sayi_Uygulamasi
{
    class Program
    {
        /*Tüm basamaklarındaki rakamların sayı değerlerinin küpleri toplamı,kendisine eşit olan sayılara "Armstron Sayı" denir.
         * Örneğin; 1,153,370,371,407
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz : ");
            String number_Entered = Console.ReadLine();
            int number = Convert.ToInt32(number_Entered);

            int[] array = new int[number_Entered.Length];
            int counter = 0;
            int tmp = number;
            while (tmp > 0)
            {
                array[counter] = tmp % 10;
                tmp = tmp / 10;
                counter++;
            }
            int sum = 0;
            for(int i = 0; i < number_Entered.Length; i++)
            {
                sum += (array[i] * array[i] * array[i]);
            }
            if (sum == number)
                Console.WriteLine("Girilen sayı Armstrong sayıdır.");
            else
                Console.WriteLine("Girilen sayı Armstron sayı değildir.");

            Console.WriteLine(number + " == " + sum);
            Console.ReadKey();
        }
    }
}
