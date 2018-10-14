using System.Threading;
using System.Threading.Tasks;

namespace Practice70483
{
    //Listing 1-14 Using Task.WaitAll
    public static class Program14_UsingTaskWaitAll
    {
        //public static void Main()
        //{
        //    Task[] tasks = new Task[3];

        //    tasks[0] = Task.Run(() =>
        //    {
        //        Thread.Sleep(1000);
        //        System.Console.WriteLine("1");
        //        return 1;
        //    });

        //    tasks[1] = Task.Run(() =>
        //    {
        //        Thread.Sleep(1000);
        //        System.Console.WriteLine("2");
        //        return 2;
        //    });

        //    tasks[2] = Task.Run(() =>
        //    {
        //        Thread.Sleep(1000);
        //        System.Console.WriteLine("3");
        //        return 3;
        //    });

        //    Task.WaitAll(tasks);
        //}
    }
}
