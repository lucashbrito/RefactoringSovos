using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringApp.DealingWithGeneralization.PullUpMethod
{
    public abstract class ReportRefactored
    {
        private int Id { get; set; }
        private string Name { get; set; }
        protected abstract DateTime GetStartDate();

        public object GenerateReport()
        {
            Console.WriteLine("Generating Report...");

            var startDate = GetStartDate();

            return new object();
        }
    }

    public class OtherListingReportRefactored : ReportRefactored
    {
        private IEnumerable<string> Headers { get; set; }

        public IEnumerable<string> GetHeaders()
        {
            return Headers;
        }

        protected override DateTime GetStartDate()
        {
            return  DateTime.UtcNow;
        }
    }

    public class VATReturnRefactored : ReportRefactored
    {
        private string CountryCode { get; set; }

        public string GetCountry()
        {
            return CountryCode;
        }

        protected override DateTime GetStartDate()
        {
            return DateTime.UtcNow.AddMonths(-1);
        }
    }
}