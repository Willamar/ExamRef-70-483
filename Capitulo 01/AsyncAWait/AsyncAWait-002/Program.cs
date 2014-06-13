using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAWait_002
{
    class Program
    {
        static void Main(string[] args)
        {
            chamaMetodoAsycA();
            
            Console.WriteLine(chamaMetodoAsyncB().Result);

            Console.Read();
        }

        private static async void chamaMetodoAsycA()
        {
            await SleepAsyncA(1000);
        }

        private static async Task<bool> chamaMetodoAsyncB()
        {
            return await SleepAsyncB(1000);
        }

        static Task SleepAsyncA(int millisecondsTimeout)
        {
            return Task.Run(() => Thread.Sleep(millisecondsTimeout));
        }

        static Task<bool> SleepAsyncB(int millisecondsTimeout)
        {
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(millisecondsTimeout, -1);
            return tcs.Task;
        }

    }
}
