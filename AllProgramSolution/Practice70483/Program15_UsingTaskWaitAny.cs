using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Practice70483
{
    //site for lamda expressions
    //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions
    //Listing 1-15 Using Task.WaitAny
    public static class Program15_UsingTaskWaitAny
    {
        public static void Main()
        {
            Task<int>[] tasks = new Task<int>[3];
            tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });

            while (tasks.Length > 0)
            {
                int i = Task.WaitAny(tasks);
            }

        }
    }
}
