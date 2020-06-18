using System;

namespace RefactoringApp.Making_Methods_Calls_Simpler.Rename_Method
{
    public class RenameMethod
    {
        public void Original()
        {
            var person = new Person
            {
                TelephoneNumber = "1234"
            };

            person.PrintTelNum();
        }

        public void Refactored()
        {
            var person = new Person
            {
                TelephoneNumber = "1234"
            };

            person.PrintTelephoneNumber();
        }
    }

    public class Person
    {
        public string TelephoneNumber { get; set; }

        public void PrintTelNum()
        {
            Console.WriteLine(TelephoneNumber);
        }

        public void PrintTelephoneNumber()
        {
            Console.WriteLine(TelephoneNumber);
        }
    }
}
