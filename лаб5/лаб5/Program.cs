using System;
using System.Diagnostics;

namespace лаб5
{
    class Program
    {

            static void Main(string[] args)
            {

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int[] C = new int[2];


                for (int j = 500000000; j > 0; j--)
                {
                    C[0]+=2;
                   
                }

                Console.WriteLine(C[0]);

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

        }
        
    }
}
