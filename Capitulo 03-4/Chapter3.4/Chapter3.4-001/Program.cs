using System;
using System.Threading;


namespace Chapter3._4_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer t = new Timer(TimerCallback, null, 0, 2000);
            Console.Read();
        }

        private static void TimerCallback(object o)
        {
            Console.WriteLine("In TimerCallback: " + DateTime.Now);
            GC.Collect();
        }
    }
}
