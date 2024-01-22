using PI_I8_AntePrskalo.Enums;
using PI_I8_AntePrskalo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_I8_AntePrskalo.Services
{
    public class EmployeeService
    {
        public double EmployeeCutLargeTrain(ITrain largeTrain, TerminalEmployee employee)
        {
            double ticketPrice = largeTrain.GetVehicleType() == VehicleType.Bus ? 8 : 10;
            EmployeeType employeeType = employee.GetEmployeeType();

            return (employeeType == EmployeeType.HigherPaid) ? ticketPrice * 0.11 : ticketPrice * 0.1;
        }

        public void FillGasIfNeededAndLoad(ITrain train)
        {
            Console.WriteLine("Gas amount:" + train.GetGasAmount());
            if (train.GetGasAmount() < 10)
            {
                Console.WriteLine("Gas is low, filling up...");
            }
        }

        public void ChargeIfNeededAndLoad(ITrain train)
        {
            Console.WriteLine("Battery charge:" + train.GetBatteryCharge());
            if (train.GetBatteryCharge() < 10)
            {
                Console.WriteLine("Battery is low, charging up...");
            }

            Console.WriteLine("Vehicle loaded...");
        }
    }
}
