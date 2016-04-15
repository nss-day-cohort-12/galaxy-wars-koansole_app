using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy_Wars.Interface;

namespace Galaxy_Wars.Species
{
    class Protoss : Species, IReligion
    {

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

        public bool radical
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

        public int zenUnified
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

    }

}
