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

            Terran terran1 = new Terran();
            Zerg zerg1 = new Zerg();
            Protoss protoss1 = new Protoss();

            //Console.WriteLine("Test species/terran population: {0}", terran1.population);
            //Console.WriteLine("Test terran lifespan: {0}", terran1.lifeSpan);
            //Console.WriteLine("Test terran humanCloning: {0}", terran1.humanCloning);
            //Console.WriteLine("Test Zerg: {0}", zerg1.intimidation);

            int counter = 1;
            bool gameOver = false;
            int anomaly = 0;

            while (!gameOver) // test final count of 50 for now
            {
                Console.WriteLine("Year: {0}", counter);
                // check for year 25
                if (counter % 25 == 0)
                {
                    Console.WriteLine("Anomaly enacted");
                    // Randomize between 3 and assign the anomoly to one of the species.
                    Random random = new Random();
                    int randomNumber = random.Next(1, 4);
                    if (randomNumber == 1) {
                        Console.WriteLine("1");
                        anomaly = 1;
                    };
                    if (randomNumber == 2)
                    {
                        Console.WriteLine("2");
                        anomaly = 2;
                    };
                    if (randomNumber == 3)
                    {
                        Console.WriteLine("3");
                        anomaly = 3;
                    };
                }

                // year counter
                counter++;
            
                // Science and Religion
                // Science gains 5,000
                terran1.fight(protoss1);
                // Religion converts 1% of the opponent's current population to their side
                protoss1.fight(terran1);
                if (anomaly == 1)
                {
                    // Science looses an additional 2%
                    terran1.loserMethod();
                } else {
                    // Religion looses an additional 2%
                    protoss1.loserMethod();
                }
                if (terran1.checkForLoser() == true || protoss1.checkForLoser() == true)
                {
                    break;
                }

                // War and Science
                // War kills 10,000 from opponent
                zerg1.fight(terran1);
                // Science gains 5,000
                terran1.fight(zerg1);
                if (anomaly == 2)
                {
                    // War looses an additional 2%
                    zerg1.loserMethod();
                } else {
                    // Science looses an additional 2%
                    terran1.loserMethod();
                }
                if (terran1.checkForLoser() == true || zerg1.checkForLoser() == true)
                {
                    break;
                }

                // Religion and War
                // Religion converts 1% of the opponent's current population to their side
                protoss1.fight(zerg1);
                // War kills 10,000 from opponent
                zerg1.fight(protoss1);
                if (anomaly == 1)
                {
                    // Religion looses an additional 2%
                    protoss1.loserMethod();
                } else {
                    // War looses an additional 2%
                    zerg1.loserMethod();
                }
                if (protoss1.checkForLoser() == true || zerg1.checkForLoser() == true)
                {
                    break;
                }

                anomaly = 0;
            }

            Console.WriteLine("Program End");

            Console.ReadKey();


        }
    }
}
