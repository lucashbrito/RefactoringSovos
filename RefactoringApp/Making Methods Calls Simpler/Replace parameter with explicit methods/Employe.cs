namespace RefactoringApp.Making_Methods_Calls_Simpler.Replace_parameter_with_explicit_methods
{
    public class Employe
    {
        public string Height { get; set; }
        public string Width { get; set; }

        void SetValue(string val)
        {
            if (val.Equals("Height")) Height = val;
            if (val.Equals("Width")) Width = val;
        }

        void SetHeight(string val)
        {
            Height = val;
        }

        void SetWidth(string val)
        {
            Width = val;
        }
    }
}
