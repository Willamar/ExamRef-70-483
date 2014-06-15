using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizingResources_004
{
    class Program
    {
        static void Main(string[] args)
        {
            object gate = new object(); 
            
            bool __lockTaken = false;
            try
            {
                Monitor.Enter(gate, ref __lockTaken);
            }
            finally
            {
                if (__lockTaken)
                {
                    Monitor.Exit(gate);
                }
            }
        }
    }
}
