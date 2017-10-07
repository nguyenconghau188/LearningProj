using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingTutorial
{
    class HelloThread
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Create new thread!");

        //    Thread newThread = new Thread(WriteB);
        //    newThread.Start();

        //    Console.WriteLine("Start newThread!");

        //    for (int i=0; i<50;i++)
        //    {
        //        Console.Write('-');
        //        Thread.Sleep(70);
        //    }

        //    Console.WriteLine("Main thread finished!");
        //    Console.Read();
        //}

        private static void WriteB()
        {
            for (int i=0;i<100;i++)
            {
                Console.Write('B');

                Thread.Sleep(100);
            }
        }
    }
}
