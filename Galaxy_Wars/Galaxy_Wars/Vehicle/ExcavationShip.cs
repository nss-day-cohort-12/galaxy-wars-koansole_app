﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    class ExcavationShip : Vehicle
    {
        public string ShovelType { get; set; }

        public override void vehicleArmor ()
        {
            armor = 30000;
        }
    }
}
