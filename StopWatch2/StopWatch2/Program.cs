using System;
using System.Diagnostics;

namespace StopWatch2
{
    class Program
    {
    static void Main(string[] args)

        {

		   public long startTimer = 0;
		public long stopTimer = 0;
		public long elapsed;

		//to start timer
		public void start()
		{
			startTimer = System.currentTimeMillis();
			Console.WriteLine("Start Time is: " + startTimer);
		}

		// to stop timer
		public void stop()
		{
			stopTimer = System.currentTimeMillis();
			Console.WriteLine("Stop Time is: " + stopTimer);
		}

		public long getElapsedTime()
		{
			elapsed = stopTimer - startTimer;
			return elapsed;

		}
	}
}
