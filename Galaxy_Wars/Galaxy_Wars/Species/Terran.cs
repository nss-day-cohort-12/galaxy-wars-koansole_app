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
            conversionModifier = 0.00;
            strength = 20000;
            vsReligionBonus = true;
            vsScienceBonus = false;
            vsWarBonus = false;


        }
        public void clone ()
        {
            population += 2000;
            Console.WriteLine("Terran population increased by 2000 due to cloning advances");
        }

        public override void fight (Species defender)
        {
            // human cloning method call
            clone();
            base.fight(defender);
        }
    }
}
