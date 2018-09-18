using System;
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

        [TestMethod]
        public void DiscountTest()
        {
            //Arrange
            var mc = new MC();
            
            //Act
            double discount = 118.75;

            //Assert
            Assert.AreEqual(discount, mc.DiscountPrice());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LicenseTest()
        {
            //Arrange
            var mc = new MC();

            //Act
            mc.LicenseNumber = "24681012";

            //Assert
            Assert.AreEqual("12345678".Length, mc.LicensePlate().Length);
            Assert.Fail();
        }
    }
}
