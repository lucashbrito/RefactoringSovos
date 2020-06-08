namespace RefactoringApp.MovingFeaturesBetweenObjects
{
    public class IntroduceForeignMethod
    {
        /// <summary>
        /// Mechanics
        /// Create a method in the client class that does what you needjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjn                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
        /// </summary>
        public void LegacyService()
        {                                                                             
            var viewModel = new DateViewmModel(2020, 01, 01)
            {};

            /// Do something else.

            var viewModel1 = new DateViewmModel(2020, 01, 01);
        }

        public void Refactoring()
        {
            var viewModel = DateViewmModel.Create(2020, 01, 01);

            // do something else.
        }
    }

    public class DateViewmModel
    {
        public int Year { get; }
        public int Month { get; }
        public int Day { get; }

        public  DateViewmModel(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public static DateViewmModel Create(int year, int month, int day)
        {
            return new DateViewmModel(year, month, day);
        }
    }
}

