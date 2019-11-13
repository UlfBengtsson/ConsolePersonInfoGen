using System;
using Lexicon.CSharp.InfoGenerator;
using ConsoleInfoGen.Models;

namespace ConsoleInfoGen
{
    class Program
    {
        static readonly InfoGenerator infoGen = new InfoGenerator(DateTime.Now.Millisecond);

        static void Main(string[] args)
        {

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(RandomPerson().Info());
            }
            
        }

        static Adress RandomAdress()
        {
            string country = infoGen.NextCountry();
            string city = infoGen.NextCity();
            string road = infoGen.NextStreet();

            Adress adress = new Adress(country,city,road);

            return adress;
        }

        static Person RandomPerson()
        {
            string first = infoGen.NextFirstName();
            string last = infoGen.NextLastName();
            string job = infoGen.NextJob();
            Adress adress = RandomAdress();

            Person person = new Person(first, last, job, adress);

            return person;
        }
    }
}
