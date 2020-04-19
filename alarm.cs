using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stationMeteo
{
    public enum AlarmSource
    {
        SYSTEM,
        SENSOR,
    }

    public enum AlarmDetails
    {
        NONE,
        OVERCURRENT,
        OVERVOLTAGE,
        TEMPSURGE,

    }

    public enum AlarmStatus
    {
        ACTIVE,
        INACTIVE
    }


}


