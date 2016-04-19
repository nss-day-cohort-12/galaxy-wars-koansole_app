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
        public bool vsReligionBonus { get; set; }
        public bool vsScienceBonus { get; set; }
        public bool vsWarBonus { get; set; }
        public string speciesName { get; set; }
        public string speciesType { get; set; }
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
        public double conversionModifier { get; set; }

        // All Species initialize with these constants
        public void init ()
        {
            population = 1000000;
            Console.WriteLine("Species Created");
        }

        public bool bonusAttack (Species defender) // boolean return
        {
            return ((vsWarBonus && defender.speciesType == "Warfare") || (vsScienceBonus && defender.speciesType == "Science") || (vsReligionBonus && defender.speciesType == "Religion"));    
        }


        public virtual void fight (Species defender)
        {   
            // determine bonus attack value (if any)
            double bonusValue = bonusAttack(defender) ? 1.02 : 0;
            int attackValue = Convert.ToInt32(strength * bonusValue);
            Console.WriteLine("{0} attacks {1} and kills {2}", speciesName, defender.speciesName, strength);
            defender.population -= strength;
        }
        public void loserMethod()
        {
            int convertedPop = Convert.ToInt32(population * 0.01);
            population -= convertedPop;
        }
        public bool checkForLoser()
        {
            if (population <= 0)
            {
                Console.WriteLine("{0} has been vanquished", speciesName);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
