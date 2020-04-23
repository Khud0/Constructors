using System;

namespace Constructors
{
    class PeoplePrinter
    {
        public static void Print(params Person[] people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
