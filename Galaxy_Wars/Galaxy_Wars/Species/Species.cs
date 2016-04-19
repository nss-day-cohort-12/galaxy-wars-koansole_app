using Galaxy_Wars.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    class Species
    {
        public string speciesName { get; set; }
        public int numberOfLegs { get; set; }
        public int speed { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int defense { get; set; }
        public int reproductionRate { get; set; }
        public int numberOfHeads { get; set; }
        public int numberOfBrainTumors { get; set; }
        public int lifeSpan { get; set; }
        public int population { get; set; }
        public int heatResistance { get; set; }
        public void loserMethod ()
        {
            int convertedPop = Convert.ToInt32(population * 0.02);
            population -= convertedPop;
        }
        // All Species initialize with these constants
        public void init ()
        {
            population = 1000000;
            Console.WriteLine("Species Created");
        }

        public virtual void fight (Species defender)
        {
            defender.population -= 20000;
            Console.WriteLine("Defender: {0}", defender.speciesName);
        }
        public bool checkForLoser()
        {
            if (population <= 0)
            {
                Console.WriteLine("{0} has been vanquished", speciesName);
                return true;
            } else
            {
                return false;
            }
        }
    }
}
