using System;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);

            /* Add handlers to the "Elapsed" event */
            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;

            myTimer.Start();

            Console.WriteLine("Press enter to remove the red event.");

            Console.ReadLine();

            /* Remove event handlers from the "Elapsed" event*/
            myTimer.Elapsed -= MyTimer_Elapsed1;

            Console.ReadLine();
        }
        
        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }
        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}