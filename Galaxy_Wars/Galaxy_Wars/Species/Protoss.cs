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
            speciesName = "Protoss";
            lifeSpan = 100;
            conversionModifier = 0.00;
            strength = 10000;
            vsReligionBonus = false;
            vsScienceBonus = false;
            vsWarBonus = true;


        }

        public void conversion(Species defender)
        {
            int convertedPop = Convert.ToInt32(defender.population * (0.02 - defender.conversionModifier));
            defender.population -= convertedPop;
            population += convertedPop;
            Console.WriteLine("Converted {0} Population: {1}", defender.speciesName, convertedPop);
        }

        public override void fight (Species defender)
        {
            // determine conversion amount before attack
            base.fight(defender);
            conversion(defender);
            // Should implement a conversion function on base species class (either for attack or defense)
            Console.WriteLine("Protoss population after conversion: {0}", population);
        }
    }

}
