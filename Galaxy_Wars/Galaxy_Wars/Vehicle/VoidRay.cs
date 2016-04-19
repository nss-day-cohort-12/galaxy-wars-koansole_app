using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    class VoidRay : Vehicle
    {
        public bool WarpSpeed { get; set; }

        public override void weaponAttack()
        {
            weaponPower = 3000;
        }
    }
}
