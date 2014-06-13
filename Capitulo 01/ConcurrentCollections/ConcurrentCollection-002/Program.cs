using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentCollection_002
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<String> col = new BlockingCollection<string>();

            Task read = Task.Run(() =>
            {
                foreach (var item in col.GetConsumingEnumerable())
                {
                    Console.WriteLine(item);
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
