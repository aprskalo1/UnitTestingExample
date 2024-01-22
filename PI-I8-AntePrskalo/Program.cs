using PI_I8_AntePrskalo.Enums;
using PI_I8_AntePrskalo.Models;
using PI_I8_AntePrskalo.Services;
using System;

namespace PI_I8_AntePrskalo
{
    class Program
    {
        static void Main()
        {
            var lowerPaid = new TerminalEmployee(EmployeeType.LowerPaid, "Yusuf");
            var higherPaid = new TerminalEmployee(EmployeeType.HigherPaid, "Marko");
            var employeeService = new EmployeeService();

            Console.WriteLine("lowerPaid: " + lowerPaid.ToString());
            Console.WriteLine("higherPaid: " + higherPaid.ToString());

            while (true) { 
                Console.WriteLine("Do you want to load a new vehicle into a train? (y/n)");
                var answer = Console.ReadLine();
                if (answer == "y") {
                    Console.WriteLine("Do you want to load a large or small train? (l/s)");
                    var trainType = Console.ReadLine(); 

                    if(trainType == "l"){
                        Console.WriteLine("Do you want to load a bus or truck? (Bus/Truck)");
                        var vehicleType = Console.ReadLine();

                        var trainLoad = vehicleType == "Bus" ? new LargeTrain(VehicleType.Bus) : new LargeTrain(VehicleType.Truck);

                        employeeService.FillGasIfNeededAndLoad(trainLoad);
                        employeeService.ChargeIfNeededAndLoad(trainLoad);

                        Console.WriteLine(employeeService.EmployeeCutLargeTrain(trainLoad, lowerPaid));
                        Console.WriteLine(employeeService.EmployeeCutLargeTrain(trainLoad, higherPaid));

                    } else if (trainType == "s") {
                        Console.WriteLine("Do you want to load a bus or truck? (Car/Van)");
                        var vehicleType = Console.ReadLine();

                        var trainLoad = vehicleType == "Car" ? new SmallTrain(VehicleType.Car) : new SmallTrain(VehicleType.Van);

                        employeeService.FillGasIfNeededAndLoad(trainLoad);
                        employeeService.ChargeIfNeededAndLoad(trainLoad);

                        Console.WriteLine(employeeService.EmployeeCutLargeTrain(trainLoad, lowerPaid));
                        Console.WriteLine(employeeService.EmployeeCutLargeTrain(trainLoad, higherPaid));
                    }
                }
            }
        }
    }
}
