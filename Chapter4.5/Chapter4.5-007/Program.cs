using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4._5_007
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();

            myQueue.Enqueue("Hello");
            myQueue.Enqueue("World");
            myQueue.Enqueue("From");
            myQueue.Enqueue("A");
            myQueue.Enqueue("Queue");

            foreach (var item in myQueue)
            {
                Console.Write(item + " ");
            }

            Console.Read();
        }
    }
}
