using System;
using System.Threading;
using System.Collections.Generic;

namespace Testen
{
    class Program
    {
        public static void sep()
        {
            Console.WriteLine("************");
            //Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            List<string> hallo = new List<string>();
            hallo.Add("test1");
            hallo.Add("test2");
            hallo.Add("test3");
            foreach (var item in hallo)
            {
                Console.WriteLine(item);
            }
            
            List<Player> Spieler = new List<Player>();

            Spieler.Add(new Player("Fritz", 12));
            Spieler.Add(new Player("Olaf", 55));
            Spieler.Add(new Player("Jürgen", 55));
            sep();
            foreach (var item in Spieler)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.age);
                sep();
            }
            sep();
            sep();
            Console.WriteLine();
            //ThreadsRef begin
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            Thread thread1 = new Thread(ThreadsRef.CountDown);
            Thread thread2 = new Thread(ThreadsRef.CountUp);
            thread1.Start();
            thread2.Start();
            //Console.WriteLine(mainThread.Name);
            //threads end
        }
    }

    class Player
    {
        public string name { get; set; }
        public int age { get; set; }

        // ctor tab tab
        public Player (string _name, int _age)
        {
            name = _name;
            age = _age;
        }



    }

}
