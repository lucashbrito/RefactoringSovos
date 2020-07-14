using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringApp.DealingWithGeneralization.PullUpConstructorBody
{
    public class Report
    {
        protected int Id { get; set; }
    }

    public class OtherListingReport : Report
    {
        public OtherListingReport(int id, string name, IEnumerable<string> headers)
        {
            Id = id;
            Name = name;
            Headers = headers;
        }

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
        public VATReturn(int id, string name, string countryCode)
        {
            Id = id;
            Name = name;
            CountryCode = countryCode;
        }

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
