using System;
using System.Threading;

namespace Practice70483
{
    //Listing 1-5 Using a thread static attribute
    public static class Program5_ThreadStaticAttribute
    {
        //If we comment thread _field the count is 20
        //[ThreadStatic]
        public static int _field;
        public static void Main()
        {
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread A : {0}", _field);
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread B : {0}",_field);
                }

            }).Start();

            Console.ReadKey();
        }
    }
}
