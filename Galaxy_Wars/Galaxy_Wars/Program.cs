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

            //Console.WriteLine("Test species/terran population: {0}", terran1.population);
            //Console.WriteLine("Test terran lifespan: {0}", terran1.lifeSpan);
            //Console.WriteLine("Test terran humanCloning: {0}", terran1.humanCloning);
            //Console.WriteLine("Test Zerg: {0}", zerg1.intimidation);



            // test loop through 25 years
            int counter = 1;
            bool gameOver = false;
            int anomaly = 0;
            while (!gameOver && counter <= 50) // test final count of 50 for now
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
                    } else {
                        // Religion looses an additional 2%
                    }

                // War and Science
                    // War kills 10,000 from opponent
                    zerg1.fight(terran1);
                    // Science gains 5,000
                    terran1.fight(zerg1);
                    if (anomaly == 2)
                    {
                        // War looses an additional 2%
                    } else {
                        // Science looses an additional 2%
                    }

                // Religion and War
                    // Religion converts 1% of the opponent's current population to their side
                    protoss1.fight(terran1);
                    // War kills 10,000 from opponent
                    zerg1.fight(protoss1);
                    if (anomaly == 1)
                    {
                        // Religion looses an additional 2%
                    } else {
                        // War looses an additional 2%
                    }
                
                // Check for a loser
                if (terran1.population <= 0) {
                    Console.WriteLine("Terran has lost");
                    gameOver = true;
                }
                if (protoss1.population <= 0)
                {
                    Console.WriteLine("Protoss has lost");
                    gameOver = true;
                }
                if (zerg1.population <= 0)
                {
                    Console.WriteLine("Zerg has lost");
                    gameOver = true;
                }

            }

            Console.WriteLine("Program End");

            Console.ReadKey();


        }
    }
}
