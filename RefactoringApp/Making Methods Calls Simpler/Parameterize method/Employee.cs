namespace RefactoringApp.Making_Methods_Calls_Simpler.Parameterize_method
{
    public class Employee
    {
        //Several methods do similar things but with different values contained in the method body.
        public double Salary { get; set; }
        public void FivePercentRaise()
        {
            Salary *= 1.05;
        }
        public void TenPercentRaise()
        {
            Salary *= 1.1;
        }

        public void SalaryPercentRaise(double percent)
        {
            Salary *= percent;
        }
    }
}
