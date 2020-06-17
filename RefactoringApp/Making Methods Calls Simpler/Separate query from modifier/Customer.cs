using System;

namespace RefactoringApp.Making_Methods_Calls_Simpler.Separate_query_from_modifier
{
    //you have a method that returns a value but also changes the state of an object.
    //Create two methods, one ofr the query and one for the modification. 
    public class Customer
    {
        public bool Save { get; set; } = true;

        public void CheckSecurity(string[] people)
        {
            var found = FoundMiscreant(people);
            SomeLaterCode(found);

            /////////////////////
            FoundMiscreantRefactoring(people);
            var personFound = FoundPerson(people);
            SomeLaterCode(personFound);
        }

        private void SomeLaterCode(string found)
        {
            throw new NotImplementedException();
        }

        public string FoundMiscreant(string[] people)
        {
            foreach (var person in people)
            {
                if (person.Equals("maria"))
                {
                    SendAlert();
                    return "maria";
                }
                if (person.Equals("joao"))
                {
                    SendAlert();
                    return "joao";
                }
            }

            return "We saved";
        }

        public void FoundMiscreantRefactoring(string[] people)
        {
            foreach (var person in people)
            {
                if (person.Equals("Leo"))
                {
                    SendAlert();
                }
                if (person.Equals("Jemis"))
                {
                    SendAlert();
                }
            }
        }

        public string FoundPerson(string[] people)
        {
            foreach (var person in people)
            {
                if (person.Equals("Leo"))
                {
                    return person;
                }
                if (person.Equals("Jemis"))
                {
                    return person;
                }
            }

            return "";
        }

        public void SendAlert()
        {
            Save = false;
        }
    }
}
