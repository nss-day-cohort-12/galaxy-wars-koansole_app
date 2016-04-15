using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            Terran terran = new Terran();
            Protoss protos = new Protoss();
            Zerg zerg = new Zerg()
            // year counter
            // check for year 25
            // randomize anomoly

            // Science and Religion
                // subtract 20,000 from both
                Fight_Logic.initalAttack(Species Terran);
                Fight_Logic.initalAttack(instance_of_Religion);

                // Science gains 5,000
                Fight_Logic.ScienceAttack();
                // Religion converts 1% of the opponent's current population to their side
                Fight_Logic.ReligionAttack(Species instance_of_Science);
                // Religion loses an additional 2%
                Fight_Logic.LoserLogic(Species instance_of_Religion);

            // War and Science
                // subtract 20,000 from both
                Fight_Logic.initalAttack(instance_of_War);
                Fight_Logic.initalAttack(instance of Science);
                // War kills 10,000 from opponent
                Fight_Logic.WarAttack(Species instance_of_Science);
                // Science gains 5,000
                Fight_Logic.ScienceAttack();
                // Science loses an additional 2%
                Fight_Logic.LoserLogic(Species instance_of_Science);

            // Religion and War
                // subtract 20,000 from both
                Fight_Logic.initalAttack(instance_of_Science);
                Fight_Logic.initalAttack(instance_of_Religion);

                // Religion converts 1% of the opponent's current population to their side
                Fight_Logic.ReligionAttack(Species instance_of_War);
                // War kills 10,000 from opponent
                Fight_Logic.WarAttack(Species instance_of_Religion);
                // War loses an additional 2%
                Fight_Logic.LoserLogic(Species instance_of_War);

        }
    }
}
