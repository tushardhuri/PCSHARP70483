using System;
using System.Threading;

namespace Practice70483
{
    //Listing 1-4 Stopping a thread
    public static class Program4_StoppingThreadSharedVariable
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("Thread Proc: {0}", i);
                Thread.Sleep(0);
            }
        }

        //public static void Main()
        //{
        //    bool stopped = false;

        //    Thread t = new Thread(new ThreadStart(() =>
        //    {
        //        while(!stopped)
        //        {
        //            Console.WriteLine("Running...");
        //            Thread.Sleep(1000);
        //        }
        //    }));

        //    t.Start();
        //    Console.WriteLine("Press Any Key to exit");
        //    Console.ReadKey();

        //    stopped = true;
        //    t.Join();
        //}
    }
}
