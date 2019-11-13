using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInfoGen.Models
{
    public class Adress
    {
        public string City { get; set; }
        public string Road { get; set; }
        public string Country { get; set; }

        public Adress(string country, string city, string road)
        {
            Country = country;
            City = city;
            Road = road;
        }

        public string Info()
        {
            return $"Country: {Country}\nCity: {City}\nStreet: {Road}";
            //"Country: {0}\nCity: {1}\nStreet: {2}", Country, City, Road
        }
    }
}
