using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy_Wars.Interface;

namespace Galaxy_Wars.Species
{
    class Zerg : Species, IWar
    {
        public int intimidation
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int populationBonus
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string vehicleClassAllowed
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string weapons
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Zerg()
        {
            init();

            // IWar Properties Initialize
            intimidation = 100;
            populationBonus = 200;
            vehicleClassAllowed = "Icarus";
            weapons = "claws";

            // Species Properties Initialize
            numberOfLegs = 4;
            lifeSpan = 50;
        }
    }
}
