using System;

namespace WriteDataToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dosyaya Veri Yazma için C# da 4 adet yöntem var
             * 2.Yöntem:
             * String bir değişkeni text dosyasına yazdırma
             */
            string poem = "A ship sailing far away cannot go quietly without encountering wind waves.Wind waves are always the friends of the advancing ones.There is rather life's joy in hardship. What a monotonous voyage without a wind wave! The more hardships I suffer, the more my heart beats. -Friedrich Wilhelm Nietzsche-";
            System.IO.File.WriteAllText(@"C:\Users\eda\Desktop\csharp_examples\write2.txt", poem);

            
        }
    }
}
