using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Testen
{
    class ThreadsRef
    {
        public static void CountDown()
        {
            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer 1: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer 1 complete");
        }

        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer 2: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer 2 complete");
        }

    }
}
