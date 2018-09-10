using System;
using System.Threading;

namespace Practice70483
{
    //Listing 1-6 Using ThreadLocal<T>
    public static class Program6_ThreadLocal
    {
        //Id 1 for Thread.CurrentThread.ManagedThreadId is created in constructor
        //static Program6_ThreadLocal()
        //{
        //    Console.WriteLine("Thread Manager Id is {0}", Thread.CurrentThread.ManagedThreadId);
        //}

        public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
        {
            Console.WriteLine("Thread Manager Id is {0}",Thread.CurrentThread.ManagedThreadId);
            return Thread.CurrentThread.ManagedThreadId;
        });

        //public static void Main()
        //{
        //    new Thread(() =>
        //    {
        //        for (int i = 0; i < _field.Value; i++)
        //        {
        //            Console.WriteLine("Thread A: {0}", i);
        //        }
        //    }).Start();

        //    new Thread(() =>
        //    {
        //        for (int j = 0; j < _field.Value; j++)
        //        {
        //            Console.WriteLine("Thread B: {0}", j);
        //        }
        //    }).Start();

        //    Console.ReadKey();
        //}
    }
}
