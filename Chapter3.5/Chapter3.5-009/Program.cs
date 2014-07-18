﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._5_009
{
    class Program
    {
        static void Main(string[] args)
        {
            if (CreatePerformanceCounters())
            {
                Console.WriteLine("Created performance counters");
                Console.WriteLine("Please restart application");
                Console.ReadKey();

                return;
            }

            var totalOperationsCounter = new PerformanceCounter("MyCategory", "# opperations executed", "", false);

            var operationsPerSecondCounter = new PerformanceCounter("MyCategory", "# operations / sec", "", false);


            totalOperationsCounter.Increment();
            operationsPerSecondCounter.Increment();
        }

        private static bool CreatePerformanceCounters()
        {
            if (!PerformanceCounterCategory.Exists("MyCategory"))
            {
                CounterCreationDataCollection counters = new CounterCreationDataCollection
                {
                    new CounterCreationData("# operations executed", "Total number of operations executed",
                        PerformanceCounterType.NumberOfItems32),

                    new CounterCreationData("# operations / sec", "Number of operations executed per second",
                        PerformanceCounterType.RateOfCountsPerSecond32)
                };

                PerformanceCounterCategory.Create("MyCategory", "Sample category for Codeproject", counters);

                return true;
            }
            return false;
        }
    }
}
