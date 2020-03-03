using System;
using System.Threading;
using static System.Console;

namespace TimerApp
{
    class Program
    {
        static void PrintTime(object state)
        {
            WriteLine($"Time is: {DateTime.Now.ToLongTimeString()}, {state.ToString()}");
        }
        static void Main()
        {
            WriteLine("***** Working with Timer type *****\n");

            // Create the delegate for the Timer type.
            TimerCallback timeCB = new TimerCallback(PrintTime);

            // Establish timer settings.
            var _ = new Timer(
                timeCB,     // The TimerCallback delegate object.
                "Are we there yet?",    // Any info to pass into the called method (null for no info).
                0,          // Amount of time to wait before starting (in milliseconds).
                1000);      // Interval of time between calls (in milliseconds).

            WriteLine("Hit Enter key to terminate...");
            ReadLine();
        }
    }
}