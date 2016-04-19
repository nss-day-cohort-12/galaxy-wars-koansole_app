using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy_Wars;

namespace Galaxy_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Galaxy Wars Testing");
            //string test1 = Console.ReadLine();
            //Console.WriteLine("You entered the number {0}", test1);

            // Species Instance Declarations
            Terran terran1 = new Terran();
            Zerg zerg1 = new Zerg();
            Protoss protoss1 = new Protoss();

            terran1.fight(zerg1);
            zerg1.fight(terran1);
            protoss1.fight(terran1);
            protoss1.fight(zerg1);


            // test loop through 25 years
            int counter = 1;
            bool gameOver = false;

            // Fight while loop
            while (!gameOver)
            {
                Console.WriteLine("Year: {0}", counter);
                if (counter % 25 == 0)
                {
                    Console.WriteLine("Anomaly enacted");
                }
                counter++;
                // temporary gameOver
                if (counter >= 50) { gameOver = true; }
            }

            Console.WriteLine("Program End");

            Console.ReadKey();

        }
    }
}
