using System;
using System.Collections.Generic;

namespace Constructors
{
    class Person
    {
        // Properties
        public string Name { get; set; }
        public DateTime Birthdate { private get; set; }
        public List<Item> Belongings { get; set; }

        // Constructors
        public Person()
        {
            Belongings = new List<Item>();
        }
        public Person(string name, DateTime birthdate)
            : this()
        {   
            this.Name = name;
            this.Birthdate = birthdate;          
        }
        

        // Calculated Properties
        public int Age
        {
            get 
            {
                var timeSpan = DateTime.Today - Birthdate;
                int yearsOld = timeSpan.Days / 365;
                return yearsOld;
            }
        }

        public override string ToString()
        {
            return $"{Name} is {Age} years old.";
        }
    }
}
