using PI_I8_AntePrskalo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_I8_AntePrskalo.Models
{
    public interface ITrain
    {
        VehicleType GetVehicleType();
        double GetGasAmount();
        double GetBatteryCharge();
    }
}
