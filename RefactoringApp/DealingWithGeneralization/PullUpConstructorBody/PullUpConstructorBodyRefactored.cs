using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringApp.DealingWithGeneralization.PullUpConstructorBody
{
    public abstract class ReportRefactored
    {
        protected ReportRefactored(int id, string name)
        {
            Id = id;
            Name = name;
        }

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
        public OtherListingReportRefactored(int id, string name, IEnumerable<string> headers) : base(id, name)
        {
            Headers = headers;
        }

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
        public VATReturnRefactored(int id, string name, string countryCode) : base(id, name)
        {
            CountryCode = countryCode;
        }

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