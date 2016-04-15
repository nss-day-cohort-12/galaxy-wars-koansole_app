using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars.Interface
{
    interface IWar
    {
        string weapons { get; set; }
        int intimidation { get; set; }
        string vehicleClassAllowed { get; set; }
        int populationBonus { get; set; }
    }
}
