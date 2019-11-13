using ConsoleInfoGen.Models;
using System;
using Xunit;

namespace XUnitTestPersonInfoGen
{
    public class PersonTest
    {

        [Fact]
        public void CeratePersonOK()
        {
            //Arrange
            string country = "United_x_test";
            string city = "test_city";
            string road = "test_street";
            Adress adress = new Adress(country, city, road);
            string firstName = "testy";
            string lastName = "testsson";
            string job = "tester";

            //Act
            Person testPerson = new Person(firstName, lastName, job, adress);

            //Assert
            Assert.NotNull(testPerson);
            Assert.Equal(firstName, testPerson.FirstName);
            Assert.Equal(lastName, testPerson.LastName);
            Assert.Equal(job, testPerson.Job);
            Assert.Equal(adress, testPerson.Adress);

        }

        [Fact]
        public void PersonInfoDataOK()
        {
            //Arrange
            string country = "United_x_test";
            string city = "test_city";
            string road = "test_street";
            Adress adress = new Adress(country, city, road);
            string firstName = "testy";
            string lastName = "testsson";
            string job = "tester";

            //Act
            string info = new Person(firstName, lastName, job, adress).Info();

            //Assert
            Assert.Contains(firstName, info);
            Assert.Contains(lastName, info);
            Assert.Contains(job, info);
            Assert.Contains(adress.Info(), info);

        }
    }
}
