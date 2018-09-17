using Microsoft.Extensions.DependencyModel.Resolution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketLibrary;

namespace UnitTest
{
    [TestClass]
    public class UnitTestMC
    {
        [TestMethod]
        public void PriceTest()
        {
            //Arrange
            var mc = new MC();

            //Act
            int price = 125;

            //Assert
            Assert.AreEqual(price, mc.Price());

        }
        [TestMethod]
        public void VehicleTest()
        {
            //Arrange
            var mc = new MC();

            //Act
            string vehicle = "MC";

            //Assert
            Assert.AreEqual(vehicle, mc.Vehicle());
        }
    }
}
