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
            // End prompt for screen display

            Terran terran1 = new Terran();
            Zerg zerg1 = new Zerg();
            Protoss protoss1 = new Protoss();

            Console.WriteLine("Test species/terran population: {0}", terran1.population);
            Console.WriteLine("Test terran lifespan: {0}", terran1.lifeSpan);
            Console.WriteLine("Test terran humanCloning: {0}", terran1.humanCloning);
            Console.WriteLine("Test Zerg: {0}", zerg1.intimidation);

            terran1.fight(zerg1);
            zerg1.fight(terran1);
            protoss1.fight(terran1);


            // test loop through 25 years
            int counter = 1;
            bool gameOver = false;
            while (!gameOver && counter <= 50) // test final count of 50 for now
            {
                Console.WriteLine("Year: {0}", counter);
                if (counter % 25 == 0)
                {
                    Console.WriteLine("Anomaly enacted");
                }
                counter++;
            }

            Console.WriteLine("Program End");

            Console.ReadKey();

            // year counter
            // check for year 25
            // randomize anomaly

            // Science and Religion
                // subtract 20,000 from both
                // Science gains 5,000
                // Religion converts 1% of the opponent's current population to their side
                // Religion looses an additional 2%

            // War and Science
                // subtract 20,000 from both
                // War kills 10,000 from opponent
                // Science gains 5,000
                // Science looses an additional 2%

            // Religion and War
                // subtract 20,000 from both
                // Religion converts 1% of the opponent's current population to their side
                // War kills 10,000 from opponent
                // War looses an additional 2%

        }
    }
}
