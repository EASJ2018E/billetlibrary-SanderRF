using Microsoft.Extensions.DependencyModel.Resolution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketLibrary;

namespace UnitTest
{
    [TestClass]
    public class UnitTestCar
    {
        [TestMethod]
        public void PriceTest()
        {
            //Arrange
            var car = new Car();

            //Act
            int price = 240;

            //Assert
            Assert.AreEqual(price,car.Price());

        }
        [TestMethod]
        public void VehicleTest()
        {
            //Arrange
            var car = new Car();
            
            //Act
            string vehicle = "Bil";
            
            //Assert
            Assert.AreEqual(vehicle,car.Vehicle());
        }
    }
}
