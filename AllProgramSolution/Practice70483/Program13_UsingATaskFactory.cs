﻿using System;
using System.Threading.Tasks;

namespace Practice70483
{
    //Listing 1-13 Using a Task Factory
    public static class Program13_UsingATaskFactory
    {
        //public static void Main()
        //{
        //    Task<Int32[]> parent = Task.Run(() =>
        //    {
        //        var results = new Int32[3];

        //        TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);

        //        tf.StartNew(() => results[0] = 0);
        //        tf.StartNew(() => results[1] = 1);
        //        tf.StartNew(() => results[2] = 2);

        //        return results;
        //    });

        //    var finalTask = parent.ContinueWith(
        //        parentTask =>
        //        {
        //            foreach (int i in parentTask.Result)
        //            {
        //                Console.WriteLine(i);
        //            }
        //        });

        //    finalTask.Wait();
        //}

    }
}
