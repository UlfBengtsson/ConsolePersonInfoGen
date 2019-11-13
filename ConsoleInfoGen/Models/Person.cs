using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInfoGen.Models
{
    public class Person
    {
        private static int idCounter = 1;

        public readonly int id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + ' ' + LastName;
            }
        }
        public string Job { get; set; }
        public Adress Adress { get; set; }


        public Person(string firstName,
                      string lastName,
                      string job,
                      Adress adress)
        {
            id = idCounter++;   //can only set readonly in constructor
            FirstName = firstName;
            LastName  = lastName;
            Job       = job;
            Adress    = adress;
        }

        public string Info()
        {
            return $"Id: {id} Fullname: {FullName}\nWork: {Job}\nLivs: {Adress.Info()}";
        }
    }
}
