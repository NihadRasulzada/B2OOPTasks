using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task1
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public bool IsAdult
        {
            get
            {
                return Age >= 18;
            }
        }

        public Person(string name, string surname, byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
