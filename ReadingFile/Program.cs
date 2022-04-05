using System;
using System.Text;

namespace ReadingDataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dosyadan veri okuma işlemi iki ayrı kısımdan oluşuyor.
             * İkincisi bir txt dosyasının içeriğini satır satır bir dizi değişkenine atamnacak
             */
            string file_path = @"C:\Users\eda\Desktop\csharp_examples\mytxt.txt";
            //ReadAllLines - satırları oku demek
            string[] rows = System.IO.File.ReadAllLines(file_path);
            //Dizmizin elemanlarını yazdırmak için foreach kullanıyoruz.
            //dizimizin elemanları string türünde olduğu için string türünde saklıyoruz
            //foreach döngüsü dizimizin eleman sayısı kadar çalışan bir döngüdür
            foreach (string s in rows)
            {
                Console.WriteLine(s);
            }
            //Bir tuşa basılana kadar beklemesini sağlamak için
            Console.ReadKey();
        }
        
    }
}
