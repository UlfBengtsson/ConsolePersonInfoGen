using ConsoleInfoGen.Models;
using System;
using Xunit;

namespace XUnitTestPersonInfoGen
{
    public class AdressTest
    {
        [Fact]
        public void CerateAdressOK()
        {
            //Arrange
            string country = "United_x_test";
            string city = "test_city";
            string road = "test_street";

            //Act
            Adress testAdress = new Adress(country, city, road);

            //Assert
            Assert.NotNull(testAdress);
            Assert.Equal(country, testAdress.Country);
            Assert.Equal(city, testAdress.City);
            Assert.Equal(road, testAdress.Road);
        }

        [Fact]
        public void InfoUsesCorrectData()
        {
            //Arrange
            string country = "United_x_test";
            string city = "test_city";
            string road = "test_street";

            //Act
            string info = new Adress(country, city, road).Info();

            //Assert
            Assert.Contains(country, info);
            Assert.Contains(city, info);
            Assert.Contains(road, info);
        }
    }
}
