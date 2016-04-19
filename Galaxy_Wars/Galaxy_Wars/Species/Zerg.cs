using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy_Wars.Interface;

namespace Galaxy_Wars
{
    class Zerg : Species, IWar
    {
        public int intimidation { get; set; }

        public int populationBonus { get; set; }

        public string vehicleClassAllowed { get; set; }

        public string weapons { get; set; }

        public Zerg()
        {
            init();

            // IWar Properties Initialize
            intimidation = 100;
            populationBonus = 200;
            vehicleClassAllowed = "Overseer";
            weapons = "claws";

            // Species Properties Initialize
            numberOfLegs = 4;
            lifeSpan = 50;
            speciesName = "Zerg";
            conversionModifier = 0.01;
            strength = 30000;
            vsReligionBonus = false;
            vsScienceBonus = true;
            vsWarBonus = false;
        }

        public static void Vehicle ()
        {
            Overseer overseer1 = new Overseer();
        }

        public override void fight (Species defender)
        {
            //strenght += overseer1.weaponPower;
            base.fight(defender);
            Console.WriteLine("Zerg attacks. New {0} population: {1}", defender.speciesName, defender.population);
            population -= 2500;
            Console.WriteLine("Zerg loses 2,500 due to overaggression. Current population: {0}", population);
        }
    }
}
