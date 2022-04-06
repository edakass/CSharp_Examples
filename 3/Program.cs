using System;

namespace WriteDataToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dosyaya Veri Yazma için C# da 4 adet yöntem var
             * 3.Yöntem:
             * Bir dizideki yalnızca istenilen elemanları text dosyasına yazdırma
             */
            string[] staff = { "Staff: Eda Kaş", "Staff: Robert Pattinson","Manager: Bella Stay","Manager: John Lyon"};
            // using  ile çağrılar ve akışlar otomatik olarak kapanıyor
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\eda\Desktop\csharp_examples\write3.txt"))
            {
                //Yeni streamWriter oluşturmuş olduk,nesnesine file ismi verdim
                foreach (string rowkeep in staff)
                {
                    //ne kadar stuff'ımız varsa foreach döngüsüde o kadar çalışacak
                    //bu foreach döngüm dört defa çalışacak
                    if (rowkeep.Contains("Manager"))
                    {
                        file.WriteLine(rowkeep);
                    }
                }
            
            }

          

            
        }
    }
}
