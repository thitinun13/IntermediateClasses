using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            for (int i = 0; i < 2; i++)
            {
                stopwatch.start(DateTime.Now);

                for (int j = 0; j < 1000; j++)
                {
                    Thread.Sleep(1);
                }

                stopwatch.StartTime = DateTime.Today.AddDays(1);
                stopwatch.EndTime = DateTime.Today.AddYears(-1);

                stopwatch.stop(DateTime.Now);
                Console.WriteLine(stopwatch.GetInterval().ToString());
                Console.ReadLine();
            }
        }
    }
    public class Stopwatch
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        private bool running = false;

        public void start(DateTime start)
        {
            if (!running)
            {
                StartTime = start;
                running = true;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch is already running");
            }
        }
        public void stop(DateTime stop)
        {
            if (running)
            {
                EndTime = stop;
                running = false;
            }
        }

        public TimeSpan GetInterval()
        {
            var duration = EndTime - StartTime;
            return duration;
        }
    }
}
