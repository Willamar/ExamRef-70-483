using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4._5_008
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();

            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("From");
            myStack.Push("A");
            myStack.Push("Queue");

            foreach (var item in myStack)
            {
                Console.Write(item + " ");
            }

            Console.Read();
        }
    }
}
