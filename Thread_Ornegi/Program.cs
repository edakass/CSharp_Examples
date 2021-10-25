using System;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Ornegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread(WriteX);
            Thread th2 = new Thread(WriteO);
            th2.Priority = ThreadPriority.Highest;
            th1.Priority = ThreadPriority.Lowest;


            th1.Start();
            th2.Start();

            Console.ReadKey();
        }
        static void WriteX()
        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread1 çalışıyor");
                Thread.Sleep(1);
            }
            Console.WriteLine("Thread1 işini bitirdi");
        }

        static void WriteO()
        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread2 çalışıyor");
                Thread.Sleep(1);
            }
            Console.WriteLine("Thread2 işini bitirdi");
        }
    }
}
