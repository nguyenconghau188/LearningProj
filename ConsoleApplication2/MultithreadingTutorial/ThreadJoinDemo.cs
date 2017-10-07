using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingTutorial
{
    class ThreadJoinDemo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Create new thread");

            Thread letgoThread = new Thread(LetGo);

            letgoThread.Start();

            letgoThread.Join();

            Console.WriteLine("Main thread ends");

            Console.Read();
        }

        private static void LetGo()
        {
            for (int i =0; i< 15; i++)
            {
                Console.WriteLine("Let's Go " + i);
            }
        }
    }
}
