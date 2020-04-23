using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Person
    {
        // Properties
        public DateTime Birthdate { get; private set; } = DateTime.Now;
        public string Name { get; set; } = "Default Name";

        // Constructor
        public Person(string name, DateTime birthdate)
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
