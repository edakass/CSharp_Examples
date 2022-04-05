using System;

namespace ReadingDataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dosyadan veri okuma işlemi iki ayrı kısımdan oluşuyor.
             * Birincisi bir txt dosyasının içeriğini string bir değişkende saklamak
             */
            string file_path = @"C:\Users\eda\Desktop\csharp_examples\mytxt.txt";
            //içeriğinin okunarak string bir değere dönüştürülmesini sağlayacağız
            //ReadAllText: Tüm metinleri oku demek
            string text = System.IO.File.ReadAllText(file_path);
            //text değişkeninin ekranda görünmesini sağlayacak
            Console.Write(text);
            //metnin ekranda bir süre görünmesi için,bir tuşa basılana kadar kalması için ReadKey i kullanacağız.
            Console.ReadKey();
        }
    }
}
