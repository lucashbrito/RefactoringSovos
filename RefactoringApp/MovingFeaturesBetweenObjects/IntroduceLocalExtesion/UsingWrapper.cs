using System;

namespace RefactoringApp.MovingFeaturesBetweenObjects.IntroduceLocalExtesion
{
    public class UsingWrapper
    {
        public Transaction PreviousDate { get; set; }
        void Service()
        {
            var newStart = new DateTime(2020, 01, 01 + 1);
        }

        void ExampleUsingWrapper() 
        {
            var nextStart = PreviousDate.NextStart;
        }

    }

    public class Transaction
    {
        public DateTime Date { get; }

        public DateTime NextStart => new DateTime(Date.Year, Date.Month, Date.Day + 1);

        public Transaction(DateTime date)
        {
            Date = date;
        }
    }
}
