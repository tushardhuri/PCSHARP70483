using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Practice70483
{

    //Listing 1-11 Scheduling different continuation tasks
    public static class Program11_SchedulingDifferentContinuationTasks
    {
        //public static void Main()
        //{
        //    Task<int> t = Task.Run(() =>
        //    {
        //        return 42;
        //    });

        //    t.ContinueWith((i) => { Console.WriteLine("Cancelled"); }, TaskContinuationOptions.OnlyOnCanceled);
        //    t.ContinueWith((i) => { Console.WriteLine("Faulted"); }, TaskContinuationOptions.OnlyOnFaulted);
        //    var completedTask = t.ContinueWith((i) => { Console.WriteLine("Completed"); }, TaskContinuationOptions.OnlyOnRanToCompletion);

        //    completedTask.Wait();
        //}
    }
}
