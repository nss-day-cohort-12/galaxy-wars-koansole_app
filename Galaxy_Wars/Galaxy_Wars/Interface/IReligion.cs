using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars.Interface
{
    interface IReligion
    {
        bool radical { get; set; }
        int zenUnified { get; set; }
        string vehicleType { get; set; }
    }
}
