using System;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace ConcurrentCollection_001
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<String> col = new BlockingCollection<string>();

            Task read = Task.Run(() =>
            {
                while (true)
                {
                    Console.WriteLine(col.Take());
                }
            });

            Task write = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s))
                    {
                        break;
                    }
                    col.Add(s);
                }
            });

            write.Wait();

        }
    }
}
