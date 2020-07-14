using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringApp.DealingWithGeneralization.PullUpField
{
    public class ReportRefactored
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class OtherListingReportRefactored : ReportRefactored
    {
        public IEnumerable<string> Headers { get; set; }
    }

    public class VATReturnRefactored : ReportRefactored
    {
        public string CountryCode { get; set; }
    }
}