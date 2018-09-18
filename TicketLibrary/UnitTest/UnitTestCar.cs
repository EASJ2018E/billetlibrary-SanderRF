using System;
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

        [TestMethod]
        public void DiscountTest()
        {
            //Arrange
            var car = new Car();

            //Act
            double discount = 228;
            
            //Assert
            Assert.AreEqual(discount, car.DiscountPrice());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LicenseTest()
        {
            //Arrange
            var car = new Car();
            
            //Act
            car.LicenseNumber = "24681012";

            //Assert
            Assert.AreEqual("12345678".Length, car.LicensePlate().Length);
            Assert.Fail();
        }
    }
}
