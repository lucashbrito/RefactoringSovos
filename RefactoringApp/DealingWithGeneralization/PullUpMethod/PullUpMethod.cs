using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringApp.DealingWithGeneralization.PullUpMethod
{
    public class Report
    {
        private int Id { get; set; }
    }

    public class OtherListingReport : Report
    {
        private string Name { get; set; }
        private IEnumerable<string> Headers { get; set; }

        public object GenerateReport()
        {
            Console.WriteLine("Generating Report...");

            var startDate = DateTime.UtcNow;

            return new object();
        }

        public IEnumerable<string> GetHeaders()
        {
            return Headers;
        }
    }

    public class VATReturn : Report
    {
        private string Name { get; set; }
        private string CountryCode { get; set; }

        public object GenerateReport()
        {
            Console.WriteLine("Generating Report...");

            var startDate = DateTime.UtcNow.AddMonths(-1);

            return new object();
        }

        public string GetCountry()
        {
            return CountryCode;
        }
    }
}
