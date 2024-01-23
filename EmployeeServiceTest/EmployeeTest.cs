using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Moq;
using PI_I8_AntePrskalo.Enums;
using PI_I8_AntePrskalo.Models;
using PI_I8_AntePrskalo.Services;

namespace EmployeeServiceTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestClass]
        public class EmployeeServiceTest
        {
            [TestMethod]
            public void EmployeeCutLargeTrain_LowerPaid_ReturnsCorrectCut()
            {
                // Arrange
                var mockTrain = new Mock<ITrain>();
                mockTrain.Setup(train => train.GetVehicleType()).Returns(VehicleType.Bus);

                var mockEmployee = new Mock<TerminalEmployee>();
                mockEmployee.Setup(employee => employee.GetEmployeeType()).Returns(EmployeeType.LowerPaid);

                var employeeService = new EmployeeService();

                // Act
                var result = employeeService.EmployeeCutLargeTrain(mockTrain.Object, mockEmployee.Object);

                // Assert
                Assert.AreEqual(0.1 * 8, result); 
            }

            [TestMethod]
            public void FillGasIfNeededAndLoad_GasBelowThreshold_FillsGas()
            {
                // Arrange
                var mockTrain = new Mock<ITrain>();
                mockTrain.Setup(train => train.GetGasAmount()).Returns(5);

                var employeeService = new EmployeeService();

                // Act
                employeeService.FillGasIfNeededAndLoad(mockTrain.Object);
            }

            [TestMethod]
            public void ChargeIfNeededAndLoad_ChargeBelowThreshold_ChargesBattery()
            {
                // Arrange
                var mockTrain = new Mock<ITrain>();
                mockTrain.Setup(train => train.GetBatteryCharge()).Returns(5); 

                var employeeService = new EmployeeService();

                // Act
                employeeService.ChargeIfNeededAndLoad(mockTrain.Object);
            }
        }
    }
}