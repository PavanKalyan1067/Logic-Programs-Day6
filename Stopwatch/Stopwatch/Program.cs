using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StopwatchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excution Time

            var watch = Stopwatch.StartNew();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i + " ");
            }
            watch.Stop();

            Console.WriteLine($"Execution time : { watch.ElapsedMilliseconds }ms");
        
            //Ticks
        
            var sw = Stopwatch.StartNew();
            long ticks = sw.ElapsedTicks;
            Console.WriteLine($"Ticks : { ticks }" );

            //TimeSpan

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine($"TimeSpan : { ts }");
        }
    }
}