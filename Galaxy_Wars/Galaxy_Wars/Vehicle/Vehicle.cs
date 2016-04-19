using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    class Vehicle
    {
        public int speed { get; set; }
        public string weapons { get; set; }
        public bool FTL { get; set; }
        public int armor { get; set; }
        public string species { get; set; }
        public int weaponPower { get; set; }
        public string VehicleClass { get; set; }
        public virtual void weaponAttack()
        {
            weaponPower = 1000;
        }
        public virtual void vehicleArmor()
        {
            armor = 1000;
        }
    }
}
