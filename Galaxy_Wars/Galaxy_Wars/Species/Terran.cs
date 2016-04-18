using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy_Wars.Interface;

namespace Galaxy_Wars
{

    class Terran : Species, IScience
    {
        public bool breathsInSpace { get; set; }

        public int populationBonus { get; set; }

        public string vehicleClassAllowed { get; set; }


        public bool humanCloning { get; set; }

        public Terran()
        {
            init();
            // IScience Properties Initialize
            breathsInSpace = true;
            humanCloning = true;
            populationBonus = 0;
            vehicleClassAllowed = "Destroyer";


            // Species Properties Initialize
            numberOfLegs = 2;
            lifeSpan = 80;
            speciesName = "Terran";
        }
        public override void fight (Species defender)
        {
            base.fight(defender);
            defender.population -= 5000;
            Console.WriteLine("Terran attacks. New {0} population: {1}", defender.speciesName, defender.population);
        }
    }
}
