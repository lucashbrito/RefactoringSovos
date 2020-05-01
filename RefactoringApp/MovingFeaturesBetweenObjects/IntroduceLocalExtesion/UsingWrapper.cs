using System;

namespace RefactoringApp.MovingFeaturesBetweenObjects.IntroduceLocalExtesion
{
    public class UsingWrapper
    {
        public SpecialDateTime PreviousDate { get; set; }
        void Example()
        {
            var newStart = new DateTime(2020, 01, 01 + 1);
        }

        void ExampleUsingWrapper()
        {
            var nextStart = PreviousDate.NextStart;
        }

    }

    public class SpecialDateTime
    {
        public DateTime Date { get; }

        public DateTime NextStart => new DateTime(Date.Year, Date.Month, Date.Day + 1);

        public SpecialDateTime(DateTime date)
        {
            Date = date;
        }
    }
}
