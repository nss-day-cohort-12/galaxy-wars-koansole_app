using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    class Fight_Logic
    {
        // inital attack on both sides
        public void initalAttack (Species CurrentSpecies)
        {
            // subtract 20,000 from the current popoulation
            CurrentSpecies.population -= 20000;
        }

        public void WarAttack (Species CurrentSpecies)
        {
            CurrentSpecies.population -= 10000;
        }

        public void ReligionAttack(Species CurrentSpecies)
        {
            private int _adder = (CurrentSpecies.population * 0.01)
            Instance_of_Religion.population += _adder;
            CurrentSpecies.population -= _adder;
        }

        public void ScienceAttack()
        {
            Instance_of_Science.population += 5000;
        }

        public void LoserLogic(Species CurrentSpecies)
        {
            CurrentSpecies.population -= (CurrentSpecies.population * 0.02);
        }
    }
}
