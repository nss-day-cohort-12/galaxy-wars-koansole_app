﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    class Overseer : Vehicle
    {
        public bool SpawnChangling { get; set; }

        public override void weaponAttack()
        {
            weaponPower = 30000;
        }
    }
}
