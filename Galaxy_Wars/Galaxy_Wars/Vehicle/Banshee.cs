using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    class Banshee : Vehicle
    {
        public bool StealthDrive { get; set; }

        public override void weaponAttack()
        {
            weaponPower = 3000;
        }
    }
}
