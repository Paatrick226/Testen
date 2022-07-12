using System;
using System.Collections.Generic;

namespace Testen
{
    class Program
    {
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
            Console.WriteLine("************");

            List<Player> Spieler = new List<Player>();

            Spieler.Add(new Player("Fritz", 12));
            Spieler.Add(new Player("Olaf", 55));
            Spieler.Add(new Player("Jürgen", 55));

            foreach (var item in Spieler)
            {
                Console.WriteLine(item.name);
                Console.WriteLine("\n");
                Console.WriteLine(item.age);
            }



        }
    }

    class Player
    {
        public string name { get; set; }
        public int age { get; set; }

        public Player (string _name, int _age)
        {
            name = _name;
            age = _age;
        }

    }

}
