using System;
using baseone;
using Rhino.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace baseoneunittest
{
    [TestClass]
    public class VehicleRepositoryTests
    {
        [TestMethod]
        public void ShouldCallAddFunction()
        {
            //Arrange
            var rhinommock = MockRepository.GenerateMock<IVehicleRepository<Vehicle>>();
            VehicleService service = new VehicleService(rhinommock);
            Bicycle bicycle = new Bicycle { vehicleID = 123, NumberOfWheels = 2, BicycleType = "bmx" };

            //Act
            rhinommock.Add(bicycle);

            //Assert
            rhinommock.AssertWasCalled(x => x.Add(bicycle));

        }
    }
}
