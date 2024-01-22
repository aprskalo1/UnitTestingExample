using PI_I8_AntePrskalo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_I8_AntePrskalo.Models
{
    public class LargeTrain : ITrain
    {
        private readonly VehicleType vehicleType;

        public LargeTrain(VehicleType type)
        {
            vehicleType = type;
        }

        public double GetBatteryCharge()
        {
            Random rnd = new Random();
            return rnd.Next(0, 100);
        }

        public double GetGasAmount()
        {
            Random rnd = new Random();
            return rnd.Next(0, 100);
        }

        public VehicleType GetVehicleType()
        {
            return vehicleType;
        }
    }
}
