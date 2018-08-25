using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practice70483
{
    //Listing 1-3 Using the Parameterized Thread Start
    public static class Program3_UsingParameterizedThreadStart
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("Thread Proc : {0}", i);
                Thread.Sleep(1000);
            }
        }

        //public static void Main()
        //{
        //    Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));                       
        //    t.Start(5);
        //    t.Join();
        //}
    }
}
