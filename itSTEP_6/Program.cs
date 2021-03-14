using System;
using WorldOfTanks;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace itSTEP_6
{

    class Program
    {
        public static void TankWar(List<T34> t34s, List<PANTHER> panthers)
        {
            Console.Clear();
            int counter = 1;
            Console.WriteLine("Starting fight!");
            var T34AndPanther = t34s.Zip(panthers, (t, p) => new { t34 = t, panther = p });
            foreach(var pair in T34AndPanther)
            {
                Console.WriteLine("Duel # {0}", counter++);
                Console.WriteLine("Tank on the left:\n\n{0}\nTank on the right:\n\n{1}",pair.t34.ShowInfo(), pair.panther.ShowInfo());


                Thread.Sleep(1500);
                Console.WriteLine("\nBoom!\n");

                Thread.Sleep(1000);
                Console.WriteLine("Swish!\n");

                Thread.Sleep(1000);
                Console.WriteLine("Kaboom!\n");
                Thread.Sleep(1000);
                if ((pair.t34^pair.panther) == pair.t34)
                {
                    Console.WriteLine("Tank on the left won! Congratz!");
                }
                else
                {
                    Console.WriteLine("Tank on the right won! Congratz!");
                }
                Console.WriteLine("Press ENTER to move to the next fight");
                Console.ReadKey();
                Console.Clear();

            }
        }


        static void Main(string[] args)
        {
            Console.Clear();
            List<PANTHER> Pantheras = new List<PANTHER> {
            new PANTHER("Panther_1"),
            new PANTHER("Panther_2"),
            new PANTHER("Panther_3"),
            };

            List<T34> T34S = new List<T34> {
            new T34("T34_1"),
            new T34("T34_1"),
            new T34("T34_1"),
            };

            TankWar(T34S, Pantheras);



        }
    }
}
