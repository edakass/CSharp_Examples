using System;

namespace WriteDataToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dosyaya Veri Yazma için C# da 4 adet yöntem var
             * 4.Yöntem:
             * Varolan bir text dosyasına metin ekleme.
             * Metin dosyasının içeriği silinmeden yeni ekleme
             */
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\eda\Desktop\csharp_examples\write4.txt", true))
                //bu true parametresi sayesinde veri ekleyebileceğiz,bunu eklemezsek
                //varsayılan olarak false atanır o da override işlemi yapar,yani dosyayı siler üzerine yazar
                file.WriteLine("Hello World");

        }
    }
}
