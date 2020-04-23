﻿using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = 
            {
                new Person("Tiffany", new DateTime(2019, 11, 6)),
                new Person("Robot", new DateTime(2000, 1, 1)),
                new Person("Santa", new DateTime(1, 1, 1))
            };

            PeoplePrinter.Print(people);
        }
    }
}
