using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy_Wars.Interface;

namespace Galaxy_Wars
{
    class Protoss : Species, IReligion
    {
        public int populationBonus { get; set; }

        public bool radical { get; set; }

        public string vehicleClassAllowed { get; set; }

        public int zenUnified { get; set; }


        public Protoss()
        {
            init();
            // IReligion Properties Initialize
            populationBonus = 0;
            radical = true;
            vehicleClassAllowed = "HeavensGate";
            zenUnified = 0;


            // Species Properties Initialize
            numberOfLegs = 2;
            lifeSpan = 100;
        }
        public override void fight(Species defender)
        {
            base.fight(defender);
            // determine conversion amount before attack
            int convertedPop = Convert.ToInt32(defender.population * 0.01);
            Console.WriteLine("Converted Population: {0}", convertedPop);
            defender.population -= convertedPop;
            Console.WriteLine("Protoss attacks. New {0} population: {1}", defender.speciesName, defender.population);
            // Should implement a conversion function on base species class (either for attack or defense)
            population += convertedPop;
            Console.WriteLine("Protoss population after conversion: {0}", population);
        }
    }

}
