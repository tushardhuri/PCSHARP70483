using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practice70483
{
    //Listing 1-2 Using Background Thread
    public static class Program2_UsingBackgroundThread
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine("Thread Proc : {0}",i);
                Thread.Sleep(1000);
            }
        }

        //public static void Main()
        //{
        //    Thread t = new Thread(new ThreadStart(ThreadMethod));
        //    //t.IsBackground = true;// Does not display the thread in Console
        //    t.IsBackground = false;//Displays the thread in Console
        //    t.Start();
        //}
    }
}
