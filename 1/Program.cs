using System;

namespace WriteDataToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dosyaya Veri Yazma için C# da 4 adet yöntem var
             * 1.Yöntem:
             * Dizi elemanlarını satır satır text dosyasına yazdırma
             */
            string[] rows = { "Number:1", "Name: Harry", "Surname: Styles" };
            System.IO.File.WriteAllLines(@"C:\Users\eda\Desktop\csharp_examples\write.txt",rows);
            
        }
    }
}
