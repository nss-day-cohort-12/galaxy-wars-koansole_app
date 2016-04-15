using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy_Wars.Interface;

namespace Galaxy_Wars.Species
{

    class Terran : Species, IScience
    {
        public bool breathsInSpace
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

        public double medicineEfficiency
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

        public Terran()
        {
            init();
            // IScience Properties Initialize
            medicineEfficiency = 100;
            populationBonus = 0;
            vehicleClassAllowed = "Destroyer";

            // Species Properties Initialize
            numberOfLegs = 2;
            lifeSpan = 80;
        }
    }
}
