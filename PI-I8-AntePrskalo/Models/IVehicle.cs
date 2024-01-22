using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_I8_AntePrskalo.Models
{
    interface IVehicle
    {
        double GetTicketPrice();
        void FillUpGas();
        void ChargeBattery();
    }
}
