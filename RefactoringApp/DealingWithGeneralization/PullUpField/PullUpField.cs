using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringApp.DealingWithGeneralization.PullUpField
{
    public class Report
    {
        public int Id { get; set; }
    }

    public class OtherListingReport : Report
    {
        public string Name { get; set; }
        public IEnumerable<string> Headers { get; set; }
    }

    public class VATReturn : Report
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
    }
}
